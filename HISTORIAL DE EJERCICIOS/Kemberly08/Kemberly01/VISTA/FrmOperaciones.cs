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


                // Creacion de variable que permitira convertir la información
               int suma;




                // Concatenar datos
                //txtResultado.Text = txtDato1.Text + txtDato2.Text;

                //Convertir datos
                //asignamos proceso a realizar
                suma = Convert.ToInt32(txtDato1.Text) + Convert.ToInt32(txtDato2.Text);

                //Mostrar resultado to.String informacion de dato numerico a String para mostrarla
                txtResultado.Text = suma.ToString();

                //Variable ex captura el error y lo muestra en ´pantalla
            } catch (Exception) {

                // Mostrar la excepción 
                //Concatenar con la variable de exepción y ".ToString" para que se ejecute de mejor manera
                //MessageBox.Show("Tus dato son incorrecto revisa" +ex.ToString());



                //Nomostrara el error detallado sin el ex.ToString
                MessageBox.Show("Tus dato son incorrecto revisa, asegurate de ingresar datos numericos" );
            }
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
