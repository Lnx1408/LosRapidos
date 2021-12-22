﻿using System; using System.Collections.Generic; using System.Data.SqlClient; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms;  namespace CapaDatos {     public class ClsManejador     {         List<ClsDatosAmbulancia> datosambulancia = new List<ClsDatosAmbulancia>();
        List<ClsDatosCliente> datosCliente = new List<ClsDatosCliente>();          private SqlConnection conexion;          private SqlConnection abrir_conexion()         {              try             {                 string ConnectionString = "server = localhost; database = LosRapidosSAbd; integrated security = true  ";                  conexion = new SqlConnection(ConnectionString);                 conexion.Open();                  Console.WriteLine("Se abrio la conexion desde la capa de acceso a datos");              }             catch (SqlException ex)             {                 throw ex;             }             return conexion;         }          private void cerrar_conexion(SqlConnection conexion)         {             conexion.Close();             Console.WriteLine("Se cerro la conexion desde la capa de acceso a datos");         }          //Método para insertar información         public void insertar_ambulancia(List<ClsParametrosAmbulancia> lst)         {             try             {                 if (lst != null)                 {                     SqlConnection conexion = abrir_conexion();                     string cadena = "INSERT INTO Ambulancia" +                                     "(modelo, tipoAmbulancia, placa, matricula, fechaActivacion, estado, observacion) " +                                     "VALUES" + "(@modelo, @tipoAmbulancia, @placa, @matricula, @fechaActivacion, @estado, @observacion)";                      SqlCommand comannd = new SqlCommand(cadena, conexion);                     comannd.Parameters.AddWithValue("@modelo", lst[0].Modelo); // a la variable de tip Mysql comand agregar un valor al parametro                     comannd.Parameters.AddWithValue("@tipoAmbulancia", lst[0].TipoAmbulancia); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica                     comannd.Parameters.AddWithValue("@placa", lst[0].Placa);                     comannd.Parameters.AddWithValue("@matricula", lst[0].Matricula);                     comannd.Parameters.AddWithValue("@fechaActivacion", lst[0].FechaActivacion);                     comannd.Parameters.AddWithValue("@estado", lst[0].Estado);                     comannd.Parameters.AddWithValue("@observacion", lst[0].Observacion);                        int t = Convert.ToInt32(comannd.ExecuteScalar()); // con esa linea executa el insert a la bd                     cerrar_conexion(conexion);                 }             }             catch (Exception ex)             { throw ex; }         }          public List<Object> listar_ambulancia()         {             List<Object> lstAmbulancia = new List<Object>();              SqlConnection conexion = abrir_conexion();             string cadena = "Select modelo, tipoAmbulancia, placa, matricula, fechaActivacion, estado, observacion from Ambulancia ";             SqlCommand comando = new SqlCommand(cadena, conexion);             SqlDataReader registros = comando.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.             while (registros.Read())  // leo la informacion almacenada en registro             {                 var tmp = new                 {                     modelo = registros["modelo"].ToString(),  // para asignar valores de la base a la variable cedula                     tipoAmbulancia = registros["tipoAmbulancia"].ToString(),                     placa = registros["placa"].ToString(),                     matricula = registros["matricula"].ToString(),                     fechaActivacion = registros["fechaActivacion"].ToString(),                     estado = registros["estado"].ToString(),                     observacion = registros["observacion"].ToString(),                                    };                  lstAmbulancia.Add(tmp);             }             cerrar_conexion(conexion);             return lstAmbulancia;         }           public List<Object> buscar_ambulancia(String placa)         {             List<Object> lstAmbulancia = new List<Object>();              SqlConnection conexion = abrir_conexion();             string cadena = "Select modelo, tipoAmbulancia, placa, matricula, fechaActivacion, estado, observacion from Ambulancia WHERE placa = @placa";             SqlCommand comando = new SqlCommand(cadena, conexion);             comando.Parameters.AddWithValue("@placa", placa);              SqlDataReader registros = comando.ExecuteReader();             while (registros.Read())             {                 var tmp = new                 {                     modelo = registros["modelo"].ToString(),  // para asignar valores de la base a la variable cedula                     tipoAmbulancia = registros["tipoAmbulancia"].ToString(),                     placa = registros["placa"].ToString(),                     matricula = registros["matricula"].ToString(),                     fechaActivacion = registros["fechaActivacion"].ToString(),                     estado = registros["estado"].ToString(),                     observacion = registros["observacion"].ToString(),                  };                 lstAmbulancia.Add(tmp);             }             cerrar_conexion(conexion);             return lstAmbulancia;         }           public int eliminar_ambulancia(String placa)         {             SqlConnection conexion = abrir_conexion();             string cadena = "DELETE FROM Ambulancia WHERE placa = @placa";             SqlCommand command = new SqlCommand(cadena, conexion);             command.Parameters.AddWithValue("@placa", placa);             int resultado = Convert.ToInt32(command.ExecuteScalar());              MessageBox.Show("Se a eliminado con exito");             cerrar_conexion(conexion);             return resultado;         }

        /*         public int actualizar_alumno_individual(String param_cedula, String param_nombre, String param_apellido, String param_edad, String param_direccion,           String param_sexo, String param_nacionalidad, String param_provincias, String param_cantones, String param_imagen, String param_semestre)         {             SqlConnection conexion = abrir_conexion();             string actualizar = "update estudiante set Nombres=@param_nombre, Apellidos=@param_apellido,  Edad=@param_edad, " +                 " Direccion=@param_direccion, Sexo=@param_sexo, Nacionalidad=@param_nacionalidad,  Provincias=@param_provincias," +                 "  Cantones=@param_cantones,  Imagen=@param_imagen,  Semestre=@param_semestre where Cedula=@param_cedula";             SqlCommand cmd = new SqlCommand(actualizar, conexion);             cmd.Parameters.AddWithValue("@param_cedula", param_cedula);             cmd.Parameters.AddWithValue("@param_nombre", param_nombre);             cmd.Parameters.AddWithValue("@param_apellido", param_apellido);             cmd.Parameters.AddWithValue("@param_edad", param_edad);             cmd.Parameters.AddWithValue("@param_direccion", param_direccion);             cmd.Parameters.AddWithValue("@param_sexo", param_sexo);             cmd.Parameters.AddWithValue("@param_nacionalidad", param_nacionalidad);             cmd.Parameters.AddWithValue("@param_provincias", param_provincias);             cmd.Parameters.AddWithValue("@param_cantones", param_cantones);             cmd.Parameters.AddWithValue("@param_imagen", param_imagen);             cmd.Parameters.AddWithValue("@param_semestre", param_semestre);              int resultado_operacion = Convert.ToInt32(cmd.ExecuteScalar());             cerrar_conexion(conexion);              return resultado_operacion;                  } */

        //Cliente
        public void insertar_cliente(List<ClsParametrosCliente> lst)
        {
            try
            {
                if (lst != null)
                {
                    SqlConnection conexion = abrir_conexion();
                    string cadena = "INSERT INTO Cliente" +
                                    "(Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Imagen ,CodigoCliente) " +
                                    "VALUES" + "(@cedula, @nombre, @apellido, @edad, @domicilio, @sexo,@imagen ,@codigoCliente)";

                    SqlCommand comannd = new SqlCommand(cadena, conexion);
                    comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula); // a la variable de tip Mysql comand agregar un valor al parametro
                    comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
                    comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);
                    comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                    comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                    comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                    comannd.Parameters.AddWithValue("@imagen", lst[0].Imagen);
                    comannd.Parameters.AddWithValue("@codigoCliente", lst[0].CodigoCliente);

                    int t = Convert.ToInt32(comannd.ExecuteScalar()); // con esa linea executa el insert a la bd
                    cerrar_conexion(conexion);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Object> listar_cliente()
        {
            List<Object> lstCliente = new List<Object>();

            SqlConnection conexion = abrir_conexion();
            string cadena = "Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Imagen ,CodigoCliente from Cliente ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.
            while (registros.Read())  // leo la informacion almacenada en registro
            {
                var tmp = new
                {
                    cedula = registros["Cedula"].ToString(),  // para asignar valores de la base a la variable cedula
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    imagen = registros["Imagen"].ToString(),
                    codigoCliente = registros["CodigoCliente"].ToString(),
                };

                lstCliente.Add(tmp);
            }
            cerrar_conexion(conexion);
            return lstCliente;
        }

        public List<Object> buscar_cliente(String cedula)
        {
            List<Object> lstCliente = new List<Object>();

            SqlConnection conexion = abrir_conexion();
            string cadena = "Select Cedula, Nombre, Apellido, Edad, Domicilio, Sexo,  Imagen , CodigoCliente from Cliente WHERE Cedula = @cedula";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@cedula", cedula);

            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    cedula = registros["Cedula"].ToString(),
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    imagen = registros["Imagen"].ToString(),
                    codigoCliente = registros["CodigoCliente"].ToString(),
                };
                lstCliente.Add(tmp);
            }

            cerrar_conexion(conexion);
            return lstCliente;
        }


        public int eliminar_cliente(String cedula)
        {
            SqlConnection conexion = abrir_conexion();
            string cadena = "DELETE FROM Cliente WHERE Cedula = @cedula";
            SqlCommand command = new SqlCommand(cadena, conexion);
            command.Parameters.AddWithValue("@cedula", cedula);
            int resultado = Convert.ToInt32(command.ExecuteScalar());

            MessageBox.Show("Se a eliminado con exito");
            cerrar_conexion(conexion);
            return resultado;
        }
           }  }  