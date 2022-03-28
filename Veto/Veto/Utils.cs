using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    /// <summary>
    /// Class with all the queries of the project
    /// </summary>
    public static partial class Utils
    {
        private static Entities entities;

        /// <summary>
        /// Initialize the instance of the BD's entity
        /// </summary>
        public static void LoadEntities()
        {
            entities = new Entities();
        }

    }
}