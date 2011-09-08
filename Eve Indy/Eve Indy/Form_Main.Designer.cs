namespace Eve_Indy
{
    partial class Form_Main
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
            this.btnBlueprints = new System.Windows.Forms.Button();
            this.btnPaM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlueprints
            // 
            this.btnBlueprints.Location = new System.Drawing.Point(12, 12);
            this.btnBlueprints.Name = "btnBlueprints";
            this.btnBlueprints.Size = new System.Drawing.Size(75, 23);
            this.btnBlueprints.TabIndex = 2;
            this.btnBlueprints.Text = "Blueprints";
            this.btnBlueprints.UseVisualStyleBackColor = true;
            this.btnBlueprints.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPaM
            // 
            this.btnPaM.Location = new System.Drawing.Point(103, 12);
            this.btnPaM.Name = "btnPaM";
            this.btnPaM.Size = new System.Drawing.Size(139, 23);
            this.btnPaM.TabIndex = 3;
            this.btnPaM.Text = "Products and Materials";
            this.btnPaM.UseVisualStyleBackColor = true;
            this.btnPaM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(326, 334);
            this.Controls.Add(this.btnPaM);
            this.Controls.Add(this.btnBlueprints);
            this.Name = "Form_Main";
            this.Text = "Eve Indy";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlueprints;
        private System.Windows.Forms.Button btnPaM;
    }
}

