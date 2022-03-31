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
        private Client owner;
        private bool create;

        public AnimalDetails(Animal animal, Client owner = null)
        {
            InitializeComponent();
            this.animal = animal;
            this.owner = owner;
            if (animal.Nom != null)
            {
                create = false;
                UpdateItems();
            }
            else
            {
                animal = new Animal();
                create = true;
                AddDiseasesBTN.Enabled = false;
            }
        }

        /// <summary>
        /// Method to update animal's informations
        /// </summary>
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

        /// <summary>
        /// Method to add a disease to the animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDiseasesBTN_Click(object sender, EventArgs e)
        {
            DiseaseSelection f = new DiseaseSelection();
            f.ShowDialog();
            Maladie d = (Maladie)f.DiseasesLB.SelectedItem;
            MaladieAnimal da = Utils.AddDiseaseAnimal(d, animal);
            DiseasesLB.Items.Add(da);
        }

        /// <summary>
        /// Method to remove a disease to the animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RmDiseaseBTN_Click(object sender, EventArgs e)
        {
            MaladieAnimal disease = (MaladieAnimal)DiseasesLB.SelectedItem;
            animal.MaladieAnimal.Remove(disease);
            DiseasesLB.Items.Remove(disease);
            Utils.RemoveDiseaseAnimal(disease);
        }

        /// <summary>
        /// Method to save the animal's details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (NameTB.Text != "" && HeightNUM.Value != 0 &&
                WeightNUM.Value != 0 && BirthCAL.SelectionStart != null)
            {

                if (create)
                {
                    animal.Nom = NameTB.Text;
                    animal.NomRace = RaceTB.Text;
                    animal.NomEspece = SpecieTB.Text;
                    animal.DateDeNaissance = BirthCAL.SelectionStart;
                    animal.Poids = (int?)WeightNUM.Value;
                    animal.Taille = (int?)HeightNUM.Value;
                    animal.IdClient = owner.IdClient;
                    Utils.SaveAnimal(animal);
                }
                else
                {
                    Utils.ModifyAnimal(animal, NameTB.Text, SpecieTB.Text, RaceTB.Text, (int)HeightNUM.Value, (int)WeightNUM.Value, BirthCAL.SelectionStart);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Method to remove an animal from the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vous allez tuer cet animal, êtes vous sûrs ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Utils.RemoveAnimal(animal);
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        /// <summary>
        /// Method to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }
    }
}
