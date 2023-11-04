namespace Init_Project
{
    partial class AddOrModifyForm
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
            lblTitle = new Label();
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPhone = new TextBox();
            cbGender = new ComboBox();
            btnAccept = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.SteelBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Transparent;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(20, 0, 0, 0);
            lblTitle.Size = new Size(482, 47);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "?";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(131, 36);
            label1.TabIndex = 2;
            label1.Text = "First Name : ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(140, 71);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(323, 44);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 157);
            label2.Name = "label2";
            label2.Size = new Size(129, 36);
            label2.TabIndex = 2;
            label2.Text = "Last Name : ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(140, 149);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(323, 44);
            txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 235);
            label3.Name = "label3";
            label3.Size = new Size(98, 36);
            label3.TabIndex = 2;
            label3.Text = "Gender : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 313);
            label4.Name = "label4";
            label4.Size = new Size(91, 36);
            label4.TabIndex = 2;
            label4.Text = "Phone : ";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 305);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(323, 44);
            txtPhone.TabIndex = 4;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(140, 227);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(194, 44);
            cbGender.TabIndex = 3;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(55, 404);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(128, 52);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(288, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 52);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddOrModifyForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(482, 491);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(cbGender);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddOrModifyForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddOrModifyForm";
            Load += AddOrModifyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private TextBox txtPhone;
        private ComboBox cbGender;
        private Button btnAccept;
        private Button btnCancel;
    }
}