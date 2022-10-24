using System.Windows.Forms;

namespace guzik2
{
    public partial class Form1 : Form
    {

        readonly Random r;
        int punkt;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            punkt = 0;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton();
            punkt++;
            toolStripStatusLabel1.Text = "Punkty: " + punkt.ToString();
            timer1.Stop();
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveButton();
            punkt = 0;
            toolStripStatusLabel1.Text = "Punkty: " + punkt.ToString();
        }

        private void MoveButton()
        {
            int maxX = this.Size.Width - button1.Size.Width - 50;
            int maxY = this.Size.Height - button1.Size.Height - 50;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;

        }
    }
}