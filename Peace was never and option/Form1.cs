using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peace_was_never_and_option
{
    public partial class Form1 : Form
    {
        int jumlahHari = -999;
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void customizeDesign()
        {
            panelFILEINPUTSubMenu.Visible = false;
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFILEINPUTSubMenu);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Baca txt Map
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Layout(object sender, LayoutEventArgs e)
        {

        }
        private void hideSubMenu()
        {
            panelFILEINPUTSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void panelFILEINPUTSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPopulasi_Click(object sender, EventArgs e)
        {

        }

        private void btnHari_Click(object sender, EventArgs e)
        {

        }
    }
}
