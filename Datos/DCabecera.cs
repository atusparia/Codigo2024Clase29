using Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCabecera
    {
   
        public int Insertar(ECabecera entidad)
        {
            //USP_InsertarCabecera(fecha, cliente)
            using (SqlConnection connection = new SqlConnection(Constantes._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertarCabecera", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Fecha", entidad.Fecha);
                    command.Parameters.AddWithValue("@Cliente", entidad.Cliente);
                    command.Parameters.AddWithValue("@Direccion", entidad.Direccion);


                    SqlParameter idOutput = new SqlParameter("@IdCabecera", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(idOutput);
                    command.ExecuteNonQuery();

                    //(int)idOutput.Value: Retorna el valor del parámetro de salida
                    
                    return (int)idOutput.Value;
                }
            }



        }

        public List<ECabecera> Listar(string cliente) {

            SqlCommand command = null;
            SqlParameter parameter1 = null;
            List<ECabecera> eCabeceras = null;

            try
            {
                eCabeceras = new List<ECabecera>();

                using (SqlConnection conexion = new SqlConnection(Constantes._connectionString))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_BuscarCliente", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    parameter1 = new SqlParameter("@cliente", SqlDbType.NVarChar, 100);
                    parameter1.Value = cliente;

                    command.Parameters.Add(parameter1);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        eCabeceras.Add(new ECabecera
                        {
                            IdCabecera = Convert.ToInt32(reader["IdCabecera"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Cliente = Convert.ToString(reader["Cliente"]),
                            Direccion = Convert.ToString(reader["Direccion"])                            
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show("Error, comunicarse con el Administrador");                
            }
            finally
            {
                command = null;
                parameter1 = null;
                eCabeceras = null;
            }
            return eCabeceras;
        }
    }
}
