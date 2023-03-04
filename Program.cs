using System;

namespace gbhw7
{
    class Program
    {
        // 1, 2, 3...
        // static int ReadInt(string prompt){
        //     System.Console.Write(prompt);
        //     return Convert.ToInt32(Console.ReadLine());
        // }

        // 1...
        // static double[,] FillDoubleArray(int rows, int cols){
        //     double[,] array = new double[rows, cols];
        //     Random rand = new Random();
        //     for(int i = 0; i < rows; i++){
        //         for(int j = 0; j < cols; j++){
        //             array[i, j] = rand.Next(-100, 101)/10.0;
        //         }
        //     }
        //     return array;
        // }

        // static void WriteDoubleArray(double[,] array){
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             Console.Write(array[i, j]+"\t");
        //         }
        //         Console.WriteLine();
        //     }
        // }
        
        // 2, 3...
        // static int[,] FillIntArray(int rows, int cols){
        //     int[,] array = new int[rows, cols];
        //     Random rand = new Random();
        //     for(int i = 0; i < rows; i++){
        //         for(int j = 0; j < cols; j++){
        //             array[i, j] = rand.Next(-10, 11);
        //         }
        //     }
        //     return array;
        // }

        // static void WriteIntArray(int[,] array){
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         for (int j = 0; j < array.GetLength(1); j++)
        //         {
        //             Console.Write(array[i, j]+"\t");
        //         }
        //         Console.WriteLine();
        //     }
        // }

        // 2... 
        // static void ElementAtIndex(int[,] array, int row, int col){
        //     if (row >= array.GetLength(0) || col >= array.GetLength(1)){
        //         Console.WriteLine("Element does not exist.");
        //     } else {
        //         Console.WriteLine(array[row, col]);
        //     }
        // }

        // 3...
        // static int[] ColumnOfIntArray(int[,] array, int column){
        //     int[] result = new int[array.GetLength(0)];
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         result[i] = array[i, column];
        //     }
        //     return result;
        // }

        // static double ArithmeticMeanOfIntArray(int[] array){
        //     double summa = 0;
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         summa += array[i];
        //     }
        //     return summa/array.Length;
        // }

        static void Main(string[] args)
        {
            // 1...
            // WriteDoubleArray(FillDoubleArray(ReadInt("Enter number of rows: "), ReadInt("Enter number of cols: ")));

            // 2..
            // int[,] matrix = FillIntArray(ReadInt("Enter number of rows: "), ReadInt("Enter number of cols: "));
            // WriteIntArray(matrix);
            // ElementAtIndex(matrix, ReadInt("Enter i: "), ReadInt("Enter j: "));

            // 3...
            // int[,] matrix2 = FillIntArray(ReadInt("Enter number of rows: "), ReadInt("Enter number of cols: "));
            // WriteIntArray(matrix2);
            // for (int j = 0; j < matrix2.GetLength(1); j++)
            // {
            //     Console.WriteLine(ArithmeticMeanOfIntArray(ColumnOfIntArray(matrix2, j)));
            // }
        }
    }
}
