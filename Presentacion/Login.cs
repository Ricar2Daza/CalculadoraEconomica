using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUid.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Introducir el usuario o contraseña", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUid.Text == "admin" && txtPassword.Text == "admin123")
            {
                MessageBox.Show("Usuario encontrado", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MenuIntereses menuIntereses = new MenuIntereses();
                menuIntereses.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
