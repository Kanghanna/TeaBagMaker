namespace TeaBagMaker
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
            this.components = new System.ComponentModel.Container();
            this.cntDownbtn = new System.Windows.Forms.Button();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.Tresult = new System.Windows.Forms.TextBox();
            this.TeaBagTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cntDownbtn
            // 
            this.cntDownbtn.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cntDownbtn.Location = new System.Drawing.Point(12, 51);
            this.cntDownbtn.Name = "cntDownbtn";
            this.cntDownbtn.Size = new System.Drawing.Size(259, 56);
            this.cntDownbtn.TabIndex = 0;
            this.cntDownbtn.Text = "담그기!";
            this.cntDownbtn.UseVisualStyleBackColor = true;
            this.cntDownbtn.Click += new System.EventHandler(this.CntDownbtn_Click);
            // 
            // cbList
            // 
            this.cbList.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbList.FormattingEnabled = true;
            this.cbList.Location = new System.Drawing.Point(13, 13);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(259, 32);
            this.cbList.TabIndex = 1;
            this.cbList.SelectedIndexChanged += new System.EventHandler(this.CbList_SelectedIndexChanged);
            this.cbList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbList_KeyPress);
            // 
            // Tresult
            // 
            this.Tresult.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tresult.Location = new System.Drawing.Point(13, 114);
            this.Tresult.Name = "Tresult";
            this.Tresult.Size = new System.Drawing.Size(258, 50);
            this.Tresult.TabIndex = 2;
            this.Tresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tresult.TextChanged += new System.EventHandler(this.Tresult_TextChanged);
            // 
            // TeaBagTimer
            // 
            this.TeaBagTimer.Interval = 1000;
            this.TeaBagTimer.Tick += new System.EventHandler(this.TeaBagTimer_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.Tresult);
            this.Controls.Add(this.cbList);
            this.Controls.Add(this.cntDownbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TeaBagMaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cntDownbtn;
        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.TextBox Tresult;
        private System.Windows.Forms.Timer TeaBagTimer;
    }
}

