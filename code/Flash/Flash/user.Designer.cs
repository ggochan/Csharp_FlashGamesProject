namespace Flash
{
    partial class User
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
            this.nickbox = new System.Windows.Forms.TextBox();
            this.u_nick = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nickbox
            // 
            this.nickbox.Location = new System.Drawing.Point(211, 73);
            this.nickbox.Multiline = true;
            this.nickbox.Name = "nickbox";
            this.nickbox.Size = new System.Drawing.Size(200, 30);
            this.nickbox.TabIndex = 2;
            this.nickbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // u_nick
            // 
            this.u_nick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.u_nick.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.u_nick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.u_nick.Location = new System.Drawing.Point(69, 63);
            this.u_nick.Name = "u_nick";
            this.u_nick.Size = new System.Drawing.Size(128, 46);
            this.u_nick.TabIndex = 5;
            this.u_nick.Text = "닉네임";
            this.u_nick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(152, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(474, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.u_nick);
            this.Controls.Add(this.nickbox);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nickbox;
        private System.Windows.Forms.Label u_nick;
        private System.Windows.Forms.Button button1;
    }
}