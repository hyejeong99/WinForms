using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lightP03
{
    public partial class Form2 : Form
    {

        //Form1 리스트뷰 값 받아오기
        public static int totalNum;
        public static string num1;
        public static string id1;
        public static string nick1;
        public static int state1;

        public static string num2;
        public static string id2;
        public static string nick2;
        public static int state2;

        public static string num3;
        public static string id3;
        public static string nick3;
        public static int state3;

        public static string num4;
        public static string id4;
        public static string nick4;
        public static int state4;

        public static string num5;
        public static string id5;
        public static string nick5;
        public static int state5;

        //기기 상태 출력
        public string state1L, state2L, state3L, state4L, state5L;

        public Form2()
        {
            InitializeComponent();

            //받아온 값으로 상태값 변경
            //STATE1
            label26.Text = nick1;
            if (state1 == 1)
            {
                state1L = "신호 없음";
                pictureBox6.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (state1 == 2)
            {
                state1L = "준비";
                pictureBox6.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (state1 == 3)
            {
                state1L = "작동중";
                pictureBox6.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (state1 == 4)
            {
                state1L = "종료";
                pictureBox6.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else
            {
                state1L = "에러";
                pictureBox6.Image = Image.FromFile(@"C:\projectImg\state5.png");
            }

            //STATE2
            label25.Text = nick2;
            if (state2 == 1)
            {
                state2L = "신호 없음";
                pictureBox7.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (state2 == 2)
            {
                state2L = "준비";
                pictureBox7.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (state2 == 3)
            {
                state2L = "작동중";
                pictureBox7.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (state2 == 4)
            {
                state2L = "종료";
                pictureBox7.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else
            {
                state2L = "에러";
                pictureBox7.Image = Image.FromFile(@"C:\projectImg\state5.png");
            }

            //STATE3
            label24.Text = nick3;
            if (state3 == 1)
            {
                state3L = "신호 없음";
                pictureBox8.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (state3 == 2)
            {
                state3L = "준비";
                pictureBox8.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (state3 == 3)
            {
                state3L = "작동중";
                pictureBox8.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (state3 == 4)
            {
                state3L = "종료";
                pictureBox8.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else
            {
                state3L = "에러";
                pictureBox8.Image = Image.FromFile(@"C:\projectImg\state5.png");
            }

            //STATE4
            label23.Text = nick4;
            if (state4 == 1)
            {
                state4L = "신호 없음";
                pictureBox9.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (state4 == 2)
            {
                state4L = "준비";
                pictureBox9.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (state4 == 3)
            {
                state4L = "작동중";
                pictureBox9.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (state4 == 4)
            {
                state4L = "종료";
                pictureBox9.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else
            {
                state4L = "에러";
                pictureBox9.Image = Image.FromFile(@"C:\projectImg\state5.png");
            }

            //STATE5
            label22.Text = nick5;
            if (state5 == 1)
            {
                state5L = "신호 없음";
                pictureBox10.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (state5 == 2)
            {
                state5L = "준비";
                pictureBox10.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (state5 == 3)
            {
                state5L = "작동중";
                pictureBox10.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (state5 == 4)
            {
                state5L = "종료";
                pictureBox10.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else
            {
                state5L = "에러";
                pictureBox10.Image = Image.FromFile(@"C:\projectImg\state5.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //종료
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //설정 화면으로 이동
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             //resultL.Text = "결과 \n발전소명 : " + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + ", 기기 ID : " + dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        
        //프로그레스바 데이터 증가시키기
        private void button4_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = 100; ///최대값을 설정한다. 
            this.timer1.Enabled = true;
            button1.Enabled = false;

            if (progressBar.Value == progressBar.Maximum)
            {
                this.timer1.Enabled = false;
                button1.Enabled = true;
                return;
            }
            this.progressBar.Value = this.progressBar.Value + 10;//버튼 누를 때마다 10퍼씩 증가
        }

        private void button17_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100; ///최대값을 설정한다. 
            this.timer1.Enabled = true;
            button1.Enabled = false;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Enabled = false;
                button1.Enabled = true;
                return;
            }
            this.progressBar1.Value = this.progressBar1.Value + 10;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            progressBar2.Maximum = 100; ///최대값을 설정한다. 
            this.timer1.Enabled = true;
            button1.Enabled = false;

            if (progressBar2.Value == progressBar2.Maximum)
            {
                this.timer1.Enabled = false;
                button1.Enabled = true;
                return;
            }
            this.progressBar2.Value = this.progressBar2.Value + 10;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            progressBar3.Maximum = 100; ///최대값을 설정한다. 
            this.timer1.Enabled = true;
            button1.Enabled = false;

            if (progressBar3.Value == progressBar3.Maximum)
            {
                this.timer1.Enabled = false;
                button1.Enabled = true;
                return;
            }
            this.progressBar3.Value = this.progressBar3.Value + 10;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            progressBar4.Maximum = 100; ///최대값을 설정한다. 
            this.timer1.Enabled = true;
            button1.Enabled = false;

            if (progressBar4.Value == progressBar4.Maximum)
            {
                this.timer1.Enabled = false;
                button1.Enabled = true;
                return;
            }
            this.progressBar4.Value = this.progressBar4.Value + 10;
        }
        //작동 버튼 클릭했을 때
        private void btnRun_Click(object sender, EventArgs e)
        {
            resultL.Text = "1001 기기의 작동 버튼을 클릭했습니다.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultL.Text = "1002 기기의 작동 버튼을 클릭했습니다.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultL.Text = "1003 기기의 작동 버튼을 클릭했습니다.";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resultL.Text = "1004 기기의 작동 버튼을 클릭했습니다.";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultL.Text = "1005 기기의 작동 버튼을 클릭했습니다.";
        }
        //멈춤 버튼 클릭했을 때
        private void btnStop_Click(object sender, EventArgs e)
        {
            resultL.Text = "1001 기기의 멈춤 버튼을 클릭했습니다.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultL.Text = "1002 기기의 멈춤 버튼을 클릭했습니다.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultL.Text = "1003 기기의 멈춤 버튼을 클릭했습니다.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resultL.Text = "1004 기기의 멈춤 버튼을 클릭했습니다.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultL.Text = "1005 기기의 멈춤 버튼을 클릭했습니다.";
        }
        //원래 자리로 돌아가는 버튼 클릭했을 때
        private void btnHome_Click(object sender, EventArgs e)
        {
            resultL.Text = "1001 기기의 제자리 버튼을 클릭했습니다.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultL.Text = "1002 기기의 제자리 버튼을 클릭했습니다.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultL.Text = "1003 기기의 제자리 버튼을 클릭했습니다.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resultL.Text = "1004 기기의 제자리 버튼을 클릭했습니다.";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            resultL.Text = "1005 기기의 제자리 버튼을 클릭했습니다.";
        }
        //기기 상태 출력
        private void label2_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1001, 기기 별명 : "+label26.Text+", 기기 상태 : "+state1L;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1002, 기기 별명 : " + label25.Text + ", 기기 상태 : " + state2L;
        }
        private void label13_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1003, 기기 별명 : " + label24.Text + ", 기기 상태 : " + state3L;
        }
        private void label17_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1004, 기기 별명 : " + label23.Text + ", 기기 상태 : " + state4L;
        }
        private void label21_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1005, 기기 별명 : " + label22.Text + ", 기기 상태 : " + state5L;
        }
    }
}
