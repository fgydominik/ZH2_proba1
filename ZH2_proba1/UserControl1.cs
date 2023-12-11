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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            FilterGame();
        }

        Models.BoardGameContext boardGameContext = new Models.BoardGameContext();

        private void textBoxGameSzures_TextChanged(object sender, EventArgs e)
        {
            FilterGame();
        }

        private void FilterGame()
        {
            var jatekSzures = from x in boardGameContext.Games
                              where x.Nev.Contains(textBoxGameSzures.Text)
                              select x;

            listBoxGame.DataSource = jatekSzures.ToList();
            listBoxGame.DisplayMember = "Nev";
        }

        private void listBoxGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game game = (Game)listBoxGame.SelectedItem;

            var selectedGame = from x in boardGameContext.Games
                           where x.GameSk == game.GameSk
                           select new JatekAdat
                           {
                               GameSk = x.GameSk,
                               Kategoria = x.KategoriaFkNavigation.KategoriaNev,
                               MinLetszam = x.MinLetszam,
                               MaxLetszam = x.MaxLetszam,
                               ArFt = x.ArFt,
                               IdotartamPerc = x.IdotartamPerc,
                               SzuksegesEletkor = x.SzuksegesEletkor
                           };

            dataGridView1.DataSource = selectedGame.ToList();
        }
    }
}
