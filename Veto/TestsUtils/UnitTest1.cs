using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using Veto;

namespace TestsUtils
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetClientAll()
        {
            Utils.LoadEntities();

            Dictionary<string, string> expectedNameWithPassword = new Dictionary<string, string>();
            expectedNameWithPassword.Add("Paul65", "azerty");
            expectedNameWithPassword.Add("germainK", "1234");
            expectedNameWithPassword.Add("vero44", "password");
            expectedNameWithPassword.Add("XxmariexX", "framboise");

            List<Client> clients = Utils.GetClientsAll();
            foreach (KeyValuePair<string, string> str in expectedNameWithPassword)
            {
                Assert.IsTrue(clients.Contains(clients.Find(c => c.NomClient == str.Key)));
            }
        }
    }
}
