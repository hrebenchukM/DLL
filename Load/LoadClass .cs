using System.Text;
using System.Windows.Forms;
using ILoad;

namespace Load
{
    public class LoadClass: InterfaceLoad
    {
        public string LoadText()
        {
            using OpenFileDialog dlg = new();
            dlg.Filter = "RTF Files|*.rtf|All Files|*.*";
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RichTextBox rtb = new RichTextBox();
                rtb.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
                return rtb.Rtf;
            }
            return string.Empty;
        }
    }
}
