using System.Data.Odbc;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloSeguridadHSC
{
    public class SentenciasBitacora
    {
        public int pkId { get; set; }
        public int fkIdUsuario { get; set; }
        public string host { get; set; }
        public string ip { get; set; }
        public int fkIdModulo { get; set; }
        public int fkIdAplicacion { get; set; }
        public string accion { get; set; }
        public DateTime conexionFecha { get; set; }
        public TimeSpan conexionHora { get; set; }

        public SentenciasBitacora()
        {
            DateTime fecha = DateTime.Now;
            string fechaconHora = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaSolita = fecha.ToString("yyyy-MM-dd");
            DateTime fechaNueva = DateTime.Parse(fechaconHora);
            conexionFecha = DateTime.Parse(fechaSolita);
            conexionHora = new TimeSpan(fechaNueva.Hour, fechaNueva.Minute, fechaNueva.Second);
        }

        Conexion ODBC = new Conexion();

        /// MELANIE REVOLORIO
        /// <summary>
        /// Metodo que almacena en la base de datos el registro para la bitácora
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <param name="IdModulo"></param>
        /// <param name="IdAplicacion"></param>
        /// <param name="accion"></param>
        public void guardarEnBitacora(string IdUsuario, string IdModulo, string IdAplicacion, string accion)
        {
            string host = Dns.GetHostName();
            string ip = "";
            IPAddress[] hostIPs = Dns.GetHostAddresses(host);
            for (int i = 0; i < hostIPs.Length; i++)
            {
                ip = hostIPs[i].ToString();
            }

            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO bitacorausuario (pkId, host, ip, conexionFecha, conexionHora, fkIdUsuario, fkIdAplicacion, accion, fkIdModulo) " +
                "VALUES (NULL, ?host?, ?ip?, ?conexionFecha?, ?conexionHora?, ?fkIdUsuario?, ?fkIdAplicacion?, ?accion?, ?fkIdModulo?);";
                var ValorDeVariables = new
                {
                    host = host,
                    ip = ip,
                    conexionFecha = conexionFecha,
                    conexionHora = conexionHora,
                    fkIdUsuario = IdUsuario,
                    fkIdAplicacion = IdAplicacion,
                    accion = accion,
                    fkIdModulo = IdModulo
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.desconexion(conexionODBC);
            }
        }

        /// JORGE GONZÁLEZ
        /// <summary>
        /// Método que obtiene el ID del Usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public string obtenerIdDeUsuario(string nombre)
        {

            string res = "";
            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "SELECT pkId FROM usuario WHERE nombre = ?nombre?;";
                var ValorDeVariables = new
                {
                    nombre = nombre
                };
                res = conexionODBC.Query<string>(sqlinsertar, ValorDeVariables).FirstOrDefault();

                ODBC.desconexion(conexionODBC);
            }
            return res;
        }
        public string obtenerIdDeAplicacion(string nombre)
        {

            string res = "";
            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "SELECT pkId FROM aplicacion WHERE nombre = ?nombre?;";
                var ValorDeVariables = new
                {
                    nombre = nombre
                };
                res = conexionODBC.Query<string>(sqlinsertar, ValorDeVariables).FirstOrDefault();

                ODBC.desconexion(conexionODBC);
            }
            return res;
        }

        public string obtenerIdDeModulo(string nombre)
        {

            string res = "";
            OdbcConnection conexionODBC = ODBC.conexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "SELECT fkIdModulo FROM aplicacion WHERE nombre = ?nombre?;";
                var ValorDeVariables = new
                {
                    nombre = nombre
                };
                res = conexionODBC.Query<string>(sqlinsertar, ValorDeVariables).FirstOrDefault();

                ODBC.desconexion(conexionODBC);
            }
            return res;
        }

        /// MELANIE REVOLORIO
        public OdbcDataAdapter llenarTblBitacora(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            string sql = "SELECT pkid,  fkidusuario, host, ip, fkidmodulo, fkidaplicacion, accion, conexionfecha, conexionhora FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, ODBC.conexion());
            return dataTable;
        }

    }
}

