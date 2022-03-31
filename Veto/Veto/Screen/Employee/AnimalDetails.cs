using System;
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
    public partial class AnimalDetails : Form
    {

        private Animal animal;

        public AnimalDetails(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            if (animal.Nom != null)
            {
                UpdateItems();
            }
        }

        private void UpdateItems()
        {
            NameTB.Text = animal.Nom;
            RaceTB.Text = animal.NomRace;
            SpecieTB.Text = animal.NomEspece;
            HeightNUM.Value = (decimal)animal.Taille;
            WeightNUM.Value = (decimal)animal.Poids;
            BirthCAL.SelectionStart = (DateTime)animal.DateDeNaissance;
            DiseasesLB.Items.AddRange(animal.MaladieAnimal.ToArray());
        }

        private void AddDiseasesBTN_Click(object sender, EventArgs e)
        {
            DiseaseSelection f = new DiseaseSelection();
            f.ShowDialog();
            Maladie d = (Maladie)f.DiseasesLB.SelectedItem;
            // Création de l'animal maladie
            // Ajout à la listbox
        }

        private void RmDiseaseBTN_Click(object sender, EventArgs e)
        {
            MaladieAnimal disease = (MaladieAnimal)DiseasesLB.SelectedItem;
            animal.MaladieAnimal.Remove(disease);
            // Supprimer
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (NameTB.Text != "" && HeightNUM.Value != 0 &&
                WeightNUM.Value != 0 && BirthCAL.SelectionStart != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous allez tuer cet animal, êtes vous sûrs ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }
    }
}
