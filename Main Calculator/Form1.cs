using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Calculator
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        // Botões aqui
        private void Numero1_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(1);
        }

        private void Numero2_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(2);
        }

        private void Numero3_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(3);
        }

        private void Numero4_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(4);
        }

        private void Numero5_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(5);
        }

        private void Numero6_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(6);
        }

        private void Numero7_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(7);
        }

        private void Numero8_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(8);
        }

        private void Numero9_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(9);
        }

        private void Numero0_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString(0);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            MainTextBox.Text = null;
        }

        private void Adicao_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString("+");
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString("-");
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString("÷");
        }

        private void Multiplica_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString("*");
        }

        private void Result_Click(object sender, EventArgs e)
        {
            string num1 = string.Empty;
            string num1reversed = string.Empty;
            string num2 = string.Empty;
            // Algoritimo de resolução de Adição aqui 
            if (MainTextBox.Text.Contains("+") == true)
            {
                for(int i = MainTextBox.Text.IndexOf("+"); i >= 0; i--)
                {
                    num1 += MainTextBox.Text[i];
                }

                for(int f = num1.Length - 1; f > 0; f--)
                {
                    num1reversed += num1[f];
                }

                for(int k = MainTextBox.Text.IndexOf("+") + 1; k < MainTextBox.Text.Length; k++)
                {
                    num2 += MainTextBox.Text[k];
                }

                int n1 = Convert.ToInt32(num1reversed);
                int n2 = Convert.ToInt32(num2);
                MainTextBox.Text = Convert.ToString(n1 + n2);
            }

            // Algoritimo de resolução de subtração aqui
            if (MainTextBox.Text.Contains("-") == true)
            {
                for (int i = MainTextBox.Text.IndexOf("-"); i >= 0; i--)
                {
                    num1 += MainTextBox.Text[i];
                }

                for (int f = num1.Length - 1; f > 0; f--)
                {
                    num1reversed += num1[f];
                }

                for (int k = MainTextBox.Text.IndexOf("-") + 1; k < MainTextBox.Text.Length; k++)
                {
                    num2 += MainTextBox.Text[k];
                }

                int n1 = Convert.ToInt32(num1reversed);
                int n2 = Convert.ToInt32(num2);
                MainTextBox.Text = Convert.ToString(n1 - n2);
            }

            // Algoritimo de Resolução de Multiplicação aqui
            if (MainTextBox.Text.Contains("*") == true)
            {
                for (int i = MainTextBox.Text.IndexOf("*"); i >= 0; i--)
                {
                    num1 += MainTextBox.Text[i];
                }

                for (int f = num1.Length - 1; f > 0; f--)
                {
                    num1reversed += num1[f];
                }

                for (int k = MainTextBox.Text.IndexOf("*") + 1; k < MainTextBox.Text.Length; k++)
                {
                    num2 += MainTextBox.Text[k];
                }

                int n1 = Convert.ToInt32(num1reversed);
                int n2 = Convert.ToInt32(num2);
                MainTextBox.Text = Convert.ToString(n1 * n2);
            }

            // Algoritimo de Resolução de Divisão aqui
            if (MainTextBox.Text.Contains("÷") == true)
            {
                for (int i = MainTextBox.Text.IndexOf("÷"); i >= 0; i--)
                {
                    num1 += MainTextBox.Text[i];
                }

                for (int f = num1.Length - 1; f > 0; f--)
                {
                    num1reversed += num1[f];
                }

                for (int k = MainTextBox.Text.IndexOf("÷") + 1; k < MainTextBox.Text.Length; k++)
                {
                    num2 += MainTextBox.Text[k];
                }

                int n1 = Convert.ToInt32(num1reversed);
                int n2 = Convert.ToInt32(num2);
                if (n2 == 0)
                {
                    MainTextBox.Text = "Erro";
                }
                else 
                    MainTextBox.Text = Convert.ToString(n1 / n2);
            }

            // Algoritimo de Resolução de Fatorial aqui
            if (MainTextBox.Text.Contains("!") == true)
            {
                for (int i = MainTextBox.Text.IndexOf("!"); i >= 0; i--)
                {
                    num1 += MainTextBox.Text[i];
                }

                for (int f = num1.Length - 1; f > 0; f--)
                {
                    num1reversed += num1[f];
                }

                int n1 = Convert.ToInt32(num1reversed);
                int fatorial = 1;
                for (int g = n1; g >= 1; g--)
                {
                    fatorial *= g;
                }
                MainTextBox.Text = Convert.ToString(fatorial);
            }

            // Algoritimo de Resolução de Potencia aqui
            if (MainTextBox.Text.Contains("^") == true)
            {
                for (int i = MainTextBox.Text.IndexOf("^"); i >= 0; i--)
                {
                    num1 += MainTextBox.Text[i];
                }

                for (int f = num1.Length - 1; f > 0; f--)
                {
                    num1reversed += num1[f];
                }

                for (int k = MainTextBox.Text.IndexOf("^") + 1; k < MainTextBox.Text.Length; k++)
                {
                    num2 += MainTextBox.Text[k];
                }

                int n1 = Convert.ToInt32(num1reversed);
                int n2 = Convert.ToInt32(num2);
                MainTextBox.Text = Convert.ToString(Math.Pow(n1,n2));
            }
        }

        // Botão fatorial aqui
        private void Fatorial_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString("!");
        }

        // Botão de Potencia aqui
        private void Potencia_Click(object sender, EventArgs e)
        {
            MainTextBox.Text += MainTextBox.Text = Convert.ToString("^");
        }

        // Algoritimo responsavel por Dark mode aqui
        private void Darkmode_Click(object sender, EventArgs e)
        {
            if (DarkMode.Text == "Dark mode")
            {
                DarkMode.Text = "Light mode";
                BackColor = Color.FromArgb(18, 18, 18);
                MainTextBox.BackColor = Color.DimGray;
                MainTextBox.ForeColor = Color.White;
                Numero1.BackColor = Color.DimGray;
                Numero1.ForeColor = Color.White;
                Numero2.BackColor = Color.DimGray;
                Numero2.ForeColor = Color.White;
                Numero3.BackColor = Color.DimGray;
                Numero3.ForeColor = Color.White;
                Numero4.BackColor = Color.DimGray;
                Numero4.ForeColor = Color.White;
                Numero5.BackColor = Color.DimGray;
                Numero5.ForeColor = Color.White;
                Numero6.BackColor = Color.DimGray;
                Numero6.ForeColor = Color.White;
                Numero7.BackColor = Color.DimGray;
                Numero7.ForeColor = Color.White;
                Numero8.BackColor = Color.DimGray;
                Numero8.ForeColor = Color.White;
                Numero9.BackColor = Color.DimGray;
                Numero9.ForeColor = Color.White;
                Numero0.BackColor = Color.DimGray;
                Numero0.ForeColor = Color.White;

                Fatorial.BackColor = Color.DimGray;
                Fatorial.ForeColor = Color.White;
                ButtonMultiplica.BackColor = Color.DimGray;
                ButtonMultiplica.ForeColor = Color.White;
                ButtonDivisao.BackColor = Color.DimGray;
                ButtonDivisao.ForeColor = Color.White;
                ButtonAdicao.BackColor = Color.DimGray;
                ButtonAdicao.ForeColor = Color.White;
                ButtonSubtracao.BackColor = Color.DimGray;
                ButtonSubtracao.ForeColor = Color.White;
                ButtonClear.BackColor = Color.DimGray;
                ButtonClear.ForeColor = Color.White;
                Potencia.BackColor = Color.DimGray;
                Potencia.ForeColor = Color.White;
                Result.BackColor = Color.DimGray;
                Result.ForeColor = Color.White;
                DarkMode.BackColor = Color.DimGray;
                DarkMode.ForeColor = Color.White;
            }
                
            // Troca de volta pro White mode aqui
            else if (DarkMode.Text == "Light mode")
            {
                DarkMode.Text = "Dark mode";
                BackColor = Color.White;
                MainTextBox.BackColor = Color.FromArgb(224, 224, 224);
                MainTextBox.ForeColor = Color.Black;
                Numero1.BackColor = Color.FromArgb(224, 224, 224);
                Numero1.ForeColor = Color.Black;
                Numero2.BackColor = Color.FromArgb(224, 224, 224);
                Numero2.ForeColor = Color.Black;
                Numero3.BackColor = Color.FromArgb(224, 224, 224);
                Numero3.ForeColor = Color.Black;
                Numero4.BackColor = Color.FromArgb(224, 224, 224);
                Numero4.ForeColor = Color.Black;
                Numero5.BackColor = Color.FromArgb(224, 224, 224);
                Numero5.ForeColor = Color.Black;
                Numero6.BackColor = Color.FromArgb(224, 224, 224);
                Numero6.ForeColor = Color.Black;
                Numero7.BackColor = Color.FromArgb(224, 224, 224);
                Numero7.ForeColor = Color.Black;
                Numero8.BackColor = Color.FromArgb(224, 224, 224);
                Numero8.ForeColor = Color.Black;
                Numero9.BackColor = Color.FromArgb(224, 224, 224);
                Numero9.ForeColor = Color.Black;
                Numero0.BackColor = Color.FromArgb(224, 224, 224);
                Numero0.ForeColor = Color.Black;

                Fatorial.BackColor = Color.FromArgb(224, 224, 224);
                Fatorial.ForeColor = Color.Black;
                ButtonMultiplica.BackColor = Color.FromArgb(224, 224, 224);
                ButtonMultiplica.ForeColor = Color.Black;
                ButtonDivisao.BackColor = Color.FromArgb(224, 224, 224);
                ButtonDivisao.ForeColor = Color.Black;
                ButtonAdicao.BackColor = Color.FromArgb(224, 224, 224);
                ButtonAdicao.ForeColor = Color.Black;
                ButtonSubtracao.BackColor = Color.FromArgb(224, 224, 224);
                ButtonSubtracao.ForeColor = Color.Black;
                ButtonClear.BackColor = Color.FromArgb(224, 224, 224);
                ButtonClear.ForeColor = Color.Black;
                Potencia.BackColor = Color.FromArgb(224, 224, 224);
                Potencia.ForeColor = Color.Black;
                Result.BackColor = Color.FromArgb(224, 224, 224);
                Result.ForeColor = Color.Black;
                DarkMode.BackColor = Color.FromArgb(224, 224, 224);
                DarkMode.ForeColor = Color.Black;
            }
                
        }

        // Encontrei esse bug alterando a transparencia, so consegui resolve-lo declarando Transparencia false
        private void Calculadora_Load(object sender, EventArgs e)
        {
            AllowTransparency = false;
        }
    }
}