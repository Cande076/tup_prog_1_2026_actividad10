namespace ejercicio1;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    NumericService service = new NumericService();

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        this.Text = tbValor.Text;
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        int valor = Convert.ToInt32(tbValor.Text);
        service.Registrar(valor);
        tbValor.Text = "";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        double promedio = service.Promedio();
        lbResultado.Text = promedio.ToString();
    }

    private void tbBuscar_TextChanged(object sender, EventArgs e)
    {

    }

    private void tbResultado_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        int idx = Convert.ToInt32(tbBuscar.Text);
        int valor = service.VerValor(idx);
        tbResultado.Text = valor.ToString();
    }

    private void btnListarOrdenado_Click(object sender, EventArgs e)
    {
        int contador = service.VerContador();

        for (int i = 0; i < contador; i++)
        {
            int valor =service.MostrarValores(i);
            tbResultado.Text += valor.ToString();
        }
    }
}
