namespace Opdracht_3_extra.Views
{
    partial class VolumeDisplay
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
            this.pb_volume = new System.Windows.Forms.ProgressBar();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_volume
            // 
            this.pb_volume.Location = new System.Drawing.Point(35, 31);
            this.pb_volume.Name = "pb_volume";
            this.pb_volume.Size = new System.Drawing.Size(344, 37);
            this.pb_volume.TabIndex = 0;
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(205, 44);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(19, 13);
            this.lbl_volume.TabIndex = 1;
            this.lbl_volume.Text = "00";
            // 
            // VolumeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 87);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.pb_volume);
            this.Name = "VolumeDisplay";
            this.Text = "VolumeDisplay";
            this.Load += new System.EventHandler(this.VolumeDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_volume;
        private System.Windows.Forms.Label lbl_volume;
    }
}