namespace Flash
{
    partial class game3
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
            this.g3_pa1 = new System.Windows.Forms.Panel();
            this.endla = new System.Windows.Forms.Label();
            this.g3_la = new System.Windows.Forms.Label();
            this.g3_la1 = new System.Windows.Forms.Label();
            this.g3_la2 = new System.Windows.Forms.Label();
            this.g3_la3 = new System.Windows.Forms.Label();
            this.g3_la4 = new System.Windows.Forms.Label();
            this.g3_lv = new System.Windows.Forms.Label();
            this.g3_next = new System.Windows.Forms.Label();
            this.g3_total = new System.Windows.Forms.Label();
            this.g3_count = new System.Windows.Forms.Label();
            this.GameOverTimer = new System.Windows.Forms.Timer(this.components);
            this.g3_btn2 = new System.Windows.Forms.Button();
            this.g3_btn1 = new System.Windows.Forms.Button();
            this.g3_pa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // g3_pa1
            // 
            this.g3_pa1.BackColor = System.Drawing.Color.White;
            this.g3_pa1.Controls.Add(this.endla);
            this.g3_pa1.Location = new System.Drawing.Point(12, 12);
            this.g3_pa1.Name = "g3_pa1";
            this.g3_pa1.Size = new System.Drawing.Size(1050, 929);
            this.g3_pa1.TabIndex = 0;
            this.g3_pa1.Paint += new System.Windows.Forms.PaintEventHandler(this.g3_pa1_Paint);
            // 
            // endla
            // 
            this.endla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.endla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endla.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.endla.Location = new System.Drawing.Point(345, 359);
            this.endla.Name = "endla";
            this.endla.Size = new System.Drawing.Size(385, 234);
            this.endla.TabIndex = 5;
            this.endla.Text = "게임종료\r\n\r\n다시시작 : ENTER";
            this.endla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endla.Visible = false;
            // 
            // g3_la
            // 
            this.g3_la.BackColor = System.Drawing.Color.White;
            this.g3_la.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_la.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.g3_la.Location = new System.Drawing.Point(1149, 104);
            this.g3_la.Name = "g3_la";
            this.g3_la.Size = new System.Drawing.Size(256, 87);
            this.g3_la.TabIndex = 3;
            this.g3_la.Text = "사용자 닉네임";
            this.g3_la.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_la1
            // 
            this.g3_la1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.g3_la1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_la1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.g3_la1.Location = new System.Drawing.Point(1145, 334);
            this.g3_la1.Name = "g3_la1";
            this.g3_la1.Size = new System.Drawing.Size(76, 58);
            this.g3_la1.TabIndex = 4;
            this.g3_la1.Text = "LV :";
            this.g3_la1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_la2
            // 
            this.g3_la2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.g3_la2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_la2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.g3_la2.Location = new System.Drawing.Point(1152, 402);
            this.g3_la2.Name = "g3_la2";
            this.g3_la2.Size = new System.Drawing.Size(86, 58);
            this.g3_la2.TabIndex = 5;
            this.g3_la2.Text = "NEXT :";
            this.g3_la2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_la3
            // 
            this.g3_la3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.g3_la3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_la3.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.g3_la3.Location = new System.Drawing.Point(1153, 470);
            this.g3_la3.Name = "g3_la3";
            this.g3_la3.Size = new System.Drawing.Size(97, 58);
            this.g3_la3.TabIndex = 6;
            this.g3_la3.Text = "TOTAL :";
            this.g3_la3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_la4
            // 
            this.g3_la4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.g3_la4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_la4.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.g3_la4.Location = new System.Drawing.Point(1151, 565);
            this.g3_la4.Name = "g3_la4";
            this.g3_la4.Size = new System.Drawing.Size(109, 58);
            this.g3_la4.TabIndex = 7;
            this.g3_la4.Text = "COUNT :";
            this.g3_la4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_lv
            // 
            this.g3_lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.g3_lv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_lv.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.g3_lv.Location = new System.Drawing.Point(1335, 334);
            this.g3_lv.Name = "g3_lv";
            this.g3_lv.Size = new System.Drawing.Size(76, 58);
            this.g3_lv.TabIndex = 8;
            this.g3_lv.Text = "0";
            this.g3_lv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_next
            // 
            this.g3_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.g3_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_next.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.g3_next.Location = new System.Drawing.Point(1335, 402);
            this.g3_next.Name = "g3_next";
            this.g3_next.Size = new System.Drawing.Size(76, 58);
            this.g3_next.TabIndex = 9;
            this.g3_next.Text = "0";
            this.g3_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_total
            // 
            this.g3_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.g3_total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_total.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.g3_total.Location = new System.Drawing.Point(1335, 470);
            this.g3_total.Name = "g3_total";
            this.g3_total.Size = new System.Drawing.Size(76, 58);
            this.g3_total.TabIndex = 10;
            this.g3_total.Text = "0";
            this.g3_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_count
            // 
            this.g3_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.g3_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_count.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.g3_count.Location = new System.Drawing.Point(1335, 565);
            this.g3_count.Name = "g3_count";
            this.g3_count.Size = new System.Drawing.Size(76, 58);
            this.g3_count.TabIndex = 11;
            this.g3_count.Text = "0";
            this.g3_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // g3_btn2
            // 
            this.g3_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.g3_btn2.FlatAppearance.BorderSize = 0;
            this.g3_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_btn2.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.g3_btn2.ForeColor = System.Drawing.Color.White;
            this.g3_btn2.Location = new System.Drawing.Point(1169, 820);
            this.g3_btn2.Name = "g3_btn2";
            this.g3_btn2.Size = new System.Drawing.Size(209, 72);
            this.g3_btn2.TabIndex = 13;
            this.g3_btn2.Text = "이전 화면";
            this.g3_btn2.UseVisualStyleBackColor = false;
            this.g3_btn2.Click += new System.EventHandler(this.g3_btn2_Click);
            // 
            // g3_btn1
            // 
            this.g3_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(71)))));
            this.g3_btn1.FlatAppearance.BorderSize = 0;
            this.g3_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3_btn1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.g3_btn1.ForeColor = System.Drawing.Color.White;
            this.g3_btn1.Location = new System.Drawing.Point(1169, 722);
            this.g3_btn1.Name = "g3_btn1";
            this.g3_btn1.Size = new System.Drawing.Size(209, 72);
            this.g3_btn1.TabIndex = 12;
            this.g3_btn1.Text = "랭킹 보기";
            this.g3_btn1.UseVisualStyleBackColor = false;
            this.g3_btn1.Click += new System.EventHandler(this.g3_btn1_Click);
            // 
            // game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.g3_btn2);
            this.Controls.Add(this.g3_btn1);
            this.Controls.Add(this.g3_count);
            this.Controls.Add(this.g3_total);
            this.Controls.Add(this.g3_next);
            this.Controls.Add(this.g3_lv);
            this.Controls.Add(this.g3_la4);
            this.Controls.Add(this.g3_la3);
            this.Controls.Add(this.g3_la2);
            this.Controls.Add(this.g3_la1);
            this.Controls.Add(this.g3_la);
            this.Controls.Add(this.g3_pa1);
            this.Name = "game3";
            this.Text = "game3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game3_KeyUp);
            this.g3_pa1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel g3_pa1;
        private System.Windows.Forms.Label g3_la;
        private System.Windows.Forms.Label g3_la1;
        private System.Windows.Forms.Label g3_la2;
        private System.Windows.Forms.Label g3_la3;
        private System.Windows.Forms.Label g3_la4;
        private System.Windows.Forms.Label g3_lv;
        private System.Windows.Forms.Label g3_next;
        private System.Windows.Forms.Label g3_total;
        private System.Windows.Forms.Label g3_count;
        private System.Windows.Forms.Timer GameOverTimer;
        private System.Windows.Forms.Button g3_btn2;
        private System.Windows.Forms.Button g3_btn1;
        private System.Windows.Forms.Label endla;
    }
}