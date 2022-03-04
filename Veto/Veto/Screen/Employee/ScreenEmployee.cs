using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class ScreenEmployee : Veto.ScreenCommon
    {

        public ScreenEmployee() { InitializeComponent(); }


        public ScreenEmployee(Salarie user) : base(user)
        {
            InitializeComponent();
        }
    }
}
