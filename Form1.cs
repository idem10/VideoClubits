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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String usuario = textBox1.Text;
            String contraseña = textBox2.Text;
            var client = new ServicioLogClient();            
            try
            {
                if (usuario != null || contraseña != null)
                {
                    var login = client.GetLog(usuario, contraseña);

                    if (login.tipoUsuario == "admin")
                    {
                        if (login.bloqueado == true)
                        {
                            MessageBox.Show("Usuario Bloqueado");
                        }else{
                            MenuAdmin ma = new MenuAdmin();
                            ma.Show();
                            usuario = "";
                            contraseña = "";
                        }
                    }
                    else if (login.tipoUsuario == "socio")
                    {
                        if (login.bloqueado == true)
                        {
                            MessageBox.Show("Usuario Bloqueado");
                        }
                        else
                        {
                            MenuSocio ms = new MenuSocio();
                            ms.Show();
                        }
                    }
                    else if (login.tipoUsuario == "vendedor")
                    {
                        if (login.bloqueado == true)
                        {
                            MessageBox.Show("Usuario Bloqueado");
                        }
                        else
                        {
                            MenuVendedor mv = new MenuVendedor();
                            mv.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Datos incompletos");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Error usuario no encontrado");
            }
            
        }
    }
}
