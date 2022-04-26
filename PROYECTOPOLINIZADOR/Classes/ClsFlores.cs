using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOPOLINIZADOR.Classes
{
    class ClsFlores : ClsConexion
    {
        public int codigo;
        public int IdEspecie;
        public int IdAgente;
        public string nombre;
        public string descripcion;
        public byte[] fotografia;
        public ClsFlores()
        {
            this.codigo = 0;
            this.IdEspecie = 0;
            this.IdAgente = 0;
            this.nombre = "";
            this.descripcion = "";
            this.fotografia = null;
        }

        public ClsFlores(int pCodigo)
        {
            this.codigo = pCodigo;
            this.IdEspecie = 0;
            this.IdAgente = 0;
            this.nombre = "";
            this.descripcion = "";
            this.fotografia = null;
        }
        public ClsFlores(int pCodigo, int pIdEspecie, int pIdAgente, string pNombre, string pDescripcion, byte[] pFotografia)
        {
            this.codigo = pCodigo;
            this.IdEspecie = pIdEspecie;
            this.IdAgente = pIdAgente;
            this.nombre = pNombre;
            this.descripcion = pDescripcion;
            this.fotografia = pFotografia;
        }
        public String MantenimientoFlores(ClsFlores pClsFlores, string pAccion)
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
                    coneccion.CommandText = "STP_MANTENIMIENTO_FLORES"; //Nombre de Nuestro Procedimiento Almacenado
                    coneccion.CommandTimeout = 10; 

                    

                    if (pAccion == "I")
                    {
                        coneccion.Parameters.AddWithValue("@PCODIGO", pClsFlores.codigo);
                        coneccion.Parameters.AddWithValue("@IDESPECIE", pClsFlores.IdEspecie);
                        coneccion.Parameters.AddWithValue("@IDAGENTE", pClsFlores.IdAgente);
                        coneccion.Parameters.AddWithValue("@PNOMBRE", pClsFlores.nombre);
                        coneccion.Parameters.AddWithValue("@PDESCRIPCION", pClsFlores.descripcion);
                        coneccion.Parameters.AddWithValue("@PFOTOGRAFIA", pClsFlores.fotografia);
                        coneccion.Parameters.AddWithValue("@PACCION", pAccion);
                        coneccion.ExecuteNonQuery();
                        vResultado = "Ejecutado con exito";

                        MessageBox.Show("REGISTRO AGREGADO CON ÉXITO");
                    }
                    else if (pAccion == "M")
                    {
                        coneccion.Parameters.AddWithValue("@PCODIGO", pClsFlores.codigo);
                        coneccion.Parameters.AddWithValue("@IDESPECIE", pClsFlores.IdEspecie);
                        coneccion.Parameters.AddWithValue("@IDAGENTE", pClsFlores.IdAgente);
                        coneccion.Parameters.AddWithValue("@PNOMBRE", pClsFlores.nombre);
                        coneccion.Parameters.AddWithValue("@PDESCRIPCION", pClsFlores.descripcion);
                        coneccion.Parameters.AddWithValue("@PFOTOGRAFIA", pClsFlores.fotografia);
                        coneccion.Parameters.AddWithValue("@PACCION", pAccion);
                        coneccion.ExecuteNonQuery();
                        vResultado = "Ejecutado con exito";
                        MessageBox.Show("REGISTRO ACTUALIZADO CON ÉXITO");
                    }
                    else
                    {

                        

                        coneccion.Parameters.AddWithValue("@PCODIGO", pClsFlores.codigo);
                        coneccion.Parameters.AddWithValue("@IDESPECIE", pClsFlores.IdEspecie);
                        coneccion.Parameters.AddWithValue("@IDAGENTE", pClsFlores.IdAgente);
                        coneccion.Parameters.AddWithValue("@PNOMBRE", pClsFlores.nombre);
                        coneccion.Parameters.AddWithValue("@PDESCRIPCION", pClsFlores.descripcion);
                        coneccion.Parameters.AddWithValue("@PFOTOGRAFIA", null);
                        coneccion.Parameters.AddWithValue("@PACCION", pAccion);
                        coneccion.ExecuteNonQuery();
                        vResultado = "Ejecutado con exito";
                        MessageBox.Show("REGISTRO ELIMINADO CON ÉXITO");
                    }
                    conectado.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("ERROR: DATOS INCORRECTOS");
                    MessageBox.Show(Ex.Message);
                }
            }
            return vResultado;
        }
        /*private DataTable datatable = new DataTable();
        private Image img; 
        public DataTable ListaFlores(ClsFlores pClsFlores, string pAccion)
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

                coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                coneccion.CommandType = CommandType.StoredProcedure;
                coneccion.CommandText = "STP_MANTENIMIENTO_FLORES"; //Nombre de Nuestro Procedimiento Almacenado
                coneccion.Parameters.AddWithValue("@PCODIGO", pClsFlores.codigo);
                coneccion.Parameters.AddWithValue("@IDESPECIE", 0);
                coneccion.Parameters.AddWithValue("@IDAGENTE", 0);
                coneccion.Parameters.AddWithValue("@PNOMBRE", pClsFlores.nombre);
                coneccion.Parameters.AddWithValue("@PDESCRIPCION", pClsFlores.descripcion);
                coneccion.Parameters.AddWithValue("@PFOTOGRAFIA", pClsFlores.fotografia);
                coneccion.Parameters.AddWithValue("@PACCION", pAccion);
                adapter = new SqlDataAdapter(coneccion);
                adapter.Fill(datatable);
                conectado.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            return datatable;
        }*/
    }
}




