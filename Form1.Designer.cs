namespace WinformTask
{
    partial class Form1
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
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnNotebook = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrand
            // 
            this.btnBrand.Location = new System.Drawing.Point(73, 148);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(114, 31);
            this.btnBrand.TabIndex = 0;
            this.btnBrand.Text = "Brand";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnNotebook
            // 
            this.btnNotebook.Location = new System.Drawing.Point(431, 148);
            this.btnNotebook.Name = "btnNotebook";
            this.btnNotebook.Size = new System.Drawing.Size(114, 31);
            this.btnNotebook.TabIndex = 5;
            this.btnNotebook.Text = "Notebook";
            this.btnNotebook.UseVisualStyleBackColor = true;
            this.btnNotebook.Click += new System.EventHandler(this.btnNotebook_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(757, 148);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(114, 31);
            this.btnPhone.TabIndex = 7;
            this.btnPhone.Text = "Phone";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 587);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnNotebook);
            this.Controls.Add(this.btnBrand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnNotebook;
        private System.Windows.Forms.Button btnPhone;
    }
}

