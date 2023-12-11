using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH2_proba1.Models;

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
            Rendeleslistazas();
            RendelesSum();
            RendelesIdListazas();
        }

        private void Rendeleslistazas()
        {
            rendeleBindingSource.DataSource = boardGameContext.Rendeles.ToList();
            gameBindingSource.DataSource = boardGameContext.Games.ToList();
        }

        private void RendelesSum()
        {
            var osszeg = (from x in boardGameContext.Rendeles
                          select x.FizetendoFt).Sum();

            textBoxOsszeg.Text = osszeg.ToString() + " Ft";
        }

        private void RendelesIdListazas()
        {
            var rendelesIDs = from x in boardGameContext.Rendeles
                              select x;

            listBoxRendelesID.DataSource = rendelesIDs.ToList();
            listBoxRendelesID.DisplayMember = "RendelesId";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UjRendelesForm ujRendelesForm = new UjRendelesForm();
            if (ujRendelesForm.ShowDialog() == DialogResult.OK)
            {
                Models.Rendele rendeles = new Models.Rendele();
                rendeles.GameFk = Int32.Parse(ujRendelesForm.textBoxjatek.Text);
                //rendeles.GameFk = Int32.Parse(ujRendelesForm.comboBoxJatek.ValueMember);
                rendeles.MennyisegDb = Int32.Parse(ujRendelesForm.textBoxDb.Text);

                var jatekAr = (from x in boardGameContext.Games
                               where x.GameSk == rendeles.GameFk
                               select x.ArFt).FirstOrDefault();

                rendeles.FizetendoFt = rendeles.MennyisegDb * jatekAr;

                boardGameContext.Add(rendeles);

                try
                {
                    boardGameContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                Rendeleslistazas();
                RendelesSum();
                RendelesIdListazas();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var kiválasztottRendeles = (Rendele)listBoxRendelesID.SelectedItem;

            var torlendo = (from x in boardGameContext.Rendeles
                           where x.RendelesId == kiválasztottRendeles.RendelesId
                           select x).FirstOrDefault();

            boardGameContext.Rendeles.Remove(torlendo);

            try
            {
                boardGameContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Rendeleslistazas();
            RendelesSum();
            RendelesIdListazas();
        }
    }
}
