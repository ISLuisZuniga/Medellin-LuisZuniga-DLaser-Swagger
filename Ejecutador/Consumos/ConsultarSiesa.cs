using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Ejecutador.Consumos
{
    public class ConsultarSiesa
    {
        public DataSet ConsultarQuery( string xml)
        {
            var ConSiesa = new consumoSiesa.WSUNOEE();
            ConSiesa.Url = "https://wsworldwide.siesacloud.com:8043/WSUNOEE/WSUNOEE.asmx";


            DataSet dsconsulta = new DataSet();
            dsconsulta = ConSiesa.EjecutarConsultaXML(xml);
            return dsconsulta;
        } 


    }
}
