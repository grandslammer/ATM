﻿namespace ATM.Presentation_Layer
{
    partial class frmLodgement
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lodgement";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(713, 415);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 4;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Amount to Lodge:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(411, 233);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(252, 38);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(301, 354);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(198, 63);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // frmLodgement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainMenu);
            this.Name = "frmLodgement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLodgement";
            this.Load += new System.EventHandler(this.FrmLodgement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAccept;
    }
}