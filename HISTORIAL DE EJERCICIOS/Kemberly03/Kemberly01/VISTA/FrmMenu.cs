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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

           
        }
        public String usuarioEstado;

        private void FrmMenu_Load(object sender, EventArgs e)
        {
         label1.Text = usuarioEstado;
        }

        private void clickAquiParaMasInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDeObj = new FrmAcercaDe();
            // abrir formulario MdiParent 
            frmAcercaDeObj.MdiParent = this;
            frmAcercaDeObj.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVisualDeUsuario frmListaVisual = new FrmListaVisualDeUsuario();
            // abrir formulario MdiParent 
            frmListaVisual.MdiParent = this;
            frmListaVisual.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accederAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
