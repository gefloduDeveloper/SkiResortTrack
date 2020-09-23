using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiResortTrack.Classes
{
    public class Result
    {
        public int lenght { get; set; }
        public int slope { get; set; }
        public string route { get; set; }

        public Result()
        {
            lenght = 0;
            slope = 0;
            route = String.Empty;
        }

        /// <summary>
        /// Compares the currente result with the given one
        /// </summary>
        /// <param name="temp">result to caompare with</param>
        /// <returns>returns if the temp result is better than the current one, first comparing the lenght, in case of a tie compares the steep</returns>
        public bool isBetter(Result temp)
        {
            bool isBetter = false;
            if (temp.lenght > this.lenght)
            {
                isBetter = true;
            }
            else
            {
                if (temp.lenght == this.lenght)
                {
                    if (temp.slope > this.slope)
                    {
                        isBetter = true;
                    }
                }
            }
            return isBetter;
        }

        /// <summary>
        /// returns the calculated slope based on the assigned route
        /// </summary>
        /// <returns>calculated slope</returns>
        public int getSlope()
        {
            int slope = 0;
            string[] edges = this.route.Split('-');
            if (edges.Length > 1)
            {
                slope = Convert.ToInt32(edges[0]) - Convert.ToInt32(edges[edges.Length - 1]);
            }
            return slope;
        }

        /// <summary>
        /// resturns the object info in a string
        /// </summary>
        /// <returns>result info in a string var</returns>
        public override string ToString()
        {
            return ("lenght: " + lenght + ", \nslope: " + slope + ", \nroute: " + route);
        }
    }
}
