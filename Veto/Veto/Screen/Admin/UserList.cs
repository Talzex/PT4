using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class UserList : Veto.ScreenAdmin
    {
        public UserList() { InitializeComponent(); }

        public UserList(Salarie user) : base(user)
        {
            InitializeComponent();
        }
    }
}
