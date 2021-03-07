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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //using ---- establecer conexión con una bases de datos
                using (programacionEntities db = new programacionEntities())

                {
                    UserList userList = new UserList();

                    userList.Nombre = txtNombre.Text;
                    userList.Apellido =txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }catch (Exception EX){
                MessageBox.Show(EX.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())


                {
                    UserList userList1 = new UserList();
                    int Eliminar = Convert.ToInt32(txtId.Text);
                    //dentro de los parentesis declararvariables
                     userList1 = db.UserList.Find(Eliminar);
                     db.UserList.Remove(userList1);
                     db.SaveChanges();

       
           
        }
    }catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
              
        {
            using (programacionEntities db = new programacionEntities()) {

                int update = Convert.ToInt32(txtId.Text);
            
            }
        }
    }
}
