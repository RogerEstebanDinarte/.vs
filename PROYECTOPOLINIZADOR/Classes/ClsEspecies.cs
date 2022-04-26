using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTOPOLINIZADOR.Classes
{
    class ClsEspecies : ClsConexion
    {
        public int idEspecie;
        public string nombre;
        public string epocaFloracion;
        public string estacionPlantacion;
        public string tipoSueloApropiado;
        public int tiempoExposicion;

        public ClsEspecies()
        {
            this.idEspecie = 0;
            this.nombre = "";
            this.epocaFloracion = "";
            this.estacionPlantacion = "";
            this.tipoSueloApropiado = "";
            this.tiempoExposicion = 0;
        }

        public ClsEspecies(int pIdEspecie, string pNombre, string pEpocaFloracion, string pEstacionPlantacion,
        string pTipoSueloApropiado, int pTiempoExposicion)
        {
            this.idEspecie = pIdEspecie;
            this.nombre = pNombre;
            this.epocaFloracion = pEpocaFloracion;
            this.estacionPlantacion = pEstacionPlantacion;
            this.tipoSueloApropiado = pTipoSueloApropiado;
            this.tiempoExposicion = pTiempoExposicion;
        }




        public String MantenimientoAgentes(ClsEspecies pClsEspecie, string pAccion)
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
                    coneccion.CommandText = "STP_ESPECIES"; //Nombre de Nuestro Procedimiento Almacenado

                    coneccion.CommandTimeout = 10;
                    coneccion.Parameters.AddWithValue("@IdEspecie", pClsEspecie.idEspecie);
                    coneccion.Parameters.AddWithValue("@pNombre", pClsEspecie.nombre);
                    coneccion.Parameters.AddWithValue("@pEpocaFloracion", pClsEspecie.epocaFloracion);
                    coneccion.Parameters.AddWithValue("@pEstacionPlantacion", pClsEspecie.estacionPlantacion);
                    coneccion.Parameters.AddWithValue("@pTipoSueloApropiado", pClsEspecie.tipoSueloApropiado);
                    coneccion.Parameters.AddWithValue("@pTiempoExposicion", pClsEspecie.tiempoExposicion);
                    coneccion.Parameters.AddWithValue("@pACCION", pAccion);
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
        public DataTable ListaEspecies(ClsEspecies pClsEspecie, string pAccion)
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
                coneccion.CommandText = "STP_ESPECIES"; //Nombre de Nuestro Procedimiento Almacenado

                coneccion.Parameters.AddWithValue("@IdEspecie", pClsEspecie.idEspecie);
                coneccion.Parameters.AddWithValue("@pNombre", pClsEspecie.nombre);
                coneccion.Parameters.AddWithValue("@pEpocaFloracion", pClsEspecie.epocaFloracion);
                coneccion.Parameters.AddWithValue("@pEstacionPlantacion", pClsEspecie.estacionPlantacion);
                coneccion.Parameters.AddWithValue("@pTipoSueloApropiado", pClsEspecie.tipoSueloApropiado);
                coneccion.Parameters.AddWithValue("@pTiempoExposicion", pClsEspecie.tiempoExposicion);
                coneccion.Parameters.AddWithValue("@pACCION", pAccion);
                adapter = new SqlDataAdapter(coneccion);
                adapter.Fill(datatable);
                conectado.Close();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
                Console.WriteLine(Ex.Message);
            }
            return datatable;
        }
    }
}