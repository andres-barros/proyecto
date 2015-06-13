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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        countryEntities bd = new countryEntities();
        socios cos=new socios();
        invitados coi=new invitados();
        private void btning_Click(object sender, EventArgs e)
        {
            cos = (from s in bd.socios where s.identificacion == textide.Text select s).FirstOrDefault(); 
            if (cos != null)
            {
                Form3 f3 = new Form3(cos,coi);
                f3.Show();
                Form1 f = new Form1();
                f.SetVisibleCore(false);
                
            }
            else
            {
                coi=(from s in bd.invitados where s.identificacion == textide.Text select s).FirstOrDefault();
                if (coi != null)
                {
                    Form3 f3 = new Form3(cos,coi);
                    f3.Show();
                }
                else
                {
                    string id = textide.Text;
                    Form2 fr = new Form2(id);
                    fr.Show();
                }
            }
        }

        private void mostrar()
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
