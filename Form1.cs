using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using soapClientAlumno.servicios_Alumno;
using System.Web.Services.Protocols;

namespace soapClientAlumno
{
    public partial class AlumnosSW : Form
    {
        public AlumnosSW()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBienvenida_Click(object sender, EventArgs e)
        {
            try { 
                //INVOCACION DE METODO
                servicios_Alumno.ClassroomWSPortTypeClient client = new servicios_Alumno.ClassroomWSPortTypeClient();
                string user = InputUsuario.Text;
                string contraseña = InputContraseña.Text;
                string matricula =  InputMatricula.Text;
                servicios_Alumno.RespuestaBienvenida response = client.Bienvenida(user, contraseña, matricula);

                DisplayStatus.Text = "Status: " + response.status + "\r\n" +
                   "Message: " + response.message;

            } catch(SoapException ex) {
                //HANDLER SOAP-FAULT
                DisplayStatus.Text = "CODE" + ex.Code.ToString() + "\r\n" +
                    "Message: " + ex.Message.ToString();
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void EtqStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
