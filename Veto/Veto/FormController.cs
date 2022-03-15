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

        private Form[] allForms;
        private Form activeForm;


        private FormController() { activeForm = Program.mainScreen; }

        public static FormController GetController() { return formController; }

        /// <summary>
        /// Create all the screens that the given user can access
        /// </summary>
        /// <param name="isAdmin">If the user is an admin</param>
        /// <param name="user">The user that is connected</param>
        public static void CreateScreens(bool isAdmin, Salarie user)
        {
            CloseAllForms();
            if (isAdmin)
            {
                formController.allForms = new Form[] {
                    new UserList(user)
                };
            }
            else
            {
                formController.allForms = new Form[] {
                    new Calendar(user),
                    new Clients(user),
                    new Stock(user),
                    new Cart(user),
                    new Stats(user)
                };
            }
            formController.ActivateForm(0);
        }

        /// <summary>
        /// Closes all the forms that where created
        /// </summary>
        public static void CloseAllForms()
        {
            if (formController.allForms != null)
            {
                formController.activeForm = Program.mainScreen;
                foreach (Form f in formController.allForms)
                {
                    f.DialogResult = DialogResult.OK;
                    f.Close();
                }
            }
        }

        /// <summary>
        /// Displays the form
        /// </summary>
        /// <param name="i">The index of the form to show</param>
        public void ActivateForm(int i)
        {
            if (i >= 0 && i < allForms.Length)
            {
                Form other = allForms[i];
                if (activeForm == null || other != activeForm)
                {
                    other.Location = activeForm.Location;
                    other.StartPosition = FormStartPosition.Manual;
                    activeForm.Hide();
                    other.Show();
                    activeForm = other;
                }
            }
        }

        /// <summary>
        /// Closes the app
        /// </summary>
        public static void ScreenClosed(DialogResult result)
        {
            if (result != DialogResult.OK)
                Program.mainScreen.Close();
        }

        /// <summary>
        /// Disconnect the user
        /// </summary>
        public static void Disconnect()
        {
            Program.mainScreen.Location = formController.activeForm.Location;
            Program.mainScreen.StartPosition = FormStartPosition.Manual;
            formController.activeForm.Hide();
            Program.mainScreen.Show();
            CloseAllForms();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="nb"></param>
        public static void AddItemToCart(Produit p, int nb)
        {
            Cart cart = (Cart)formController.allForms[3];
            cart.AddProduct(p, nb);
        }

    }
}
