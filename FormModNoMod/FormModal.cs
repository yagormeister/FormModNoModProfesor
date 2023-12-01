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
    public partial class FormModal : Form
    {
        public int Peso { get; set; }
        public FormModal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Peso = Convert.ToInt32(tbPeso.Text);
        }

        private void FormModal_Load(object sender, EventArgs e)
        {
            tbPeso.Text = Peso.ToString();
        }
    }
}
