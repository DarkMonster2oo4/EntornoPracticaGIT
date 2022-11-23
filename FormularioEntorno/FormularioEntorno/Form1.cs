namespace FormularioEntorno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 1;
            double coste = 0;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            if (rbOrdinario.Checked)
            {
                tipoTelegrama = 'o';
            }
            //Obtengo el n�mero de palabras que forma el telegrama
            for (int i = 0; i < textoTelegrama.Length; i++)
            {
                if (textoTelegrama[i] == ' ' && textoTelegrama[i - 1] != ' ')
                {
                    numPalabras++;
                }
            }
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.50 * (numPalabras - 10);
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);

            if (numPalabras <= 1)
            {
                coste = 0;
            }

            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}