using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veto
{
    public partial class UserBase : Veto.ScreenAdmin
    {
        public UserBase(Salarie user) : base(user)
        {
            InitializeComponent();
        }
    }
}
