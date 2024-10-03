using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5_Крестики_Нолики
{
    public partial class Form2 : Form
    {
        public String ext {get; set;}
        public String player { get; set; }
        public Form2(String Player)
        {
            InitializeComponent();
            player = Player;
            label1.Text = "Победил :  " + Player;
        }
        //private void NewGame2_Click(object sender, EventArgs e)
        //{
        //    ext = "NewGame";
        //    Close();
        //}
        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    ext = "Exit";
        //    Close();
        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
