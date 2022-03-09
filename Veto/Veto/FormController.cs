using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public class FormController
    {

        private static readonly FormController formController = new FormController();

        private Form[] activeForms;


        private FormController() { }

        public static FormController GetController() { return formController; }

        public void CreateScreens(bool isAdmin, Salarie user)
        {
            if (isAdmin)
            {
                activeForms = new Form[] {
                    new UserList(user)
                };
            }
            else
            {
                activeForms = new Form[] {
                    new Calendar(user),
                    new Clients(user),
                    new Stock(user),
                    new Cart(user),
                    new Stats(user)
                };
            }
        }

        public void CloseAllForms()
        {
            foreach (Form f in activeForms)
            {
                f.Close();
            }
        }

    }
}
