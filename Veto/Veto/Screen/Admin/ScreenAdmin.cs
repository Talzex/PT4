using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Veto
{
    public partial class ScreenAdmin : Veto.ScreenCommon
    {

        public ScreenAdmin() { InitializeComponent(); }

        public ScreenAdmin(Salarie user) : base(user)
        {
            InitializeComponent();
            //SidePNL.Visible = true;
        }
    }
}
