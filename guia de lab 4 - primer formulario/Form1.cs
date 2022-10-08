using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia_de_lab_4___primer_formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btncal_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            string ItemSelect = comboOpciones.Text;
            double resultado;

            switch (ItemSelect)

            {
                case "Suma":

                    resultado = num + num2;
                    txtresultado.Text = Convert.ToString(resultado);

                    break;
                case "Resta":


                    resultado = num - num2;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;

                case "Multiplicación":

                    resultado = num * num2;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;
                case "División":

                    resultado = num / num2;
                    txtresultado.Text = Convert.ToString(resultado);
                    break;



            }
        }
    }

    internal class txtresultado
    {
        public static string Text { get; internal set; }
    }

    internal class txtNum2
    {
        public static object Text { get; internal set; }
    }

    internal class comboOpciones
    {
        public static string Text { get; internal set; }
    }

    internal class txtNum1
    {
        internal static object Text;
    }
}

