using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparacionExamenExtraAD
{
    class AccionesSQL
    {

        /**
         * Método que establece la conexión
         */
        public static SqlConnection establecerConexion()
        {

            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "Data Source=XAVI44A5;Initial Catalog= gimnasioExamen;Integrated Security=True";

            return conexion;
        }


        /**
         * Método que crea la sentencia que llena la dataGridView 
         */
        public static SqlCommand crearSentenciaLlenadoDataGridEspecialidades(SqlConnection conexion)
        {
            SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = conexion;
            sentencia.CommandText = "select * from especialidades";
           
            return sentencia;
        }

        /**
        * Método que crea la sentencia que llena la combobox de profesores
        */
        public static SqlCommand crearSentenciaLlenadoComboBoxProfesores(SqlConnection conexion)
        {
            SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = conexion;
            sentencia.CommandText = "select nombre from profesores";

            return sentencia;
        }

        /**
        * Método que crea la sentencia que llena la combobox de deportes
        */
        public static SqlCommand crearSentenciaLlenadoComboBoxDeportes(SqlConnection conexion)
        {
            SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = conexion;
            sentencia.CommandText = "select * from deportes";

            return sentencia;
        }


        public static SqlCommand getNombreProfe(SqlConnection conexion, String dni)
        {
            SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = conexion;
            sentencia.CommandText = "select nombre from profesores where dni = @dni";

            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@dni", dni);

            return sentencia;
        }

        public static SqlCommand getDeporte(SqlConnection conexion, int idDeporte)
        {
             SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = conexion;
            sentencia.CommandText = "select desc_deporte from deportes where id_deporte = @idDeporte";

            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@idDeporte", idDeporte);

            return sentencia;
        }

        public static SqlCommand BorrarEspecialitat(SqlConnection conexion, int idDeporte, string dni, int grau)
        {
            SqlCommand sentence = new SqlCommand();

            sentence.Connection = conexion;
            sentence.CommandText = "delete especialidades where id_deporte = @id_deporte " + 
                "and dni = @dni and grado = @grau";

            sentence.Parameters.Clear();
            sentence.Parameters.AddWithValue("@id_deporte", idDeporte);
            sentence.Parameters.AddWithValue("@dni", dni);
            sentence.Parameters.AddWithValue("@grau", grau);

            return sentence;     
        }


        public static SqlCommand crearSentenciaAltaNuevaEspecialidad(SqlConnection connect,
            int idDeporte, string dni, int grau)
        {

 	        SqlCommand sentence = new SqlCommand();

            sentence.Connection = connect;
            sentence.CommandText = "INSERT INTO especialidades VALUES (@id_deporte, @dni, @grau)";

            sentence.Parameters.Clear();
            sentence.Parameters.AddWithValue("@id_deporte", idDeporte);
            sentence.Parameters.AddWithValue("@dni", dni);
            sentence.Parameters.AddWithValue("@grau", grau);

            return sentence; 
        }


        public static SqlCommand getidDeporteSeleccionadoEnCombo(SqlConnection connect, string esport)
        {
            SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = connect;
            sentencia.CommandText = "select id_deporte from deportes where desc_deporte = @desc";

            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@desc", esport);

            return sentencia;
        }


        public static SqlCommand getDniProfeSeleccionadoEnCombo(SqlConnection connect, string nomProfe)
        {
            SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = connect;
            sentencia.CommandText = "select dni from profesores where nombre = @nom";

            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@nom", nomProfe);

            return sentencia;
        }
    }
}
