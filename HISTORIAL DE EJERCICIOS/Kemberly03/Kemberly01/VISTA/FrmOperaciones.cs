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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)

        { //try catch manejar errores 
            try {

                int suma;
                //asignamos proceso a realizar 
                suma = Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text);
                txtResultado.Text = suma.ToString();


            } catch (Exception ex) {

                MessageBox.Show("Tus dato son incorrecto revisa");
            }
           // txtResultado.Text = txt1.Text + txt2.Text;
        }
    }
}
