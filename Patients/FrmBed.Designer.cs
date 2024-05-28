﻿namespace HIMS_Project.Patients
{
    partial class FrmBed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBed = new System.Windows.Forms.DataGridView();
            this.BedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalBed = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblBedAvailable = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchEntry = new System.Windows.Forms.TextBox();
            this.cbFilterTopBedRecord = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilterBedRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilterBedPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxFilterBedStatus = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBedID = new System.Windows.Forms.TextBox();
            this.lblAutoGeneratedBedID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBedDescription = new System.Windows.Forms.TextBox();
            this.checkBoxBedStatus = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFilterRoomType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFilterRoom = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBedPrice = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBed)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Bed Information Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvBed
            // 
            this.dgvBed.AllowUserToAddRows = false;
            this.dgvBed.AllowUserToDeleteRows = false;
            this.dgvBed.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvBed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBed.BackgroundColor = System.Drawing.Color.White;
            this.dgvBed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBed.ColumnHeadersHeight = 50;
            this.dgvBed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BedID,
            this.BedDescription,
            this.Status,
            this.RoomNumber,
            this.RoomID});
            this.dgvBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBed.EnableHeadersVisualStyles = false;
            this.dgvBed.GridColor = System.Drawing.Color.Gray;
            this.dgvBed.Location = new System.Drawing.Point(10, 304);
            this.dgvBed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBed.Name = "dgvBed";
            this.dgvBed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBed.RowHeadersWidth = 51;
            this.dgvBed.RowTemplate.Height = 45;
            this.dgvBed.Size = new System.Drawing.Size(926, 263);
            this.dgvBed.TabIndex = 10;
            // 
            // BedID
            // 
            this.BedID.DataPropertyName = "BedID";
            this.BedID.HeaderText = "Bed ID";
            this.BedID.MinimumWidth = 6;
            this.BedID.Name = "BedID";
            this.BedID.Width = 125;
            // 
            // BedDescription
            // 
            this.BedDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BedDescription.DataPropertyName = "BedDescription";
            this.BedDescription.HeaderText = "Bed Description";
            this.BedDescription.MinimumWidth = 6;
            this.BedDescription.Name = "BedDescription";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RoomNumber.DataPropertyName = "RoomNumber";
            this.RoomNumber.HeaderText = "Room Number";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 139;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "Room ID";
            this.RoomID.MinimumWidth = 6;
            this.RoomID.Name = "RoomID";
            this.RoomID.Visible = false;
            this.RoomID.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLblTotalBed,
            this.toolStripLabel2,
            this.toolStripLblBedAvailable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 577);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "Total :";
            // 
            // toolStripLblTotalBed
            // 
            this.toolStripLblTotalBed.Name = "toolStripLblTotalBed";
            this.toolStripLblTotalBed.Size = new System.Drawing.Size(12, 22);
            this.toolStripLblTotalBed.Text = "?";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel2.Text = "Available :";
            // 
            // toolStripLblBedAvailable
            // 
            this.toolStripLblBedAvailable.Name = "toolStripLblBedAvailable";
            this.toolStripLblBedAvailable.Size = new System.Drawing.Size(12, 22);
            this.toolStripLblBedAvailable.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Criteria :";
            // 
            // cbSearchCriteria
            // 
            this.cbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCriteria.FormattingEnabled = true;
            this.cbSearchCriteria.Location = new System.Drawing.Point(142, 47);
            this.cbSearchCriteria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSearchCriteria.Name = "cbSearchCriteria";
            this.cbSearchCriteria.Size = new System.Drawing.Size(188, 37);
            this.cbSearchCriteria.TabIndex = 4;
            this.cbSearchCriteria.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Entry :";
            // 
            // txtSearchEntry
            // 
            this.txtSearchEntry.Location = new System.Drawing.Point(462, 47);
            this.txtSearchEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchEntry.Name = "txtSearchEntry";
            this.txtSearchEntry.Size = new System.Drawing.Size(184, 37);
            this.txtSearchEntry.TabIndex = 6;
            this.txtSearchEntry.TabStop = false;
            // 
            // cbFilterTopBedRecord
            // 
            this.cbFilterTopBedRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterTopBedRecord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTopBedRecord.FormattingEnabled = true;
            this.cbFilterTopBedRecord.Location = new System.Drawing.Point(749, 50);
            this.cbFilterTopBedRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilterTopBedRecord.Name = "cbFilterTopBedRecord";
            this.cbFilterTopBedRecord.Size = new System.Drawing.Size(188, 37);
            this.cbFilterTopBedRecord.TabIndex = 7;
            this.cbFilterTopBedRecord.TabStop = false;
            this.cbFilterTopBedRecord.SelectedIndexChanged += new System.EventHandler(this.cbFilterTopBedRecord_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.txtFilterBedRoom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFilterBedPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBoxFilterBedStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(293, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // txtFilterBedRoom
            // 
            this.txtFilterBedRoom.Location = new System.Drawing.Point(93, 109);
            this.txtFilterBedRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilterBedRoom.Name = "txtFilterBedRoom";
            this.txtFilterBedRoom.Size = new System.Drawing.Size(184, 37);
            this.txtFilterBedRoom.TabIndex = 13;
            this.txtFilterBedRoom.TabStop = false;
            this.txtFilterBedRoom.TextChanged += new System.EventHandler(this.txtFilterBedRoom_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Room :";
            // 
            // txtFilterBedPrice
            // 
            this.txtFilterBedPrice.Location = new System.Drawing.Point(93, 66);
            this.txtFilterBedPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilterBedPrice.Name = "txtFilterBedPrice";
            this.txtFilterBedPrice.Size = new System.Drawing.Size(184, 37);
            this.txtFilterBedPrice.TabIndex = 9;
            this.txtFilterBedPrice.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price :";
            // 
            // checkBoxFilterBedStatus
            // 
            this.checkBoxFilterBedStatus.AutoSize = true;
            this.checkBoxFilterBedStatus.Location = new System.Drawing.Point(93, 41);
            this.checkBoxFilterBedStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFilterBedStatus.Name = "checkBoxFilterBedStatus";
            this.checkBoxFilterBedStatus.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFilterBedStatus.TabIndex = 10;
            this.checkBoxFilterBedStatus.TabStop = false;
            this.checkBoxFilterBedStatus.UseVisualStyleBackColor = true;
            this.checkBoxFilterBedStatus.Click += new System.EventHandler(this.checkBoxFilterBedStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Available :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bed ID :";
            // 
            // txtBedID
            // 
            this.txtBedID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBedID.Location = new System.Drawing.Point(381, 95);
            this.txtBedID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBedID.Name = "txtBedID";
            this.txtBedID.ReadOnly = true;
            this.txtBedID.Size = new System.Drawing.Size(118, 37);
            this.txtBedID.TabIndex = 15;
            this.txtBedID.TabStop = false;
            // 
            // lblAutoGeneratedBedID
            // 
            this.lblAutoGeneratedBedID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutoGeneratedBedID.AutoSize = true;
            this.lblAutoGeneratedBedID.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoGeneratedBedID.Location = new System.Drawing.Point(399, 104);
            this.lblAutoGeneratedBedID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutoGeneratedBedID.Name = "lblAutoGeneratedBedID";
            this.lblAutoGeneratedBedID.Size = new System.Drawing.Size(84, 19);
            this.lblAutoGeneratedBedID.TabIndex = 16;
            this.lblAutoGeneratedBedID.Text = "Auto Generated";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description :";
            // 
            // txtBedDescription
            // 
            this.txtBedDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBedDescription.Location = new System.Drawing.Point(402, 143);
            this.txtBedDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBedDescription.Multiline = true;
            this.txtBedDescription.Name = "txtBedDescription";
            this.txtBedDescription.Size = new System.Drawing.Size(185, 146);
            this.txtBedDescription.TabIndex = 2;
            // 
            // checkBoxBedStatus
            // 
            this.checkBoxBedStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBedStatus.AutoSize = true;
            this.checkBoxBedStatus.Location = new System.Drawing.Point(571, 106);
            this.checkBoxBedStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxBedStatus.Name = "checkBoxBedStatus";
            this.checkBoxBedStatus.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBedStatus.TabIndex = 3;
            this.checkBoxBedStatus.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Status :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Room Type :";
            // 
            // cbFilterRoomType
            // 
            this.cbFilterRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterRoomType.FormattingEnabled = true;
            this.cbFilterRoomType.Location = new System.Drawing.Point(749, 95);
            this.cbFilterRoomType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilterRoomType.Name = "cbFilterRoomType";
            this.cbFilterRoomType.Size = new System.Drawing.Size(188, 37);
            this.cbFilterRoomType.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 149);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Room :";
            // 
            // cbFilterRoom
            // 
            this.cbFilterRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterRoom.FormattingEnabled = true;
            this.cbFilterRoom.Location = new System.Drawing.Point(749, 146);
            this.cbFilterRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFilterRoom.Name = "cbFilterRoom";
            this.cbFilterRoom.Size = new System.Drawing.Size(188, 37);
            this.cbFilterRoom.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(626, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "Price /Day";
            // 
            // txtBedPrice
            // 
            this.txtBedPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBedPrice.Location = new System.Drawing.Point(749, 197);
            this.txtBedPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBedPrice.Name = "txtBedPrice";
            this.txtBedPrice.Size = new System.Drawing.Size(188, 37);
            this.txtBedPrice.TabIndex = 6;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(601, 256);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(99, 33);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(718, 256);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 33);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(836, 256);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // FrmBed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(946, 602);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtBedPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbFilterRoom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbFilterRoomType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBoxBedStatus);
            this.Controls.Add(this.txtBedDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAutoGeneratedBedID);
            this.Controls.Add(this.txtBedID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbFilterTopBedRecord);
            this.Controls.Add(this.txtSearchEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSearchCriteria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBed);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBed";
            this.Load += new System.EventHandler(this.FrmBed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBed)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBed;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalBed;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblBedAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchCriteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchEntry;
        private System.Windows.Forms.ComboBox cbFilterTopBedRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFilterBedStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilterBedRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilterBedPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBedID;
        private System.Windows.Forms.Label lblAutoGeneratedBedID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBedDescription;
        private System.Windows.Forms.CheckBox checkBoxBedStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbFilterRoomType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbFilterRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBedPrice;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
    }
}