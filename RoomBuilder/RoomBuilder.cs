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
    public partial class RoomBuilder : Form
    {
        public RoomBuilder()
        {
            InitializeComponent();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            var form = new NewItem(this);
            form.Show();
        }

        private void btnNewEnemy_Click(object sender, EventArgs e)
        {
            var form = new NewEnemy();
            form.ShowDialog();
        }

        private void btnMakeRoom_Click(object sender, EventArgs e)
        {
            var room = new Room();
            room.name = txtName.Text;
            room.text = txtRoomText.Text;
            room.connections = new List<object>();
            room.items = new List<object>();
            room.enemies = new List<object>();
            room.secrets = new List<object>();

            foreach (var selection in chkConnections.CheckedItems)
            {
                room.connections.Add(selection);
            }
            foreach (var selection in chkItems.CheckedItems)
            {
                room.items.Add(selection);
            }
            foreach (var selection in chkEnemies.CheckedItems)
            {
                room.enemies.Add(selection);
            }
            foreach (var selection in chkSecret.CheckedItems)
            {
                room.secrets.Add(selection);
            }

            System.Windows.Forms.MessageBox.Show(room.name + " created successfully!");

            chkConnections.Items.Add(room.name);
            ClearSelections(chkConnections);
            ClearSelections(chkItems);
            ClearSelections(chkEnemies);
            ClearSelections(chkSecret);
        }

        private void ClearSelections(CheckedListBox control)
        {
            for (var chk = 0; chk < control.Items.Count; chk++)
            {
                if (control.GetItemCheckState(chk) == CheckState.Checked)
                {
                    control.SetItemCheckState(chk, CheckState.Unchecked);
                }
            }
            control.ClearSelected();
        }
        
    }
}
