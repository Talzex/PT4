﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public partial class ScreenBase : Form
    {
        public ScreenBase()
        {
            InitializeComponent();
            List<Client> clients = Utils.GetClientsAll();
            String s = "";
            foreach(Client c in clients)
            {
                label1.Text = s + c.NomClient;
            }
        }

        protected DialogResult ChangeScreen(ScreenBase other)
        {
            other.Location = this.Location;
            other.StartPosition = FormStartPosition.Manual;
            other.FormClosing += delegate { this.Show(); };
            this.Hide();
            return other.ShowDialog();

        }
    }
}
