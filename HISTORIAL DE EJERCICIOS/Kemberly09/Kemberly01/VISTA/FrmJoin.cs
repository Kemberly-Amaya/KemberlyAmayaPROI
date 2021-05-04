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
    public partial class FrmJoin : Form
    {
        public FrmJoin()
        {
            InitializeComponent();
        }

        private void FrmJoin_Load(object sender, EventArgs e)
        {
            ClsDJoin clsDJoin = new ClsDJoin();
            //Retomar el  metodo Lista --- se debe construir otra Lista de Lista pero en el formulario de VISTA
            List<List<Object>> VerListaDeListas = new List<List<object>>();

            // verListaDeListas sera igual al metodo creado en clsJoin
            VerListaDeListas = clsDJoin.JoinUsuarioType();

            //Deserealizar(descomposicion) el metodo ---- utilizamos con for
            for (int i = 0; i < VerListaDeListas.Count; i++) 
            {
                //Deserealizar VerListaDeLista
                dataGridView1.Rows.Add(VerListaDeListas[i][0], VerListaDeListas[i][1], VerListaDeListas[i][2],VerListaDeListas[i][3]); //[i]--- Filas , [0]--- Columnas
            
            }

        }
    }
}
