namespace meu_bloco_de_notas
{
    public partial class Form1 : Form
    {
        string filename {  get; set; }
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            filename = openFileDialog.FileName;
            if (result == DialogResult.OK)
            {
                string text = File.ReadAllText(filename);
                textBox1.Text = text;
                label1.Text = filename;
            }
        }

        private void buttonsalvar_Click(object sander, EventArgs e)
        {
            File.WriteAllText(filename, textBox1.Text);
        }
    }
}
