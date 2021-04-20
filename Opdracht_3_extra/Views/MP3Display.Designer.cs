namespace Opdracht_3_extra
{
    partial class MP3Display
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
            this.lbl_song = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.btn_volumeUp = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_volumeDown = new System.Windows.Forms.Button();
            this.btn_nextSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(12, 36);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(70, 13);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Current song:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(12, 58);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(45, 13);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "Volume:";
            // 
            // lbl_song
            // 
            this.lbl_song.AutoSize = true;
            this.lbl_song.Location = new System.Drawing.Point(91, 36);
            this.lbl_song.Name = "lbl_song";
            this.lbl_song.Size = new System.Drawing.Size(69, 13);
            this.lbl_song.TabIndex = 2;
            this.lbl_song.Text = "Not playing...";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(91, 58);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(19, 13);
            this.lbl_volume.TabIndex = 3;
            this.lbl_volume.Text = "00";
            // 
            // btn_volumeUp
            // 
            this.btn_volumeUp.Location = new System.Drawing.Point(118, 112);
            this.btn_volumeUp.Name = "btn_volumeUp";
            this.btn_volumeUp.Size = new System.Drawing.Size(41, 34);
            this.btn_volumeUp.TabIndex = 4;
            this.btn_volumeUp.Text = "++";
            this.btn_volumeUp.UseVisualStyleBackColor = true;
            this.btn_volumeUp.Click += new System.EventHandler(this.btn_volumeUp_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(94, 152);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(85, 35);
            this.btn_play.TabIndex = 5;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_volumeDown
            // 
            this.btn_volumeDown.Location = new System.Drawing.Point(118, 193);
            this.btn_volumeDown.Name = "btn_volumeDown";
            this.btn_volumeDown.Size = new System.Drawing.Size(41, 34);
            this.btn_volumeDown.TabIndex = 6;
            this.btn_volumeDown.TabStop = false;
            this.btn_volumeDown.Text = "- -";
            this.btn_volumeDown.UseVisualStyleBackColor = true;
            this.btn_volumeDown.Click += new System.EventHandler(this.btn_volumeDown_Click);
            // 
            // btn_nextSong
            // 
            this.btn_nextSong.Location = new System.Drawing.Point(186, 152);
            this.btn_nextSong.Name = "btn_nextSong";
            this.btn_nextSong.Size = new System.Drawing.Size(38, 35);
            this.btn_nextSong.TabIndex = 7;
            this.btn_nextSong.Text = ">|";
            this.btn_nextSong.UseVisualStyleBackColor = true;
            this.btn_nextSong.Click += new System.EventHandler(this.btn_nextSong_Click);
            // 
            // MP3Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 261);
            this.Controls.Add(this.btn_nextSong);
            this.Controls.Add(this.btn_volumeDown);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_volumeUp);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_song);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Name = "MP3Display";
            this.Text = "MP3Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_song;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Button btn_volumeUp;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_volumeDown;
        private System.Windows.Forms.Button btn_nextSong;
    }
}

