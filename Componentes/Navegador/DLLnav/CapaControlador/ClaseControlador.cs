using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;
using CapaModeloNav;
using System.Collections;
namespace CapaControlador
{
    public class ClaseControlador
    {
        string errores = "";
        TextBox[] texts;
        Control control;

        ClaseModeloSegunda ModeloSegunda = new ClaseModeloSegunda();
        ClaseModeloTercera ModeloTercera = new ClaseModeloTercera();

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public TextBox[] ordenandoTextos(Control parent)
        {
            
            texts = ModeloTercera.AsignaAlias(parent);
            control = parent;
            TextBox[] alias = new TextBox[texts.Length];

            int j = 0;
            for (int i = (texts.Length - 1); i >= 0; i--)
            {
                alias[j] = texts[i];
                j++;
            }

            return alias;
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void comparaTagscampoBD(TextBox[] alias, string tabla, string BD)
        {
           try
            {
                errores = ModeloTercera.comparaTagscampoBD(alias, tabla, BD);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion comparaTagscampoBD");

            }
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funAsignarSalidadControl(Form menu)
        {
            try
            {
                if (String.IsNullOrEmpty(errores))
                {
                    ModeloSegunda.metodoSalir(menu);
                    ModeloSegunda.metodoDeshabilitarTexts(control);
                }
                else
                {
                    MessageBox.Show(errores);
                    menu.Close();
                }
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion funAsignarSalidadControl");

            }
        }

        /*2*/
        public int idSiguienteDeNuevoIngreso(string tabla)
        {
            int longitud = texts.Length;
            int entero = ModeloTercera.idSiguienteDeNuevoIngreso(tabla, texts[longitud - 1].Tag.ToString());

            return entero;
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void metodoLlenarCombo(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            try { 
            ModeloSegunda.metodoLlenarCombo(cbx,tabla,value, display, estatus);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion metodoLlenarCombo");

            }
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void SeleccionDeFilaDGV(DataGridView data)
        {
            try
            {
                ModeloTercera.SeleccionDeFilaDGV(data);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion SeleccionDeFilaDGV");

            }
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void activaRadiobtn(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            try
            {
                ModeloSegunda.metodoActivaRadiobtn(activo, inactivo, estatus);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion activaRadiobtn");

            }
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void CambioEstadoTextBox(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            try
            {
                ModeloTercera.CambioEstadoTextBox(estado, AI, cadenaEstado);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion CambioEstadoTextBox");

            }
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void enviarDatoCbxaTextbox(ComboBox combo, TextBox combotexto)
        {
            try
            {
                ModeloSegunda.metodoEnviarDatoCbxaTextbox(combo, combotexto);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion enviarDatoCbxaTextbox");

            }

        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void SeleccionarElementoEnComboBox(ComboBox combo, TextBox combotexto)
        {
            try
            {
                ModeloTercera.SeleccionarElementoEnComboBox(combo, combotexto);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion SeleccionarElementoEnComboBox");

            }
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void CambiarFormatoFecha(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                ModeloSegunda.metodoCambiarFormatoFecha(date, textoDate);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion CambiarFormatoFecha");

            }
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void SeleccionarFechaDTP(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                ModeloTercera.SeleccionarFechaDTP(date, textoDate);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion SeleccionarFechaDTP");

            }
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public string obtieneRutaReporte(string idAplicacion, string campoRuta, string campoB, string tablaR)
        {
            string ruta = ModeloSegunda.obtieneRutaReporte(idAplicacion, campoRuta, campoB, tablaR);
            return ruta;
        }


        

        public DataTable ActualizarDGV(string tablaDB)//Jaime López 0901-18-735
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return ModeloTercera.ActualizarDGV(tablaDB);
        }
        public bool modificar(TextBox[] campos, string tablas)//Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
        {
          return ModeloTercera.Modificar(campos, tablas); 
        }

        /*1*/
        public bool insertarDatostabla(TextBox[] campos, string tablas)
        {
            return ModeloSegunda.metodoInsertarDatosTabla(campos, tablas);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void InhabilitarRegistro(TextBox[] arreglo, string tabla, string campoEstado)
        {
            try
            {
                ModeloSegunda.metodoInhabilitarRegistro(arreglo, tabla, campoEstado);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion InhabilitarRegistro");

            }
        }

        /*Geovani Fernando Mendoza - 9959-18-15407*/
        public void LlamadaAyudas(string idAplicacion, string nombreCampo, string tablaA)
        {
            try
            {
                ModeloTercera.LlamadaAyudas(idAplicacion, nombreCampo, tablaA, control);
            }
            catch
            {

                MessageBox.Show("Error en la capa controlador, revisar la funcion LlamadaAyudas");

            }

            //MessageBox.Show(tablaA);

        }

        /*Liam Patrick Bernard García - 0901-18-10092*/
        public string funObtienePermisos(string idUsuario, string idAplicacion)
        {
            CapaModeloSeguridadHSC.llamarPermisos modeloSeguridad = new CapaModeloSeguridadHSC.llamarPermisos();
            return modeloSeguridad.llenarpermisos(idUsuario, idAplicacion);
        }

    }

}
