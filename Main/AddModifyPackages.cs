using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class AddModifyPackages : Form
    {
        public AddModifyPackages(string operationType, int id = 0) //set default id to next autonumber?
        {
            InitializeComponent();
            txtId.Text = id.ToString();
        }
    }
}
