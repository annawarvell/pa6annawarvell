namespace finalPA
{
    partial class frmCWID
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
            this.lbCWID = new System.Windows.Forms.Label();
            this.txtCWID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCWID
            // 
            this.lbCWID.AutoSize = true;
            this.lbCWID.Location = new System.Drawing.Point(12, 19);
            this.lbCWID.Name = "lbCWID";
            this.lbCWID.Size = new System.Drawing.Size(155, 24);
            this.lbCWID.TabIndex = 0;
            this.lbCWID.Text = "Enter your CWID:";
            // 
            // txtCWID
            // 
            this.txtCWID.Location = new System.Drawing.Point(173, 14);
            this.txtCWID.Name = "txtCWID";
            this.txtCWID.Size = new System.Drawing.Size(162, 29);
            this.txtCWID.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(155, 49);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 32);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(263, 49);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(88, 32);
            this.btnCLOSE.TabIndex = 3;
            this.btnCLOSE.Text = "CLOSE";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            // 
            // frmCWID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 257);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCWID);
            this.Controls.Add(this.lbCWID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCWID";
            this.Text = "CWID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCWID;
        private System.Windows.Forms.TextBox txtCWID;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCLOSE;
    }
}

