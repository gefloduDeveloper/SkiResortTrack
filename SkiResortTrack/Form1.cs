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
            map.getBestRoute(map, ref result);
            lblTaskDescription.Text = "Best track found!.";
            txtResult.Text = result.ToString();
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
