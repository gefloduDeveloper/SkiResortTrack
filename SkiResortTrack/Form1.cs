using SkiResortTrack.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiResortTrack
{
    public partial class Form1 : Form
    {
        string curretFilePath = @"C:\Users\Serv\source\repos\SkiResortTrack\SkiResortTrack\Resources";
        string filename;
        Result result;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            result = new Result();
            lblTaskDescription.Text = "Reading map File.";
            Map map = new Map(filename);
            lblTaskDescription.Text = "Checking routes.";
            getBestRoute(map, ref result);
            lblTaskDescription.Text = "Best track found!.";
            txtResult.Text = result.ToString();
        }

        private void getBestRoute(Map map, ref Result result)
        {
            Result tempResult = new Result();
            for (int i = 0; i < map.height; i++)
            {
                for(int j = 0; j < map.width; j++)
                {
                    tempResult = getlongestRoute(map, i, j, tempResult);
                    if(tempResult.isBetter(result))
                    {
                        result = tempResult;
                    }
                }
            }
        }

        private Result getlongestRoute(Map map, int i, int j,Result temp)
        {
            Result newResult = new Result();
            newResult.lenght = temp.lenght + 1;
            newResult.route = temp.route=="" ? map.mapValues[i,j].ToString():newResult.route = temp.route + "-" + map.mapValues[i, j].ToString();
            newResult.slope = newResult.getSlope();
            //we'll check the neighbors clockwise (up, right,down,left)
            //UP
            //if(i > 1)
            //{
            //    if (map.mapValues[i - 1, j] < map.mapValues[i, j])
            //    {
            //        newResult = getlongestRoute(map, i - 1, j, newResult);
            //    }
            //}

            return newResult;
        }

        private void btnMapFileSelector_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = curretFilePath;
            file.DefaultExt = ".txt";
            file.Filter = "Text documents (.txt)|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                filename = file.FileName;
            }
            lblMapFile.Text = System.IO.Path.GetFileName(filename);
        }
    }
}
