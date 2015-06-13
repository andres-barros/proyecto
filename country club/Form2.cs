using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace country_club
{
    public partial class Form2 : Form
    {
        public Form2(string id)
        {
            InitializeComponent();
            this.id=id;
        }
        countryEntities bd = new countryEntities();
        string id;
        private void agregarinvitado()
        {
            invitados inv = new invitados()
            {
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                identificacion = id,
                direccion = txtdir.Text,
                telefono = txttelefono.Text,
                correo = txtcorreo.Text
                
            };
            
            bd.invitados.Add(inv);
            bd.SaveChanges();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtapellido.Text == "")
            {
                MessageBox.Show("Hay campos vacios que son requeridos");
            }
            else
            {
                agregarinvitado();
                MessageBox.Show("Añadido correctamente");
                this.SetVisibleCore(false);
            }
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            foto f = new foto();
            f.Show();
        }

      

       
    }
}
