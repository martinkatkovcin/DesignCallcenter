namespace DesignCallcenter
{
    partial class XtraForm1
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
            this.initial1 = new DesignCallcenter.Initial();
            this.SuspendLayout();
            // 
            // initial1
            // 
            this.initial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initial1.Location = new System.Drawing.Point(0, 0);
            this.initial1.Name = "initial1";
            this.initial1.Size = new System.Drawing.Size(2594, 987);
            this.initial1.TabIndex = 0;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2594, 987);
            this.Controls.Add(this.initial1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private Initial initial1;
    }
}