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

        public override string ToString()
        {
            return ("lenght: " + lenght + ", \nslope: " + slope + ", \nroute: " + route);
        }
    }
}
