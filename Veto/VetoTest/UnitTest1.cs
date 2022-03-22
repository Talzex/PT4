using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Veto;
using static Veto.Utils;

namespace VetoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChargerEntities();
            Dictionary<string, string> expectedNameWithPassword = new Dictionary<string, string>();
            expectedNameWithPassword.Add("Paul65", "azerty");
            expectedNameWithPassword.Add("germainK", "1234");
            expectedNameWithPassword.Add("vero44", "password");
            expectedNameWithPassword.Add("XxmariexX", "framboise");

            List<Client> clients = GetClientsAll();
            foreach (KeyValuePair<string, string> str in expectedNameWithPassword)
            {
                Assert.IsTrue(clients.Contains(clients.Find(c => c.NomClient == str.Key)));
            }
        }
    }
}
