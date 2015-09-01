using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.ServicioVideoClubRentaRef;
using VideoClub.ServicioVideoClubPeliculasRef;
using VideoClub.ServicioVideoClubAdeudoRef;

namespace VideoClub
{
    public partial class MenuSocio : Form
    {
        int cont = 0;
        public MenuSocio()
        {
            InitializeComponent();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPeliculas cp = new ConsultaPeliculas();
            cp.Show();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservar rv = new Reservar();
            rv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            String usr = textBox1.Text;
            int cod = Int32.Parse(textBox2.Text);
            String fech = fechaI.Text;            
            int id = 0;            
            var client = new ServicioRentaClient();            
            try
            {
                if (usr != null)
                {
                    var ins = client.Renta(id,usr, cod, fech);
                }
                else
                {
                    MessageBox.Show("Datos incompletos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar datos");              
            }
            var adeu = new Service1Client();
            if (comboBox1.Text == "estrenos")
            {
                float adeudo = 30;
                try
                {
                    if (comboBox1.Text != null)
                    {
                        var ad = adeu.Adeudo(id, usr, adeudo);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al ingresar datos");
                }
            }
            else if (comboBox1.Text == "normales")
            {
                float adeudo = 15;
                try
                {
                    if (comboBox1.Text != null)
                    {
                        var ad = adeu.Adeudo(id, usr, adeudo);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al ingresar datos");
                }
            }
            else if (comboBox1.Text == "promocion")
            {
                float adeudo = 5;
                try
                {
                    if (comboBox1.Text != null)
                    {
                        var ad = adeu.Adeudo(id, usr, adeudo);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al ingresar datos");
                }
            }            
            var cli = new ServicioVideoClubPeliculasClient();
            string result = "";
            try
            {                
                var pelicula = cli.GetPelicula(cod);
                var sb = new StringBuilder();
                sb.Append("Codigo:" + pelicula.codigo.ToString() + "\r\n");
                sb.Append("Titulo: " + pelicula.titulo.ToString() + "\r\n");
                sb.Append("Año de filmacion: " + pelicula.añofilm.ToString() + "\r\n");
                sb.Append("Actores: " + pelicula.actores.ToString() + "\r\n");
                sb.Append("Directores: " + pelicula.directores.ToString() + "\r\n");
                sb.Append("Leguaje disponible: " + pelicula.Ldisponible.ToString() + "\r\n");
                sb.Append("Lenguaje original: " + pelicula.Loriginal.ToString() + "\r\n");
                sb.Append("Duracion: " + pelicula.duracion.ToString() + "\r\n");
                sb.Append("Genero: " + pelicula.genero.ToString() + "\r\n");
                sb.Append("Cantidad disponible: " + pelicula.disponibles.ToString() + "\r\n");
                result = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error codigo no encotrado");
            }
            textBox4.Text = result;
            fechaI.Value = DateTime.Now.AddDays(1);
            MessageBox.Show("Fecha de entrega " +fechaI);
             
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }       
    }
}

