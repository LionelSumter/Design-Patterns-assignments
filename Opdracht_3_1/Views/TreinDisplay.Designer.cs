namespace Opdracht_3_1.Views
{
    partial class TreinDisplay
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_huidig_station = new System.Windows.Forms.Label();
            this.lbl_spoor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(62, 28);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(98, 17);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Huidig station:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(62, 55);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(50, 17);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "Spoor:";
            // 
            // lbl_huidig_station
            // 
            this.lbl_huidig_station.AutoSize = true;
            this.lbl_huidig_station.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_huidig_station.Location = new System.Drawing.Point(201, 28);
            this.lbl_huidig_station.Name = "lbl_huidig_station";
            this.lbl_huidig_station.Size = new System.Drawing.Size(30, 17);
            this.lbl_huidig_station.TabIndex = 2;
            this.lbl_huidig_station.Text = "iets";
            // 
            // lbl_spoor
            // 
            this.lbl_spoor.AutoSize = true;
            this.lbl_spoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spoor.Location = new System.Drawing.Point(201, 55);
            this.lbl_spoor.Name = "lbl_spoor";
            this.lbl_spoor.Size = new System.Drawing.Size(30, 17);
            this.lbl_spoor.TabIndex = 3;
            this.lbl_spoor.Text = "iets";
            // 
            // TreinDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.lbl_spoor);
            this.Controls.Add(this.lbl_huidig_station);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Name = "TreinDisplay";
            this.Text = "TreinDisplay";
            this.Load += new System.EventHandler(this.TreinDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_huidig_station;
        private System.Windows.Forms.Label lbl_spoor;
    }
}