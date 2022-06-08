using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitacoraUsuario;
using CapaControlador;
using CapaVista;
using static datosUsuario;

namespace DLL.nav
{
    public partial class navegador : UserControl
    {
        //Variables Globales
        TextBox[] campos;
        string tablas;
        string DB;
        int estado = 0;
        public string campoEstado = "";
        public string tablaAyuda = "";
        public string campoAyuda = "";
        public reporte formReporte = new reporte();
        public string idAplicacion = "";

        DataGridView dataE;
        ClaseControlador control = new ClaseControlador();
        Control controles;
        //Gabriel Coyoy
        //Estas variables permiten actualizar los datos de las combobox
        ArrayList referencia0 = new ArrayList();
        ArrayList referencia1 = new ArrayList();
        ArrayList referencia2 = new ArrayList();
        ArrayList referencia3 = new ArrayList();
        ArrayList referencia4 = new ArrayList();

        //Liam Patrick Bernard García 0901-18-10092
        public Boolean permisoIngreso = true;  //Valor que debe llegar de seguridad
        public Boolean permisoModificar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoEliminar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoConsultar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoReporteador = true;  //Valor que debe llegar de seguridad

        public string permisos;
        public string usuario = "";
        public string aplicacion = "";
        public string idusuario;
        public string idmodulo;

        CapaControladorSeguridadHSC.Controlador bitacora = new CapaControladorSeguridadHSC.Controlador();
        //Fin varaibles globales


        public navegador()
        {
            InitializeComponent();
        }

        public void ActualizaPermisos() //Liam Patrick Bernard García 0901-18-10092, Jaime López 0901-18-735
        {
            try
            {
                CapaControladorSeguridadHSC.Controlador controladorSeguridad = new CapaControladorSeguridadHSC.Controlador();




                permisos = control.funObtienePermisos(idusuario, idAplicacion);


                if (permisos.Length < 5)
                {
                    MessageBox.Show("El Usuario no tiene permisos para esta aplicacion.");
                    generic.Close();
                    return;
                }

                if (permisos[0] == '1')
                {
                    permisoIngreso = true;
                }
                else
                {
                    permisoIngreso = false;
                }

                if (permisos[1] == '1')
                {

                }
                else
                {
                    MessageBox.Show("Usted No Tiene Permisos de Lectura");
                    generic.Close();
                }

                if (permisos[2] == '1')
                {
                    permisoReporteador = true;
                }
                else
                {
                    permisoReporteador = false;
                }

                if (permisos[3] == '1')
                {
                    permisoEliminar = true;
                }
                else
                {
                    permisoEliminar = false;
                }

                if (permisos[4] == '1')
                {
                    permisoModificar = true;
                }
                else
                {
                    permisoModificar = false;
                }

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;

                //Habilitación de Permisos, Liam Patrick Bernard García, 0901-18-10092

                if (permisoIngreso == false)
                {
                    btnIngresar.Enabled = false;
                }
                else
                {
                    btnIngresar.Enabled = true;
                }

                if (permisoModificar == false)
                {
                    btnModificar.Enabled = false;
                }
                else
                {
                    btnModificar.Enabled = true;
                }

                if (permisoEliminar == false)
                {
                    btnEliminar.Enabled = false;
                }
                else
                {
                    btnEliminar.Enabled = true;
                }

                if (permisoConsultar == false)
                {
                    btnConsultar.Enabled = false;
                }
                else
                {
                    btnConsultar.Enabled = true;
                }

                if (permisoReporteador == false)
                {
                    btnReporte.Enabled = false;
                }
                else
                {
                    btnReporte.Enabled = true;
                }
            }
            catch
            {

            }

        }


