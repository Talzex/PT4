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
        public UserList()
        {
            InitializeComponent();
            LoadUsers();
        }

        public UserList(Salarie user) : base(user)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads all the users into a UserDesign
        /// </summary>
        private void LoadUsers()
        {
            var userList = new List<Salarie>(); // Get all users
            userList.Add(new Salarie
            {
                Login = "Jean",
                Roles = new Roles
                {
                    Nom = "Facteur"
                }
            });
            userList.Add(new Salarie
            {
                Login = "Michel",
                Roles = new Roles
                {
                    Nom = "Médecin"
                }
            });
            foreach (Salarie s in userList)
            {
                CenterPNL.Controls.Add(new UserDesign(s));
            }
        }
    }
}
