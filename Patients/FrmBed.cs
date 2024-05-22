﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.Patients
{
    public partial class FrmBed : Form
    {
        protected SqlConnection connection = 
            new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=HIMS;Integrated Security=True;");

        protected DataSet dataSet = new DataSet();

        protected SqlCommand command = new SqlCommand();

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
            setUp();
            setUpBinding();
        }

        protected void setUp()
        {
            //set up for tbBed
            command.Connection = connection; 
            command.CommandText = $"SELECT * FROM {VIEW_BED_INFO}"; 
            bedAdapter.SelectCommand = command;

            //map from default table name to specific table name
            bedAdapter.TableMappings.Add("Table", VIEW_BED_INFO);
            bedAdapter.Fill(dataSet);

            bedBindingSource.DataSource = dataSet;
            bedBindingSource.DataMember = VIEW_BED_INFO;

            dgvBed.DataSource = bedBindingSource;

            //set up for tbRoomType
            roomTypeAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_ROOM_TYPE_SELECT}",
                connection);

            roomTypeAdapter.TableMappings.Add("Table", VIEW_ROOM_TYPE_SELECT);
            roomTypeAdapter.Fill(dataSet);

            roomTypeBindingSource.DataSource = dataSet;
            roomTypeBindingSource.DataMember = VIEW_ROOM_TYPE_SELECT;

            //set up for tbRoom
            roomAdapter.SelectCommand = new SqlCommand($"SELECT * FROM {VIEW_ROOM_SELECT}",
                connection);

            roomAdapter.TableMappings.Add("Table", VIEW_ROOM_SELECT); 
            roomAdapter.Fill(dataSet);

            roomBindingSource.DataSource = dataSet;
            roomBindingSource.DataMember = VIEW_ROOM_SELECT; 
        }
        
        private void setUpBinding()
        {
            //bind to control
            txtBedID.DataBindings.Add("Text", bedBindingSource, "BedID");
            txtBedDescription.DataBindings.Add("Text", bedBindingSource, "BedDescription");

            cbFilterRoom.DataSource = roomBindingSource;
            cbFilterRoom.DisplayMember = "RoomNumber";
            cbFilterRoom.ValueMember = "RoomID";
            cbFilterRoom.DataBindings.Add("SelectedValue", bedBindingSource, "RoomID");

            cbFilterRoomType.DataSource = roomTypeBindingSource;
            cbFilterRoomType.DisplayMember = "RoomTypeName";
            cbFilterRoomType.ValueMember = "RoomTypeID";
            cbFilterRoomType.DataBindings.Add("SelectedValue", roomBindingSource, "RoomTypeID"); 
        }

        private void FrmBed_Load(object sender, EventArgs e)
        {
            lblAutoGeneratedBedID.Text = "";
            cbFilterTopBedRecord.Items.AddRange(new object[] { 
                "Top 5 Records",
                "Top 10 Records"
            });
            cbFilterTopBedRecord.SelectedIndex = 0;

            dgvBed.SelectionChanged += DgvBed_SelectionChanged;

            ListChangeBedBindingSource(); 
            bedBindingSource.ListChanged += BedBindingSource_ListChanged;
        }

        private void BedBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListChangeBedBindingSource(); 
        }

        private void ListChangeBedBindingSource()
        {
            toolStripLblTotalBed.Text = bedBindingSource.Count.ToString();
        }

        private void DgvBed_SelectionChanged(object sender, EventArgs e)
        {
            var currentRow = bedBindingSource.Current as DataRowView;
            if (currentRow != null)
            {
                string status = (string)currentRow.Row["Status"];
                if (string.Equals(status, "Available"))
                    checkBoxBedStatus.Checked = true;
                else
                    checkBoxBedStatus.Checked = false;
            }
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

            dataSet.Tables[VIEW_BED_INFO].Clear(); 
            if(cbFilterTopBedRecord.SelectedIndex == 0)
                //user selects top 5 records
                bedAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 5;
            else
                //user selects top 10 records
                bedAdapter.SelectCommand.Parameters["@numberOfRecords"].Value = 10; 
            bedAdapter.Fill(dataSet); 
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

            dataSet.Tables[VIEW_BED_INFO].Clear();
            if (checkBoxFilterBedStatus.Checked)
            {
                bedAdapter.SelectCommand.Parameters["@status"].Value = 1;
                bedAdapter.SelectCommand.Parameters["@roomNumber"].Value = txtFilterBedRoom.Text;
            }
            else
            {
                bedAdapter.SelectCommand.Parameters["@status"].Value = 0;
                bedAdapter.SelectCommand.Parameters["@roomNumber"].Value = txtFilterBedRoom.Text;
            }
            bedAdapter.Fill(dataSet);
        }

        private void checkBoxFilterBedStatus_Click(object sender, EventArgs e)
        {
            FilterBedInfo(); 
        }

        private void txtFilterBedRoom_TextChanged(object sender, EventArgs e)
        {
            //validate 
            if(txtFilterBedRoom.Text.Length > 3)
            {
                MessageBox.Show("Room Number is invalid!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFilterBedRoom.Clear(); 
                return; 
            }

            FilterBedInfo(); 
        }
    }
}