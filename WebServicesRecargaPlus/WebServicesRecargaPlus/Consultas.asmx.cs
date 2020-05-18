using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace WebServicesRecargaPlus
{
    /// <summary>
    /// Summary description for Consultas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Consultas : System.Web.Services.WebService
    {
        private String _stringConexion = "server=192.168.1.72; database=RecargaPlus ; user id=TAP ; pwd=12345";

        [WebMethod]
        public String login(String usuario, String clave)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                String respuesta = "";
                int tipo = -1;
                int idpersona = -1;
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Persona WHERE usuario = @usuario AND clave = @clave";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        respuesta += reader.GetInt32(0) + ",";
                        respuesta += reader.GetString(1) + ",";
                        respuesta += reader.GetString(2) + ",";
                        respuesta += reader.GetString(3) + ",";
                        respuesta += reader.GetString(4) + ",";
                        respuesta += reader.GetString(5) + ",";
                        respuesta += reader.GetByte(6);
                        tipo = reader.GetByte(6);
                        idpersona = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                if (tipo == 1)
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT saldo FROM Colaborador WHERE persona = @persona";
                        command.Parameters.AddWithValue("@persona", idpersona);
                        command.CommandType = CommandType.Text;
                        var reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            respuesta += "," + reader.GetSqlMoney(0).ToDouble();
                        }
                        reader.Close();
                    }
                }
                return respuesta;
            }
        }
        [WebMethod]
        public String getBonificaciones()
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT "+
                                          " Bonificacion.id,"+
                                          " Bonificacion.bonificacion,"+
                                          " Compania.id," +
                                          " Compania.compania," +
                                          " Monto.id," +
                                          " Monto.monto"+
                                          " From Bonificacion"+
                                          " INNER JOIN Compania ON Bonificacion.compania = compania.id"+
                                          " INNER JOIN Monto ON Bonificacion.monto = Monto.id";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    String respuesta = "";
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            respuesta += reader.GetInt32(0) + ",";
                            respuesta += reader.GetSqlMoney(1).ToDouble() + ",";
                            respuesta += reader.GetInt32(2) + ",";
                            respuesta += reader.GetString(3) + ",";
                            respuesta += reader.GetInt32(4) + ",";
                            respuesta += reader.GetSqlMoney(5).ToDouble();
                            respuesta += "-";
                        }
                    }
                    return respuesta;
                }
            }
        }
        [WebMethod]
        public String getBonificacion(int idCompania, int idMonto)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id, bonificacion FROM Bonificacion WHERE compania = @compania AND monto = @monto";
                    command.Parameters.AddWithValue("@compania", idCompania);
                    command.Parameters.AddWithValue("@monto", idMonto);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    String respuesta = "";
                    if (reader.HasRows)
                    {
                        reader.Read();
                        respuesta += reader.GetInt32(0) + ",";
                        respuesta += reader.GetSqlMoney(1).ToDouble() + ",";
                    }
                    return respuesta;
                }
            }
        }
        [WebMethod]
        public String getColaboradores()
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT"+
                                          " Persona.*,"+
                                          " Colaborador.id,"+
                                          " Colaborador.saldo"+
                                          " From Colaborador"+
                                          " INNER JOIN Persona ON Colaborador.persona = Persona.id";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    String respuesta = "";
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            respuesta += reader.GetInt32(0) + ",";
                            respuesta += reader.GetString(1) + ",";
                            respuesta += reader.GetString(2) + ",";
                            respuesta += reader.GetString(3) + ",";
                            respuesta += reader.GetString(4) + ",";
                            respuesta += reader.GetString(5) + ",";
                            respuesta += reader.GetByte(6) + ",";
                            respuesta += reader.GetInt32(7) + ",";
                            respuesta += reader.GetSqlMoney(8).ToDouble();
                            respuesta += "-";
                        }
                    }
                    return respuesta;
                }
            }
        }
        [WebMethod]
        public String getCompanias()
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Compania";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    String respuesta = "";
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            respuesta += reader.GetInt32(0) + ",";
                            respuesta += reader.GetString(1);
                            respuesta += "-";
                        }
                    }
                    return respuesta;
                }
            }
        }
        [WebMethod]
        public String getMontos()
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Monto";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    String respuesta = "";
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            respuesta += reader.GetInt32(0) + ",";
                            respuesta += reader.GetSqlMoney(1).ToDouble();
                            respuesta += "-";
                        }
                    }
                    return respuesta;
                }
            }
        }
        [WebMethod] 
        public String getRecargas(int idPersona)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT"+
                                          " Recarga.id,"+
                                          " Recarga.numero,"+
                                          " Persona.id,"+
                                          " Persona.nombre,"+
                                          " Persona.apepat,"+
                                          " Persona.apemat,"+
                                          " Bonificacion.id," +
                                          " Bonificacion.bonificacion," +
                                          " Monto.id," +
                                          " Monto.monto," +
                                          " Compania.id," +
                                          " Compania.compania" +
                                          " From Recarga"+
                                          " INNER JOIN Persona ON Recarga.persona = Persona.id"+
                                          " INNER JOIN Bonificacion ON Recarga.bonificacion = Bonificacion.id"+
                                          " INNER JOIN Monto ON Recarga.monto = Monto.id"+
                                          " INNER JOIN Compania ON Recarga.compania = Compania.id"+
                                          " WHERE Recarga.persona = @persona";
                    command.Parameters.AddWithValue("@persona", idPersona);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    String respuesta = "";
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            respuesta += reader.GetInt32(0) + ",";
                            respuesta += reader.GetString(1) + ",";
                            respuesta += reader.GetInt32(2) + ",";
                            respuesta += reader.GetString(3) + ",";
                            respuesta += reader.GetString(4) + ",";
                            respuesta += reader.GetString(5) + ",";
                            respuesta += reader.GetInt32(6) + ",";
                            respuesta += reader.GetSqlMoney(7).ToDouble() + ",";
                            respuesta += reader.GetInt32(8) + ",";
                            respuesta += reader.GetSqlMoney(9).ToDouble() + ",";
                            respuesta += reader.GetInt32(10) + ",";
                            respuesta += reader.GetString(11);
                            respuesta += "_";
                        }
                    }
                    return respuesta;
                }
            }
        }
        [WebMethod]
        public bool setBonificacion(String bonificacion, int idMonto, int idCompania)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Bonificacion VALUES (@bonificacion, @monto, @compania)";
                    command.Parameters.AddWithValue("@bonificacion", double.Parse(bonificacion));
                    command.Parameters.AddWithValue("@monto", idMonto);
                    command.Parameters.AddWithValue("@compania", idCompania);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        [WebMethod]
        public bool setColaborador(String nombre, String apepat, String apemat, String usuario, String clave, String saldo)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                bool insert = false;
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Persona VALUES (@nombre, @apepat, @apemat, @usuario, @clave, 1)";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apepat", apepat);
                    command.Parameters.AddWithValue("@apemat", apemat);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                int id = -1;
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id FROM Persona WHERE usuario = @usuario AND clave = @clave AND tipo = 1";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        id = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                if (id != -1)
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Colaborador VALUES (@saldo, @persona)";
                        command.Parameters.AddWithValue("@saldo", double.Parse(saldo));
                        command.Parameters.AddWithValue("@persona", id);
                        command.CommandType = CommandType.Text;
                        insert = command.ExecuteNonQuery() > 0;
                        return insert;
                    }
                }
                return insert;
            }
        }
        [WebMethod]
        public bool setCompania(String compania)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Compania VALUES (@compania)";
                    command.Parameters.AddWithValue("@compania", compania);
                    command.CommandType = CommandType.Text;
                    var row = command.ExecuteNonQuery();
                    if (row > 0)
                        return true;
                    return false;
                }
            }
        }
        [WebMethod]
        public bool setMonto(String monto)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Monto VALUES (@monto)";
                    command.Parameters.AddWithValue("@monto", double.Parse(monto));
                    command.CommandType = CommandType.Text;
                    var row = command.ExecuteNonQuery();
                    if (row > 0)
                        return true;
                    return false;
                }
            }
        }
        [WebMethod]
        public bool setRecarga(String numero, int idPersona, int idBonificacion, int idMonto, int idCompania)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Recarga VALUES (@numero, @persona, @bonificacion, @monto, @compania)";
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@persona", idPersona);
                    command.Parameters.AddWithValue("@bonificacion", idBonificacion);
                    command.Parameters.AddWithValue("@monto", idMonto);
                    command.Parameters.AddWithValue("@compania", idCompania);
                    command.CommandType = CommandType.Text;
                    var row = command.ExecuteNonQuery();
                    if (row > 0)
                        return true;
                    return false;
                }
            }
        }
        [WebMethod]
        public bool updateBonificacion(int idBonificacion, double bonificacion, int idMonto, int idCompania)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Bonificacion set bonificacion = @bonificacion, monto = @monto, compania = @compania WHERE id = @id";
                    command.Parameters.AddWithValue("@bonificacion", bonificacion);
                    command.Parameters.AddWithValue("@monto", idMonto);
                    command.Parameters.AddWithValue("@compania", idCompania);
                    command.Parameters.AddWithValue("@id", idBonificacion);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        [WebMethod]
        public bool updateColaborador(int idPersona, String nombre, String apepat, String apemat, String usuario, String clave, String saldo)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                bool update = false;
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Persona SET nombre = @nombre, apepat = @apepat, apemat = @apemat, usuario = @usuario, clave = @clave WHERE id = @id";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apepat", apepat);
                    command.Parameters.AddWithValue("@apemat", apemat);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.Parameters.AddWithValue("@id", idPersona);
                    command.CommandType = CommandType.Text;
                    update = command.ExecuteNonQuery() > 0;

                }
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Colaborador SET saldo = @saldo WHERE persona = @id";
                    command.Parameters.AddWithValue("@saldo", double.Parse(saldo));
                    command.Parameters.AddWithValue("@id", idPersona);
                    command.CommandType = CommandType.Text;
                    update = command.ExecuteNonQuery() > 0;

                }
                return update;
            }
        }
        [WebMethod]
        public bool deleteColaborador(int idPersona)
        {
            using (var connection = new SqlConnection(_stringConexion))
            {
                connection.Open();
                bool delete = false;
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Colaborador WHERE persona = @persona";
                    command.Parameters.AddWithValue("@persona", idPersona);
                    command.CommandType = CommandType.Text;
                    delete = command.ExecuteNonQuery() > 0;

                }
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Persona WHERE id = @persona";
                    command.Parameters.AddWithValue("@persona", idPersona);
                    command.Parameters.AddWithValue("@id", idPersona);
                    command.CommandType = CommandType.Text;
                    delete = command.ExecuteNonQuery() > 0;

                }
                return delete;
            }
        }
    }
}
