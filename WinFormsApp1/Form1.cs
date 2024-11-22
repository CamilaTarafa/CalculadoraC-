namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double Val1;
        private double Val2;
        private double Resultado;
        private int Operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = txtTitulo.Text + "9";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            Val2 = Convert.ToDouble(txtTitulo.Text);

            switch (Operacion)
            {
                case 1:
                    Resultado = Val1 + Val2;
                    break;

                case 2:
                    Resultado = Val1 - Val2;
                    break;

                case 3:
                    Resultado = Val1 * Val2;
                    break;

                case 4:
                    Resultado = Val1 / Val2;
                    break;
            }
            txtTitulo.Text = Resultado.ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Operacion = 1;
            Val1 = Convert.ToDouble(txtTitulo.Text);
            txtTitulo.Text = "";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operacion = 2;

            Val1 = Convert.ToDouble(txtTitulo.Text);
            txtTitulo.Text = "";


        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Operacion = 3;
            Val1 = Convert.ToDouble(txtTitulo.Text);
            txtTitulo.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Operacion = 4;
            Val1 = Convert.ToDouble(txtTitulo.Text);
            txtTitulo.Text = "";
        }
    }
}
