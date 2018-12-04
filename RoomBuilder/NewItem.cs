using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBuilder
{
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
            hideOptions();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbType.SelectedIndex)
            {
                case 0:
                    hideOptions();
                    lblWeapon.Visible = true;
                    txtWeapon.Visible = true;
                    break;
                case 1:
                    hideOptions();
                    lblArmor.Visible = true;
                    txtArmor.Visible = true;
                    break;
                case 2:
                    hideOptions();
                    lblRestore.Visible = true;
                    txtRestore.Visible = true;
                    break;
                case 3:
                    hideOptions();
                    lblDecrease.Visible = true;
                    txtDecrease.Visible = true;
                    break;
                case 4:
                    hideOptions();
                    lblKey.Visible = true;
                    cmbKey.Visible = true;
                    break;
                default:
                    hideOptions();
                    break;
            }
        }

        private void hideOptions()
        {
            lblWeapon.Visible = false;
            txtWeapon.Visible = false;
            lblArmor.Visible = false;
            txtArmor.Visible = false;
            lblRestore.Visible = false;
            txtRestore.Visible = false;
            lblDecrease.Visible = false;
            txtDecrease.Visible = false;
            lblKey.Visible = false;
            cmbKey.Visible = false;
        }
    }
}
