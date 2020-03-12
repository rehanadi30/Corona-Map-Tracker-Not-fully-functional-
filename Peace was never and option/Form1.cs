using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualBasic;
//using TubesStima;

namespace Peace_was_never_and_option
{
    public partial class Form1 : Form
    {
        int FormTerbuka = 1;
        int jumlahHari = -999;
        OpenFileDialog openFile = new OpenFileDialog();
        string line = "";
        BFS bfs = new BFS();
        Queue<string> temp = new Queue<string>();
        bool mapFile, popFile = false;

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
            if (FormTerbuka == 1)
            {
                showSubMenu(panelFILEINPUTSubMenu);
            }
            else
                showSubMenu(panelFILEINPUTSubMenu);
            FormTerbuka = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Masukin txt Map
        {
            int n;
            string[] split;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                line = sr.ReadLine();
                split = line.Split(' ');
                n = Convert.ToInt32(split[0]);
                for (int i = 0; i < n; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(' ');
                    try
                    {
                        bfs.towns[split[0]].AddEdge(split[1], Convert.ToDouble(split[2]));
                    } catch (Exception exc){
                        temp.Enqueue(line);
                    }
                }
                sr.Close();
                foreach (var item in bfs.towns)
                {
                    Console.WriteLine(item.Key);
                    foreach (var edge in item.Value.edges)
                    {
                        Console.WriteLine("\t" + edge.ToTown + " " + edge.Probability);
                    }
                }
                mapFile = true;
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

        private void btnPopulasi_Click(object sender, EventArgs e) //Tombol Populasi
        {
            string[] split;
            int n;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                line = sr.ReadLine();
                split = line.Split(' ');
                n = Convert.ToInt32(split[0]);
                bfs.start = split[1];

                for (int i = 0; i < n; i++)
                {
                    line = sr.ReadLine();
                    split = line.Split(' ');
                    bfs.towns.Add(split[0], new Vertex(split[0], Convert.ToInt32(split[1])));
                }
                sr.Close();

                string s;
                while (temp.Count > 0)
                {
                    s = temp.Dequeue();
                    split = s.Split(' ');
                    bfs.towns[split[0]].AddEdge(split[1], Convert.ToDouble(split[2]));
                }
                foreach (var item in bfs.towns)
                {
                    Console.WriteLine(item.Key + " " + item.Value.Population);
                }
                popFile = true;
            }
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
                //Do Nothing
            }
            else
            {
                openChildForm(new Form3());
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string Content = Interaction.InputBox("Masukkan hari yang kamu ingin ketahui", "Pemilihan Hari", "0", 500, 300);
            try
            {
                if (Content != "")
                {
                    MessageBox.Show(Content, "Hari terpilih");
                }
                jumlahHari = System.Convert.ToInt32(Content);
            }
            catch (Exception) { }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo("https://www.galamedianews.com/media/original/200212152442-tak-i.jpg");
            System.Diagnostics.Process.Start(sInfo);
        }
        public class Vertex
        {
            private string name;
            private int population;
            private int day;
            private bool? infected;
            public List<Edge> edges;

            public int Population { get => population; set => population = value; }
            public string Name { get => name; set => name = value; }
            public int Day { get => day; set => day = value; }
            public bool? Infected { get => infected; set => infected = value; }
            public Vertex(string town, int pop)
            {
                day = -999;
                infected = null;
                name = town;
                population = pop;
                edges = new List<Edge>();
            }
            public void AddEdge(string to, double prob)
            {
                edges.Add(new Edge(name, to, prob));
            }

