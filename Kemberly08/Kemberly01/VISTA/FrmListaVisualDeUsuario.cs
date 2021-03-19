using Kemberly01.DAO;
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
    public partial class FrmListaVisualDeUsuario : Form
    {
        public FrmListaVisualDeUsuario()
        {
            InitializeComponent();
        }

        private void FrmListaVisualDeUsuario_Load(object sender, EventArgs e)
        {
            //Load ---> primero a cargar cuando se  habra el formulario
            //Load cargar lo que son datos


            ClsListaUsuarios cls = new ClsListaUsuarios();

            // Uso de foreach ---> estructura de repeticon se usa para recorrer listas
            foreach (var iteracion in cls.user) {


                dataGridView1.Rows.Add(iteracion.ToString());
            
            }
        }
    }
}
