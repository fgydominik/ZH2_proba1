using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_proba1
{
    public partial class UjRendelesForm : Form
    {
        public UjRendelesForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren() == true )
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonMégse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void UjRendelesForm_Load(object sender, EventArgs e)
        {
            //comboBoxJatek.DisplayMember = "Nev";
        }

        private void textBoxjatek_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxjatek.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxjatek, "Nem lehet üres");
            }
        }

        private void textBoxjatek_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxjatek, string.Empty);
        }

        private void textBoxDb_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[1-9]{1}$");
            if (!regex.IsMatch(textBoxDb.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxDb, "Maxminum 9 db ot lehet rendelni");
            }
        }

        private void textBoxDb_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxjatek, string.Empty);
        }
    }
}
