namespace xo_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Player = new System.Windows.Forms.Label();
            this.lbl_Turn = new System.Windows.Forms.Label();
            this.lbl_Winner = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_RestartGame = new System.Windows.Forms.Button();
            this.pp_A3 = new System.Windows.Forms.PictureBox();
            this.pp_A2 = new System.Windows.Forms.PictureBox();
            this.pp_A1 = new System.Windows.Forms.PictureBox();
            this.pp_B3 = new System.Windows.Forms.PictureBox();
            this.pp_C3 = new System.Windows.Forms.PictureBox();
            this.pp_B2 = new System.Windows.Forms.PictureBox();
            this.pp_B1 = new System.Windows.Forms.PictureBox();
            this.pp_C1 = new System.Windows.Forms.PictureBox();
            this.pp_C2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pp_A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_B3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_C2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Player
            // 
            this.lbl_Player.AutoSize = true;
            this.lbl_Player.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player.ForeColor = System.Drawing.Color.White;
            this.lbl_Player.Location = new System.Drawing.Point(52, 141);
            this.lbl_Player.Name = "lbl_Player";
            this.lbl_Player.Size = new System.Drawing.Size(129, 36);
            this.lbl_Player.TabIndex = 1;
            this.lbl_Player.Text = "Player1";
            // 
            // lbl_Turn
            // 
            this.lbl_Turn.AutoSize = true;
            this.lbl_Turn.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turn.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Turn.Location = new System.Drawing.Point(3, 86);
            this.lbl_Turn.Name = "lbl_Turn";
            this.lbl_Turn.Size = new System.Drawing.Size(90, 34);
            this.lbl_Turn.TabIndex = 0;
            this.lbl_Turn.Text = "Turn:";
            // 
            // lbl_Winner
            // 
            this.lbl_Winner.AutoSize = true;
            this.lbl_Winner.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Winner.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Winner.Location = new System.Drawing.Point(3, 209);
            this.lbl_Winner.Name = "lbl_Winner";
            this.lbl_Winner.Size = new System.Drawing.Size(127, 34);
            this.lbl_Winner.TabIndex = 2;
            this.lbl_Winner.Text = "Winner:";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Result.Location = new System.Drawing.Point(52, 271);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(190, 36);
            this.lbl_Result.TabIndex = 3;
            this.lbl_Result.Text = "In Progress";
            // 
            // btn_RestartGame
            // 
            this.btn_RestartGame.BackColor = System.Drawing.Color.Black;
            this.btn_RestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RestartGame.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RestartGame.ForeColor = System.Drawing.Color.White;
            this.btn_RestartGame.Location = new System.Drawing.Point(26, 334);
            this.btn_RestartGame.Name = "btn_RestartGame";
            this.btn_RestartGame.Size = new System.Drawing.Size(228, 46);
            this.btn_RestartGame.TabIndex = 4;
            this.btn_RestartGame.Text = "Restart";
            this.btn_RestartGame.UseVisualStyleBackColor = false;
            this.btn_RestartGame.Click += new System.EventHandler(this.btn_RestartGame_Click);
            // 
            // pp_A3
            // 
            this.pp_A3.BackColor = System.Drawing.Color.Black;
            this.pp_A3.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_A3.Location = new System.Drawing.Point(555, 53);
            this.pp_A3.Name = "pp_A3";
            this.pp_A3.Size = new System.Drawing.Size(95, 81);
            this.pp_A3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_A3.TabIndex = 5;
            this.pp_A3.TabStop = false;
            this.pp_A3.Tag = "A3";
            this.pp_A3.Click += new System.EventHandler(this.pp_Click);
            // 
            // pp_A2
            // 
            this.pp_A2.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_A2.Location = new System.Drawing.Point(424, 53);
            this.pp_A2.Name = "pp_A2";
            this.pp_A2.Size = new System.Drawing.Size(95, 81);
            this.pp_A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_A2.TabIndex = 6;
            this.pp_A2.TabStop = false;
            this.pp_A2.Tag = "A2";
            this.pp_A2.Click += new System.EventHandler(this.pp_Click);
            // 
            // pp_A1
            // 
            this.pp_A1.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_A1.Location = new System.Drawing.Point(283, 53);
            this.pp_A1.Name = "pp_A1";
            this.pp_A1.Size = new System.Drawing.Size(95, 81);
            this.pp_A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_A1.TabIndex = 7;
            this.pp_A1.TabStop = false;
            this.pp_A1.Tag = "A1";
            this.pp_A1.Click += new System.EventHandler(this.pp_Click);
            // 
            // pp_B3
            // 
            this.pp_B3.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_B3.Location = new System.Drawing.Point(555, 177);
            this.pp_B3.Name = "pp_B3";
            this.pp_B3.Size = new System.Drawing.Size(95, 81);
            this.pp_B3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_B3.TabIndex = 8;
            this.pp_B3.TabStop = false;
            this.pp_B3.Tag = "B3";
            this.pp_B3.Click += new System.EventHandler(this.pp_Click);
            // 
            // pp_C3
            // 
            this.pp_C3.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_C3.Location = new System.Drawing.Point(555, 282);
            this.pp_C3.Name = "pp_C3";
            this.pp_C3.Size = new System.Drawing.Size(95, 81);
            this.pp_C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_C3.TabIndex = 9;
            this.pp_C3.TabStop = false;
            this.pp_C3.Tag = "C3";
            this.pp_C3.Click += new System.EventHandler(this.pp_Click);
            // 
            // pp_B2
            // 
            this.pp_B2.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_B2.Location = new System.Drawing.Point(424, 177);
            this.pp_B2.Name = "pp_B2";
            this.pp_B2.Size = new System.Drawing.Size(95, 81);
            this.pp_B2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_B2.TabIndex = 10;
            this.pp_B2.TabStop = false;
            this.pp_B2.Tag = "B2";
            this.pp_B2.Click += new System.EventHandler(this.pp_Click);
            // 
            // pp_B1
            // 
            this.pp_B1.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_B1.Location = new System.Drawing.Point(283, 177);
            this.pp_B1.Name = "pp_B1";
            this.pp_B1.Size = new System.Drawing.Size(95, 81);
            this.pp_B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_B1.TabIndex = 11;
            this.pp_B1.TabStop = false;
            this.pp_B1.Tag = "B1";
            this.pp_B1.Click += new System.EventHandler(this.pp_Click);
            // 
            // pp_C1
            // 
            this.pp_C1.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_C1.Location = new System.Drawing.Point(283, 282);
            this.pp_C1.Name = "pp_C1";
            this.pp_C1.Size = new System.Drawing.Size(95, 81);
            this.pp_C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_C1.TabIndex = 12;
            this.pp_C1.TabStop = false;
            this.pp_C1.Tag = "C1";
            this.pp_C1.Click += new System.EventHandler(this.pp_Click);
            // 
            // pp_C2
            // 
            this.pp_C2.Image = global::xo_Game.Properties.Resources.question_mark_96;
            this.pp_C2.Location = new System.Drawing.Point(424, 282);
            this.pp_C2.Name = "pp_C2";
            this.pp_C2.Size = new System.Drawing.Size(95, 81);
            this.pp_C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pp_C2.TabIndex = 13;
            this.pp_C2.TabStop = false;
            this.pp_C2.Tag = "C2";
            this.pp_C2.Click += new System.EventHandler(this.pp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.pp_C2);
            this.Controls.Add(this.pp_C1);
            this.Controls.Add(this.pp_B1);
            this.Controls.Add(this.pp_B2);
            this.Controls.Add(this.pp_C3);
            this.Controls.Add(this.pp_B3);
            this.Controls.Add(this.pp_A1);
            this.Controls.Add(this.pp_A2);
            this.Controls.Add(this.pp_A3);
            this.Controls.Add(this.btn_RestartGame);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_Winner);
            this.Controls.Add(this.lbl_Turn);
            this.Controls.Add(this.lbl_Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XO Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pp_A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_B3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pp_C2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Player;
        private System.Windows.Forms.Label lbl_Turn;
        private System.Windows.Forms.Label lbl_Winner;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_RestartGame;
        private System.Windows.Forms.PictureBox pp_A3;
        private System.Windows.Forms.PictureBox pp_A2;
        private System.Windows.Forms.PictureBox pp_A1;
        private System.Windows.Forms.PictureBox pp_B3;
        private System.Windows.Forms.PictureBox pp_C3;
        private System.Windows.Forms.PictureBox pp_B2;
        private System.Windows.Forms.PictureBox pp_B1;
        private System.Windows.Forms.PictureBox pp_C1;
        private System.Windows.Forms.PictureBox pp_C2;
    }
}

