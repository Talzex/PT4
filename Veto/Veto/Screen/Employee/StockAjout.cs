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
    public partial class StockAjout : Form
    {
        public StockAjout()
        {
            InitializeComponent();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddimageBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Title = "Sélectionner une image";
            OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = new Bitmap(OpenFileDialog.FileName);
            }
            
        }
    }
}
