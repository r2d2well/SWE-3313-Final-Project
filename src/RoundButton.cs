using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace SWE_3313_Project
{
    //Class Created to Allow Me to Create a Circular Button
    public class RoundButton : Button
    {
        //Inhearts From the Button Class
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
            //Overrides the OnPaint Method from Button Class to Draw in a shape of a circle instead of a square
        }
    }

}