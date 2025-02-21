
using System.Windows.Forms;
using ISelectionColor;

namespace SelectionColor
{
    public class ColorClass : InterfaceColor
    {
        public Color SelectColor()
        {
         
            using ColorDialog dlg = new();
            dlg.ShowDialog();
            return dlg.Color;

        }
    }
}
