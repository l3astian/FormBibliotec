using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Inicio = new Form1();
            Inicio.Show();
        }
    }
}
