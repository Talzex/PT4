using NUnit.Framework;
using Veto;
using System;
using System.Collections.Generic;

namespace TU
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Dictionary<string, string> expectedNameWithPassword = new Dictionary<string, string>();
            expectedNameWithPassword.Add("Paul65", "azerty");
            expectedNameWithPassword.Add("germainK", "1234");
            expectedNameWithPassword.Add("vero44", "password");
            expectedNameWithPassword.Add("XxmariexX", "framboise");

            Utils.LoadEntities();
            

        }
    }
}