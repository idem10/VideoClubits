using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.ServicioVideoClubRef;
using System.ServiceModel;

namespace VideoClub
{
    public partial class CrearUsuario : Form
    {       
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = textBox1.Text;
            String usr = textBox2.Text;
            String contra = textBox3.Text;
            String tU = comboBox1.Text;
            String dom = textBox4.Text;
            String ti = comboBox2.Text;
            String fi = Fecha.Text;
            var client = new ServicioLogClient();
            try
            {
                if (usr != null || contra != null || tU != null || dom != null || ti != null || fi != null)
                {
                    var ins = client.Insertar(usr,contra,nom,tU,dom,ti,fi);
                }
                else
                {
                    MessageBox.Show("Datos incompletos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario Insertado");
                Close();
            }
        }
    }
}
