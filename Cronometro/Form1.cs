using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {

        int contador=10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncrono_Click(object sender, EventArgs e)
        {
            tiempo.Start();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            lblcontador.Text = contador.ToString();
            contador = contador - 1;

            if (contador < 0)
            {

                tiempo.Stop();
                MessageBox.Show("Conteo Completo");
            }
    }
    }
}
