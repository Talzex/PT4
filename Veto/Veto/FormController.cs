using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    public sealed class FormController
    {

        private static readonly FormController formController = new FormController();

        private Form[] activeForms;


        private FormController() { }

        public static FormController GetController() { return formController; }

        public static void CreateScreens(bool isAdmin, Salarie user)
        {
            CloseAllForms();
            if (isAdmin)
            {
                formController.activeForms = new Form[] {
                    new UserList(user)
                };
            }
            else
            {
                formController.activeForms = new Form[] {
                    new Calendar(user),
                    new Clients(user),
                    new Stock(user),
                    new Cart(user),
                    new Stats(user)
                };
            }
        }

        public static void CloseAllForms()
        {
            if (formController.activeForms != null)
            {
                foreach (Form f in formController.activeForms)
                {
                    f.Close();
                }
            }
        }

        public Form GetForm(int i)
        {
            return activeForms[i];
        }

    }
}
