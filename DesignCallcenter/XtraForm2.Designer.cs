namespace DesignCallcenter
{
    partial class XtraForm2
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
            this.design1 = new DesignCallcenter.Design();
            this.SuspendLayout();
            // 
            // design1
            // 
            this.design1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.design1.Location = new System.Drawing.Point(0, 0);
            this.design1.Name = "design1";
            this.design1.Size = new System.Drawing.Size(1796, 931);
            this.design1.TabIndex = 0;
            // 
            // XtraForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 931);
            this.Controls.Add(this.design1);
            this.Name = "XtraForm2";
            this.Text = "XtraForm2";
            this.ResumeLayout(false);

        }

        #endregion

        private Design design1;
    }
}