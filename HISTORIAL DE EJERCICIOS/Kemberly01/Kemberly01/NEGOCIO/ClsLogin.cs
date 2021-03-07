using Kemberly01.DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemberly01.NEGOCIO // invocar clases y objetos con "namespace"

{
    class ClsLogin
    {
        // Creación de un objeto en c#
        //Login log = new Login(); 


        // public ---> hace referencia que se puede acceder desde otras clases
        // metodos ---> void -- no devuelve nada, int-- necesitan "return", boolean necesitan "return"

        //Este es un método
        public int acceso(Login log) {

            // Declaración de un estado
            int estado = 0;
            //Decisión
            if (log.Usuario.Equals("kemberly")&& log.Password.Equals("123")) {

                estado = 1;

            }
            // 0 es igual a decir False, 1 representa True
            return estado;
        }












        /*public Boolean Ingresar(Login log) {
            if (log.Usuario.Equals("Kemberly") && log.Password.Equals("123"))
            {
                return true;
            }
            else {
                return false;
            }
        }
            */
        internal bool Ingresar(Login dom)
        {
            throw new NotImplementedException();
        }
    }





}

