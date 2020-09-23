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
        string filename;
        Result result;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            result = new Result();
            if(string.IsNullOrEmpty(filename))
            {
                lblLog.Text = "Select a map file to start!.";
            }
            else
            {
                btnMapFileSelector.Enabled = false;
                btnStart.Enabled = false;
                txtResult.Clear();
                lblLog.Text = "Working...";
                try
                {
                    Map map = new Map(filename);
                    map.getBestRoute(map, ref result);
                    txtResult.Text = result.ToString();
                }
                catch(Exception ex)
                {
                    lblLog.Text = "Error!";
                    txtResult.Text = ex.Message;
                }
                btnStart.Enabled = true;
                btnMapFileSelector.Enabled = true;
            }
        }

        
        private void btnMapFileSelector_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
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
