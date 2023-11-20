using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayının_var_olup_olmadıgına_bakan_uygulama_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                lbSayi.Items.Add(rnd.Next(1, 101));
            }
        }

        private void btnVarMi_Click(object sender, EventArgs e)
        {
            int ara = Convert.ToInt32(txtAra.Text);
            bool bulundu = false;

            for (int i= 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lbSayi.Items[i]);

                if (sayi == ara)
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu)
            {
                MessageBox.Show("Aranan sayı bulundu");
            }
            else
            {
                MessageBox.Show("Aranan sayı bulunamadı");
            }
        }
    }
}
