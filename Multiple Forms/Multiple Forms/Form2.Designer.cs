namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnUpperCase = new System.Windows.Forms.RadioButton();
            this.rbtnLowerCase = new System.Windows.Forms.RadioButton();
            this.rbtnProperCase = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(54, 231);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnProperCase);
            this.groupBox1.Controls.Add(this.rbtnLowerCase);
            this.groupBox1.Controls.Add(this.rbtnUpperCase);
            this.groupBox1.Location = new System.Drawing.Point(54, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Case";
            // 
            // rbtnUpperCase
            // 
            this.rbtnUpperCase.AutoSize = true;
            this.rbtnUpperCase.Location = new System.Drawing.Point(38, 19);
            this.rbtnUpperCase.Name = "rbtnUpperCase";
            this.rbtnUpperCase.Size = new System.Drawing.Size(81, 17);
            this.rbtnUpperCase.TabIndex = 0;
            this.rbtnUpperCase.TabStop = true;
            this.rbtnUpperCase.Text = "Upper Case";
            this.rbtnUpperCase.UseVisualStyleBackColor = true;
            // 
            // rbtnLowerCase
            // 
            this.rbtnLowerCase.AutoSize = true;
            this.rbtnLowerCase.Location = new System.Drawing.Point(38, 54);
            this.rbtnLowerCase.Name = "rbtnLowerCase";
            this.rbtnLowerCase.Size = new System.Drawing.Size(81, 17);
            this.rbtnLowerCase.TabIndex = 1;
            this.rbtnLowerCase.TabStop = true;
            this.rbtnLowerCase.Text = "Lower Case";
            this.rbtnLowerCase.UseVisualStyleBackColor = true;
            // 
            // rbtnProperCase
            // 
            this.rbtnProperCase.AutoSize = true;
            this.rbtnProperCase.Location = new System.Drawing.Point(38, 88);
            this.rbtnProperCase.Name = "rbtnProperCase";
            this.rbtnProperCase.Size = new System.Drawing.Size(83, 17);
            this.rbtnProperCase.TabIndex = 2;
            this.rbtnProperCase.TabStop = true;
            this.rbtnProperCase.Text = "Proper Case";
            this.rbtnProperCase.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnProperCase;
        private System.Windows.Forms.RadioButton rbtnLowerCase;
        private System.Windows.Forms.RadioButton rbtnUpperCase;
    }
}