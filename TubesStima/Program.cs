using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace TubesStima
{
    class Vertex
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

    class Edge
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
    class BFS
    {
        public Dictionary<string, Vertex> towns;
        public Queue<string[]> queue;
        public string start;

        BFS()
        {
            int n;
            string[] split;

            towns = new Dictionary<string, Vertex>();
            queue = new Queue<string[]>();

            try
            {
                StreamReader popFile = new StreamReader(Directory.GetCurrentDirectory() + "\\population.txt");
                StreamReader mapFile = new StreamReader(Directory.GetCurrentDirectory() + "\\map.txt");
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
                /*foreach (var item in towns)
                {
                    Console.WriteLine(item.Key);
                    foreach (var i in item.Value.edges)
                    {
                        Console.WriteLine("\t" + i.ToTown + " " + i.Probability);
                    }
                }*/
                mapFile.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                Environment.Exit(0);
            }
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
            double e, InfectedPopulation;
            int res;
            e = Math.E;
            // InfectedPopulation = suspectTown.Population / (1 + ((suspectTown.Population - 1) * Math.Pow(e, -0.25 * spreadDur)));
            InfectedPopulation = (suspectTown.Population * spreadDur) / 20;
            res = Convert.ToInt32(InfectedPopulation);
            return res;
        }

        //Jika S(A,B) = I(A,t).Tr(A,B) > 1, return true
        public bool Spread(string from, string target,int spreadDur)
        {
            double InfectedPopulation;
            Vertex suspectTown = towns[from];
            InfectedPopulation = CountInfected(suspectTown,spreadDur);
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BFS pr = new BFS();
            string userInput;
            int targetDate, spreadDur, time;
            Vertex curTown,tarTown;
            userInput = Console.ReadLine();
            targetDate = Convert.ToInt32(userInput);
            pr.towns[pr.start].Day = 0;
            Console.WriteLine("Tanggal dimasukkan : " + targetDate);
            pr.queue.Clear();
            pr.AddQueue(pr.towns[pr.start]);
            while (pr.queue.Count != 0)
            {
                string[] temp;
                temp = pr.queue.Peek();
                Console.WriteLine(" Cek Penyebaran dari "+ temp[0] + " -> " + temp[1]);
                curTown = pr.towns[temp[0]];
                tarTown = pr.towns[temp[1]];

                spreadDur = targetDate - curTown.Day;
                Console.WriteLine(" Virus pertama kali muncul di daerah A pada T(A) = " + curTown.Day + " maka t(A) = " + targetDate + " - " + curTown.Day + "=" + spreadDur);
                if (pr.Spread(temp[0], temp[1], spreadDur))
                {
                    Console.WriteLine("Karena S(A,B) > 1, maka virus berhasil tersebar dari daerah " + temp[0] + " ke daerah  " + temp[1]);
                    Console.WriteLine("Selanjutnya, cari tahu kapan virus berhasil tersebar ke daerah "  + temp[1]);
                    pr.towns[temp[0]].Infected = true;
                    time = pr.SpreadTime(temp[0], temp[1]);
                    Console.WriteLine("S(A,B) = " + time);
                    if ((time < pr.towns[temp[1]].Day) || (pr.towns[temp[1]].Day == -999))
                    {
                        pr.towns[temp[1]].Day = time;
                        pr.AddQueue(pr.towns[temp[1]]);
                    } 
                }
                else
                {
                    Console.WriteLine("Karena S(A,B) < 1, maka virus tidak berhasil tersebar dari daerah " + temp[0] + " ke daerah  " + temp[1]);
                    pr.towns[temp[0]].Infected = false;
                }
                pr.queue.Dequeue();

                Console.Write("q = [ ");
                foreach (var item in pr.queue)
                {
                    Console.Write(item[0] + "->" + item[1] + " , ");
                }
                Console.WriteLine("] ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
