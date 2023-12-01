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
    public partial class FormNoModal : Form
    {
        Form padre;
        public FormNoModal(Form padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            ((Form1) padre).desactivarEtiq();
        }
    }
}
