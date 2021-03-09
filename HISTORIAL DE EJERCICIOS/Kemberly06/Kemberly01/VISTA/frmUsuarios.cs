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
            //Limpiara los datos 
            clear();


        }
        //metodo para limpiar cajas de textos "Clear"
        void clear() {

            //Metodo recomendable de utilizar
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPass.Clear();

            //Limpiar caja de texto asignando dato vacio
            // remplaza lo que esta en el textbox por un dato vacio
            //txtNombre.Text = "";

            // Limpiar caja de texto asignando dato nulo
            // remplaza lo que esta en el textbox por un dato nulo y desaparece
            // por completo la informacion
            //txtApellido.Text = null;
         
        
        }
        //Este es un metodo sin retorno
        void Carga()

        {
            dtgListaUsuarios.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();
                foreach (var iteracion in Lista)
                {
                    dtgListaUsuarios.Rows.Add(iteracion.IdUserList,iteracion.Nombre,iteracion.Apellido,iteracion.Edad,iteracion.Pass);

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
            clear();

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
            clear();


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

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nuevo evento "CelClick"

            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String NombreUsu = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String ApellidoUsu = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String EdadUsu = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String PassUsu = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();

            txtId.Text = Id;
            txtNombre.Text = NombreUsu;
            txtApellido.Text = ApellidoUsu;
            txtEdad.Text = EdadUsu;
            txtPass.Text = PassUsu;



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmUsuarios_Load_1(object sender, EventArgs e)
        {

        }
    }
}      
        
        
        
        
        
        
        
            

