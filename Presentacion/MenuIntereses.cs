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
    public partial class MenuIntereses : Form
    {
        private Form currentForm = null;

        public MenuIntereses()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ******************************************** OTHERS *******************************************/
        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null) currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnInteresSimple_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentacion.Simple());
        }

        private void btnInteresCompuesto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentacion.Compuesto());
        }

        private void btnInteresAnualidad_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentacion.Anualidades());
        }

        private void btnGradientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Presentacion.Gradiente());
        }

        private void MenuIntereses_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                panelChildForm.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                panelChildForm.Visible = true;
            }
        }
    }
}
