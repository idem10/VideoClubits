using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.ServicioVideoClubPeliculasRef;

namespace VideoClub
{
    public partial class MenuVendedor : Form
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void MenuVendedor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String result = "";
            int cant = Int32.Parse(textBox3.Text);
            var cli = new ServicioVideoClubPeliculasClient();
            try
            {

                var login = cli.GetCantidad(cant);
                var sb = new StringBuilder();
                result = sb.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Codigo no encontrado");
            }
            textBox4.Text = result;
            int rest = Int32.Parse(textBox4.Text);
            int can = cant - rest;
            String usr = textBox1.Text;
            int cod = Int32.Parse(textBox2.Text);
            var client = new ServicioVideoClubPeliculasClient();
            try
            {
                if (usr != null)
                {
                    var ins = client.RVP(usr, cod, can);
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

        private void button2_Click(object sender, EventArgs e)
        {
            String result = "";
            int cant = Int32.Parse(textBox3.Text);
            var cli = new ServicioVideoClubPeliculasClient();
            try
            {

                var login = cli.GetCantidad(cant);
                var sb = new StringBuilder();
                result = sb.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Codigo no encontrado");
            }
            textBox4.Text = result;
            int rest = Int32.Parse(textBox4.Text);
            int can = cant - rest;
            String usr = textBox1.Text;
            int cod = Int32.Parse(textBox2.Text);
            var client = new ServicioVideoClubPeliculasClient();
            try
            {
                if (usr != null)
                {
                    var ins = client.RVP(usr, cod, can);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
