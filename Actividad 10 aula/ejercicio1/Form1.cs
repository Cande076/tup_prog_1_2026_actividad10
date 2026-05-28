namespace ejercicio1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        this.Text = tbValor.Text;
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }
}
