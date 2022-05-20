namespace Flash
{
    partial class rank
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
            this.r_back = new System.Windows.Forms.Button();
            this.r_pa1 = new System.Windows.Forms.Panel();
            this.r_game3 = new System.Windows.Forms.Button();
            this.r_game2 = new System.Windows.Forms.Button();
            this.r_game1 = new System.Windows.Forms.Button();
            this.r_memo = new System.Windows.Forms.Label();
            this.r_rank = new System.Windows.Forms.Label();
            this.r_time = new System.Windows.Forms.Label();
            this.r_nick = new System.Windows.Forms.Label();
            this.r_count = new System.Windows.Forms.Label();
            this.r_pa2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.r_pa1.SuspendLayout();
            this.r_pa2.SuspendLayout();
            this.SuspendLayout();
            // 
            // r_back
            // 
            this.r_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(94)))));
            this.r_back.FlatAppearance.BorderSize = 0;
            this.r_back.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.r_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r_back.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.r_back.Location = new System.Drawing.Point(1234, 820);
            this.r_back.Name = "r_back";
            this.r_back.Size = new System.Drawing.Size(227, 110);
            this.r_back.TabIndex = 5;
            this.r_back.TabStop = false;
            this.r_back.Text = "초기 화면";
            this.r_back.UseVisualStyleBackColor = false;
            this.r_back.Click += new System.EventHandler(this.r_back_Click);
            // 
            // r_pa1
            // 
            this.r_pa1.BackColor = System.Drawing.Color.White;
            this.r_pa1.Controls.Add(this.r_game3);
            this.r_pa1.Controls.Add(this.r_game2);
            this.r_pa1.Controls.Add(this.r_game1);
            this.r_pa1.Dock = System.Windows.Forms.DockStyle.Top;
            this.r_pa1.Location = new System.Drawing.Point(0, 0);
            this.r_pa1.Name = "r_pa1";
            this.r_pa1.Size = new System.Drawing.Size(1482, 85);
            this.r_pa1.TabIndex = 11;
            // 
            // r_game3
            // 
            this.r_game3.BackColor = System.Drawing.Color.White;
            this.r_game3.Dock = System.Windows.Forms.DockStyle.Left;
            this.r_game3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.r_game3.FlatAppearance.BorderSize = 0;
            this.r_game3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.r_game3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r_game3.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold);
            this.r_game3.Location = new System.Drawing.Point(394, 0);
            this.r_game3.Name = "r_game3";
            this.r_game3.Size = new System.Drawing.Size(197, 85);
            this.r_game3.TabIndex = 5;
            this.r_game3.TabStop = false;
            this.r_game3.Text = "스네이크";
            this.r_game3.UseVisualStyleBackColor = false;
            this.r_game3.Click += new System.EventHandler(this.r_game3_Click);
            // 
            // r_game2
            // 
            this.r_game2.BackColor = System.Drawing.Color.White;
            this.r_game2.Dock = System.Windows.Forms.DockStyle.Left;
            this.r_game2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.r_game2.FlatAppearance.BorderSize = 0;
            this.r_game2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.r_game2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r_game2.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold);
            this.r_game2.Location = new System.Drawing.Point(197, 0);
            this.r_game2.Name = "r_game2";
            this.r_game2.Size = new System.Drawing.Size(197, 85);
            this.r_game2.TabIndex = 4;
            this.r_game2.TabStop = false;
            this.r_game2.Text = "오델로";
            this.r_game2.UseVisualStyleBackColor = false;
            this.r_game2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.r_game2_MouseClick);
            // 
            // r_game1
            // 
            this.r_game1.BackColor = System.Drawing.Color.White;
            this.r_game1.Dock = System.Windows.Forms.DockStyle.Left;
            this.r_game1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.r_game1.FlatAppearance.BorderSize = 0;
            this.r_game1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.r_game1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r_game1.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold);
            this.r_game1.Location = new System.Drawing.Point(0, 0);
            this.r_game1.Name = "r_game1";
            this.r_game1.Size = new System.Drawing.Size(197, 85);
            this.r_game1.TabIndex = 3;
            this.r_game1.TabStop = false;
            this.r_game1.Text = "오 목";
            this.r_game1.UseVisualStyleBackColor = false;
            this.r_game1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.r_game1_MouseClick);
            // 
            // r_memo
            // 
            this.r_memo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.r_memo.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.r_memo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.r_memo.Location = new System.Drawing.Point(1006, 1);
            this.r_memo.Name = "r_memo";
            this.r_memo.Size = new System.Drawing.Size(471, 49);
            this.r_memo.TabIndex = 10;
            this.r_memo.Text = "기록일시";
            this.r_memo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_rank
            // 
            this.r_rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.r_rank.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.r_rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.r_rank.Location = new System.Drawing.Point(2, 1);
            this.r_rank.Name = "r_rank";
            this.r_rank.Size = new System.Drawing.Size(192, 49);
            this.r_rank.TabIndex = 11;
            this.r_rank.Text = "순위";
            this.r_rank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_time
            // 
            this.r_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.r_time.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.r_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.r_time.Location = new System.Drawing.Point(685, 1);
            this.r_time.Name = "r_time";
            this.r_time.Size = new System.Drawing.Size(317, 49);
            this.r_time.TabIndex = 12;
            this.r_time.Text = "쇼요시간";
            this.r_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_nick
            // 
            this.r_nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.r_nick.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.r_nick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.r_nick.Location = new System.Drawing.Point(198, 1);
            this.r_nick.Name = "r_nick";
            this.r_nick.Size = new System.Drawing.Size(235, 49);
            this.r_nick.TabIndex = 13;
            this.r_nick.Text = "닉네임";
            this.r_nick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_count
            // 
            this.r_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.r_count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.r_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.r_count.Location = new System.Drawing.Point(437, 1);
            this.r_count.Name = "r_count";
            this.r_count.Size = new System.Drawing.Size(244, 49);
            this.r_count.TabIndex = 14;
            this.r_count.Text = "점수";
            this.r_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // r_pa2
            // 
            this.r_pa2.Controls.Add(this.label2);
            this.r_pa2.Controls.Add(this.label3);
            this.r_pa2.Controls.Add(this.label4);
            this.r_pa2.Controls.Add(this.label5);
            this.r_pa2.Controls.Add(this.label6);
            this.r_pa2.Dock = System.Windows.Forms.DockStyle.Top;
            this.r_pa2.Location = new System.Drawing.Point(0, 85);
            this.r_pa2.Name = "r_pa2";
            this.r_pa2.Size = new System.Drawing.Size(1482, 712);
            this.r_pa2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(438, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 49);
            this.label2.TabIndex = 21;
            this.label2.Text = "점수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(199, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 49);
            this.label3.TabIndex = 20;
            this.label3.Text = "닉네임";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.label4.Location = new System.Drawing.Point(686, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 49);
            this.label4.TabIndex = 19;
            this.label4.Text = "쇼요시간";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 49);
            this.label5.TabIndex = 18;
            this.label5.Text = "순위";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.label6.Location = new System.Drawing.Point(1007, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(471, 49);
            this.label6.TabIndex = 17;
            this.label6.Text = "기록일시";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.r_back);
            this.Controls.Add(this.r_pa2);
            this.Controls.Add(this.r_pa1);
            this.Name = "rank";
            this.Text = "rank";
            this.r_pa1.ResumeLayout(false);
            this.r_pa2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button r_back;
        private System.Windows.Forms.Panel r_pa1;
        private System.Windows.Forms.Button r_game3;
        private System.Windows.Forms.Button r_game2;
        private System.Windows.Forms.Button r_game1;
        private System.Windows.Forms.Label r_memo;
        private System.Windows.Forms.Label r_rank;
        private System.Windows.Forms.Label r_time;
        private System.Windows.Forms.Label r_nick;
        private System.Windows.Forms.Label r_count;
        private System.Windows.Forms.Panel r_pa2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}