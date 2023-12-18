namespace Final_Exam_Q3
{
    //Program defines an adjacency list and adjacency graph for given digraph
    internal class Program
    {
        //Represents the eight colors in the diagram
        public enum Color
        {
            Red,
            Navy,
            Gray,
            Blue,
            Yellow,
            Orange,
            Purple,
            Green
        }
        //Adjacency matrix
        static int[,] mGraph = new int[,]
        {
            //        Red   Navy   gray  blue  yellow  orange  purp  green
            /*Red*/ {-1, 1, 5, -1, -1, -1, -1, -1},
            /*Navy*/{-1, -1, -1, 1, 8, -1, -1, -1},
            /*Gray*/{-1, -1, -1, 0, -1, 1, -1, -1},
            /*blue*/{-1, 1, 0, -1, -1, -1, -1, -1},
            /*yellow*/{-1, -1, -1, -1, -1, -1, -1, 6 },
            /*orang*/{-1, -1, -1, -1, -1, -1, 1, -1 },
            /*purp*/{-1, -1, -1, -1, 1, -1, -1, -1 },
            /*green*/{-1, -1, -1, -1, -1, -1, -1, -1 }
        };

        //Adjacency list graph
        static int[][] lGraph = new int[][]
        {
            /*Red*/ new int[]{ (int)Color.Navy, (int)Color.Gray},
            /*Navy*/ new int[]{ (int)Color.Blue, (int)Color.Yellow},
            /*Gray*/ new int[]{ (int)Color.Blue, (int)Color.Orange},
            /*blue*/ new int[]{ (int)Color.Navy, (int)Color.Gray},
            /*yellow*/ new int[]{ (int)Color.Green},
            /*orang*/ new int[]{ (int)Color.Purple},
            /*purp*/ new int[]{ (int)Color.Yellow},
            /*green*/ null
        };
        //Parallel graph for lGraph with Adjacency list weights
        static int[][] wGraph = new int[][]
        {
            /*Red*/ new int[]{1,5},
            /*Navy*/ new int[]{1,8},
            /*Gray*/ new int[]{0,1},
            /*blue*/ new int[]{1,0},
            /*yellow*/ new int[]{6},
            /*orang*/ new int[]{1},
            /*purp*/ new int[]{1},
            /*green*/ null
        };


    }
}