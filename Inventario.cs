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
using System.ServiceModel;

namespace VideoClub
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new ServicioVideoClubPeliculasClient();
            string result = "";
            try
            {
                int cod = Int32.Parse(textBox1.Text);
                var pelicula = client.GetPelicula(cod);
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
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error codigo no encotrado");
            }
            Lista.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int codigo = Int32.Parse(cod.Text);
            String titulo = tit.Text;
            String an = año.Text;
            String actores = act.Text;
            String directores = dir.Text;
            String LOrig = lor.Text;
            String LDispo = ldis.Text;
            String Dur = dur.Text;
            String Gen = gen.Text;
            int dispo = Int32.Parse(disp.Text);
            var client = new ServicioVideoClubPeliculasClient();
            try
            {
                if (cod != null)
                {
                    var ins = client.Insertar(codigo, titulo, an, actores, directores, LOrig, LDispo, Dur, Gen, dispo);
                }
                else
                {
                    MessageBox.Show("Datos incompletos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pelicula Insertada");
                cod.Text = "";
                tit.Text = "";
                año.Text = "";
                act.Text = "";
                dir.Text = "";
                lor.Text = "";
                ldis.Text = "";
                dur.Text = "";
                gen.Text = "";
                disp.Text = "";
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = Int32.Parse(textBox2.Text);
            var client = new ServicioVideoClubPeliculasClient();
            try
            {
                if (codigo != 0)
                {
                    var ins = client.Eliminar(codigo);
                }
                else
                {
                    MessageBox.Show("Datos incompletos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pelicula Dada de baja ");
                textBox2.Text = "";
            }
        }
    }
}