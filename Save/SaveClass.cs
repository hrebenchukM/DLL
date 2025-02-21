using ISave;

namespace Save
{
    public class SaveClass : InterfaceSave
    {
        public void SaveText(string s)
        {
            using SaveFileDialog dlg = new();
            dlg.ShowDialog();
            using StreamWriter sw = new StreamWriter(dlg.FileName);
            sw.Write(s);
            sw.Close();
            
        }
    }
}
