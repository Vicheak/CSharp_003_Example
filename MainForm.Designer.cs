namespace Init_Project
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAddNew = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            dataGridViewShowPeopleList = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel = new ToolStripLabel();
            toolStripLabelShowPeopleAmount = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowPeopleList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Top;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 0, 0);
            label1.Size = new Size(982, 47);
            label1.TabIndex = 0;
            label1.Text = "People List";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(12, 63);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(123, 41);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(702, 63);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(123, 41);
            btnModify.TabIndex = 3;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(847, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 41);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewShowPeopleList
            // 
            dataGridViewShowPeopleList.AllowUserToAddRows = false;
            dataGridViewShowPeopleList.AllowUserToDeleteRows = false;
            dataGridViewShowPeopleList.AllowUserToResizeColumns = false;
            dataGridViewShowPeopleList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewShowPeopleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewShowPeopleList.AutoGenerateColumns = false;
            dataGridViewShowPeopleList.BackgroundColor = Color.White;
            dataGridViewShowPeopleList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewShowPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewShowPeopleList.ColumnHeadersHeight = 50;
            dataGridViewShowPeopleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewShowPeopleList.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn });
            dataGridViewShowPeopleList.DataSource = personBindingSource;
            dataGridViewShowPeopleList.EnableHeadersVisualStyles = false;
            dataGridViewShowPeopleList.Location = new Point(14, 114);
            dataGridViewShowPeopleList.Name = "dataGridViewShowPeopleList";
            dataGridViewShowPeopleList.ReadOnly = true;
            dataGridViewShowPeopleList.RowHeadersWidth = 51;
            dataGridViewShowPeopleList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewShowPeopleList.RowTemplate.Height = 40;
            dataGridViewShowPeopleList.Size = new Size(956, 404);
            dataGridViewShowPeopleList.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(Person);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel, toolStripLabelShowPeopleAmount });
            toolStrip1.Location = new Point(0, 528);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(982, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel
            // 
            toolStripLabel.Name = "toolStripLabel";
            toolStripLabel.Size = new Size(122, 22);
            toolStripLabel.Text = "People Amount : ";
            // 
            // toolStripLabelShowPeopleAmount
            // 
            toolStripLabelShowPeopleAmount.Name = "toolStripLabelShowPeopleAmount";
            toolStripLabelShowPeopleAmount.Size = new Size(16, 22);
            toolStripLabelShowPeopleAmount.Text = "?";
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(982, 553);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridViewShowPeopleList);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAddNew);
            Controls.Add(label1);
            Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewShowPeopleList).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddNew;
        private Button btnModify;
        private Button btnDelete;
        private DataGridView dataGridViewShowPeopleList;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel;
        private ToolStripLabel toolStripLabelShowPeopleAmount;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private BindingSource personBindingSource;
    }
}