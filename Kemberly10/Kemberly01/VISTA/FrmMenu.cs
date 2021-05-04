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
        //Declaración de variavle pública de tipo String
        // Esta variable se podrá modificar desde el Login 
        public String usuarioEstado;

        private void FrmMenu_Load(object sender, EventArgs e)
        {   // El método Load hace la función de modificar lo
            // que esta en el Label1
            //Mostrará el usuario que se logeo en la app
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
            //Desabilitar botones

            FrmOperaciones frmOpe = new FrmOperaciones();
            // abrir formulario MdiParent 
            frmOpe.MdiParent = this;

            //Desabilitar botón Resta
            frmOpe.btnResta.Enabled = false;

            frmOpe.Show();

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmOpe = new FrmOperaciones();
            // abrir formulario MdiParent 
            frmOpe.MdiParent = this;

            //Desabilitar botón Suma
            frmOpe.btnSuma.Enabled = false;

            frmOpe.Show();
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmUsuarios frmUsu = new frmUsuarios();
            // abrir formulario MdiParent 
            //frmUsu.MdiParent = this;
            //frmUsu.Show();
        }

        private void cRUDBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsu = new frmUsuarios();
            frmUsu.MdiParent = this;
            frmUsu.Show();
        }
    }
}
