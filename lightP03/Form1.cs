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
    public partial class Form1 : Form
    {

        Image lr = Properties.Resources.leftR;
        Image ud = Properties.Resources.upD;

        //기기 상태 표시 확인
        int clickN1, clickN2, clickN3, clickN4, clickN5 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //resultL.Text = "결과 \n발전소명 : " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + ", 기기 ID : " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //종료
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //작동 화면으로 이동
            this.Visible = false;
            Form2 showForm2 = new Form2();
            showForm2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit(); //종료
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Form2에 값 넘겨주기
            Form2.num1 = label2.ToString();
            Form2.id1 = label3.ToString();
            Form2.nick1 = textBox1.Text.ToString();
            Form2.state1 = clickN1;

            Form2.num2 = label9.ToString();
            Form2.id2 = label8.ToString();
            Form2.nick2 = textBox6.Text.ToString();
            Form2.state2 = clickN2;

            Form2.num3 = label13.ToString();
            Form2.id3 = label12.ToString();
            Form2.nick3 = textBox9.Text.ToString();
            Form2.state3 = clickN3;

            Form2.num4 = label17.ToString();
            Form2.id4 = label16.ToString();
            Form2.nick4 = textBox12.Text.ToString();
            Form2.state4 = clickN4;

            Form2.num5 = label21.ToString();
            Form2.id5 = label20.ToString();
            Form2.nick5 = textBox15.Text.ToString();
            Form2.state5 = clickN5;

            MessageBox.Show("설정 완료되었습니다.");
        }

        //버튼 클릭해서 기기 상태 수정
        private void button3_Click(object sender, EventArgs e)
        {
            clickN1++;
            if (clickN1 == 1)
            {
                resultL.Text = "1001 기기의 상태를 [신호 없음](으)로 변경했습니다.";
                button3.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (clickN1 == 2)
            {
                resultL.Text = "1001 기기의 상태를 [준비](으)로 변경했습니다.";
                button3.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (clickN1 == 3)
            {
                resultL.Text = "1001 기기의 상태를 [작동중](으)로 변경했습니다.";
                button3.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (clickN1 == 4)
            {
                resultL.Text = "1001 기기의 상태를 [종료](으)로 변경했습니다.";
                button3.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else if (clickN1 == 5)
            {
                resultL.Text = "1001 기기의 상태를 [에러](으)로 변경했습니다.";
                button3.Image = Image.FromFile(@"C:\projectImg\state5.png");
                clickN1 = 0;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clickN2++;
            if (clickN2 == 1)
            {
                resultL.Text = "1002 기기의 상태를 [신호 없음](으)로 변경했습니다.";
                button4.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (clickN2 == 2)
            {
                resultL.Text = "1002 기기의 상태를 [준비](으)로 변경했습니다.";
                button4.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (clickN2 == 3)
            {
                resultL.Text = "1002 기기의 상태를 [작동중](으)로 변경했습니다.";
                button4.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (clickN2 == 4)
            {
                resultL.Text = "1002 기기의 상태를 [종료](으)로 변경했습니다.";
                button4.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else if (clickN2 == 5)
            {
                resultL.Text = "1002 기기의 상태를 [에러](으)로 변경했습니다.";
                button4.Image = Image.FromFile(@"C:\projectImg\state5.png");
                clickN2 = 0;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            clickN3++;
            if (clickN3 == 1)
            {
                resultL.Text = "1003 기기의 상태를 [신호 없음](으)로 변경했습니다.";
                button5.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (clickN3 == 2)
            {
                resultL.Text = "1003 기기의 상태를 [준비](으)로 변경했습니다.";
                button5.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (clickN3 == 3)
            {
                resultL.Text = "1003 기기의 상태를 [작동중](으)로 변경했습니다.";
                button5.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (clickN3 == 4)
            {
                resultL.Text = "1003 기기의 상태를 [종료](으)로 변경했습니다.";
                button5.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else if (clickN3 == 5)
            {
                resultL.Text = "1003 기기의 상태를 [에러](으)로 변경했습니다.";
                button5.Image = Image.FromFile(@"C:\projectImg\state5.png");
                clickN3 = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickN4++;
            if (clickN4 == 1)
            {
                resultL.Text = "1004 기기의 상태를 [신호 없음](으)로 변경했습니다.";
                button6.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (clickN4 == 2)
            {
                resultL.Text = "1004 기기의 상태를 [준비](으)로 변경했습니다.";
                button6.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (clickN4 == 3)
            {
                resultL.Text = "1004 기기의 상태를 [작동중](으)로 변경했습니다.";
                button6.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (clickN4 == 4)
            {
                resultL.Text = "1004 기기의 상태를 [종료](으)로 변경했습니다.";
                button6.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else if (clickN4 == 5)
            {
                resultL.Text = "1004 기기의 상태를 [에러](으)로 변경했습니다.";
                button6.Image = Image.FromFile(@"C:\projectImg\state5.png");
                clickN4 = 0;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            clickN5++;
            if (clickN5 == 1)
            {
                resultL.Text = "1005 기기의 상태를 [신호 없음](으)로 변경했습니다.";
                button7.Image = Image.FromFile(@"C:\projectImg\state6.png");
            }
            else if (clickN5 == 2)
            {
                resultL.Text = "1005 기기의 상태를 [준비](으)로 변경했습니다.";
                button7.Image = Image.FromFile(@"C:\projectImg\state7.png");
            }
            else if (clickN5 == 3)
            {
                resultL.Text = "1005 기기의 상태를 [작동중](으)로 변경했습니다.";
                button7.Image = Image.FromFile(@"C:\projectImg\state8.png");
            }
            else if (clickN5 == 4)
            {
                resultL.Text = "1005 기기의 상태를 [종료](으)로 변경했습니다.";
                button7.Image = Image.FromFile(@"C:\projectImg\state9.png");
            }
            else if (clickN5 == 5)
            {
                resultL.Text = "1005 기기의 상태를 [에러](으)로 변경했습니다.";
                button7.Image = Image.FromFile(@"C:\projectImg\state5.png");
                clickN5 = 0;
            }
        }

        //라디오버튼 클릭했을 때
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1001 기기의 수평 버튼을 클릭했습니다.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1001 기기의 수직 버튼을 클릭했습니다.";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1002 기기의 수평 버튼을 클릭했습니다.";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1002 기기의 수직 버튼을 클릭했습니다.";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1003 기기의 수평 버튼을 클릭했습니다.";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1003 기기의 수직 버튼을 클릭했습니다.";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1004 기기의 수평 버튼을 클릭했습니다.";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1004 기기의 수직 버튼을 클릭했습니다.";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1005 기기의 수평 버튼을 클릭했습니다.";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            resultL.Text = "1005 기기의 수직 버튼을 클릭했습니다.";
        }

        //기기 상태 출력
        private void label2_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1001, 기기 별명 : " + textBox1.Text + ", 가로 : " + textBox2.Text + ", 세로 : " + textBox3.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1002, 기기 별명 : " + textBox6.Text + ", 가로 : " + textBox5.Text + ", 세로 : " + textBox4.Text;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1003, 기기 별명 : " + textBox9.Text + ", 가로 : " + textBox8.Text + ", 세로 : " + textBox7.Text;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1004, 기기 별명 : " + textBox12.Text + ", 가로 : " + textBox11.Text + ", 세로 : " + textBox10.Text;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            resultL.Text = "기기 ID : 1005, 기기 별명 : " + textBox15.Text + ", 가로 : " + textBox14.Text + ", 세로 : " + textBox13.Text;
        }
    }
}