        public TextBox[] ClasificaTextboxsegunParent(Control parent)
        {
            try
            {
                controles = parent;

            }
            catch
            {

            }
            return control.ordenandoTextos(parent);

        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void ObtenerCamposdeTabla(TextBox[] alias, string tabla, string BD)
        {
            try
            {
                control.comparaTagscampoBD(alias, tabla, BD);
                campos = alias;
                tablas = tabla;
                DB = BD;
            }
            catch
            {

            }

        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void MetodoSalirVista(Form menu)
        {
            try
            {
                control.funAsignarSalidadControl(menu);
            }
            catch
            {

            }

        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void LlenarCombobox(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            try
            {
                referencia1.Add(tabla);
                referencia2.Add(value);
                referencia3.Add(display);
                referencia4.Add(estatus);
                referencia0.Add(cbx);
                control.metodoLlenarCombo(cbx, tabla, value, display, estatus);
            }
            catch
            {

            }


        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void SelecciondeFilaDGV(DataGridView data)
        {
            try
            {
                dataE = data;
                control.SeleccionDeFilaDGV(data);
            }
            catch
            {

            }

        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void ActivaRadiobtn(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            try
            {
                control.activaRadiobtn(activo, inactivo, estatus);

            }
            catch
            {

            }
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void CambioEstadoTextbox(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            try
            {
                control.CambioEstadoTextBox(estado, AI, cadenaEstado);
            }
            catch
            {

            }

        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void EnviarDatoComboaTextbox(ComboBox combo, TextBox combotexto)
        {
            try
            {
                control.enviarDatoCbxaTextbox(combo, combotexto);

            }
            catch
            {

            }

        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void SeleccionarElementosenCombo(ComboBox combo, TextBox combotexto)
        {
            try
            {
                control.SeleccionarElementoEnComboBox(combo, combotexto);

            }
            catch
            {

            }

        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void CambiarFormatoFecha(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                control.CambiarFormatoFecha(date, textoDate);

            }
            catch
            {

            }

        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void SeleccionarFechaDTP(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                control.SeleccionarFechaDTP(date, textoDate);

            }
            catch
            {

            }

        }


        private void ActualizarCombobox()
        {
            try
            {
                for (int i = 0; i < referencia0.Count; i++)
                {

                    control.metodoLlenarCombo((ComboBox)referencia0[i], (string)referencia1[i], (string)referencia2[i], (string)referencia3[i], (string)referencia4[i]);
                }

            }
            catch
            {

            }


        }



        private void DesactivarBotones(int tipo) //Jaime López 0901-18-735
        {
            try
            {
                if (tipo == 0)
                {
                    //activa
                    //Función de Validar Permisos, Liam Patrick Bernard Garcia, 0901-18-10092
                    if (permisoIngreso == false)
                    {
                        btnIngresar.Enabled = false;
                    }
                    else
                    {
                        btnIngresar.Enabled = true;
                    }

                    if (permisoModificar == false)
                    {
                        btnModificar.Enabled = false;
                    }
                    else
                    {
                        btnModificar.Enabled = true;
                    }

                    if (permisoEliminar == false)
                    {
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        btnEliminar.Enabled = true;
                    }

                    if (permisoConsultar == false)
                    {
                        btnConsultar.Enabled = false;
                    }
                    else
                    {
                        btnConsultar.Enabled = true;
                    }

                    if (permisoReporteador == false)
                    {
                        btnReporte.Enabled = false;
                    }
                    else
                    {
                        btnReporte.Enabled = true;
                    }

                    btnActualizar.Enabled = true;
                    //desactiva
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                }
                else
                {
                    //desactiva
                    btnIngresar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnReporte.Enabled = false;
                    btnActualizar.Enabled = false;
                    //activa
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                }

            }
            catch
            {

            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)//Jaime López 0901-18-735
        {
            try
            {
                estado = 0;
                DesactivarBotones(0);
                ManipularEstadodeElementosVista(0);


                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Cancelar");

            }
            catch
            {

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Metodos de ingresar y eliminar adaptados por Melissa Aldana, al boton guardar
                switch (estado)
                {
                    case 1://Ingresar
                        bool resultadoI;
                        resultadoI = control.insertarDatostabla(campos, tablas);
                        if (resultadoI == true)
                        {
                            MessageBox.Show("El ingreso se a realizado con éxito!");
                        }
                        else
                        {
                            MessageBox.Show("El ingreso no se realizó con éxito!");
                        }

                        break;

                    case 2://Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
                        bool resultado;//Varaible para saber si se ejecutó con éxito la sentencia SQL
                        resultado = control.modificar(campos, tablas);
                        if (resultado == true)
                        {
                            MessageBox.Show("Modificación realizada con éxito!");
                        }
                        else
                        {
                            MessageBox.Show("Modificación no se realizó con éxito!");
                        }
                        break;


                    case 3://Eliminar

                        control.InhabilitarRegistro(campos, tablas, campoEstado);


                        break;

                    case 0://Error alguno de los otros casos no hizo su trabajo
                        MessageBox.Show("Error, no ha seleccionado ninguna función para guardar sus acciones");
                        break;
                }
                estado = 0;
                DesactivarBotones(0);
                ManipularEstadodeElementosVista(0);
                LlenarTabla();//recarga los datos de la tabla

            }
            catch
            {

            }




        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int entero = control.idSiguienteDeNuevoIngreso(tablas);
                int cantidadCampos = campos.Length;
                campos[0].Text = entero.ToString();


                foreach (Control ctr in controles.Controls)
                {
                    if (ctr is TextBox)
                    {
                        if (ctr.Tag.ToString() == campos[0].Tag.ToString())
                        {
                            ctr.Enabled = false;
                        }
                        else
                        {
                            ctr.Enabled = true;

                        }

                    }

                    if (ctr is ComboBox)
                    {
                        ctr.Enabled = true;
                    }

                    if (ctr is DateTimePicker)
                    {
                        ctr.Enabled = true;
                    }

                    if (ctr is RadioButton)
                    {
                        ctr.Enabled = true;
                    }
                }

                estado = 1;
                DesactivarBotones(1);
                ManipularEstadodeElementosVista(1);

                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Insertar");

            }
            catch
            {

            }

        }

        //Lo hizo Wilber Enrique Segura Ramirez 0901-18-13952
        private void btnModificar_Click(object sender, EventArgs e)//Boton de modificar campos dinámico
        {
            try
            {
                if (dvgConsulta != null)
                {
                    if (dvgConsulta.RowCount - 1 > 0)
                    {
                        ManipularEstadodeElementosVista(3);

                        estado = 2;
                        DesactivarBotones(1);
                    }
                    else
                    {
                        MessageBox.Show("No tiene Registros");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("No existe ninguna datagridview");
                    return;
                }

                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Modificar");

            }
            catch
            {

            }

        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                control.InhabilitarRegistro(campos, tablas, campoEstado);
                //control.funSeleccionarDTControl(dataE);
                estado = 3;
                DesactivarBotones(0);
                ManipularEstadodeElementosVista(0);
                LlenarTabla();


                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Eliminar");

            }
            catch
            {

            }


        }


        //boton de verificacion para navegacion sin registros
        public Boolean VerificarContenidodeTabla()
        {//Kevin Rolando González Ramírez 0901-18-1387
            try
            {


            }
            catch
            {

            }
            if (dvgConsulta.RowCount - 1 > 0)

                return true;
            else
                return false;
        }


        DataGridView dvgConsulta;
        //funcion para pedir datagridView


        public void ObtenerNombreDGV(DataGridView tabla)//Kevin Rolando González Ramírez 0901-18-1387
        {
            try
            {
                dvgConsulta = tabla;

            }
            catch
            {

            }

        }


        public void LlenarTabla() //Jaime López 0901-18-735
        {
            try
            {
                DataTable dt = control.ActualizarDGV(tablas);
                dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgConsulta.DataSource = dt;

            }
            catch
            {

            }

        }


        private void btnSiguiente_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {
            try
            {
                //verificacion de la existencia de registros
                if (VerificarContenidodeTabla() == false)
                {
                    MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                    return;
                }

                //obtengo el indicie actual
                int actual = dvgConsulta.CurrentCell.RowIndex;


                int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 
                int numFilas = dvgConsulta.RowCount;
                //MessageBox.Show("cantidad de filas: "+numFilas);


                if (actual == numFilas - 2)
                {
                    dvgConsulta.CurrentCell = dvgConsulta.Rows[0].Cells[0];
                }
                else
                {

                    var arList = new ArrayList();//todos los campos a obtener de la tabla


                    dvgConsulta.CurrentCell = dvgConsulta.Rows[actual + 1].Cells[0];
                    //for para guardar todos los datos de la columnas
                    for (int i = 0; i < numColumnas; i++)
                    {
                        string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                        arList.Add(col);//vamos guardando todos los campos

                    }
                }
                ContabilizarCamposenBD();

                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Boton Siguiente");

            }
            catch
            {

            }


        }

        private void btnAnterior_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {
            try
            {
                //verificacion de la existencia de registros
                if (VerificarContenidodeTabla() == false)
                {
                    MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                    return;
                }

                //obtengo el indicie actual
                int actual = dvgConsulta.CurrentCell.RowIndex;


                //hacer un condicional para ver si no es el primer campo

                if (actual == 0)
                {
                    // MessageBox.Show("Lo siento no puede retroceder mas esta en el primer campo");
                    dvgConsulta.CurrentCell = dvgConsulta.Rows[dvgConsulta.RowCount - 2].Cells[0];
                }
                else
                {


                    dvgConsulta.CurrentCell = dvgConsulta.Rows[actual - 1].Cells[0];
                    var arList = new ArrayList();//todos los campos a obtener de la tabla

                    int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 

                    //for para guardar todos los datos de la columnas
                    for (int i = 0; i < numColumnas; i++)
                    {
                        string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                        arList.Add(col);//vamos guardando todos los campos

                    }

                }
                ContabilizarCamposenBD();
                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Boton Anterior");

            }
            catch
            {

            }

        }

        private void btnInicio_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {
            try
            {
                //verificacion de la existencia de registros
                if (VerificarContenidodeTabla() == false)
                {
                    MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                    return;
                }

                dvgConsulta.CurrentCell = dvgConsulta.Rows[0].Cells[0];

                var arList = new ArrayList();//todos los campos a obtener de la tabla

                int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 

                //for para guardar todos los datos de la columnas
                for (int i = 0; i < numColumnas; i++)
                {
                    string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                    arList.Add(col);//vamos guardando todos los campos

                }
                ContabilizarCamposenBD();


                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Inicio");

            }
            catch
            {

            }

        }

        private void btnFinal_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {
            try
            {
                //verificacion de la existencia de registros
                if (VerificarContenidodeTabla() == false)
                {
                    MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                    return;
                }

                dvgConsulta.CurrentCell = dvgConsulta.Rows[dvgConsulta.RowCount - 2].Cells[0];

                var arList = new ArrayList();//todos los campos a obtener de la tabla

                int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 


                for (int i = 0; i < numColumnas; i++)
                {
                    string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                    arList.Add(col);

                }
                ContabilizarCamposenBD();


                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Final");

            }
            catch
            {

            }


        }

        private void navegador_Load(object sender, EventArgs e)
        {
            try
            {


            }
            catch
            {

            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //falta actu de combos
                for (int i = 0; i < campos.Length; i++)
                {

                    campos[i].Text = "";

                }

                ActualizarCombobox();

                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Actualizar");

            }
            catch
            {

            }
            LlenarTabla();

        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Salir");

            }
            catch
            {

            }
            generic.Close();
        }
        Form generic;

        public void ObtenerReferenciaFormActual(Form generico)
        {
            try
            {
                generic = generico;

            }
            catch
            {

            }

        }




        private void btnAyuda_Click(object sender, EventArgs e)
        {
            try
            {
                control.LlamadaAyudas(idAplicacion, campoAyuda, tablaAyuda);

                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Ayuda");

            }
            catch
            {

            }

        }

        private void ManipularEstadodeElementosVista(int modo)
        {
            try
            {
                int cantidadCampos = campos.Length;
                if (modo == 0)
                {
                    foreach (Control ctr in controles.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            ctr.Enabled = false;
                            ctr.Text = "";
                        }

                        if (ctr is ComboBox)
                        {
                            ctr.Enabled = false;
                            ctr.Text = "";
                        }

                        if (ctr is DateTimePicker)
                        {
                            ctr.Enabled = false;

                        }

                        if (ctr is RadioButton)
                        {
                            ctr.Enabled = false;
                        }

                        if (ctr is DataGridView)
                        {
                            ctr.Enabled = true;
                        }
                    }
                }

                if (modo == 1 || modo == 3)
                {
                    foreach (Control ctr in controles.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            if (ctr.Tag.ToString() == campos[0].Tag.ToString())
                            {
                                ctr.Enabled = false;
                            }
                            else
                            {
                                ctr.Enabled = true;
                                if (modo == 1)
                                {
                                    ctr.Text = "";
                                }

                            }
                        }

                        if (ctr is ComboBox)
                        {
                            ctr.Enabled = true;
                        }

                        if (ctr is DateTimePicker)
                        {
                            ctr.Enabled = true;
                            if (modo == 1)
                            {
                                ((DateTimePicker)ctr).Value = DateTime.Now;
                            }

                        }

                        if (ctr is RadioButton)
                        {
                            ctr.Enabled = true;
                            if (modo == 1)
                            {
                                ((RadioButton)ctr).Checked = false;
                            }

                        }

                        if (ctr is DataGridView)
                        {
                            ctr.Enabled = false;
                        }
                    }
                }

            }
            catch
            {

            }



        }
        public void ContabilizarCamposenBD()
        {
            try
            {
                int cantidadCampos = dvgConsulta.Columns.Count;

                for (int i = 0; i < cantidadCampos; i++)
                {
                    campos[i].Text = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                }

            }
            catch
            {

            }


        }

        public void LlamarRutaReporte(string campoRuta, string campoB, string tablaR)
        {
            try
            {
                formReporte.ruta = control.obtieneRutaReporte(idAplicacion, campoRuta, campoB, tablaR);

            }
            catch
            {

            }

        }


        public void MostrarVistaReporte()
        {
            try
            {
                formReporte.Show();

            }
            catch
            {

            }

        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(formReporte.ruta))
                {
                    MessageBox.Show("Error con la ruta del reporte, verifique que la Aplicacion existe y que la ruta sea la correcta!");
                }
                else
                {
                    MostrarVistaReporte();
                }

            }
            catch
            {

            }

        }


        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(formReporte.ruta))
                {
                    MessageBox.Show("Error con la ruta del reporte, verifique que la Aplicacion existe y que la ruta sea la correcta!");
                }
                else
                {
                    MostrarVistaReporte();
                }

                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Reporteador");

            }
            catch
            {

            }


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultasInteligentes CI = new ConsultasInteligentes();
                CI.Show();


                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Consulta");

            }
            catch
            {

            }

        }
        public void Obtenerayuda(string idAplicacion, string campoAyuda, string tablaAyuda)
        {
            try
            {
                control.LlamadaAyudas(idAplicacion, campoAyuda, tablaAyuda);

                bitacora.guardarEnBitacora(IdUsuario, idmodulo, idAplicacion, "Ayuda");
            }
            catch
            {

            }

        }
    }
}
