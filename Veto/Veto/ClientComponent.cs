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
    public partial class ClientComponent : UserControl
    {
        private Client client;

        public ClientComponent(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            //TODO afficher ClientsDetails
        }
    }
}