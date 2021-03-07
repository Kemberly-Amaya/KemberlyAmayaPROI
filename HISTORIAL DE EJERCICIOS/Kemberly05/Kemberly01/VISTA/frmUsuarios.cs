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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            Carga();
        }

        //Este es un metodo sin retorno
        void Carga()
        {
            dataGridView1.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();
                foreach (var iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.IdUserList,iteracion.Nombre,iteracion.Apellido,iteracion.Edad,iteracion.Pass);

                }

            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //using ---- establecer conexión con una bases de datos
                using (programacionEntities db = new programacionEntities())

                {
                    UserList userList = new UserList();

                    userList.Nombre = txtNombre.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())

                {
                    int Eliminar = Convert.ToInt32(txtId.Text);

                    //Expresion Lamda
                    UserList userList = db.UserList.Where(x => x.IdUserList == Eliminar).Select(x => x).FirstOrDefault();
                    // int Eliminar = Convert.ToInt32(txtId.Text);
                    //userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())


                {
                    int update = Convert.ToInt32(txtId.Text);


                    // Expresion Lamda para poder eliminar datos
                   // UserList user = db.UserList.Where(x => x.IdUserList == update).Select(x => x).FirstOrDefault();

                    UserList userList = new UserList();
                    userList = db.UserList.Find(update);
                    userList.Nombre = txtNombre.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.SaveChanges();

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }
            Carga();
        }
    }
}      
        
        
        
        
        
        
        
            

