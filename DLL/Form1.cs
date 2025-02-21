using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

using ILoad;
using ISave;

using ISelectionColor;

using ISelectionText;


namespace DLL
{
    public partial class Form1 : Form
    {

        static Assembly loadAsml; //Сборка load
        static Type loadType;// Тип load
        static object loadInstance; // Экземпляр load для ощущения разницы
        static InterfaceLoad load_object;


        static Assembly saveAsml;
        static Type saveType;
        static InterfaceSave save_object;


        static Assembly textAsml;
        static Type textType;
        static InterfaceText text_object;


        static Assembly colorAsml;
        static Type colorType;
        static InterfaceColor color_object;


        public Form1()
        {


            loadAsml = Assembly.LoadFrom("Load.dll");

            // Получаем тип из сборки
            loadType = loadAsml.GetType("Load.LoadClass");

            // Создаем экземпляр группы для ощущения разницы
            //loadInstance = Activator.CreateInstance(loadType);

            load_object = (ILoad.InterfaceLoad)Activator.CreateInstance(loadType);




            saveAsml = Assembly.LoadFrom("Save.dll");
            saveType = saveAsml.GetType("Save.SaveClass");
            save_object = (InterfaceSave)Activator.CreateInstance(saveType);


            colorAsml = Assembly.LoadFrom("SelectionColor.dll");
            colorType = colorAsml.GetType("SelectionColor.ColorClass");
            color_object = (InterfaceColor)Activator.CreateInstance(colorType);

            textAsml = Assembly.LoadFrom("SelectionText.dll");
            textType = textAsml.GetType("SelectionText.TextClass");
            text_object = (InterfaceText)Activator.CreateInstance(textType);



            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string text = (string)loadType.GetMethod("LoadText").Invoke(loadInstance, null);//вот и разница
            string text = load_object.LoadText();
            richTextBox1.Text = text;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            save_object.SaveText(text);
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color color = color_object.SelectColor();
            richTextBox1.SelectionColor = color;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = text_object.SelectText();
            richTextBox1.SelectionFont = font;
        }
    }
}
