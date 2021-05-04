using Kemberly01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemberly01.DAO
{
    class ClsDJoin
    {
        //Construir listas de lista
        // 1 construir Lista

        public List<List<Object>> JoinUsuarioType()
        {
            List<List<Object>> Matriz = new List<List<object>>();
            using (programacionEntities db = new programacionEntities())
            {
                //crear variable usuario

                var lista = (from usuarioVariable in db.UserList
                             from type in db.typeOfUser
                             where usuarioVariable.IdTypeOfUser_Fk == type.IdTypeOfUser

                             //Sub Consulta selecciona los campos de los objetos de arriba

                             select new
                             {
                                 usuarioVariable.IdUserList,
                                 usuarioVariable.Nombre,
                                 type.IdTypeOfUser,
                                 type.TypeOfUserName

                             }).ToList();  //Para que el CLR lo detecte como una sola lista, la cual nacio de dos listas

                //Para poder retornar lista se debe pasar a la Matrizz
                //Esto es un arreglo de multiples dimensiones ---- Se trabajará con un ciclo for
                // i --- indice

                for (int i = 0; i < lista.Count; i++)
                {


                    //Rellenar Matriz con los datos que se tienen en "lista"
                    // Matriz --- es variable
                    // Serealizar Objeto, nota: abrir y cerrar parentesis para poder serealizar el objeto creado
                    Matriz.Add(new List<Object>() {
                        //Construcción de matriz
                       lista[i].IdUserList, lista[i].Nombre, lista[i].IdTypeOfUser, lista[i].TypeOfUserName});
                
            }
        }
            return Matriz;

        }
    }
}