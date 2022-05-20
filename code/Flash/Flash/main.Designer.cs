namespace Flash
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.m_main = new System.Windows.Forms.Label();
            this.game1 = new System.Windows.Forms.Button();
            this.game2 = new System.Windows.Forms.Button();
            this.game3 = new System.Windows.Forms.Button();
            this.rankbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.userbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.m_user1 = new System.Windows.Forms.Label();
            this.m_user2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // m_main
            // 
            this.m_main.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold);
            this.m_main.Location = new System.Drawing.Point(611, 76);
            this.m_main.Name = "m_main";
            this.m_main.Size = new System.Drawing.Size(303, 82);
            this.m_main.TabIndex = 0;
            this.m_main.Text = "플래시 게임";
            // 
            // game1
            // 
            this.game1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.game1.FlatAppearance.BorderSize = 0;
            this.game1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.game1.ForeColor = System.Drawing.Color.Black;
            this.game1.Location = new System.Drawing.Point(513, 223);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(447, 141);
            this.game1.TabIndex = 1;
            this.game1.TabStop = false;
            this.game1.Text = "            오 목";
            this.game1.UseVisualStyleBackColor = false;
            this.game1.Click += new System.EventHandler(this.game1_Click);
            // 
            // game2
            // 
            this.game2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(209)))), ((int)(((byte)(208)))));
            this.game2.FlatAppearance.BorderSize = 0;
            this.game2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game2.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.game2.Location = new System.Drawing.Point(513, 423);
            this.game2.Name = "game2";
            this.game2.Size = new System.Drawing.Size(447, 141);
            this.game2.TabIndex = 2;
            this.game2.TabStop = false;
            this.game2.Text = "            오델로";
            this.game2.UseVisualStyleBackColor = false;
            this.game2.Click += new System.EventHandler(this.game2_Click);
            // 
            // game3
            // 
            this.game3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(166)))), ((int)(((byte)(232)))));
            this.game3.FlatAppearance.BorderSize = 0;
            this.game3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game3.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.game3.Location = new System.Drawing.Point(513, 623);
            this.game3.Name = "game3";
            this.game3.Size = new System.Drawing.Size(447, 141);
            this.game3.TabIndex = 3;
            this.game3.TabStop = false;
            this.game3.Text = "            스네이크";
            this.game3.UseVisualStyleBackColor = false;
            this.game3.Click += new System.EventHandler(this.game3_Click);
            // 
            // rankbtn
            // 
            this.rankbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(125)))));
            this.rankbtn.FlatAppearance.BorderSize = 0;
            this.rankbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rankbtn.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.rankbtn.Location = new System.Drawing.Point(1226, 821);
            this.rankbtn.Name = "rankbtn";
            this.rankbtn.Size = new System.Drawing.Size(227, 110);
            this.rankbtn.TabIndex = 4;
            this.rankbtn.TabStop = false;
            this.rankbtn.Text = "랭킹";
            this.rankbtn.UseVisualStyleBackColor = false;
            this.rankbtn.Click += new System.EventHandler(this.rankbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(526, 437);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(526, 636);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // userbtn
            // 
            this.userbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.userbtn.FlatAppearance.BorderSize = 0;
            this.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userbtn.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.userbtn.ForeColor = System.Drawing.Color.White;
            this.userbtn.Location = new System.Drawing.Point(30, 821);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(227, 110);
            this.userbtn.TabIndex = 8;
            this.userbtn.TabStop = false;
            this.userbtn.Text = "신규등록";
            this.userbtn.UseVisualStyleBackColor = false;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 110);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "기존등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_user1
            // 
            this.m_user1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.m_user1.Location = new System.Drawing.Point(1204, 555);
            this.m_user1.Name = "m_user1";
            this.m_user1.Size = new System.Drawing.Size(111, 69);
            this.m_user1.TabIndex = 10;
            this.m_user1.Text = "User1";
            this.m_user1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_user2
            // 
            this.m_user2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.m_user2.Location = new System.Drawing.Point(1204, 673);
            this.m_user2.Name = "m_user2";
            this.m_user2.Size = new System.Drawing.Size(111, 69);
            this.m_user2.TabIndex = 11;
            this.m_user2.Text = "User2";
            this.m_user2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1276, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 69);
            this.label1.TabIndex = 12;
            this.label1.Text = "사용자 닉네임";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1276, 726);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 69);
            this.label2.TabIndex = 13;
            this.label2.Text = "사용자 닉네임";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_user2);
            this.Controls.Add(this.m_user1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userbtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_main);
            this.Controls.Add(this.rankbtn);
            this.Controls.Add(this.game3);
            this.Controls.Add(this.game2);
            this.Controls.Add(this.game1);
            this.Name = "main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_main;
        private System.Windows.Forms.Button game1;
        private System.Windows.Forms.Button game2;
        private System.Windows.Forms.Button game3;
        private System.Windows.Forms.Button rankbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button userbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label m_user1;
        private System.Windows.Forms.Label m_user2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

