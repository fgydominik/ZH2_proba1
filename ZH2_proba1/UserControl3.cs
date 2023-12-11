using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_proba1
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        Models.BoardGameContext boardGameContext = new Models.BoardGameContext();

        private void UserControl3_Load(object sender, EventArgs e)
        {
            rendeleBindingSource.DataSource = boardGameContext.Rendeles.ToList();
            gameBindingSource.DataSource = boardGameContext.Games.ToList();

            var osszeg = (from x in boardGameContext.Rendeles
                          select x.FizetendoFt).Sum();

            textBoxOsszeg.Text = osszeg.ToString() + " Ft";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UjRendelesForm ujRendelesForm = new UjRendelesForm();
            if (ujRendelesForm.ShowDialog() == DialogResult.OK)
            {
                Models.Rendele rendeles = new Models.Rendele();
                rendeles.GameFk = Int32.Parse(ujRendelesForm.textBoxjatek.Text);
                rendeles.MennyisegDb = Int32.Parse(ujRendelesForm.textBoxDb.Text);

                
                //rendeles.FizetendoFt = rendeles.MennyisegDb * rendeles.GameFkNavigation.ArFt;
               
               
                //var fizetendo = from x in rendeles
                //                where x.GameFk == rendeles.GameFkNavigation.GameSk
                //                select x.GameFkNavigation.ArFt; 

                boardGameContext.Add(rendeles);

                try
                {
                    boardGameContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                rendeleBindingSource.DataSource = boardGameContext.Rendeles.ToList();
            }
        }
    }
}
