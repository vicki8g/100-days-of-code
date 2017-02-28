using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giannakopoulos_Vicki
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            //10 X 12 twodimensional array
            int[,] twoDArray = new int[10, 12];
            int[] oneDArray = new int[120];


            FillTwoDimArray(twoDArray);
            DisplayTwoDimArray(twoDArray);
            StoreValues(twoDArray,oneDArray);
            DisplayOneDimArray(oneDArray);

        }

        //method to fill twoD array with random numbers a range between 1 and 100 (inclusive)
        static void FillTwoDimArray(int[,] twoDArray)
        {
            Random myRandom = new Random(); //Random class is under System namespace
            
            for (int row = 0; row < twoDArray.GetLength(0); row++) //each row
            {
                for (int col = 0; col < twoDArray.GetLength(1); col++) //each column
                {
                    twoDArray[row, col] = myRandom.Next(1, 101); //generate number between 1-100 inclusive

                }
            }

        }

        //display twoD arrays
        static void DisplayTwoDimArray(int[,] twoDArray)
        {
            Console.WriteLine("Display of 2D Array");
            for (int row = 0; row < twoDArray.GetLength(0); row++) //each row
            {
                for (int col = 0; col < twoDArray.GetLength(1); col++) //each column
                {
                    Console.Write(twoDArray[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
       
        //copy twoD array values into oneD array
        static void StoreValues(int[,] twoDArray, int[] oneDArray)
        {

            int tempValue = 0;
            for (int row = 0; row < twoDArray.GetLength(0); row++) //each row
            {
                

                for (int col = 0; col < twoDArray.GetLength(1); col++) //each column
                {
                    
                    oneDArray[tempValue] = twoDArray[row, col];
                    tempValue = tempValue+ 1;
                }
                
            }
        }

             //display oneD array
        static void DisplayOneDimArray(int[] oneDArray)
        {
            Console.WriteLine("Display 1D Array");
            for(int row =0; row < oneDArray.Length; row++)
            {
                Console.WriteLine(oneDArray[row]);
            }

        }
    }
}
