using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int nrruchu = 0;

        private void BRestartuj_Click(object sender, EventArgs e)
        {
            Restart();
            WynikO.Text = "0";
            WynikX.Text = "0";
            LbKtory.Text = "O";
            gracz1 = true;

        }

        private void Restart()
        {
            nrruchu=0;
            Button[] all = new Button[9];
            all[0] = B1;
            all[1] = B2;
            all[2] = B3;
            all[3] = B4;
            all[4] = B5;
            all[5] = B6;
            all[6] = B7;
            all[7] = B8;
            all[8] = B9;
            foreach(Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }

        }

        private void Sprawdzanie()
        {
            if (B1.Text != "" && B1.Text == B2.Text && B2.Text == B3.Text)
                Wygrana();
            else if (B4.Text != "" && B4.Text == B5.Text && B5.Text == B6.Text)
                Wygrana();
            else if (B7.Text != "" && B7.Text == B8.Text && B8.Text == B9.Text)
                Wygrana();
            else if (B1.Text != "" && B1.Text == B4.Text && B4.Text == B7.Text)
                Wygrana();
            else if (B2.Text != "" && B2.Text == B5.Text && B5.Text == B8.Text)
                Wygrana();
            else if (B3.Text != "" && B3.Text == B6.Text && B6.Text == B9.Text)
                Wygrana();
            else if (B1.Text != "" && B1.Text == B5.Text && B5.Text == B9.Text)
                Wygrana();
            else if (B3.Text != "" && B3.Text == B5.Text && B5.Text == B7.Text)
                Wygrana();
            else if(nrruchu==9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restart();
            }

        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)
            {
                WynikO.Text = ((int.Parse(WynikO.Text) + 1).ToString());
            }
            else
            {
                WynikX.Text = ((int.Parse(WynikX.Text) + 1).ToString());
            }
            Restart();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if(nrruchu>=5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";

        }

        private void B2_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (nrruchu >= 5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (nrruchu >= 5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (nrruchu >= 5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (nrruchu >= 5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (nrruchu >= 5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (nrruchu >= 5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (nrruchu >= 5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            nrruchu++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (nrruchu >= 5)
            {
                Sprawdzanie();
            }
            gracz1 = !gracz1;
            LbKtory.Text = gracz1 ? "O" : "X";
        }
    }
}
