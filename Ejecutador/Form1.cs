using Ejecutador.Consumos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejecutador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "INGRESAR":
                    break;
                case "CONSULTAR":
                    ConsultarSiesa ConSiesa = new ConsultarSiesa();
                    DataSet DS = new DataSet();
                    DS = ConSiesa.ConsultarQuery(textBox1.Text);
                    dataGridView1.DataSource = DS.Tables[0];
                    Archivos Genxml = new Archivos();
                    Genxml.ArmarPlano(DS, @"C:\Users\ImplementadorCRM\Desktop\Nuevacarpeta\");
                    textBox2.Text = DS.GetXml();
                    break;

                default:
                    textBox2.Text = "Debes Seleccionar Un item";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
