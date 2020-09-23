using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortTrack.Classes
{
    class Map
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
    }
}