            public bool EdgeExists(string to)
            {
                foreach (var item in edges)
                {
                    if (item.ToTown == to)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public class Edge
        {
            private string fromTown;
            private string toTown;
            private double probability;

            public string FromTown { get => fromTown; set => fromTown = value; }
            public string ToTown { get => toTown; set => toTown = value; }
            public double Probability { get => probability; set => probability = value; }

            public Edge(string from, string to, double prob)
            {
                toTown = to;
                fromTown = from;
                probability = prob;
            }
        }

        public class BFS
        {
            OpenFileDialog openFile = new OpenFileDialog();
            public Dictionary<string, Vertex> towns;
            public Queue<string[]> queue;
            public string start;

            public BFS()
            {
                //int n;
                //string[] split;

                towns = new Dictionary<string, Vertex>();
                queue = new Queue<string[]>();

                /*try
                {
                    StreamReader popFile = new StreamReader(openFile.FileName);
                    StreamReader mapFile = new StreamReader(openFile.FileName);
                    split = popFile.ReadLine().Split(' ');
                    n = Convert.ToInt32(split[0]);
                    start = split[1];
                    Console.WriteLine("Region count: " + n);
                    Console.WriteLine("Starting town: " + start);

                    for (int i = 0; i < n; i++)
                    {
                        split = popFile.ReadLine().Split(' ');
                        try
                        {
                            towns.Add(split[0], new Vertex(split[0], Convert.ToInt32(split[1])));
                        }
                        catch (Exception) { }
                    }

                    popFile.Close();

                    n = Convert.ToInt32(mapFile.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        split = mapFile.ReadLine().Split(' ');
                        var value = double.Parse(split[2], CultureInfo.InvariantCulture);
                        towns[split[0]].AddEdge(split[1], value);
                    }
                    foreach (var item in towns)
                    {
                        Console.WriteLine(item.Key);
                        foreach (var i in item.Value.edges)
                        {
                            Console.WriteLine("\t" + i.ToTown + " " + i.Probability);
                        }
                    }
                    mapFile.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadLine();
                    Environment.Exit(0);
                } */
            }


            public void AddQueue(Vertex newVertex)
            {
                string[] temp;
                foreach (Edge edge in newVertex.edges)
                {
                    temp = new string[2];
                    temp[0] = edge.FromTown;
                    temp[1] = edge.ToTown;
                    queue.Enqueue(temp);
                }
            }

            public void VertexInit()
            {
                foreach (var item in towns)
                {
                    item.Value.Day = 0;
                    item.Value.Infected = null;
                }
                towns[start].Infected = null;
            }
            /*
             Jumlah masyarakat yang terkena virus = P(A) / (1 + (P(A) - 1)e^(-0.25T(A)))
             = t(A) * P(A) / 20
                 */
            public double CountInfected(Vertex suspectTown, int spreadDur)
            {
                double InfectedPopulation;
                int res;
                //dpuble e = Math.E;
                // InfectedPopulation = suspectTown.Population / (1 + ((suspectTown.Population - 1) * Math.Pow(e, -0.25 * spreadDur)));
                InfectedPopulation = (suspectTown.Population * spreadDur) / 20;
                res = Convert.ToInt32(InfectedPopulation);
                return res;
            }

            //Jika S(A,B) = I(A,t).Tr(A,B) > 1, return true
            public bool Spread(string from, string target, int spreadDur)
            {
                double InfectedPopulation;
                Vertex suspectTown = towns[from];
                InfectedPopulation = CountInfected(suspectTown, spreadDur);
                Console.WriteLine(" Jumlah masyarakat yang terkena virus di daerah A adalah I(A, " + spreadDur + ") = " + InfectedPopulation);
                foreach (Edge edge in suspectTown.edges)
                {
                    if ((edge.ToTown == target) && (InfectedPopulation * edge.Probability > 1))
                    {
                        Console.WriteLine(" S(A,B) = I(A, " + spreadDur + ") = " + InfectedPopulation + "*" + edge.Probability + " = " + (InfectedPopulation * edge.Probability));
                        return true;
                    }
                }
                return false;
            }

            public int SpreadTime(string from, string target)
            {
                int day;
                day = 0;
                double InfectedPopulation;
                Vertex suspectTown = towns[from];
                Vertex targetTown = towns[target];
                double ProbabilityVertex = 0;
                InfectedPopulation = CountInfected(suspectTown, day);
                foreach (Edge edge in suspectTown.edges)
                {
                    if ((edge.ToTown == target))
                    {
                        ProbabilityVertex = edge.Probability;
                    }
                }
                while (true)
                {
                    if (InfectedPopulation * ProbabilityVertex > 1)
                    {
                        break;
                    }
                    else
                    {
                        day++;
                        InfectedPopulation = CountInfected(suspectTown, day);
                    }
                }
                return day + suspectTown.Day;
            }
        }
    }
}

