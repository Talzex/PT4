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
        }

        public UserList(Salarie user) : base(user)
        {
            InitializeComponent();
            LoadUsers();
        }

        /// <summary>
        /// Loads all the users into a UserDesign
        /// </summary>
        public void LoadUsers()
        {
            CenterPNL.Controls.Clear();
            var userList = Utils.GetEmployeeAll();
            foreach (Salarie s in userList)
            {
                CenterPNL.Controls.Add(new UserDesign(s, CenterPNL));
            }
        }

        /// <summary>
        /// Adds an employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBTN_Click(object sender, EventArgs e)
        {
            UserDesign design = new UserDesign(new Salarie(), CenterPNL);
            design.ShowModificatationForm();
        }
    }
}
