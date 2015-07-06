namespace LibararyManagementSystem
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterUserNameTextbox = new System.Windows.Forms.TextBox();
            this.RegisterPasswordTextbox = new System.Windows.Forms.TextBox();
            this.RegisterConfirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.R_Registerbutton = new System.Windows.Forms.Button();
            this.R_Cancelbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdminRadio = new System.Windows.Forms.RadioButton();
            this.teacherRadio = new System.Windows.Forms.RadioButton();
            this.student_Radio = new System.Windows.Forms.RadioButton();
            this.textLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // RegisterUserNameTextbox
            // 
            this.RegisterUserNameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.RegisterUserNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterUserNameTextbox.Location = new System.Drawing.Point(189, 77);
            this.RegisterUserNameTextbox.Multiline = true;
            this.RegisterUserNameTextbox.Name = "RegisterUserNameTextbox";
            this.RegisterUserNameTextbox.Size = new System.Drawing.Size(180, 20);
            this.RegisterUserNameTextbox.TabIndex = 3;
            this.RegisterUserNameTextbox.TextChanged += new System.EventHandler(this.RegisterUserNameTextbox_TextChanged);
            // 
            // RegisterPasswordTextbox
            // 
            this.RegisterPasswordTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.RegisterPasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPasswordTextbox.Location = new System.Drawing.Point(189, 117);
            this.RegisterPasswordTextbox.Multiline = true;
            this.RegisterPasswordTextbox.Name = "RegisterPasswordTextbox";
            this.RegisterPasswordTextbox.PasswordChar = '*';
            this.RegisterPasswordTextbox.Size = new System.Drawing.Size(180, 20);
            this.RegisterPasswordTextbox.TabIndex = 4;
            // 
            // RegisterConfirmPasswordTextbox
            // 
            this.RegisterConfirmPasswordTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.RegisterConfirmPasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterConfirmPasswordTextbox.Location = new System.Drawing.Point(189, 155);
            this.RegisterConfirmPasswordTextbox.Multiline = true;
            this.RegisterConfirmPasswordTextbox.Name = "RegisterConfirmPasswordTextbox";
            this.RegisterConfirmPasswordTextbox.PasswordChar = '*';
            this.RegisterConfirmPasswordTextbox.Size = new System.Drawing.Size(180, 20);
            this.RegisterConfirmPasswordTextbox.TabIndex = 5;
            this.RegisterConfirmPasswordTextbox.TextChanged += new System.EventHandler(this.RegisterConfirmPasswordTextbox_TextChanged);
            // 
            // R_Registerbutton
            // 
            this.R_Registerbutton.BackColor = System.Drawing.Color.Transparent;
            this.R_Registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Registerbutton.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Registerbutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.R_Registerbutton.Location = new System.Drawing.Point(47, 353);
            this.R_Registerbutton.Name = "R_Registerbutton";
            this.R_Registerbutton.Size = new System.Drawing.Size(85, 33);
            this.R_Registerbutton.TabIndex = 6;
            this.R_Registerbutton.Text = "Register";
            this.R_Registerbutton.UseVisualStyleBackColor = false;
            this.R_Registerbutton.Click += new System.EventHandler(this.R_Registerbutton_Click);
            // 
            // R_Cancelbutton
            // 
            this.R_Cancelbutton.BackColor = System.Drawing.Color.Transparent;
            this.R_Cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_Cancelbutton.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Cancelbutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.R_Cancelbutton.Location = new System.Drawing.Point(284, 353);
            this.R_Cancelbutton.Name = "R_Cancelbutton";
            this.R_Cancelbutton.Size = new System.Drawing.Size(85, 33);
            this.R_Cancelbutton.TabIndex = 8;
            this.R_Cancelbutton.Text = "Cancel";
            this.R_Cancelbutton.UseVisualStyleBackColor = false;
            this.R_Cancelbutton.Click += new System.EventHandler(this.R_Cancelbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.AdminRadio);
            this.groupBox1.Controls.Add(this.teacherRadio);
            this.groupBox1.Controls.Add(this.student_Radio);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(38, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Status";
            // 
            // AdminRadio
            // 
            this.AdminRadio.AutoSize = true;
            this.AdminRadio.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRadio.Location = new System.Drawing.Point(46, 77);
            this.AdminRadio.Name = "AdminRadio";
            this.AdminRadio.Size = new System.Drawing.Size(73, 27);
            this.AdminRadio.TabIndex = 0;
            this.AdminRadio.TabStop = true;
            this.AdminRadio.Text = "Admin";
            this.AdminRadio.UseVisualStyleBackColor = true;
            this.AdminRadio.CheckedChanged += new System.EventHandler(this.AdminRadio_CheckedChanged);
            // 
            // teacherRadio
            // 
            this.teacherRadio.AutoSize = true;
            this.teacherRadio.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRadio.Location = new System.Drawing.Point(46, 52);
            this.teacherRadio.Name = "teacherRadio";
            this.teacherRadio.Size = new System.Drawing.Size(81, 27);
            this.teacherRadio.TabIndex = 0;
            this.teacherRadio.TabStop = true;
            this.teacherRadio.Text = "Teacher";
            this.teacherRadio.UseVisualStyleBackColor = true;
            this.teacherRadio.CheckedChanged += new System.EventHandler(this.teacherRadio_CheckedChanged);
            // 
            // student_Radio
            // 
            this.student_Radio.AutoSize = true;
            this.student_Radio.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Radio.Location = new System.Drawing.Point(46, 29);
            this.student_Radio.Name = "student_Radio";
            this.student_Radio.Size = new System.Drawing.Size(81, 27);
            this.student_Radio.TabIndex = 0;
            this.student_Radio.TabStop = true;
            this.student_Radio.Text = "Student";
            this.student_Radio.UseVisualStyleBackColor = true;
            this.student_Radio.CheckedChanged += new System.EventHandler(this.student_Radio_CheckedChanged);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(52, 182);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(0, 23);
            this.textLabel.TabIndex = 10;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibararyManagementSystem.Properties.Resources.register_black;
            this.ClientSize = new System.Drawing.Size(444, 425);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.R_Cancelbutton);
            this.Controls.Add(this.R_Registerbutton);
            this.Controls.Add(this.RegisterConfirmPasswordTextbox);
            this.Controls.Add(this.RegisterPasswordTextbox);
            this.Controls.Add(this.RegisterUserNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegisterUserNameTextbox;
        private System.Windows.Forms.TextBox RegisterPasswordTextbox;
        private System.Windows.Forms.TextBox RegisterConfirmPasswordTextbox;
        private System.Windows.Forms.Button R_Registerbutton;
        private System.Windows.Forms.Button R_Cancelbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AdminRadio;
        private System.Windows.Forms.RadioButton teacherRadio;
        private System.Windows.Forms.RadioButton student_Radio;
        private System.Windows.Forms.Label textLabel;
    }
}