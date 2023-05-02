namespace Dijkstra
{
    internal class Program
    {
        const int INF = 99999;
        static void Main(string[] args)
        {
            int[,] graph = new int[8, 8]
            {        
                // { 0 , 11, 4 , 31, 22, 32, 14, 26 },
                // { 11, 0 , 7 , 20, 11, 21, 3 , 15 },
                // { 4 , 7 , 0 , 27, 18, 28, 10, 22 },
                // { 31, 20, 27, 0 , 9 , 1 , 17, 5  },
                // { 22, 11, 18, 9 , 0 , 10, 8 , 4  },
                // { 32, 21, 28, 1 , 10, 0 , 18, 6  },
                // { 14, 3 , 10, 17, 8 , 10, 0 , 12 },
                // { 26, 15, 22, 5 , 4 , 6 , 12, 0  }
                { 0 ,  INF, 4  , INF, INF, INF, INF, INF },
                { INF, 0  , 7  , INF, INF, INF, 3  , INF },
                { 4 ,  7  , 0  , INF, INF, INF, INF, INF },
                { INF, INF, INF, 0  , INF, 1  , INF, 5   },
                { INF, INF, INF, INF, 0  , INF, 8  , 4   },
                { INF, INF, INF, 1  , INF, 0  , INF, INF },
                { INF, 3  , INF, INF, 8  , INF, 0  , INF },
                { INF, INF, INF, 5  , 4  , INF, INF, 0   }
                // { 0 ,  INF, 2  , INF, INF, INF, INF, INF },
                // { INF, 0  , 2  , INF, INF, INF, 6  , INF },
                // { 0 ,  1  , 0  , INF, INF, INF, INF, INF },
                // { INF, INF, INF, 0  , INF, 5  , INF, 7   },
                // { INF, INF, INF, INF, 0  , INF, 6  , 7   },
                // { INF, INF, INF, 3  , INF, 0  , INF, INF },
                // { INF, 1  , INF, INF, 4  , INF, 0  , INF },
                // { INF, INF, INF, 3  , 4  , INF, INF, 0   }
            };



            int[] distance;
            int[] path;
            Dijkstra.ShortestPath(in graph, 0, out distance, out path);
            Console.WriteLine("<Dijkstra>");
            PrintResult(distance, path);
        }

        private static void PrintResult(int[] distance, int[] path)
        {
            Console.Write("Vertex");
            Console.Write("\t");
            Console.Write("dist");
            Console.Write("\t");
            Console.WriteLine("path");

            for (int i = 0; i < distance.Length; i++)
            {
                Console.Write(i);
                Console.Write("\t");
                if (distance[i] >= INF)
                    Console.Write("INF");
                else
                    Console.Write("{0:D3}", distance[i]);
                Console.Write("\t");
                Console.WriteLine(path[i]);
            }
        }
    }
}
