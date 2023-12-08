namespace Ejercicio_14_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonMayor_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool Resultado;

            try
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);

                Resultado = Num1 < Num2;

                TrueFalseLabel.Text = Resultado.ToString();
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }

        }

        private void BotonMenor_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool Resultado;

            try
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);

                Resultado = Num2 < Num1;

                TrueFalseLabel.Text = Resultado.ToString();
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }

        }

        private void BotonIgual_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool Resultado;

            try
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);

                Resultado = Num1 == Num2;

                TrueFalseLabel.Text = Resultado.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }

        private void BotonDistinto_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            bool Resultado;

            try
            {
                Num1 = double.Parse(txtNum1.Text);
                Num2 = double.Parse(txtNum2.Text);

                Resultado = Num1 != Num2;

                TrueFalseLabel.Text = Resultado.ToString();
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}