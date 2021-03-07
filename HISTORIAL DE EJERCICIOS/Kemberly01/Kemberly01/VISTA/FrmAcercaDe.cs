using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kemberly01.VISTA
{
    public partial class FrmAcercaDe : MaterialSkin.Controls.MaterialForm
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue100, Primary.Green100, Primary.Pink100, Accent.Green400, TextShade.WHITE);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
