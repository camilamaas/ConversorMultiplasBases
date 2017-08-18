using System;
using System.Windows.Forms;

namespace ConversorMultiplasBases
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void botaoConverter_Click(object sender, EventArgs e)
        {
            string valorInformado = txtNumeroConverter.Text;
            Conversoes converter = new Conversoes();

            if (!string.IsNullOrEmpty(valorInformado))
            {

                if (entradaDecimal.Checked)
                {
                    listaValoresConvertidos.Items.Add("Decimal (entrada): " + valorInformado);
                    listaValoresConvertidos.Items.Add("Hexadecimal: " + converter.decimalParaHexadecimal(valorInformado));
                    listaValoresConvertidos.Items.Add("Octal: " + converter.decimalParaOctal(valorInformado));
                    listaValoresConvertidos.Items.Add("Binário: " + converter.decimalParaBinario(valorInformado));

                }
                else if (entradaHexadecimal.Checked)
                {

                    listaValoresConvertidos.Items.Add("Decimal: " + converter.hexadecimalParaDecimal(valorInformado));
                    listaValoresConvertidos.Items.Add("Hexadecimal (entrada): " + valorInformado);
                    listaValoresConvertidos.Items.Add("Octal: " + converter.hexadecimalParaOctal(valorInformado));
                    listaValoresConvertidos.Items.Add("Binário: " + converter.hexadecimalParaBinario(valorInformado));
                }
                else if (entradaBinario.Checked)
                {

                    listaValoresConvertidos.Items.Add("Decimal: " + converter.binarioParaDecimal(valorInformado));
                    listaValoresConvertidos.Items.Add("Hexadecimal: " + converter.binarioParaHexadecimal(valorInformado));
                    listaValoresConvertidos.Items.Add("Octal: " + converter.binarioParaOctal(valorInformado));
                    listaValoresConvertidos.Items.Add("Binário (entrada): " + valorInformado);

                }
                else if (entradaOctal.Checked)
                {
                    listaValoresConvertidos.Items.Add("Decimal: " + converter.octalParaDecimal(valorInformado));
                    listaValoresConvertidos.Items.Add("Hexadecimal: " + converter.octalParaHexadecimal(valorInformado));
                    listaValoresConvertidos.Items.Add("Octal (entrada): " + valorInformado);
                    listaValoresConvertidos.Items.Add("Binário: " + converter.octalParaBnario(valorInformado));

                }
            }
            else
            {
                MessageBox.Show("Informe um valor para converter!");
            }
        }


        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            listaValoresConvertidos.Items.Clear();
            txtNumeroConverter.Clear();
        }
    }
}
