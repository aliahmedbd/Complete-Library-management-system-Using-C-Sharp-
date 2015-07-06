namespace LibararyManagementSystem
{
    partial class returnBookForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.catagoryLabel = new System.Windows.Forms.Label();
            this.returnExitButton = new System.Windows.Forms.Button();
            this.returnBookText = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(24, 119);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(285, 20);
            this.nameLabel.TabIndex = 2;
            // 
            // catagoryLabel
            // 
            this.catagoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catagoryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.catagoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryLabel.Location = new System.Drawing.Point(24, 159);
            this.catagoryLabel.Name = "catagoryLabel";
            this.catagoryLabel.Size = new System.Drawing.Size(285, 20);
            this.catagoryLabel.TabIndex = 3;
            // 
            // returnExitButton
            // 
            this.returnExitButton.BackColor = System.Drawing.Color.Transparent;
            this.returnExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnExitButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnExitButton.Location = new System.Drawing.Point(228, 213);
            this.returnExitButton.Name = "returnExitButton";
            this.returnExitButton.Size = new System.Drawing.Size(82, 32);
            this.returnExitButton.TabIndex = 6;
            this.returnExitButton.Text = "Exit";
            this.returnExitButton.UseVisualStyleBackColor = false;
            this.returnExitButton.Click += new System.EventHandler(this.returnExitButton_Click);
            // 
            // returnBookText
            // 
            this.returnBookText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookText.Location = new System.Drawing.Point(24, 39);
            this.returnBookText.Multiline = true;
            this.returnBookText.Name = "returnBookText";
            this.returnBookText.Size = new System.Drawing.Size(285, 20);
            this.returnBookText.TabIndex = 7;
            this.returnBookText.TextChanged += new System.EventHandler(this.returnBookText_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(24, 79);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(285, 20);
            this.idLabel.TabIndex = 8;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(24, 213);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(82, 32);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Book To Be Returned";
            // 
            // returnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibararyManagementSystem.Properties.Resources.return_book_black;
            this.ClientSize = new System.Drawing.Size(438, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.returnBookText);
            this.Controls.Add(this.returnExitButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.catagoryLabel);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.Name = "returnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.returnBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label catagoryLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button returnExitButton;
        private System.Windows.Forms.TextBox returnBookText;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
    }
}