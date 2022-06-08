using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        //Fotografía 
        public byte[] obtenerByte(string id)
        {
            byte[] imagen = sn.obtenerByte(id);
            return imagen;
        }
        public int idSiguienteDeNuevoIngreso(string tabla, string campo)
        {

            int entero = sn.idSiguienteDeNuevoIngreso(tabla, campo);

            return entero;
        }
        public void insertaNuevaFoto(string id, byte[] foto)
        {
            sn.insertaNuevaFoto(id, foto);
        }
        public void insertaFoto(string id, byte[] foto)
        {
            sn.insertaFoto(id, foto);
        }
        public string idProducto(string nombreE)
        {
            return sn.idProducto(nombreE);
        }
        public string stockProducto(string nombreE)
        {
            return sn.stockProducto(nombreE);
        }
    }
}
