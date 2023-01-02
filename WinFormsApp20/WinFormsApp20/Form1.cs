namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciadamsolauzaklýk, ikinciadamsolauzaklýk, ucuncuadamsolauzaklýk;
        Random rastgele = new Random();
        int secim;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(18, 125);
            pictureBox2.Location = new Point(18, 296);
            pictureBox3.Location = new Point(18, 451);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secim = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secim = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            secim = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciadamsolauzaklýk = pictureBox1.Left;
            ikinciadamsolauzaklýk = pictureBox2.Left;
            ucuncuadamsolauzaklýk = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int insanGenislik1 = pictureBox1.Width;
            int insanGenislik2 = pictureBox2.Width;
            int insanGenislik3 = pictureBox3.Width;

            int bitis = label3.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(10, 20);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(10, 20);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(10, 20);

            if (insanGenislik1 + pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler 1.insan kazandýnýz");
                if (secim == 1)
                {
                    MessageBox.Show("seçiminiz doðru 1.insan kazandý");
                }
                else
                {
                    MessageBox.Show("seçim yanlýþ");
                }
            }




            if (insanGenislik2 + pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler 2.insan kazandýnýz");
                if (secim == 2)
                {
                    MessageBox.Show("seçiminiz doðru 2.insan kazandý");
                }
                else
                {
                    MessageBox.Show("seçim yanlýþ");
                }
            }

            if (insanGenislik3 + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler 3.insan kazandýnýz");
                if (secim == 3)
                {
                    MessageBox.Show("seçiminiz doðru 3.insan kazandý");
                }
                else
                {
                    MessageBox.Show("seçim yanlýþ");
                }
            }
        }
    }
}