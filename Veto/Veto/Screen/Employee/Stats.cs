using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class Stats : Veto.ScreenEmployee
    {

        public Stats() { InitializeComponent(); }

        public Stats(Salarie user) : base(user)
        {
            InitializeComponent();
        }
    }
}
