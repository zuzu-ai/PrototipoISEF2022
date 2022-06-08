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
    public class ClaseModeloTercera
    {

        Conexion conexion = new Conexion();
        string tablaBD = "";
        TextBox[] arreglo;
        string rutaAyudaCHM = "";
        string rutaAyudaHTML = "";

        /*
        Revisa la tabla al cual se van a aplicar los cambios contando el 
        numero de datos existentes que contiene segun el valor obtenido 
        obtiene el numero siguiente correspondiente al nuevo ingreso que 
        se quiera realizar        
             */
        public int idSiguienteDeNuevoIngreso(string tabla, string campoB)
        {
            string ultimoEntero = "";
            int enteroSumado = 0;
            OdbcDataReader leer = null;

            string sql = "select" + " " + "(" + campoB + "*1" + ")" + " " + "as" + " " + campoB + " " + "FROM" + " " + tabla + " " + "ORDER BY" + " " + campoB + " " + "DESC Limit 1";
            OdbcConnection conect = conexion.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    ultimoEntero = leer.GetString(0);
                    //enteroSumado += ultimoEntero; 
                    enteroSumado = int.Parse(ultimoEntero) + 1;
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

            if (enteroSumado == 0)
            {
                enteroSumado = 1;
            }


            return enteroSumado;
        }

        /*
           Abre el documento de ayuda atraves de variables definidas en el form donde se utilice o se haga referencia 
           al DLL del componente Navegador             
         */
        public void LlamadaAyudas(string idAplicacion, string nombreCampo, string tablaA, Control parent)
        {
            OdbcDataReader leer = null;

            string sql = "SELECT * FROM " + " " + tablaA + " " + "WHERE " + " " + nombreCampo + "=" + idAplicacion;

            OdbcConnection conect = conexion.conexion();

            try
            {

                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    rutaAyudaCHM = leer.GetString(4);

                    rutaAyudaHTML = leer.GetString(5);
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

            if (String.IsNullOrEmpty(rutaAyudaCHM) || String.IsNullOrEmpty(rutaAyudaHTML))
            {
                MessageBox.Show("La ruta ingresa CHM o Referencia HTML es incorrecta, verifique Aplicacion!");

            }
            else
            {
                Help.ShowHelp(parent, rutaAyudaCHM, rutaAyudaHTML);
            }


        }

        /*
         Toma los textbox y los mete en el arreglo de alias 
         con un contador.
         */

        public TextBox[] AsignaAlias(Control parent)
        {
            int contador = 0;

            foreach (Control ctr in parent.Controls)
            {
                if (ctr is TextBox)
                {
                    contador++;
                }
            }

            TextBox[] alias = new TextBox[contador];

            contador = 0;
            foreach (Control ctr in parent.Controls)
            {

                if (ctr is TextBox)
                {
                    alias[contador] = (TextBox)ctr;
                    contador++;
                }

            }

            return alias;
        }

        /*
         Consulta la estructura de los datos en la tabla validando que sí exista y en caso de que exista va asignando un alias a cada 
         valor y comprueba que la cantidad de valores coincida con la cantidad de campos dentro de la tabla solicitada.
         */

        public string comparaTagscampoBD(TextBox[] alias, string tabla, string BD)
        {
            /* Inicio para busqueda de tabla en BD */
            string cantidad_tabla = "";
            string errores = "";
            string sql = "SELECT count(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA = '" + BD + "' AND TABLE_NAME = '" + tabla + "'";

            OdbcConnection conect = conexion.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                cantidad_tabla = comando.ExecuteScalar().ToString();

                if (cantidad_tabla == "0")
                {
                    errores += "Error en la tabla" + " " + tabla + " " + "no existe en la Base de datos";
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
                //errores += "error en la BD " + " " + ex;
            }
            finally
            {
                conexion.desconexion(conect);
            }
            /* Final para busqueda de tabla en BD */


            //primer If, uso no definido            
            validarcampostablascontagsdetextbox(alias, errores, tabla, BD);

            //segundo If, uso no definido  
            contarcantidaddecolumnasdetablarequerida(alias, errores, tabla, BD);


            if (String.IsNullOrEmpty(errores))
            {
                arreglo = alias;
            }
            /* Final de busqueda de columnas en la BD */
            return errores;
        }


        //Uso no definido, funAsignarAlias
        public void validarcampostablascontagsdetextbox(TextBox[] alias, string errores, string tabla, string BD)
        {

            try
            {
                OdbcConnection conect = conexion.conexion();

                /* Inicio busqueda de cantidades de campos en la una tabla */
                if (String.IsNullOrEmpty(errores)) //if No. 1
                {
                    int cantidadT = 0;

                    foreach (TextBox dato in alias)
                    {
                        cantidadT++;
                    }

                    string cantidadTotalCampos = "";
                    string cantidadCampos = "SELECT count(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '" + tabla + "' AND table_schema = '" + BD + "'";
                    conect = conexion.conexion();

                    try
                    {
                        //MySqlCommand buscarCantidad = new MySqlCommand(cantidadCampos, conexionBD);
                        OdbcCommand buscarCantidad = new OdbcCommand(cantidadCampos, conect);
                        cantidadTotalCampos = buscarCantidad.ExecuteScalar().ToString();
                        int cantidadEntero = int.Parse(cantidadTotalCampos);

                        if (cantidadT > cantidadEntero)
                        {
                            errores += "Error los campos del arreglo son mayores al de la tabla " + " " + tabla;
                        }
                        else if (cantidadT < cantidadEntero)
                        {
                            errores += "Error los campos del arreglo son menores al de la tabla " + " " + tabla;
                        }
                    }
                    catch (OdbcException ex)
                    {
                        MessageBox.Show("Error al cargar los datos " + ex.Message);
                    }
                    finally
                    {
                        conexion.desconexion(conect);
                    }
                }
                /* Final búsqueda de cantidades de campos en una tabla */
            }
            catch (OdbcException ex)
            {

                MessageBox.Show("Error en el metodo 1, de prueba funAsignarAlias" + ex.Message);

            }
        }


        //Segundo If funAsignarAlias, uso no definido
        public void contarcantidaddecolumnasdetablarequerida(TextBox[] alias, string errores, string tabla, string BD)
        {
            try
            {

                OdbcConnection conect = conexion.conexion();

                /* Inicio de busqueda de columnas en la BD */
                if (String.IsNullOrEmpty(errores))
                {
                    string[] arreglo;
                    int cantidad = 0;

                    foreach (TextBox dato in alias)
                    {
                        cantidad++;
                    }

                    arreglo = new string[cantidad];
                    string cantidadColumnas = "";
                    int i = 0;

                    foreach (TextBox dato in alias)
                    {
                        arreglo[i] = dato.Tag.ToString();
                        string sqlQ = "SELECT count(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = '" + BD + "' AND TABLE_NAME = '" + tabla + "' AND COLUMN_NAME = '" + arreglo[i] + "'";

                        conect = conexion.conexion();


                        try
                        {
                            //MySqlCommand buscarColumna = new MySqlCommand(sqlQ, conexionBD);
                            OdbcCommand buscarColumna = new OdbcCommand(sqlQ, conect);
                            cantidadColumnas = buscarColumna.ExecuteScalar().ToString();

                            if (cantidadColumnas == "0")
                            {
                                errores += "Error el campo" + " " + arreglo[i] + " " + "dentro de la tabla" + " " + tabla + " " + "no esta definido en la Base de datos";
                                break;
                            }
                        }
                        catch (OdbcException ex)
                        {
                            MessageBox.Show("Error al cargar los datos " + ex.Message);
                        }
                        finally
                        {
                            conexion.desconexion(conect);
                        }

                        i++;
                    }

                }

            }

            catch (OdbcException ex)
            {
                MessageBox.Show("Error en el metodo 2, de prueba funAsignarAlias" + ex.Message);
            }
        }

        /*
         Envía la información de la fila seleccionada dentro del 
         DataGridView a un arreglo. "no se esta referenciando"
         */

        public void SeleccionDeFilaDGV(DataGridView data)
        {
            var filaSeleccionada = data.CurrentRow;
            int i = 0;
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                foreach (DataGridViewCell celda in filaSeleccionada.Cells)
                {
                    arreglo[i].Text = celda.Value.ToString();
                    i++;
                }

            }
        }

        /*
         escribe el estatus que se envío a través de una cadena en un textbox dedicado a este valor.
         */
        public void CambioEstadoTextBox(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            if (AI.Checked == true)
            {
                estado.Text = cadenaEstado;
            }
        }

        /*
         Obtiene el dato seleccionado dentro del combobox y lo envía a un textbox.
         */
        public void SeleccionarElementoEnComboBox(ComboBox combo, TextBox combotexto)
        {
            combo.SelectedValue = combotexto.Text.ToString();

        }

        /*
         Comprueba que el valor no sea vacío y lo convierte al formato que acepta MySQL.
         */

        public void SeleccionarFechaDTP(DateTimePicker date, TextBox textoDate)
        {
            if (textoDate.Text != "")
            {
                date.Value = Convert.ToDateTime(textoDate.Text.ToString());
            }

        }

        /*
         Obtiene los registros de la tabla especificada y los muestra en el DataGridView.
         */
        public DataTable ActualizarDGV(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            Conexion cn = new Conexion();

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "select * from " + tabla + " " + "ORDER BY" + " " + "length(" + arreglo[0].Tag.ToString() + ")ASC";
            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);
            //se trajo el código del procesamiento de la data ODBC a esta parte
            //para aumentar la seguridad, antes estaba en la capa Controlador
            DataTable table = new DataTable();
            dataTable.Fill(table);
            return table;
        }
        
        public bool Modificar(TextBox[] campos, string tablas)//Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
        {
            int resultado = 0;
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string cad = "Entro a la conexion";
            string sentencia = "update " + tablas + " set ";
            for (int i = 1; i < campos.Length; i++)
            {
                if (i < campos.Length - 1)
                {
                    sentencia += campos[i].Tag.ToString() + " = '" + campos[i].Text + "', ";
                }
                else
                {
                    sentencia += campos[i].Tag.ToString() + " = '" + campos[i].Text + "' ";
                }
            }
            sentencia += "where " + campos[0].Tag.ToString() + " = '" + campos[0].Text + "';";
            cad = "Sentencia creada " + sentencia;
            try
            {
                OdbcCommand ingreso = new OdbcCommand(sentencia, conn);
                cad = "Se logró conexion";
                ingreso.ExecuteNonQuery();
                cad = "se ejecutó la sentencia";
                resultado = 1;
            }
            catch (OdbcException Error)
            {
                cad = Error.Message;
                Console.WriteLine("Error al actualizar " + Error);

            }
            cn.desconexion(conn);
            if (resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
