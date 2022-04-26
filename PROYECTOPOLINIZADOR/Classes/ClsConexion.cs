using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTOPOLINIZADOR.Classes
{
    public class ClsConexion
    {
        //public String coneccion = "Data Source=DESKTOP-U4AIB2E;Initial Catalog=DbPuntoVenta;Integrated Security=True";
        //public String coneccion = "Data Source=localhost;Initial Catalog=DbPuntoVenta;Integrated Security=True";
        public String coneccion = "Data Source =serverprojectg1.database.windows.net; Initial Catalog=BdProcesosPolinizadores;User id=Administrador;Password=UtnLiberia2022**;";

        public SqlConnection cnn;

        public Boolean Conectando()
        {
            try
            {
                cnn = new SqlConnection(this.coneccion);
                //Probamos que ahy coneccion.

                cnn.Close();
                //Cerramos la coneccion
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
