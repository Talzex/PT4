using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class ScreenCommon : Veto.ScreenBase
    {

        Entities db = new Entities();

        public ScreenCommon()
        {
            InitializeComponent();
        }

        private void EcranCommun_Load(object sender, EventArgs e)
        {

        }
    }
}
