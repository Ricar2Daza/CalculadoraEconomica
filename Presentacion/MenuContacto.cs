using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;

namespace Presentacion.GUIUsuario
{
    public partial class MenuContacto : Form
    {
        // ***************************************** PROPERTIES *****************************************/
        private Usuario usuario;
        private Form currentForm = null;

        public MenuContacto(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            txtNameUsuario.Text = usuario.Nombre;
            txtNameUsuario.ForeColor = Color.LightSteelBlue;
            lblFechaEntrada.Text = usuario.FechaEntrada.ToString();
        }
        // ********************************************* FIN *********************************************/

        // ******************************************** EVENTS *******************************************/
        private void button7_Click(object sender, EventArgs e) => this.Close();

        private void MenuContacto_Load(object sender, EventArgs e) => HideSubMenu();

        private void btnCrearContacto_Click(object sender, EventArgs e)
        {
            if (panelSubCrearContactos.Visible == true)
            {
                panelSubCrearContactos.Visible = false;
            }
            else ShowSubMenu(panelSubCrearContactos);
        }

        private void btnBuscarContactos_Click(object sender, EventArgs e)
        {
            if (panelSubBuscarContactos.Visible == true)
            {
                panelSubBuscarContactos.Visible = false;
            }
            else ShowSubMenu(panelSubBuscarContactos);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new GUIContacto1.ModificarContacto(currentForm, panelChildForm, usuario.Id));
        }

        private void btnCrearPersonal_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new GUIContactoPersonal.CrearContactoPersonal(usuario.Id));
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new GUIContactoComercial.CrearContactoComercial(usuario.Id));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            if (currentForm != null) currentForm.Close();
        }

        private void btnBuscarPersonal_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new GUIContactoPersonal.BuscarContactoPersonal(usuario.Id));
        }

        private void btnBuscarComercial_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new GUIContactoComercial.BuscarContactoComercial(usuario.Id));
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new GUIContacto1.BorrarContacto(usuario.Id));
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = System.Drawing.Color.FromArgb(145, 160, 200);
            button7.ForeColor = System.Drawing.Color.FromArgb(10, 25, 74);
            button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(145, 160, 200);
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = System.Drawing.Color.FromArgb(10, 25, 74);
            button7.ForeColor = System.Drawing.Color.FromArgb(145, 160, 200);
            button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(145, 160, 200);
        }
        // ********************************************* FIN *********************************************/

        // ******************************************** OTHERS *******************************************/
        private void HideSubMenu()
        {
            panelSubCrearContactos.Visible = false;
            panelSubBuscarContactos.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

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
        // ********************************************* FIN *********************************************/
    }
}
