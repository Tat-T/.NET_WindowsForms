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
    public partial class Form1 : Form
    {
        Button[] arrButton;
        String Player;
        
        public Form1()
        {
            InitializeComponent();
            //labelPlayer.Text = "Ходит :  " + Player;
            arrButton = new Button[10];
            arrButton[1] = btn1; arrButton[2] = btn2; arrButton[3] = btn3;
            arrButton[4] = btn4; arrButton[5] = btn5; arrButton[6] = btn6;
            arrButton[7] = btn7; arrButton[8] = btn8; arrButton[9] = btn9;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            //if (((Button)sender).Text == "")
            //{
            //    ((Button)sender).Text = Player;
            //    if (isWin()){MessageBox.Show($"{Player} Победил!!!");}

            //    Player = (Player == "Х") ? "O" : "Х";
            //    //((Button)sender).Enabled = false;// делает кнопку не рабочей
            //    labelPlayer.Text = "Ходит :  " + Player;
            //}  
            if (((Button)sender).Text == "")
            {
                ((Button)sender).Text = Player;
                if (isWin()) 
                {
                    Button b = new Button();
                    var msg = new Form2(Player);
                    msg.ShowDialog();
                    if (msg.ext == "Exit") Close();
                    else if (msg.ext == "NewGame")
                        btnNewGame_Click(sender, e);
                }

                Player = (Player == "Х") ? "O" : "Х";
                //((Button)sender).Enabled = false;// делает кнопку не рабочей
               // labelPlayer.Text = "Ходит :  " + Player;
            }
            Text = $"Ходит :  {Player}";

        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            for(int i=1; i<10; i++)
            arrButton[i].Text = "";
            Text="Крестики-нолики";
        }
        bool isWin()
        {
            if    (arrButton[1].Text == arrButton[2].Text
                && arrButton[1].Text == arrButton[3].Text
                && arrButton[1].Text != "")
                return true;
            if    (arrButton[1].Text == arrButton[4].Text
                && arrButton[1].Text == arrButton[7].Text
                && arrButton[1].Text != "")
                return true;
            if    (arrButton[1].Text == arrButton[5].Text
                && arrButton[1].Text == arrButton[9].Text
                && arrButton[1].Text != "")
                return true;
            if    (arrButton[2].Text == arrButton[5].Text
                && arrButton[2].Text == arrButton[8].Text
                && arrButton[2].Text != "")
                return true;
            if    (arrButton[3].Text == arrButton[5].Text
                && arrButton[3].Text == arrButton[7].Text
                && arrButton[3].Text != "")
                return true;
            if    (arrButton[3].Text == arrButton[6].Text
                && arrButton[3].Text == arrButton[9].Text
                && arrButton[3].Text != "")
                return true;
            if    (arrButton[4].Text == arrButton[5].Text
                && arrButton[4].Text == arrButton[6].Text
                && arrButton[4].Text != "")
                return true;
            if   (arrButton[7].Text == arrButton[8].Text
               && arrButton[7].Text == arrButton[9].Text
               && arrButton[7].Text != "")
                return true;
            return false;

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    Player = (Player == "Х") ? "O" : "Х";
        //    form.Text = $"Ходит :  {Player}";
        //}
    }
}
