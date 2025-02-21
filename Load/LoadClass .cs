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
            dlg.ShowDialog();
            using StreamReader sr = new StreamReader(dlg.FileName);
            string str = sr.ReadToEnd();
            sr.Close();
            return str;
        }
    }
}
