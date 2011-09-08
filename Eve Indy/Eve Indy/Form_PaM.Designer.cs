namespace Eve_Indy
{
    partial class frmPaM
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
            this.lbMaterials = new System.Windows.Forms.ListBox();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblMaterials = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMaterials
            // 
            this.lbMaterials.FormattingEnabled = true;
            this.lbMaterials.Location = new System.Drawing.Point(373, 115);
            this.lbMaterials.Name = "lbMaterials";
            this.lbMaterials.Size = new System.Drawing.Size(207, 290);
            this.lbMaterials.TabIndex = 0;
            this.lbMaterials.SelectedIndexChanged += new System.EventHandler(this.lbMaterials_SelectedIndexChanged);
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(47, 115);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(205, 290);
            this.lbProducts.TabIndex = 1;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(102, 78);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(84, 24);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Products";
            // 
            // lblMaterials
            // 
            this.lblMaterials.AutoSize = true;
            this.lblMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterials.Location = new System.Drawing.Point(429, 78);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(100, 25);
            this.lblMaterials.TabIndex = 3;
            this.lblMaterials.Text = "Materials";
            // 
            // frmPaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 460);
            this.Controls.Add(this.lblMaterials);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.lbMaterials);
            this.Name = "frmPaM";
            this.Text = "Products and Materials";
            this.Load += new System.EventHandler(this.frmPaM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMaterials;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblMaterials;
    }
}