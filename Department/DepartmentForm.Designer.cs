namespace HIMS_Project.Department
{
    partial class DepartmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.txtfloorNumber = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btConcel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.BedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "StaffID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "DepartmentName";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(35, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "BuildingName";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(721, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "FloorNumber";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(721, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(721, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(267, 84);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffID.Multiline = true;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(300, 39);
            this.txtStaffID.TabIndex = 0;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartmentName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(267, 167);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDepartmentName.Multiline = true;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(300, 39);
            this.txtDepartmentName.TabIndex = 1;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuildingName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingName.Location = new System.Drawing.Point(267, 251);
            this.txtBuildingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuildingName.Multiline = true;
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(300, 39);
            this.txtBuildingName.TabIndex = 2;
            // 
            // txtfloorNumber
            // 
            this.txtfloorNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfloorNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfloorNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfloorNumber.Location = new System.Drawing.Point(965, 84);
            this.txtfloorNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfloorNumber.Multiline = true;
            this.txtfloorNumber.Name = "txtfloorNumber";
            this.txtfloorNumber.Size = new System.Drawing.Size(300, 39);
            this.txtfloorNumber.TabIndex = 3;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(965, 164);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(300, 39);
            this.txtCapacity.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(965, 247);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 39);
            this.txtDescription.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(31, 30);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(160, 52);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUpdate.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(263, 30);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(160, 52);
            this.btUpdate.TabIndex = 13;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click_1);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(495, 30);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(160, 52);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // btConcel
            // 
            this.btConcel.BackColor = System.Drawing.Color.Red;
            this.btConcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConcel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConcel.ForeColor = System.Drawing.Color.White;
            this.btConcel.Location = new System.Drawing.Point(1036, 30);
            this.btConcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConcel.Name = "btConcel";
            this.btConcel.Size = new System.Drawing.Size(160, 52);
            this.btConcel.TabIndex = 15;
            this.btConcel.Text = "Concel";
            this.btConcel.UseVisualStyleBackColor = false;
            this.btConcel.Click += new System.EventHandler(this.btConcel_Click_1);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1300, 52);
            this.label7.TabIndex = 17;
            this.label7.Text = "Department information management";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btConcel);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(31, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 113);
            this.panel1.TabIndex = 18;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvDepartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDepartment.ColumnHeadersHeight = 50;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BedID,
            this.BedDescription,
            this.BuildingName,
            this.FloorNumber,
            this.Description,
            this.Capacity,
            this.StaffID});
            this.dgvDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDepartment.EnableHeadersVisualStyles = false;
            this.dgvDepartment.GridColor = System.Drawing.Color.Gray;
            this.dgvDepartment.Location = new System.Drawing.Point(31, 453);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartment.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDepartment.RowHeadersWidth = 51;
            this.dgvDepartment.RowTemplate.Height = 45;
            this.dgvDepartment.Size = new System.Drawing.Size(1234, 264);
            this.dgvDepartment.TabIndex = 16;
            // 
            // BedID
            // 
            this.BedID.DataPropertyName = "DepartmentID";
            this.BedID.HeaderText = "Department ID";
            this.BedID.MinimumWidth = 6;
            this.BedID.Name = "BedID";
            // 
            // BedDescription
            // 
            this.BedDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BedDescription.DataPropertyName = "DepartmentName";
            this.BedDescription.HeaderText = "Department Name";
            this.BedDescription.MinimumWidth = 6;
            this.BedDescription.Name = "BedDescription";
            // 
            // BuildingName
            // 
            this.BuildingName.DataPropertyName = "BuildingName";
            this.BuildingName.HeaderText = "Building Name";
            this.BuildingName.MinimumWidth = 6;
            this.BuildingName.Name = "BuildingName";
            // 
            // FloorNumber
            // 
            this.FloorNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FloorNumber.DataPropertyName = "FloorNumber";
            this.FloorNumber.HeaderText = "Floor Number";
            this.FloorNumber.MinimumWidth = 6;
            this.FloorNumber.Name = "FloorNumber";
            this.FloorNumber.Width = 167;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            // 
            // StaffID
            // 
            this.StaffID.DataPropertyName = "StaffID";
            this.StaffID.HeaderText = "Staff ID";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1300, 729);
            this.Controls.Add(this.dgvDepartment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtfloorNumber);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.TextBox txtfloorNumber;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btConcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
    }
}