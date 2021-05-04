using Kemberly01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kemberly01.DAO
{
    class ClsDUserList
    {


        public List<UserList> cargarDatosUserlist() {
            List<UserList> Lista;

            using (programacionEntities db = new programacionEntities())
            {
                Lista = db.UserList.ToList();



            }

            return Lista;
        }

        // Primera forma de pasar parametro

        //public void SaveDatosUser(String Nombre, String Apellido, int Edad, String Pass) {
        //    try
        //    {
        //        //using ---- establecer conexión con una bases de datos
        //        using (programacionEntities db = new programacionEntities())

        //        {
        //            UserList userList = new UserList();

        //            //Enviar elementos de la vista al metodo 
        //            // se envia con parametros

        //            userList.Nombre = Nombre;
        //            userList.Apellido = Apellido;
        //            userList.Edad = Edad;
        //            userList.Pass = Pass;
        //            db.UserList.Add(userList);
        //            db.SaveChanges();

        //            MessageBox.Show("Save");
        //        }
        //    }
        //    catch (Exception EX)
        //    {
        //        MessageBox.Show(EX.ToString());
        //    }

        //}



        // SEGUNDA FORMA

        public void SaveDatosUser(UserList user)
        {
            try
            {
                //using ----establecer conexión con una bases de datos
                using (programacionEntities db = new programacionEntities())

                {
                    UserList userList = new UserList();

                    //Enviar elementos de la vista al metodo
                    //se envia con parametros

                    userList.Nombre = user.Nombre;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }

        }

        public void deleteUser(int iD){
            try
            {
                using (programacionEntities db = new programacionEntities())

                {
                    int Eliminar = Convert.ToInt32(iD);

                    //Expresion Lamda
                    UserList userList = db.UserList.Where(x => x.IdUserList == Eliminar).Select(x => x).FirstOrDefault();

                    //UserList userList = new UserList();
                    //int Eliminar = Convert.ToInt32(txtId.Text);
                    userList = db.UserList.Find(Eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }


        }


        public void updateUser(UserList user) {
            try
            {
               
                using (programacionEntities db = new programacionEntities())

                {
                    int update = Convert.ToInt32(user.IdUserList);
                    UserList userList = db.UserList.Where(x => x.IdUserList == update).Select(x => x).FirstOrDefault();
                  

                    userList.Nombre = user.Nombre;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.SaveChanges();


                    MessageBox.Show("Save");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }


        }

    }
 }

