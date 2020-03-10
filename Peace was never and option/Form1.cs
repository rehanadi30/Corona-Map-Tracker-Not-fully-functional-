using System;
using System.IO;
using System.Windows.Forms;

namespace Peace_was_never_and_option
{
    public partial class Form1 : Form
    {
        int jumlahHari = -999;
        OpenFileDialog openFile = new OpenFileDialog();
        string line = "";
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
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        //listBox1.Items.Add(line);
                    }
                }
                sr.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            openFile.Filter = "Text Files (.txt)| *.txt";
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

        private void SELAMATDATANG_Click(object sender, EventArgs e)
        {

        }

        private void linkWebWHO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("https://www.who.int/emergencies/diseases/novel-coronavirus-2019");
            System.Diagnostics.Process.Start(sInfo);
        }

        private void button3_Click_1(object sender, EventArgs e) //Tombol Generate
        {
            if (jumlahHari == -999)
            {

            }
            else
            openChildForm(new Form3());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }
        private Form formAktif = null;
        private void openChildForm(Form childForm)
        {
            if (formAktif != null) formAktif.Close();
            formAktif = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void childPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void labelNamaProgram_Click(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
