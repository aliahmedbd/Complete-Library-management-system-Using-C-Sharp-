namespace LibararyManagementSystem
{
    partial class addCatagoryForm
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
            this.addCatagoryTextbox = new System.Windows.Forms.TextBox();
            this.catagoryAddbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCatagoryTextbox
            // 
            this.addCatagoryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCatagoryTextbox.Location = new System.Drawing.Point(40, 104);
            this.addCatagoryTextbox.Multiline = true;
            this.addCatagoryTextbox.Name = "addCatagoryTextbox";
            this.addCatagoryTextbox.Size = new System.Drawing.Size(340, 20);
            this.addCatagoryTextbox.TabIndex = 2;
            this.addCatagoryTextbox.TextChanged += new System.EventHandler(this.addCatagoryTextbox_TextChanged);
            // 
            // catagoryAddbutton
            // 
            this.catagoryAddbutton.BackColor = System.Drawing.Color.Transparent;
            this.catagoryAddbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.catagoryAddbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.catagoryAddbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.catagoryAddbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catagoryAddbutton.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryAddbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.catagoryAddbutton.Location = new System.Drawing.Point(307, 165);
            this.catagoryAddbutton.Name = "catagoryAddbutton";
            this.catagoryAddbutton.Size = new System.Drawing.Size(74, 32);
            this.catagoryAddbutton.TabIndex = 3;
            this.catagoryAddbutton.Text = "Add";
            this.catagoryAddbutton.UseVisualStyleBackColor = false;
            this.catagoryAddbutton.Click += new System.EventHandler(this.catagoryAddbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category Name";
            // 
            // addCatagoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibararyManagementSystem.Properties.Resources.catagory_black;
            this.ClientSize = new System.Drawing.Size(406, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catagoryAddbutton);
            this.Controls.Add(this.addCatagoryTextbox);
            this.MaximizeBox = false;
            this.Name = "addCatagoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Catagory";
            this.Load += new System.EventHandler(this.addCatagoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addCatagoryTextbox;
        private System.Windows.Forms.Button catagoryAddbutton;
        private System.Windows.Forms.Label label1;
    }
}