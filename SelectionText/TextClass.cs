using ISelectionText;

namespace SelectionText
{
    public class TextClass : InterfaceText 
    {
        public Font SelectText()
        {
      
            using FontDialog dlg = new();
            dlg.ShowDialog();
            return dlg.Font;

        }
    }
}
