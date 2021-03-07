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
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.Nombre = "Milton";
                    userList.Apellido = "Orellana";
                    userList.Edad = 20;
                    userList.Pass = "0001";
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();
                    int Eliminar = Convert.ToInt32(textBox5.Text);
                    userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

       
           
        }
    }catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }
    }
}
