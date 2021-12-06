using CafeAndRestaurant.Lib.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAndRestaurant.Forms
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        private List<BinaBilgileri> _bina;
        public FrmGiris(List<BinaBilgileri> bina)
        {
            _bina = bina;       
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            FrmKurulum frmIlk = new FrmKurulum();
            frmIlk.Show();
            this.Hide();
        }

        private void btnBack1_Click_1(object sender, EventArgs e)
        {
            FrmKurulum frmIlk = new FrmKurulum();
            frmIlk.Show();
            this.Hide();
        }

        private void btnBack1_Click_2(object sender, EventArgs e)
        {
            FrmKurulum frmIlk = new FrmKurulum();
            frmIlk.Show();
            this.Hide();
        }

        private void btnYönetici_Click(object sender, EventArgs e)
        {
             FrmRapor frmRaporlar = new FrmRapor();
            frmRaporlar.Show();
            this.Hide();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonel frmPersonel = new FrmPersonel(_bina);
            frmPersonel.Show();
            this.Hide();

        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
