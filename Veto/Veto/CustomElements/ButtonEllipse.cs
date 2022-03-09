using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veto
{
    internal class ButtonEllipse : Button
    {
        /// <summary>
        /// Method to create a round button.
        /// </summary>
        /// <param name="pevent"></param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region =  new System.Drawing.Region(graphics);
            base.OnPaint(pevent);
        }
    }
}
