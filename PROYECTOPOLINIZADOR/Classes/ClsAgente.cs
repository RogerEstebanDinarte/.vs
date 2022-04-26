using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTOPOLINIZADOR.Classes
{
    class ClsAgente : ClsConexion
    {
        public int idAgente;
        public string nombre;
        public string tipo;
        public string subtipo;



        public ClsAgente()
        {
            this.idAgente = 0;
            this.nombre = "";
            this.tipo = "";
            this.subtipo = "";
        }



        public ClsAgente(int pIdAgente, string pNombre, string pTipo, string pSubtipo)
        {
            this.idAgente = pIdAgente;
            this.nombre = pNombre;
            this.tipo = pTipo;
            this.subtipo = pSubtipo;
        }



        public String MantenimientoAgentes(ClsAgente pClsAgente, string pAccion)
        {
            String vResultado = "Error de conexion";
            if (this.Conectando())//Probamos si hay coneccion...
            {
                try
                {
                    //creamos nuestra propia coneccion
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand();
                    coneccion.Connection = conectado;
                    coneccion.CommandType = CommandType.StoredProcedure;
                    coneccion.CommandText = "SpAgentePolinizador"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10;

                    coneccion.Parameters.AddWithValue("@IdAgente", pClsAgente.idAgente);
                    coneccion.Parameters.AddWithValue("@pNombre", pClsAgente.nombre);
                    coneccion.Parameters.AddWithValue("@pTipo", pClsAgente.tipo);
                    coneccion.Parameters.AddWithValue("@pSubTipo", pClsAgente.subtipo);
                    coneccion.Parameters.AddWithValue("@pAccion", pAccion);
                    coneccion.ExecuteNonQuery();

                    vResultado = "Ejecutado con exito";
                    if (pAccion == "I")
                    {
                        MessageBox.Show("REGISTRO AGREGADO CON ÉXITO");
                    }
                    else if (pAccion == "M")
                    {
                        MessageBox.Show("REGISTRO ACTUALIZADO CON ÉXITO");
                    }
                    else
                    {
                        MessageBox.Show("REGISTRO ELIMINADO CON ÉXITO");
                    }
                    conectado.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("ERROR: DATOS INCORRECTOS");
                }
            }

            return vResultado;
        }

        private DataTable datatable = new DataTable();
        public DataTable ListaAgentes(ClsAgente pClsAgente, string pAccion)
        {
            try
            {
                SqlDataAdapter adapter;
                DataSet ds = new DataSet();
                //creamos nuestra propia coneccion
                SqlConnection conectado = new SqlConnection(this.coneccion);
                conectado.Open();
                SqlCommand coneccion = new SqlCommand();
                coneccion.Connection = conectado;
                //coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "SpAgentePolinizador"; //Nombre de Nuestro Procedimiento Almacenado
                
                coneccion.Parameters.AddWithValue("@IdAgente", pClsAgente.idAgente);
                coneccion.Parameters.AddWithValue("@pNombre", pClsAgente.nombre);
                coneccion.Parameters.AddWithValue("@pTipo", pClsAgente.tipo);
                coneccion.Parameters.AddWithValue("@pSubTipo", pClsAgente.subtipo);
                coneccion.Parameters.AddWithValue("@pAccion", pAccion);
                adapter = new SqlDataAdapter(coneccion);
                adapter.Fill(datatable);
                conectado.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return datatable;
        }

        

    }
}
