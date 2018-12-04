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
            var form = new NewItem();
            form.ShowDialog();
        }

        private void btnNewEnemy_Click(object sender, EventArgs e)
        {
            var form = new NewEnemy();
            form.ShowDialog();
        }
    }
}
