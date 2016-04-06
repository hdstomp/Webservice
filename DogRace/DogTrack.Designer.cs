namespace DogRace
{
    partial class DogTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogTrack));
            this.picRaceTrack = new System.Windows.Forms.PictureBox();
            this.btnRace = new System.Windows.Forms.Button();
            this.picGreyhound1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // picRaceTrack
            // 
            this.picRaceTrack.Image = global::DogRace.Properties.Resources.racetrack;
            this.picRaceTrack.Location = new System.Drawing.Point(254, 23);
            this.picRaceTrack.Name = "picRaceTrack";
            this.picRaceTrack.Size = new System.Drawing.Size(600, 200);
            this.picRaceTrack.TabIndex = 0;
            this.picRaceTrack.TabStop = false;
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(762, 281);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(92, 68);
            this.btnRace.TabIndex = 1;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // picGreyhound1
            // 
            this.picGreyhound1.Image = ((System.Drawing.Image)(resources.GetObject("picGreyhound1.Image")));
            this.picGreyhound1.Location = new System.Drawing.Point(254, 33);
            this.picGreyhound1.Name = "picGreyhound1";
            this.picGreyhound1.Size = new System.Drawing.Size(74, 19);
            this.picGreyhound1.TabIndex = 2;
            this.picGreyhound1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(254, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 19);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(254, 138);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 19);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(254, 190);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 19);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(762, 355);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 68);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // DogTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 503);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picGreyhound1);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.picRaceTrack);
            this.Name = "DogTrack";
            this.Text = "DogTrack";
            ((System.ComponentModel.ISupportInitialize)(this.picRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreyhound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRaceTrack;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.PictureBox picGreyhound1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnReset;
    }
}

