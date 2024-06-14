using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.Patients
{
    public partial class FrmBed : BaseForm
    {
        protected SqlConnection connection = Program.Connection;

        protected DataSet dataSet = new DataSet();

        protected SqlDataAdapter bedAdapter = new SqlDataAdapter();
        protected BindingSource bedBindingSource = new BindingSource();

        protected SqlDataAdapter roomTypeAdapter = new SqlDataAdapter();
        protected BindingSource roomTypeBindingSource = new BindingSource();

        protected SqlDataAdapter roomAdapter = new SqlDataAdapter();
        protected BindingSource roomBindingSource = new BindingSource();

        public static string VIEW_BED_INFO = "vBedInfo";
        public static string VIEW_ROOM_TYPE_SELECT = "vRoomTypeSelect";
        public static string VIEW_ROOM_SELECT = "vRoomSelect";

        public FrmBed()
        {
            InitializeComponent();
            setUpCommand();
            FillData();
            setUpBinding();
        }

        protected void setUpCommand()
        {
            //set up command for tbBed
            bedAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_BED_INFO}",
                this.connection);
            bedAdapter.InsertCommand = new SqlCommand
            {
                CommandText = "spInsertBedInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.InsertCommand.Parameters.Add(new SqlParameter("@BedDescription", SqlDbType.NVarChar, 255, "BedDescription")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            bedAdapter.InsertCommand.Parameters.Add("@Status", SqlDbType.Bit, 0, "Status")
                   .Direction = ParameterDirection.Input; 
            bedAdapter.InsertCommand.Parameters.Add("@RoomID", SqlDbType.Int, 0, "RoomID")
                   .Direction = ParameterDirection.Input;
            bedAdapter.InsertCommand.Parameters.Add("@BedID", SqlDbType.Int, 0)
                   .Direction = ParameterDirection.Output; 
            bedAdapter.UpdateCommand = new SqlCommand
            {
                CommandText = "spUpdateBedInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.UpdateCommand.Parameters.Add("@BedID", SqlDbType.Int, 0, "BedID")
                   .Direction = ParameterDirection.Input;
            bedAdapter.UpdateCommand.Parameters.Add(new SqlParameter("@BedDescription", SqlDbType.NVarChar, 255, "BedDescription")
            {
                IsNullable = true,
                Direction = ParameterDirection.Input
            });
            bedAdapter.UpdateCommand.Parameters.Add("@Status", SqlDbType.Bit, 0, "Status")
                   .Direction = ParameterDirection.Input;
            bedAdapter.UpdateCommand.Parameters.Add("@RoomID", SqlDbType.Int, 0, "RoomID")
                   .Direction = ParameterDirection.Input;
            bedAdapter.DeleteCommand = new SqlCommand
            {
                CommandText = "spDeleteBedInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.DeleteCommand.Parameters.Add("@bedID", SqlDbType.Int, 0, "BedID")
                .Direction = ParameterDirection.Input;

            //set up command for tbRoomType
            roomTypeAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_ROOM_TYPE_SELECT}",
                this.connection);

            //set up command for tbRoom
            roomAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterRoomInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };

            roomAdapter.SelectCommand.Parameters.Add("@roomTypeID", SqlDbType.SmallInt, 0)
                .Direction = ParameterDirection.Input;
        }

        protected void FillData()
        {
            //map from default table name to specific table name
            bedAdapter.TableMappings.Add("Table", VIEW_BED_INFO);
            bedAdapter.Fill(dataSet);
            bedBindingSource.DataSource = dataSet;
            bedBindingSource.DataMember = VIEW_BED_INFO;

            roomTypeAdapter.TableMappings.Add("Table", VIEW_ROOM_TYPE_SELECT);
            roomTypeAdapter.Fill(dataSet);
            roomTypeBindingSource.DataSource = dataSet;
            roomTypeBindingSource.DataMember = VIEW_ROOM_TYPE_SELECT;

            dataSet.Tables.Add(new DataTable(VIEW_ROOM_SELECT)); 
            roomBindingSource.DataSource = dataSet;
            roomBindingSource.DataMember = VIEW_ROOM_SELECT;
        }

        protected void setUpBinding()
        {
            //bind to control
            dgvBed.DataSource = bedBindingSource;

            cbFilterRoomType.DisplayMember = "RoomTypeName";
            cbFilterRoomType.ValueMember = "RoomTypeID";
            cbFilterRoomType.DataSource = roomTypeBindingSource;

            cbFilterRoom.DataSource = roomBindingSource;
            cbFilterRoom.DisplayMember = "RoomNumber";
            cbFilterRoom.ValueMember = "RoomID"; 
        }

        private void FrmBed_Load(object sender, EventArgs e)
        {
            cbFilterTopBedRecord.Items.AddRange(new object[] {
                "Top 5 Records",
                "Top 10 Records"
            });
            cbFilterTopBedRecord.SelectedIndex = 0;

            cbSearchCriteria.Items.AddRange(new object[]
            {
                "Search By Description"
            });
            cbSearchCriteria.SelectedIndex = 0; 

            ListChangeBedBindingSource();
            bedBindingSource.ListChanged += BedBindingSource_ListChanged;
        }

        private void cbFilterTopBedRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            bedAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSelectTopBedRecord",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.SelectCommand.Parameters.Add("@numberOfRecords", SqlDbType.Int, 0)
                .Direction = ParameterDirection.Input;

            bedAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 
                cbFilterTopBedRecord.SelectedIndex == 0 ? 5 : 10;

            dataSet.Tables[VIEW_BED_INFO].Clear();
            bedAdapter.Fill(dataSet);
        }

        private void cbFilterRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterRoomInfo(Convert.ToInt32(cbFilterRoomType.SelectedValue));
            FilterBedInfoByRoomTypeID(Convert.ToInt32(cbFilterRoomType.SelectedValue)); 
        }

        private void cbFilterRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dataRow = cbFilterRoom.SelectedItem as DataRowView;
            if (dataRow == null) return; 
            FilterBedInfoByRoomNumber((string)dataRow.Row["RoomNumber"]);
        }

        private void FilterRoomInfo(int roomTypeID)
        {
            dataSet.Tables[VIEW_ROOM_SELECT].Clear();

            roomAdapter.SelectCommand.Parameters["@roomTypeID"].Value = roomTypeID;

            roomAdapter.Fill(dataSet, VIEW_ROOM_SELECT);

            if (dataSet.Tables[VIEW_ROOM_SELECT].Rows.Count == 0)
            {
                cbFilterRoom.DataSource = null; 
                if((string)cbFilterRoom.SelectedItem != "N/A")
                    cbFilterRoom.Items.Add("N/A");
                cbFilterRoom.SelectedItem = "N/A"; 
            }else
            {
                cbFilterRoom.DataSource = roomBindingSource;
                cbFilterRoom.DisplayMember = "RoomNumber";
                cbFilterRoom.ValueMember = "RoomID";
            }
        }

        private void FilterBedInfoByRoomTypeID(int roomTypeID)
        {
            bedAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterBedInfoByRoomTypeID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.SelectCommand.Parameters.Add("@roomTypeID", SqlDbType.SmallInt, 0)
               .Direction = ParameterDirection.Input;

            bedAdapter.SelectCommand.Parameters["@roomTypeID"].Value = roomTypeID;

            dataSet.Tables[VIEW_BED_INFO].Clear();
            bedAdapter.Fill(dataSet);
        }
        
        private void FilterBedInfoByRoomNumber(string roomNumber)
        {
            bedAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterBedInfoByRoomNumber",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.SelectCommand.Parameters.Add("@roomNumber", SqlDbType.VarChar, 3)
               .Direction = ParameterDirection.Input;

            bedAdapter.SelectCommand.Parameters["@roomNumber"].Value = roomNumber;

            dataSet.Tables[VIEW_BED_INFO].Clear();
            bedAdapter.Fill(dataSet);
        }

        private void checkBoxFilterBedStatus_Click(object sender, EventArgs e)
        {
            FilterBedInfo();
        }

        private void txtFilterBedRoom_TextChanged(object sender, EventArgs e)
        {
            //validate 
            if (txtFilterBedRoom.Text.Length > 3)
            {
                MessageBox.Show("Room Number is invalid!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFilterBedRoom.Clear();
                return;
            }

            FilterBedInfo();
        }

        private void FilterBedInfo()
        {
            bedAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spFilterBedInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.SelectCommand.Parameters.Add("@status", SqlDbType.Bit, 0)
                .Direction = ParameterDirection.Input;
            bedAdapter.SelectCommand.Parameters.Add("@roomNumber", SqlDbType.VarChar, 3)
                .Direction = ParameterDirection.Input;

            bedAdapter.SelectCommand.Parameters["@status"].Value = checkBoxFilterBedStatus.Checked ? 1 : 0;
            bedAdapter.SelectCommand.Parameters["@roomNumber"].Value = txtFilterBedRoom.Text;

            dataSet.Tables[VIEW_BED_INFO].Clear();
            bedAdapter.Fill(dataSet);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            checkBoxFilterBedStatus.Checked = false;
            txtFilterBedRoom.Clear();
            cbFilterRoomType.SelectedIndex = 0;
            cbFilterRoom.SelectedIndex = 0;

            cbFilterTopBedRecord_SelectedIndexChanged(null, EventArgs.Empty); 
        }

        private void BedBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangeBedBindingSource();
        }

        private void ListChangeBedBindingSource()
        {
            toolStripLblTotalBed.Text = bedBindingSource.Count.ToString();

            int countAvailable = 0; 
            foreach(DataRow dataRow in dataSet.Tables[VIEW_BED_INFO].Rows)
            {
                if (dataRow.RowState == DataRowState.Deleted) continue;
                try
                {
                    if (Convert.ToInt16(dataRow["Status"]) == 1) countAvailable++;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return; 
                }   
            }
               
            toolStripLblBedAvailable.Text = countAvailable.ToString();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyBed frmAddOrModifyBed = new FrmAddOrModifyBed();
            frmAddOrModifyBed.bedAdapter = bedAdapter; 
            frmAddOrModifyBed.bedBindingSource = bedBindingSource; 
            frmAddOrModifyBed.isAdded = true; 
            frmAddOrModifyBed.ShowDialog();

            if (frmAddOrModifyBed.DialogResult == DialogResult.OK)
            {
                bedBindingSource.EndEdit();
                bedAdapter.Update(dataSet, VIEW_BED_INFO);

                //refresh bed record
                int bedID = (int)bedAdapter.InsertCommand.Parameters["@BedID"].Value;
                SearchBedInfoByBedID(bedID);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddOrModifyBed frmAddOrModifyBed = new FrmAddOrModifyBed();
            frmAddOrModifyBed.bedAdapter = bedAdapter; 
            frmAddOrModifyBed.bedBindingSource = bedBindingSource;
            frmAddOrModifyBed.isAdded = false; 
            frmAddOrModifyBed.ShowDialog();

            if(frmAddOrModifyBed.DialogResult == DialogResult.OK)
            {
                bedBindingSource.EndEdit();
                //refresh bed record
                bedBindingSource.ResetCurrentItem();
                bedAdapter.Update(dataSet, VIEW_BED_INFO);
            }
        }

        private void SearchBedInfoByBedID(int bedID)
        {
            bedAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchBedInfoByBedID",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.SelectCommand.Parameters.Add("@BedID", SqlDbType.Int, 0)
                  .Direction = ParameterDirection.Input;
            bedAdapter.SelectCommand.Parameters["@BedID"].Value = bedID;

            dataSet.Tables[VIEW_BED_INFO].Clear();
            bedAdapter.Fill(dataSet, VIEW_BED_INFO);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bedBindingSource.Count == 0) return; 

            var currentRow = bedBindingSource.Current as DataRowView;
            int bedId = Convert.ToInt32(currentRow.Row["BedID"]);
            DialogResult result = MessageBox.Show($"Are you sure to remove bed info #{bedId} in room #{currentRow.Row["RoomNumber"]}?",
               "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
            if(result == DialogResult.OK)
            {
                bedBindingSource.RemoveCurrent();
                bedBindingSource.EndEdit();

                bedAdapter.Update(dataSet, VIEW_BED_INFO); 
            }
        }

        private void dgvBed_Paint(object sender, PaintEventArgs e)
        {
            if (dgvBed.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    "Bed information not found!",
                    dgvBed.Font,
                    dgvBed.ClientRectangle,
                    dgvBed.ForeColor,
                    dgvBed.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate
            if (string.IsNullOrWhiteSpace(txtSearchEntry.Text)) return;

            bedAdapter.SelectCommand = new SqlCommand
            {
                CommandText = "spSearchBedInfo",
                CommandType = CommandType.StoredProcedure,
                Connection = this.connection
            };
            bedAdapter.SelectCommand.Parameters.Add("@bedDescription", SqlDbType.NVarChar, 255)
               .Direction = ParameterDirection.Input;

            bedAdapter.SelectCommand.Parameters["@bedDescription"].Value = txtSearchEntry.Text;

            dataSet.Tables[VIEW_BED_INFO].Clear();
            bedAdapter.Fill(dataSet);
        }

        private void txtSearchEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch_Click(null, EventArgs.Empty);
                txtSearchEntry.Clear();
            }
        }
    }
}
