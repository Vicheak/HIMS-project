using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TreatmentType.TreatType
{
    public partial class FrmTreat : Form
    {
        protected SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-HKMUMI1\DBS;Initial Catalog=ISAD;Integrated Security=True;");
        protected DataSet dataSet = new DataSet();
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        protected SqlCommand command = new SqlCommand();
        protected BindingSource bindingSource = new BindingSource();
        public static string TableTreat = "TreatmentTypeInfo";

        public FrmTreat()
        {
            InitializeComponent();
            setUp();
        }

        protected void setUp()
        {
            try
            {
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT ISNULL(MAX(TreatmentTypeID), 0) + 1 AS NewTreatID FROM TreatmentTypeInfo"; // Use the view
                int newTreatID = Convert.ToInt32(command.ExecuteScalar());
                txtID.Text = newTreatID.ToString();

                command.CommandText = "SELECT * FROM TreatmentTypeInfo"; // Use the view
                adapter.SelectCommand = command;
                adapter.TableMappings.Add("Table", TableTreat);
                adapter.Fill(dataSet);
                bindingSource.DataSource = dataSet;
                bindingSource.DataMember = TableTreat;
                dgv.DataSource = bindingSource;

                btnSubmit.Click += DoClickSubmit;
                btnUpdate.Click += DoClickUpdate;
                btnDelete.Click += DoClickDelete;
                btnClear.Click +=DoClickClear;
                dgv.CellClick += dgv_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView rowView = (DataRowView)dgv.Rows[e.RowIndex].DataBoundItem;
                if (rowView != null)
                {
                    txtID.Text = rowView["TreatmentTypeID"].ToString();
                    txtName.Text = rowView["TreatmentTypeName"].ToString();
                    txtDesc.Text = rowView["Description"].ToString();
                }
            }
        }

        // Insert
        private void DoClickSubmit(object sender, EventArgs e)
        {
            string treatmentTypeName = txtName.Text;
            string description = txtDesc.Text;

            // Basic validation (optional)
            if (string.IsNullOrEmpty(treatmentTypeName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                InsertTreatmentType(treatmentTypeName, description);
                MessageBox.Show("Record inserted successfully.");

                // Clear textboxes after insert
                txtName.Text = "";
                txtDesc.Text = "";

                // Refresh data grid
                RefreshData();
            }
            catch (SqlException ex)
            {
                // Handle SQL specific errors
                MessageBox.Show($"A database error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void RefreshData()
        {
            dataSet.Clear();
            adapter.Fill(dataSet);
        }

        private void InsertTreatmentType(string TreatmentTypeName, string Description)
        {
            using (SqlCommand insertCommand = new SqlCommand("ProInsertTreatmentType", connection))
            {
                insertCommand.CommandType = CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("@TreatmentTypeName", TreatmentTypeName);
                insertCommand.Parameters.AddWithValue("@Description", Description);

                SqlParameter outputParam = new SqlParameter("@TreatmentTypeID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                insertCommand.Parameters.Add(outputParam);

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    insertCommand.ExecuteNonQuery(); // Execute the stored procedure
                    int newTreatmentTypeID = Convert.ToInt32(outputParam.Value);
                    txtID.Text = newTreatmentTypeID.ToString();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DoClickUpdate(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            string newTreatmentTypeName = txtName.Text;
            string newDescription = txtDesc.Text;

            // Get the index of the selected row in the DataGridView
            int selectedIndex = dgv.CurrentCell.RowIndex;

            // Check if a row is selected
            if (selectedIndex >= 0)
            {
                // Get the DataRow associated with the selected row
                DataRowView rowView = (DataRowView)dgv.Rows[selectedIndex].DataBoundItem;
                DataRow row = rowView.Row;

                // Get the TreatmentTypeID from the selected row
                int treatmentTypeID = Convert.ToInt32(row["TreatmentTypeID"]);

                // Update the database
                try
                {
                    UpdateTreatmentType(treatmentTypeID, newTreatmentTypeName, newDescription);
                    MessageBox.Show("Record updated successfully.");

                    // Refresh data grid
                    RefreshData();
                }
                catch (SqlException ex)
                {
                    // Handle SQL specific errors
                    MessageBox.Show($"A database error occurred: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle general exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void UpdateTreatmentType(int treatmentTypeID, string newTreatmentTypeName, string newDescription)
        {
            // Open connection
            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                conn.Open();

                // Create command
                using (SqlCommand cmd = new SqlCommand("UpdateTreatmentType", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@TreatmentTypeID", treatmentTypeID);
                    cmd.Parameters.AddWithValue("@TreatmentTypeName", newTreatmentTypeName);
                    cmd.Parameters.AddWithValue("@Description", newDescription);

                    // Execute command
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DoClickDelete(object sender, EventArgs e)
        {
            // Get the index of the selected row in the DataGridView
            int selectedIndex = dgv.CurrentCell.RowIndex;

            // Check if a row is selected
            if (selectedIndex >= 0)
            {
                // Get the DataRow associated with the selected row
                DataRowView rowView = (DataRowView)dgv.Rows[selectedIndex].DataBoundItem;
                DataRow row = rowView.Row;

                // Get the TreatmentTypeID from the selected row
                int treatmentTypeID = Convert.ToInt32(row["TreatmentTypeID"]);

                // Delete the record from the database
                try
                {
                    DeleteTreatmentType(treatmentTypeID);
                    MessageBox.Show("Record deleted successfully.");

                    // Refresh data grid
                    RefreshData();
                }
                catch (SqlException ex)
                {
                    // Handle SQL specific errors
                    MessageBox.Show($"A database error occurred: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle general exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void DeleteTreatmentType(int treatmentTypeID)
        {
            // Open connection
            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                conn.Open();

                // Create command
                using (SqlCommand cmd = new SqlCommand("ProDeleteTreatmentType", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameter
                    cmd.Parameters.AddWithValue("@TreatmentTypeID", treatmentTypeID);

                    // Execute command
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DoClickClear(object sender, EventArgs e)
        {
            // Clear textboxes
            txtID.Text = "";
            txtName.Text = "";
            txtDesc.Text = "";

            // Optionally, set focus to the first textbox
            txtName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void FrmTreat_Load(object sender, EventArgs e)
        {
        }
    }
}
