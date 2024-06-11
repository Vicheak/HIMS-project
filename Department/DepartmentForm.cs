using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HIMS_Project.Department
{
    public partial class DepartmentForm : Form
    {
        protected SqlConnection connection =
        new SqlConnection(@"Data Source=localhost\DBS;Initial Catalog=HIMS;Integrated Security=True;");
        protected DataSet dataSet = new DataSet();
        protected SqlCommand command = new SqlCommand();
        protected SqlDataAdapter DepartmentAdapter = new SqlDataAdapter();
        protected BindingSource DepartmentBindingSource = new BindingSource();
        public static string V_DEPARTMENT = "VDepartment";
        public DepartmentForm()
        {
            InitializeComponent();
            setUp();
            setUpBinding();
        }
        private void Clean()
        {
            txtStaffID.Clear();
            txtDepartmentName.Clear();
            txtDescription.Clear();
            txtBuildingName.Clear();
            txtCapacity.Clear();
            txtfloorNumber.Clear();
        }
        private void setUp()
        {
            command.Connection = connection;
            command.CommandText = $"SELECT * FROM {V_DEPARTMENT}";
            DepartmentAdapter.SelectCommand = command;
            DepartmentAdapter.TableMappings.Add("Table", V_DEPARTMENT);
            DepartmentAdapter.Fill(dataSet);

            DepartmentBindingSource.DataSource = dataSet;
            DepartmentBindingSource.DataMember = V_DEPARTMENT;

            dgvDepartment.DataSource = DepartmentBindingSource;
        }
        private void setUpBinding()
        {
                dgvDepartment.DataSource = DepartmentBindingSource;
                txtDepartmentName.DataBindings.Add("text", DepartmentBindingSource, "DepartmentName");
                txtBuildingName.DataBindings.Add("text", DepartmentBindingSource, "BuildingName");
                txtfloorNumber.DataBindings.Add("text", DepartmentBindingSource, "FloorNumber");
                txtDescription.DataBindings.Add("text", DepartmentBindingSource, "Description");
                txtCapacity.DataBindings.Add("text", DepartmentBindingSource, "Capacity");
                txtStaffID.DataBindings.Add("text", DepartmentBindingSource, "StaffID");
            
        }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
        }

        private void btConcel_Click(object sender, EventArgs e)
        {
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btUpdate_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    // Update the actual table instead of the view
                    SqlCommand updateDepartmentCommand = new SqlCommand(
                       "UPDATE tbDepartment SET DepartmentName = @DepartmentName, BuildingName = @BuildingName, FloorNumber = @FloorNumber, " +
                       "Description = @Description, Capacity = @Capacity WHERE StaffID = @StaffID;", connection);

                    updateDepartmentCommand.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@BuildingName", txtBuildingName.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@FloorNumber", txtfloorNumber.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                    updateDepartmentCommand.Parameters.AddWithValue("@Capacity", txtCapacity.Text);

                    updateDepartmentCommand.ExecuteNonQuery();

                    // Refresh the data grid
                    dataSet.Clear();
                    DepartmentAdapter.Fill(dataSet);

                    MessageBox.Show("Data updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btConcel_Click_1(object sender, EventArgs e)
        {
            Clean();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    // Delete from the actual table instead of the view
                    SqlCommand deleteDepartmentCommand = new SqlCommand(
                       "DELETE FROM tbDepartment WHERE StaffID = @StaffID;", connection);

                    deleteDepartmentCommand.Parameters.AddWithValue("@StaffID", txtStaffID.Text);

                    deleteDepartmentCommand.ExecuteNonQuery();

                    // Refresh the data grid
                    dataSet.Clear();
                    DepartmentAdapter.Fill(dataSet);

                    MessageBox.Show("Data deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand insertDepartmentCommand = new SqlCommand(
                   "INSERT INTO tbDepartment (StaffID, DepartmentName, BuildingName, FloorNumber, Description, Capacity) " +
                   "VALUES (@StaffID, @DepartmentName, @BuildingName, @FloorNumber, @Description, @Capacity);", connection);
                insertDepartmentCommand.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@BuildingName", txtBuildingName.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@FloorNumber", txtfloorNumber.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                insertDepartmentCommand.Parameters.AddWithValue("@Capacity", txtCapacity.Text);

                insertDepartmentCommand.ExecuteNonQuery();
                dataSet.Clear();
                DepartmentAdapter.Fill(dataSet);

                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
