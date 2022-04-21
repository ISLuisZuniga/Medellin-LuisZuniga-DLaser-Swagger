using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Ejecutador.Consumos
{
   public class Archivos
    {
        public void ArmarPlano(DataSet DS, string RutaPlano)
        {
            String[] texto;
            texto = new String[ DS.Tables[0].Rows.Count+1];
            texto[0] = String.Empty;
            for (int i = 0; i < DS.Tables[0].Columns.Count; i++)
            {
                texto[0] += DS.Tables[0].Columns[i].ColumnName + "  ";
            }

            String Linea;
           
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                Linea = String.Empty;
                for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                {
                    Linea += DS.Tables[0].Rows[i][j].ToString() + "  ";
                }

                texto[i + 1] = Linea;
            }

            File.WriteAllLines(RutaPlano + ".txt",texto);

        } 
    }
}
