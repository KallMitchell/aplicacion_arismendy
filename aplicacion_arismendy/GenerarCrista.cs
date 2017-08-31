using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections;

namespace aplicacion_arismendy
{
    class GenerarCrista
    {
        public static void generarCrystalReport() {
            //Creamos un arrayList hay que importar la clase System.Collections para ello
            ArrayList productos = new ArrayList();
            //Agregamos un objeto a un nuevo elemento en mi arrayList
            productos.Add(new Productos("nombre", "precio", "cantidad", "total", "no"));

            //Configuramos el documento  que me sirve de reporte
            ReportDocument reporte = new ReportDocument();
            //cargar la plantilla
            reporte.Load("C:\\Users\\VOSTRO\\Documents\\Visual Studio 2015\\Projects\\AplicacionArismendy\\aplicacion_arismendy\\aplicacion_arismendy\\CrystalReport2.rpt");
            //C:\Users\VOSTRO\Documents\Visual Studio 2015\Projects\AplicacionArismendy\aplicacion_arismendy\aplicacion_arismendy\CrystalReport2.rpt
            reporte.SetDataSource(productos);


            //Objeto de la clase vistaReporte
            vistaReporte vista = new vistaReporte();
            //Asignamos el reporte al crystal report viewer
            vista.CRV.ReportSource = reporte;
            //Refrescamos el crystal report viewer
            vista.CRV.Refresh();
            //Mostramos el formulario
            vista.Show();
        }
    }
}
