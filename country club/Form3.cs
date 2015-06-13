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
    public partial class Form3 : Form
    {
        public Form3(socios cos,invitados coi)
        {
            InitializeComponent();
            this.cos = cos;
            this.coi = coi;
        }

        socios cos = new socios();
        invitados coi = new invitados();
        private void Form3_Load(object sender, EventArgs e)
        {
            if (cos != null)
            {
                lblnom.Text = cos.nombre;
                lblape.Text = cos.apellido;
                lbltid.Text = cos.tipoid;
                lblide.Text = cos.identificacion;
                lblacc.Text = Convert.ToString(cos.numaccion);
                if (cos.activo == true)
                {
                    lblest.Text = "Activo";
                }
                else
                {
                    lblest.Text = "No Activo";
                }
            }else
            {
                lblnom.Text = coi.nombre;
                lblape.Text = coi.apellido;
                lbltid.Text = "cc";
                lblide.Text = coi.identificacion;
                lblacc.Text = "";
                lblest.Text = "";
            }
        }
    }
}
