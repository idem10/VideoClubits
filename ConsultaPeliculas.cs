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
    public partial class ConsultaPeliculas : Form
    {
        public ConsultaPeliculas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "codigo")
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
                }
                catch (Exception)
                {
                    MessageBox.Show("Error codigo no encotrado");
                }
                textBox2.Text = result;
            }
            else if (comboBox1.Text == "titulo")
            {
                var client = new ServicioVideoClubPeliculasClient();
                string result = "";
                try
                {
                    String titulo = textBox1.Text;
                    String genero = "", año = "", actor = "";
                    var pelicula = client.GetPeliculaT(titulo, genero, año, actor);
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
                textBox2.Text = result;
            }
            else if (comboBox1.Text == "genero")
            {
                var client = new ServicioVideoClubPeliculasClient();
                string result = "";
                try
                {
                    String gen = textBox1.Text;
                    String titulo = "", año = "", actor = "";
                    var pelicula = client.GetPeliculaT(titulo,gen,año,actor);
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
                textBox2.Text = result;
            }
            else if (comboBox1.Text == "año")
            {
                var client = new ServicioVideoClubPeliculasClient();
                string result = "";
                try
                {
                    String añ = textBox1.Text;
                    String titulo = "", genero = "", actor = "";
                    var pelicula = client.GetPeliculaT(titulo, genero, añ, actor);
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
                textBox2.Text = result;
            }
            else if (comboBox1.Text == "actor")
            {
                var client = new ServicioVideoClubPeliculasClient();
                string result = "";
                try
                {
                     String act= textBox1.Text;
                     String titulo = "", genero = "", año = "";
                     var pelicula = client.GetPeliculaT(titulo, genero, año, act);
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
                textBox2.Text = result;
            }
        }
    }
}