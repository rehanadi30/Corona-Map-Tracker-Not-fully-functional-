using System;
using System.Collections.Generic;
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
            day = 0;
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
                    towns[split[0]].AddEdge(split[1], Convert.ToDouble(split[2]));
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

        public void QueueInit()
        {
            string[] temp;
            queue.Clear();
            Vertex startVertex = towns[start];
            foreach (Edge edge in startVertex.edges)
            {
                temp = new string[2];
                temp[0] = start;
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
            towns[start].Infected = true;
        }
        /*
         Jumlah masyarakat yang terkena virus = P(A) / (1 + (P(A) - 1)e^(-0.25T(A)))
         = t(A) * P(A) / 20
             */
        public double CountInfected()
        {
            return 0;
        }

        //Jika S(A,B) = I(A,t).Tr(A,B) > 1, return true
        public bool Spread()
        {
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BFS pr = new BFS();
            pr.QueueInit();
            foreach (var item in pr.towns)
            {
                Console.WriteLine(item.Key + " " + item.Value.Population);
                foreach (var i in item.Value.edges)
                {
                    Console.WriteLine("\t" + i.ToTown + " " + i.Probability);
                }
            }
            foreach (var item in pr.queue)
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }


            Console.ReadLine();
        }
    }
}