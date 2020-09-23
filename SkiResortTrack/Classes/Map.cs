using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortTrack.Classes
{
    public class Map
    {
        public int[,] mapValues;
        public int width;
        public int height;
        
        public Map(string mapFilePath)
        {
            string[] tempValues;
            int w = 0, h = 0;
            //I use File.ReadAllLines buecause I know the file I'm working with has a maximum size of 1001 lines
            //that doesn't affect me in memory performance
            string[] fileContent = System.IO.File.ReadAllLines(mapFilePath);
            tempValues = fileContent[0].Split(' ');
            //I assume the first line contains 2 values (width and height) with that data I set the matrix size
            w = Convert.ToInt32(tempValues[0]);
            h = Convert.ToInt32(tempValues[1]);
            width = w;
            height = h;
            mapValues = new int[width,height];
            //Fill the matrix with the file data (already converted to int)
            for(int i = 1; i <= height; i++)
            {
                tempValues = fileContent[i].Split(' ');
                for (int j = 0; j < tempValues.Length; j++)
                {
                    //i counter has to substract 1 because the first row contains the sizes data
                    mapValues[i-1,j] = Convert.ToInt32(tempValues[j]);
                }
            }
        }

        public void getBestRoute(Map map, ref Result result)
        {
            for (int i = 0; i < map.height; i++)
            {
                for (int j = 0; j < map.width; j++)
                {
                    Result tempResult = new Result();
                    tempResult = getlongestRoute(map, i, j, tempResult);
                    if (result.isBetter(tempResult))
                    {
                        result = tempResult;
                    }
                }
            }
        }

        private Result getlongestRoute(Map map, int row, int column, Result result)
        {
            Result bestResult = new Result();
            Result currentResult = new Result();
            currentResult.lenght = result.lenght + 1;
            currentResult.route = result.route == "" ? map.mapValues[row, column].ToString() : result.route + "-" + map.mapValues[row, column].ToString();
            currentResult.slope = currentResult.getSlope();

            //update result in case there's no better options
            bestResult = currentResult;

            //we'll check the neighbors clockwise (up, right,down,left)
            //UP
            //If there's a minor number we set the route there
            if (row >= 1)
            {
                if (map.mapValues[row - 1, column] < map.mapValues[row, column])
                {
                    bestResult = getlongestRoute(map, row - 1, column, currentResult);
                }
            }
            //RIGHT
            //compare with the previous better
            if (column < map.width - 1)
            {
                if (map.mapValues[row, column + 1] < map.mapValues[row, column])
                {
                    Result tempResult = getlongestRoute(map, row, column + 1, currentResult);
                    if (bestResult.isBetter(tempResult))
                    {
                        bestResult = tempResult;
                    }
                }
            }
            //DOWN
            //compare with the previous better
            if (row < map.height - 1)
            {
                if (map.mapValues[row + 1, column] < map.mapValues[row, column])
                {

                    Result tempResult = getlongestRoute(map, row + 1, column, currentResult);
                    if (bestResult.isBetter(tempResult))
                    {
                        bestResult = tempResult;
                    }
                }
            }
            //LEFT
            //compare with the previous better
            if (column >= 1)
            {
                if (map.mapValues[row, column - 1] < map.mapValues[row, column])
                {

                    Result tempResult = getlongestRoute(map, row, column - 1, currentResult);
                    if (bestResult.isBetter(tempResult))
                    {
                        bestResult = tempResult;
                    }
                }
            }
            return bestResult;
        }

    }
}
