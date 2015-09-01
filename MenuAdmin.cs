using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario cu = new CrearUsuario();
            cu.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario iv = new Inventario();
            iv.Show();
        }

        private void desbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesUsr du = new DesUsr();
            du.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPeliculas cp = new ConsultaPeliculas();
            cp.Show();
        }

        private void reservarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservar rv = new Reservar();
            rv.Show();
        }
    }
}
