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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }
        
        
        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "country" && txtcontraseña.Text == "56789")
            {
                Form1 Form1 = new Form1();
                Form1.Show();
                login l = new login();
                this.SetVisibleCore(false);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        

        
       
    }
}
