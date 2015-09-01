using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.ServicioVideoClubResRef;
using VideoClub.ServicioVideoClubPeliculasRef;

namespace VideoClub
{
    public partial class Reservar : Form
    {
        public Reservar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usr = textBox1.Text;
            int cod = Int32.Parse(textBox2.Text);
            int can = Int32.Parse(comboBox1.Text);
            var client = new ServicioVideoClubResClient();
            try
            {
                if (usr != null || cod != 0 || can != 0 )
                {
                    var ins = client.Reservar(usr, cod, can); 
                    
                }
                else
                {
                    MessageBox.Show("Datos incompletos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos ingresados");
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
            Lista.Text = result;
        }
        private void resvar_Load(object sender, EventArgs e)
        {

        }
    }
}
