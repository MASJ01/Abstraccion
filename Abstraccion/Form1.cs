using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraccion
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

        private void BTN_Demostrar_Click(object sender, EventArgs e)
        {
            interactuar Enviar = new interactuar(TXB_Titulo.Text,double.Parse(TXB_Precio.Text),double.Parse(TXB_Costo.Text));
            LBL1.Text = Enviar.Imprime_dato(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
