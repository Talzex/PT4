using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class UserDetails : Veto.UserBase
    {
        public UserDetails() { InitializeComponent(); }

        public UserDetails(Salarie user) : base(user)
        {
            InitializeComponent();
        }
    }
}
