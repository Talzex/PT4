using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Veto
{
    public partial class ScreenConection : Veto.ScreenBase
    {
        public static Entities bd = new Entities();
        private String login;
        private String password;

        public ScreenConection()
        {
            InitializeComponent();
        }

        
    }
}
