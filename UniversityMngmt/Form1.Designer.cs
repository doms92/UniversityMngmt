﻿namespace UniversityMngmt
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.AcctId = new System.Windows.Forms.Label();
            this.AcctBalance = new System.Windows.Forms.Label();
            this.AcctName = new System.Windows.Forms.Label();
            this.AcctDesc = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(982, 160);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 66);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1014, 626);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 244);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1126, 375);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "University Management System";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(982, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 71);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AcctId
            // 
            this.AcctId.AutoSize = true;
            this.AcctId.Location = new System.Drawing.Point(24, 90);
            this.AcctId.Name = "AcctId";
            this.AcctId.Size = new System.Drawing.Size(116, 25);
            this.AcctId.TabIndex = 5;
            this.AcctId.Text = "Account ID";
            // 
            // AcctBalance
            // 
            this.AcctBalance.AutoSize = true;
            this.AcctBalance.Location = new System.Drawing.Point(24, 166);
            this.AcctBalance.Name = "AcctBalance";
            this.AcctBalance.Size = new System.Drawing.Size(174, 25);
            this.AcctBalance.TabIndex = 6;
            this.AcctBalance.Text = "Account Balance";
            // 
            // AcctName
            // 
            this.AcctName.AutoSize = true;
            this.AcctName.Location = new System.Drawing.Point(489, 84);
            this.AcctName.Name = "AcctName";
            this.AcctName.Size = new System.Drawing.Size(152, 25);
            this.AcctName.TabIndex = 7;
            this.AcctName.Text = "Account Name";
            // 
            // AcctDesc
            // 
            this.AcctDesc.AutoSize = true;
            this.AcctDesc.Location = new System.Drawing.Point(489, 166);
            this.AcctDesc.Name = "AcctDesc";
            this.AcctDesc.Size = new System.Drawing.Size(204, 25);
            this.AcctDesc.TabIndex = 8;
            this.AcctDesc.Text = "Account Description";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Location = new System.Drawing.Point(204, 84);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(237, 31);
            this.txtBoxID.TabIndex = 9;
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.Location = new System.Drawing.Point(204, 160);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(237, 31);
            this.txtBoxBalance.TabIndex = 10;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(699, 81);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(237, 31);
            this.txtBoxName.TabIndex = 11;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(699, 160);
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(237, 31);
            this.txtBoxDesc.TabIndex = 12;
            // 
            // FormFinAccManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 685);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.AcctDesc);
            this.Controls.Add(this.AcctName);
            this.Controls.Add(this.AcctBalance);
            this.Controls.Add(this.AcctId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormFinAccManager";
            this.Text = "Accounts Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label AcctId;
        private System.Windows.Forms.Label AcctBalance;
        private System.Windows.Forms.Label AcctName;
        private System.Windows.Forms.Label AcctDesc;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxBalance;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDesc;
    }
}

