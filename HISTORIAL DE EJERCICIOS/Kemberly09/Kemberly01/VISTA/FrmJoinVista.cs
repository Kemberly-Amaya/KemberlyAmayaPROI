using Kemberly01.MODEL;
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
    public partial class FrmJoinVista : Form
    {
        public FrmJoinVista()
        {
            InitializeComponent();
        }
        //El usuario escriba algo se cree automatcamnete la consulta
        private void txtDato_TextChanged(object sender, EventArgs e)
        {
            load();
        }

        private void FrmJoinVista_Load(object sender, EventArgs e)
        {
            load();
        }
        //Solo para consultas de tipo  Select es permitido,
        //porque 
        //Metodo para realizar consulta con linq
        void load()
        {
            dataGridView1.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var consulta = (from user in db.UserList
                                from type in db.typeOfUser

                                    //Llamada llave primaria --Contains ---realiza la funcion like en sql 
                                where user.IdTypeOfUser_Fk == type.IdTypeOfUser && user.Nombre.Contains(txtDato.Text)
                                select new
                                {
                                    user.Nombre,
                                    type.TypeOfUserName
                                }).ToList();
                            

                foreach (var iteracion in consulta)
                {
                    dataGridView1.Rows.Add(iteracion.Nombre,iteracion.TypeOfUserName);

                }

            }


        }
     }
}
