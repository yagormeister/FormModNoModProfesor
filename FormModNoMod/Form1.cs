using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormModNoMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAbrirModal_Click(object sender, EventArgs e)
        {
            FormModal frmMod = new FormModal();
            frmMod.Peso = 5;
            if (frmMod.ShowDialog() == DialogResult.OK) {
                lblAviso.Text = "Peso es "+ frmMod.Peso;
            }
            else
            {
                lblAviso.Text = "Formulario cancelado";
            }

           
        }

        public void desactivarEtiq()
        {
            if (lblModifica.Visible)
            {
                lblModifica.Visible = false;
            }
            else
            {
                lblModifica.Visible = true;
            }
        }

        private void btnNoModal_Click(object sender, EventArgs e)
        {
            FormNoModal frmNoMod = new FormNoModal(this);
            frmNoMod.Show();
        }
    }
}
