
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
            this.NewButton1 = new System.Windows.Forms.Button();
            this.NewButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewButton1
            // 
            this.NewButton1.Location = new System.Drawing.Point(95, 25);
            this.NewButton1.Name = "NewButton1";
            this.NewButton1.Size = new System.Drawing.Size(243, 143);
            this.NewButton1.TabIndex = 0;
            this.NewButton1.Text = "newbutton1";
            this.NewButton1.UseVisualStyleBackColor = true;
            this.NewButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonClick);
            // 
            // NewButton2
            // 
            this.NewButton2.Location = new System.Drawing.Point(95, 212);
            this.NewButton2.Name = "NewButton2";
            this.NewButton2.Size = new System.Drawing.Size(243, 143);
            this.NewButton2.TabIndex = 1;
            this.NewButton2.Text = "newbutton2";
            this.NewButton2.UseVisualStyleBackColor = true;
            this.NewButton2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewButton2);
            this.Controls.Add(this.NewButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewButton1;
        private System.Windows.Forms.Button NewButton2;
    }
}

