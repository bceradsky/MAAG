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

        private RoomBuilder roombuilder = null;
        public NewItem(Form callingform)
        {
            roombuilder = callingform as RoomBuilder;
            InitializeComponent();
            hideOptions();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (cmbType.SelectedIndex)
            {
                case 0:
                    try
                    {
                        int x = Int32.Parse(txtWeapon.Text);
                        if (x < 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Please input a positive integer.");
                        }
                        else
                        {
                            var newitem = new Weapon();
                            newitem.name = txtName.Text;
                            newitem.descr = txtDescr.Text;
                            newitem.damage = x;
                        }
                    }
                    catch (FormatException)
                    {
                        System.Windows.Forms.MessageBox.Show("Please input a positive integer");
                    }
                    break;
                case 1:
                    try
                    {
                        int x = Int32.Parse(txtArmor.Text);
                        if (x < 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Please input a positive integer.");
                        }
                        else
                        {
                            var newitem = new Armor();
                            newitem.name = txtName.Text;
                            newitem.descr = txtDescr.Text;
                            newitem.defense = x;
                        }
                    }
                    catch (FormatException)
                    {
                        System.Windows.Forms.MessageBox.Show("Please input a positive integer");
                    }
                    break;
                case 2:
                    try
                    {
                        int x = Int32.Parse(txtRestore.Text);
                        if (x < 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Please input a positive integer.");
                        }
                        else
                        {
                            var newitem = new Potion();
                            newitem.name = txtName.Text;
                            newitem.descr = txtDescr.Text;
                            newitem.restore = x;
                        }
                    }
                    catch (FormatException)
                    {
                        System.Windows.Forms.MessageBox.Show("Please input a positive integer");
                    }
                    break;
                case 3:
                    try
                    {
                        int x = Int32.Parse(txtDecrease.Text);
                        if (x < 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Please input a positive integer.");
                        }
                        else
                        {
                            var newitem = new Bomb();
                            newitem.name = txtName.Text;
                            newitem.descr = txtDescr.Text;
                            newitem.damage = x;
                        }
                    }
                    catch (FormatException)
                    {
                        System.Windows.Forms.MessageBox.Show("Please input a positive integer");
                    }
                    break;
                case 4:
                    var item = new Item();
                    item.name = txtName.Text;
                    item.descr = txtDescr.Text;
                    break;
                default:
                    break;
            }
            System.Windows.Forms.MessageBox.Show(txtName.Text + " created sucessfully!");
            this.roombuilder.chkItems.Items.Add(txtName.Text);
            this.Close();
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
