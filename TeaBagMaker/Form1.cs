using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] TeaList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int TeaCountNum = 0;
        int m, s = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbList.SelectedIndex = 0;
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Tresult.Text = this.cbList.Text; //
        }

        private void CbList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {

            }
        }

        private void TeaBagTimer_Tick(object sender, EventArgs e)
        {
            if (TeaCountNum < 1){
                this.TeaBagTimer.Enabled = false;
                this.Tresult.ReadOnly = false;
                this.Tresult.Text = "";
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CntDownbtn_Click(object sender, EventArgs e) //버튼 클릭했을 때
        {
            if (this.cbList.Text == "홍차" || this.cbList.Text == "국화차")
                TeaCountNum = 2;

            else if (this.cbList.Text == "녹차")
                TeaCountNum = 3;

            else if (this.cbList.Text == "루이보스차")
                TeaCountNum = 5;

            
        }

        private void Tresult_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
