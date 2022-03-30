using PW3_2022_1C_Clase_1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW3_2022_1C_Clase_1.Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = $"{Calculadora.Sumar(txtNum1.Text, txtNum2.Text)}";
        }
    }
}
