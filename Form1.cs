namespace _9._6hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("���� �����˴ϴ�.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("���� ����˴ϴ�.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("������ �����Ͻðڽ��ϱ�?","FormClosing �׽�Ʈ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g= e.Graphics;
            Random r=new Random();
            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }
    }
}