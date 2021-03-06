﻿using System.IO;
using Lextm.MSBuildLaunchPad.Configuration;
using NUnit.Framework;

namespace Lextm.MSBuildLaunchPad.UnitTests
{
    [TestFixture]
    public class SolutionParserTest
    {
        [Test]
        public void TestVs2005Sln()
        {
            byte[] bytes = Properties.Resources.MSBuildShellExtension;
            string tempFileName = Path.GetTempFileName();
            File.WriteAllBytes(tempFileName, bytes);
            var parser = new SolutionParser(tempFileName);
            Assert.AreEqual(Tool.Tool20Version, parser.Version);
        }

        [Test]
        public void TestVs2008Sln()
        {
            byte[] bytes = Properties.Resources.Lextm_CBC2_Full;
            string tempFileName = Path.GetTempFileName();
            File.WriteAllBytes(tempFileName, bytes);
            var parser = new SolutionParser(tempFileName);
            Assert.AreEqual(Tool.Tool35Version, parser.Version);
        }

        [Test]
        public void TestVs2010Sln()
        {
            byte[] bytes = Properties.Resources.SharpSnmpLib1;
            string tempFileName = Path.GetTempFileName();
            File.WriteAllBytes(tempFileName, bytes);
            var parser = new SolutionParser(tempFileName);
            Assert.AreEqual(Tool.Tool40Version, parser.Version);
        }

        [Test]
        public void TestVs11Sln()
        {
            var bytes = Properties.Resources.MSBuildLaunchPad;
            var tempFileName = Path.GetTempFileName();
            File.WriteAllBytes(tempFileName, bytes);
            var parser = new SolutionParser(tempFileName);
            Assert.AreEqual(Tool.Tool40Version, parser.Version);
        }

        [Test]
        public void TestVs12Sln()
        {
            var bytes = Properties.Resources.Obfuscar;
            var tempFileName = Path.GetTempFileName();
            File.WriteAllBytes(tempFileName, bytes);
            var parser = new SolutionParser(tempFileName);
            Assert.AreEqual(Tool.Tool120Version, parser.Version);
        }

        [Test]
        public void TestVs14Sln()
        {
            var bytes = Properties.Resources.VS2015;
            var tempFileName = Path.GetTempFileName();
            File.WriteAllBytes(tempFileName, bytes);
            var parser = new SolutionParser(tempFileName);
            Assert.AreEqual(Tool.Tool140Version, parser.Version);
        }
    }
}
