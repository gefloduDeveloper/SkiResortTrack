using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkiResortTrack.Classes;

namespace UnitTestSkiTrack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MapBuildWidth()
        {
            Map map = new Map(@"C:\Users\Serv\source\repos\SkiResortTrack\SkiResortTrack\Resources\4x4.txt");
            Assert.IsTrue(map.width == 4);
        }

        [TestMethod]
        public void MapBuildHeight()
        {
            Map map = new Map(@"C:\Users\Serv\source\repos\SkiResortTrack\SkiResortTrack\Resources\4x4.txt");
            Assert.IsTrue(map.height == 4);
        }

        [TestMethod]
        public void MapBuildValues()
        {
            Map map = new Map(@"C:\Users\Serv\source\repos\SkiResortTrack\SkiResortTrack\Resources\4x4.txt");
            Assert.IsTrue(map.mapValues[0,1] == 8 && map.mapValues[3,3] == 6);
        }

        [TestMethod]
        public void MapGetTrack()
        {
            Map map = new Map(@"C:\Users\Serv\source\repos\SkiResortTrack\SkiResortTrack\Resources\4x4.txt");
            Result result = new Result();
            map.getBestRoute(map,ref result);
            Assert.IsTrue(result.lenght == 5 && result.slope == 8 && result.route == "9-5-3-2-1");
        }

    }
}
