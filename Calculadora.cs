namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos de entrada est�o preenchidos
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            // Realiza a soma dos n�meros e exibe o resultado
            lblResultado.Text = (numero1 + numero2).ToString();

        }
    }
}
