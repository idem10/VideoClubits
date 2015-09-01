using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.ServicioVideoClubBlo;
using System.ServiceModel;

namespace VideoClub
{
    public partial class DesUsr : Form
    {

        public DesUsr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new ServicioBloClient();
            string result = "";
            try
            {
                String usr = textBox1.Text;
                var bloqueado = client.GetBlo(usr);
                var sb = new StringBuilder();
                sb.Append("ID:" + bloqueado.id.ToString() + "\r\n");
                sb.Append("Nombre: " + bloqueado.nombre.ToString() + "\r\n");
                sb.Append("Usuario: " + bloqueado.usuario.ToString() + "\r\n");
                sb.Append("Tipo De Usuario: " + bloqueado.tipoUsuario.ToString() + "\r\n");
                sb.Append("bloqueado: " + bloqueado.bloqueado.ToString() + "\r\n");
                sb.Append("domicilio: " + bloqueado.domicilio.ToString() + "\r\n");
                sb.Append("Tidentificacion: " + bloqueado.Tidentificacion.ToString() + "\r\n");
                sb.Append("Finicio : " + bloqueado.Finicio.ToString() + "\r\n");
                result = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error codigo no encotrado");
            }
            textBox2.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            var client = new ServicioBloClient();
            try
            {
                var bloq = client.Bloquear(user);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            string result = "";
            try
            {
                var bloqueado = client.GetBlo(user);
                var sb = new StringBuilder();
                sb.Append("ID:" + bloqueado.id.ToString() + "\r\n");
                sb.Append("Nombre: " + bloqueado.nombre.ToString() + "\r\n");
                sb.Append("Usuario: " + bloqueado.usuario.ToString() + "\r\n");
                sb.Append("Tipo De Usuario: " + bloqueado.tipoUsuario.ToString() + "\r\n");
                sb.Append("bloqueado: " + bloqueado.bloqueado.ToString() + "\r\n");
                sb.Append("domicilio: " + bloqueado.domicilio.ToString() + "\r\n");
                sb.Append("Tidentificacion: " + bloqueado.Tidentificacion.ToString() + "\r\n");
                sb.Append("Finicio : " + bloqueado.Finicio.ToString() + "\r\n");
                result = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error codigo no encotrado");
            }
            textBox2.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            String user = textBox1.Text;
            var client = new ServicioBloClient();            
            string result = "";
            try
            {
                var bloqueado = client.GetBlo(user);
                var sb = new StringBuilder();
                sb.Append("ID:" + bloqueado.id.ToString() + "\r\n");
                sb.Append("Nombre: " + bloqueado.nombre.ToString() + "\r\n");
                sb.Append("Usuario: " + bloqueado.usuario.ToString() + "\r\n");
                sb.Append("Tipo De Usuario: " + bloqueado.tipoUsuario.ToString() + "\r\n");
                sb.Append("bloqueado: " + bloqueado.bloqueado.ToString() + "\r\n");
                sb.Append("domicilio: " + bloqueado.domicilio.ToString() + "\r\n");
                sb.Append("Tidentificacion: " + bloqueado.Tidentificacion.ToString() + "\r\n");
                sb.Append("Finicio : " + bloqueado.Finicio.ToString() + "\r\n");
                result = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error codigo no encotrado");
            }
            textBox2.Text = result;   
       
            try
            {
                var bloq = client.Desb(user);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
