using System.Diagnostics;

namespace MyBusineesCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        /*
         private void button1_Click(object sender, EventArgs e)
         {
             Random rd = new Random();
             // 0~255 사이의 R, G, B 값을 무작위로 생성하여 배경색에 적용
             this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
         }
         */
        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // 0~255 사이의 R, G, B 값을 무작위로 생성하여 배경색에 적용
            Color c = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
            this.BackColor = c;

            // 이름/소속/메일을 적은 텍스트박스의 배경도 동일 색으로 맞춤
            textBox1.BackColor = c;
            textBox2.BackColor = c;
            textBox3.BackColor = c;



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기 로드 시 텍스트박스 배경색을 폼 배경색과 맞춥니다.
            Color c = this.BackColor;
            textBox1.BackColor = c;
            textBox2.BackColor = c;
            textBox3.BackColor = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/yupo5710",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.profile2;
        }


        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None; // 원래 스타일로 복원
        }


    }
}
