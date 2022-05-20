namespace Flash
{
    partial class board_g3
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_g1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.r_count = new System.Windows.Forms.Label();
            this.r_nick = new System.Windows.Forms.Label();
            this.r_time = new System.Windows.Forms.Label();
            this.r_rank = new System.Windows.Forms.Label();
            this.r_memo = new System.Windows.Forms.Label();
            this.b_g1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_g1
            // 
            this.b_g1.BackColor = System.Drawing.Color.White;
            this.b_g1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b_g1.Controls.Add(this.label1);
            this.b_g1.Controls.Add(this.r_count);
            this.b_g1.Controls.Add(this.r_nick);
            this.b_g1.Controls.Add(this.r_time);
            this.b_g1.Controls.Add(this.r_rank);
            this.b_g1.Controls.Add(this.r_memo);
            this.b_g1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_g1.Location = new System.Drawing.Point(0, 0);
            this.b_g1.Name = "b_g1";
            this.b_g1.Size = new System.Drawing.Size(1482, 712);
            this.b_g1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(589, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 49);
            this.label1.TabIndex = 15;
            this.label1.Text = "스네이크";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // board_g3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.b_g1);
            this.Name = "board_g3";
            this.Size = new System.Drawing.Size(1482, 712);
            this.b_g1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel b_g1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label r_count;
        private System.Windows.Forms.Label r_nick;
        private System.Windows.Forms.Label r_time;
        private System.Windows.Forms.Label r_rank;
        private System.Windows.Forms.Label r_memo;
    }
}
