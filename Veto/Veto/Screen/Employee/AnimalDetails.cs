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
        private List<MaladieAnimal> diseases;

        public AnimalDetails(Animal animal)
        {
            InitializeComponent();
            this.animal = animal;
            diseases = new List<MaladieAnimal>();
            if (animal.Nom != null)
            {
                foreach (MaladieAnimal a in animal.MaladieAnimal)
                {
                    diseases.Add(a);
                }
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
            DiseasesLB.Items.AddRange(diseases.ToArray());
        }

        private void AddDiseasesBTN_Click(object sender, EventArgs e)
        {

        }

        private void RmDiseaseBTN_Click(object sender, EventArgs e)
        {
            MaladieAnimal disease = (MaladieAnimal)DiseasesLB.SelectedItem;
            diseases.Remove(disease);
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

        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
