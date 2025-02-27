namespace A_minha_aplicação
{
    public partial class Form1 : Form
    {
        private DateTime contadorTempo;


        public Form1()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString();
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 10));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled)
            {
                button1.Text = "Parar";
            }
            else
            {
                button1.Text = "Iniciar";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contadorTempo = new DateTime(0);
            toolStripStatusLabelContador.Text = contadorTempo.ToLongTimeString(); // Atualiza o display
        }
        private void toolStripStatusLabelContador_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string info = $"({toolStripStatusLabelHora.Text} @ {toolStripStatusLabelContador.Text})";
            listBox1.Items.Add(info);
        }
    }
}
