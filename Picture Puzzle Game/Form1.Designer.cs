namespace Picture_Puzzle_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.Controls.Add(this.pbx9);
            this.gbPuzzleBox.Controls.Add(this.pbx8);
            this.gbPuzzleBox.Controls.Add(this.pbx7);
            this.gbPuzzleBox.Controls.Add(this.pbx6);
            this.gbPuzzleBox.Controls.Add(this.pbx5);
            this.gbPuzzleBox.Controls.Add(this.pbx4);
            this.gbPuzzleBox.Controls.Add(this.pbx3);
            this.gbPuzzleBox.Controls.Add(this.pbx2);
            this.gbPuzzleBox.Controls.Add(this.pbx1);
            this.gbPuzzleBox.Location = new System.Drawing.Point(12, 12);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Size = new System.Drawing.Size(506, 523);
            this.gbPuzzleBox.TabIndex = 0;
            this.gbPuzzleBox.TabStop = false;
            this.gbPuzzleBox.Text = "Puzzle Box";
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(338, 351);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(160, 160);
            this.pbx9.TabIndex = 8;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(172, 351);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(160, 160);
            this.pbx8.TabIndex = 7;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(6, 351);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(160, 160);
            this.pbx7.TabIndex = 6;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(338, 185);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(160, 160);
            this.pbx6.TabIndex = 5;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(172, 185);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(160, 160);
            this.pbx5.TabIndex = 4;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(6, 185);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(160, 160);
            this.pbx4.TabIndex = 3;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(338, 19);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(160, 160);
            this.pbx3.TabIndex = 2;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(172, 19);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(160, 160);
            this.pbx2.TabIndex = 1;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(6, 19);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(160, 160);
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMovesMade.Location = new System.Drawing.Point(116, 538);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(204, 39);
            this.lblMovesMade.TabIndex = 1;
            this.lblMovesMade.Text = "Moves Made:";
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::Picture_Puzzle_Game.Properties.Resources.original;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gbOriginal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbOriginal.Location = new System.Drawing.Point(580, 31);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(361, 326);
            this.gbOriginal.TabIndex = 2;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Original";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimeElapsed.Location = new System.Drawing.Point(628, 376);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(264, 80);
            this.lblTimeElapsed.TabIndex = 3;
            this.lblTimeElapsed.Text = "00:00:00";
            this.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShuffle.Location = new System.Drawing.Point(580, 477);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(110, 58);
            this.btnShuffle.TabIndex = 4;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPause.Location = new System.Drawing.Point(705, 477);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(110, 58);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuit.Location = new System.Drawing.Point(831, 477);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(110, 58);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Interval = 900;
            this.tmrTimeElapse.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 599);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.gbPuzzleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Isolated Gamerz  - Cute Picture Puzzle Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskAskPermissionBeforeQuit);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.SwitchPictureBox);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer tmrTimeElapse;
    }
}

