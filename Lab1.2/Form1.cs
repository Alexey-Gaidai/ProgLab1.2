namespace Lab1._2
{
    public partial class Form1 : Form
    {
        private IUseCases converter = new Converter();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = converter.convert(this.textBox1.Text).ToString();
            } catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}