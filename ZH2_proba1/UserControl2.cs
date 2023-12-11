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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            FilterKategoria();
        }

        Models.BoardGameContext boardGameContext = new Models.BoardGameContext();

        private void textBoxKategoriaSzures_TextChanged(object sender, EventArgs e)
        {
            FilterKategoria();
        }

        private void FilterKategoria()
        {
            var kategoriaSzures = from x in boardGameContext.Kategoria
                                  where x.KategoriaNev.Contains(textBoxKategoriaSzures.Text)
                                  select x;

            listBoxKategoria.DataSource = kategoriaSzures.ToList();
            listBoxKategoria.DisplayMember = "KategoriaNev";
        }

        private void listBoxKategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategorium kategorium = (Kategorium)listBoxKategoria.SelectedItem;

            var selectedKategoria = from x in boardGameContext.Games
                                    where x.KategoriaFk == kategorium.KategoriaSk
                                    select new KategoriaAdat
                                    {
                                        KategoriaSk = x.KategoriaFkNavigation.KategoriaSk,
                                        Nev = x.Nev
                                    };

            listBoxJatekok.DataSource = selectedKategoria.ToList();
            listBoxJatekok.DisplayMember = "Nev";
        }
    }
}
