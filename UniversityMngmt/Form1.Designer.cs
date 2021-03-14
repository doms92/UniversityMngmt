namespace UniversityMngmt
{
    partial class FormFinAccManager
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(421, 509);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 93);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateEdit
            // 
            this.btnUpdateEdit.Location = new System.Drawing.Point(72, 509);
            this.btnUpdateEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateEdit.Name = "btnUpdateEdit";
            this.btnUpdateEdit.Size = new System.Drawing.Size(267, 93);
            this.btnUpdateEdit.TabIndex = 1;
            this.btnUpdateEdit.Text = "Update / Edit";
            this.btnUpdateEdit.UseVisualStyleBackColor = true;
            // 
            // FormFinAccManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 850);
            this.Controls.Add(this.btnUpdateEdit);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFinAccManager";
            this.Text = "Accounts Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateEdit;
    }
}

