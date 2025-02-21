using ISave;

namespace Save
{
    public class SaveClass : InterfaceSave
    {
        public void SaveText(string s)
        {
            using SaveFileDialog dlg = new();
            dlg.Filter = "RTF Files|*.rtf|All Files|*.*"; 

            if (dlg.ShowDialog() == DialogResult.OK)
            {
              
                RichTextBox rtb = new RichTextBox();
                rtb.Rtf = s;

                
                rtb.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText);
            }
        }
    }
}
