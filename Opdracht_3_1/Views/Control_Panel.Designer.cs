namespace Opdracht_3_1
{
    partial class Control_Panel
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
            this.btn_Volgend_Station = new System.Windows.Forms.Button();
            this.brn_Nieuwe_Display = new System.Windows.Forms.Button();
            this.btn_LaatsteStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Volgend_Station
            // 
            this.btn_Volgend_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volgend_Station.Location = new System.Drawing.Point(67, 45);
            this.btn_Volgend_Station.Name = "btn_Volgend_Station";
            this.btn_Volgend_Station.Size = new System.Drawing.Size(165, 57);
            this.btn_Volgend_Station.TabIndex = 0;
            this.btn_Volgend_Station.Text = "Volgend Station";
            this.btn_Volgend_Station.UseVisualStyleBackColor = true;
            this.btn_Volgend_Station.Click += new System.EventHandler(this.btn_Volgend_Station_Click);
            // 
            // brn_Nieuwe_Display
            // 
            this.brn_Nieuwe_Display.Location = new System.Drawing.Point(12, 229);
            this.brn_Nieuwe_Display.Name = "brn_Nieuwe_Display";
            this.brn_Nieuwe_Display.Size = new System.Drawing.Size(93, 20);
            this.brn_Nieuwe_Display.TabIndex = 1;
            this.brn_Nieuwe_Display.Text = "Nieuwe display";
            this.brn_Nieuwe_Display.UseVisualStyleBackColor = true;
            this.brn_Nieuwe_Display.Click += new System.EventHandler(this.brn_Nieuwe_Display_Click);
            // 
            // btn_LaatsteStation
            // 
            this.btn_LaatsteStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LaatsteStation.Location = new System.Drawing.Point(67, 117);
            this.btn_LaatsteStation.Name = "btn_LaatsteStation";
            this.btn_LaatsteStation.Size = new System.Drawing.Size(165, 57);
            this.btn_LaatsteStation.TabIndex = 2;
            this.btn_LaatsteStation.Text = "Laatste Station";
            this.btn_LaatsteStation.UseVisualStyleBackColor = true;
            this.btn_LaatsteStation.Click += new System.EventHandler(this.btn_LaatsteStation_Click);
            // 
            // Control_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_LaatsteStation);
            this.Controls.Add(this.brn_Nieuwe_Display);
            this.Controls.Add(this.btn_Volgend_Station);
            this.Name = "Control_Panel";
            this.Text = "Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Volgend_Station;
        private System.Windows.Forms.Button brn_Nieuwe_Display;
        private System.Windows.Forms.Button btn_LaatsteStation;
    }
}

