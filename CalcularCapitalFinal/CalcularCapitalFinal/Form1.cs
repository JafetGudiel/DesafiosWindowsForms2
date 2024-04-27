using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularCapitalFinal
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

        private void button1_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(Monto.Text);
            double tasa = double.Parse(Tasa.Text);
            double periodo = double.Parse(Periodo.Text);
            tasa = tasa / 100;

            double capitalFinal = monto * Math.Pow((1 + tasa), periodo);
            capitalFinal = Math.Round(capitalFinal,2);

            Resultado.Text = capitalFinal.ToString();

        }
    }
}
