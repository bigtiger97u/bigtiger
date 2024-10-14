namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(280, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "hello_label";
            this.label2.Click += new System.EventHandler(this.시작);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 15F);
            this.button1.Location = new System.Drawing.Point(330, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 105);
            this.button1.TabIndex = 2;
            this.button1.Text = "버튼";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 866);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);

            this.Name = "Form1";
            this.Text = "결과";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

