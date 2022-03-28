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
    public partial class AnimalComponent : UserControl
    {
        private Animal animal;

        public AnimalComponent(Animal a)
        {
            InitializeComponent();
            animal = a;
            UpdateLabels();
        }

        private void DetailsBTN_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Updates the labels
        /// </summary>
        private void UpdateLabels()
        {
            NameLabel.Text = animal.Nom;
            AgeLBL.Text = "Age : " + (DateTime.Now - animal.DateDeNaissance).ToString();
        }
    }
}
