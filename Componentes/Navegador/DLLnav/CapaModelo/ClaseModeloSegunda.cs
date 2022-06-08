/*
 * Clase creada y documentada por Kevin Flores 9959-18-17632
 * Ingeniería de Software 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections;
using System.Data;
using CapaModelo;

namespace CapaModeloNav
{
    public class ClaseModeloSegunda
    {   
        Conexion conexion = new Conexion();
        string tablaBD = "";
        TextBox[] arreglo;
        string rutaAyudaCHM = "";string rutaAyudaHTML = "";

        /*metodoInsetarDatosTabla:
         Obtiene los campos atraves de los tags que se establecen en los textbox atraves de la funcion public void
        funAsignarAliasVista y el nombre de la tabla para insertar los nuevos datos a la tabla.
         */
        public bool metodoInsertarDatosTabla(TextBox[] campos, string tablas)
        {   int resultado = 0;
            try {   
                Conexion cn = new Conexion(); OdbcConnection conn = cn.conexion();
                string sentencia = "insert into " + tablas + " ( ";
                for (int i = 0; i < campos.Length; i++)
                {
                    if (i < campos.Length - 1)
                    {
                        sentencia += campos[i].Tag.ToString() + ", ";
                    }
                    else
                    {
                        sentencia += campos[i].Tag.ToString() + " ) values (";
                    }
                }
                for (int i = 0; i < campos.Length; i++)
                {
                    if (i < campos.Length - 1)
                    {
                        sentencia += "'" + campos[i].Text + "'" + ", ";
                    }
                    else
                    {
                        sentencia += "'" + campos[i].Text + "'" + " );";
                    }
                }
                try
                {
                    OdbcCommand ingreso = new OdbcCommand(sentencia, conn);
                    ingreso.ExecuteNonQuery(); resultado = 1;
                }
                catch (OdbcException Error)
                {
                    Console.WriteLine("Error al ingresar " + Error);
                }
                cn.desconexion(conn);
              
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);
            }  if (resultado == 1)
                {
                    return true;
                }else
                {
                    return false;
                }
        }

        /*metodoInhabilitarRegistro:
         Obtiene el arreglo por medio de la función public void funAsignarAliasVista y el capo estado es un string, 
         pudiendo llamar a la función que deshabilita los texbox para no modificar o alterar algo al cumplir con la acción
         */
        public void metodoInhabilitarRegistro(TextBox[] arreglo, string tabla, string campoEstado)
        {
            try
            {
                Conexion cn = new Conexion();
                OdbcConnection conexion = cn.conexion();
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i].Tag.ToString() == campoEstado)
                    {   string sql = "UPDATE" + " " + tabla + " " + "SET" + " " + campoEstado + " =" + "'" + '0' + "'" + " " + "WHERE" + " " + arreglo[0].Tag.ToString() + " = " + arreglo[0].Text;
                        //MessageBox.Show(sql);
                        try
                        {
                            OdbcCommand eliminar = new OdbcCommand(sql, conexion);
                            eliminar.ExecuteNonQuery();
                            MessageBox.Show("Registro dado de baja correctamente");
                        }
                        catch (OdbcException error)
                        {
                            MessageBox.Show("Error al eliminar el registro " + error.Message);
                        }

                    }
                }
            }
            catch (OdbcException error)
            {
                MessageBox.Show("Error al eliminar el registro " + error.Message);
            }
        }

        /*
        metodoDeshabilitarTexts: Deshabilita los elementos recibidos.
        */
        public void metodoDeshabilitarTexts(Control parent)
        {
            foreach (Control ctr in parent.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Enabled = false;
                }

                if (ctr is ComboBox)
                {
                    ctr.Enabled = false;
                }

                if (ctr is DateTimePicker)
                {
                    ctr.Enabled = false;
                }

                if (ctr is RadioButton)
                {
                    ctr.Enabled = false;
                }
            }
        }

        /*metodoLlenarCombo:
         Recopila la información que se requiere en el combobox y valida que los datos que se ingresen en éste, 
         sí tengan un estatus activo.
         */
        public void metodoLlenarCombo(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            try
            {
                cbx.DataSource = null; cbx.Items.Clear();
                String psql = "SELECT * FROM " + " " + tabla + " " + "WHERE " + " " + estatus + "= 'A' or " + estatus + "= '1' ";
                OdbcConnection conect = conexion.conexion();
                try
                {
                    OdbcCommand comando = new OdbcCommand(psql, conect);
                    OdbcDataAdapter data = new OdbcDataAdapter(comando);
                    DataTable dt = new DataTable();
                    data.Fill(dt);
                    cbx.ValueMember = value;
                    cbx.DisplayMember = display;
                    cbx.DataSource = dt;
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show("Error al leer los datos " + ex.Message);
                }
                finally
                {
                    conexion.desconexion(conect);
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
        }

        /*metodoActivaRadiobtn:
        Activa el radio button correspondiente al estatus que contiene el textbox dedicado a este dato.
         */
        public void metodoActivaRadiobtn(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            if (estatus.Text == "1")
            {
                activo.Checked = true;
            }
            else if (estatus.Text == "0")
            {
                inactivo.Checked = true;
            }
        }

        /*metodoEnviarDatoCbxaTextbox:
         Obtiene el dato seleccionado dentro del combobox y lo envía a un textbox.
         */
        public void metodoEnviarDatoCbxaTextbox(ComboBox combo, TextBox combotexto)
        {
            if (combo.SelectedValue == null)
            {
                return;
            }
            String cbx = combo.SelectedValue.ToString();
            combotexto.Text = cbx;
        }

        /*metodoCambiarFormatoFecha:
         Obtiene el dato de fecha del DateTimePicker y lo convierte en el formato que acepta MySQL.
         */
        public void metodoCambiarFormatoFecha(DateTimePicker date, TextBox textoDate)
        {
            String dt = "";
            dt = date.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            textoDate.Text = dt;
        }

        /*metodoObtieneRutaReporte
         Obtiene la ruta que proporciona la base de datos según la vista que el usuario tenga activa.
         */
        public string obtieneRutaReporte(string idAplicacion, string campoRuta, string campoB, string tablaR)
        {
            string ruta = "";
            try
            {
                OdbcDataReader leer = null;
                string sql = "SELECT" + " " + campoRuta + " " + "FROM" + " " + tablaR + " " + "WHERE " + " " + campoB + "=" + idAplicacion;
                OdbcConnection conect = conexion.conexion();
                try
                {
                    OdbcCommand comando = new OdbcCommand(sql, conect);
                    leer = comando.ExecuteReader();
                    while (leer.Read())
                    {
                        ruta = leer.GetString(0);
                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show("Error al cargar los datos" + ex.Message);
                }
                finally
                {
                    conexion.desconexion(conect);
                }                      
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
            } return ruta;
        }

        /*metodoSalir
         Verifica que permisos tiene el usuario logiado, Abre el Menú.
         */
        public void metodoSalir(Form menu)
        {
            menu.Show();
        }
    }
}
