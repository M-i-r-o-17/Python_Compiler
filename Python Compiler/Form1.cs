using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Python_Compiler
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
            Start();
        }

        private bool HavePycompiler = false;
        private bool AddIconBox = false;
        private bool EnableConsoleBox = false;
        private bool CreateOneFileBox = true;

        private string[,] LanguageApp =
            {
                {
                    "English",
                    "Notifications",
                    "To correct work you need \"pyinstaller\"",
                    "Other settings",
                    "Add icon",
                    "Open",
                    "Enable console",
                    "Compill in one file",
                    "Compiler",
                    "Open file",
                    "Compile",
                    "Language",
                    "Change",
                    "Save"
                },
                {
                    "Русский",
                    "Увидомления",
                    "Для правельной работы нужен \"pyinstaller\"",
                    "Прочие настройки",
                    "Добавить иконку",
                    "Открыть",
                    "Включить консоль",
                    "Скомпилировать в один фаил",
                    "Компилятор",
                    "Открыть фаил",
                    "Скомпилировать",
                    "Язык",
                    "Сменить",
                    "Сохранить"
                }
            };

        private string[] Paths = { "", "" };
        private bool StringToBool(string value)
        {
            value = value.ToLower();
            if (value == "true")
                return true;
            else
                return false;
        }
       
        private void DefaultSettings()
        {
            Language.SelectedIndex = 0;
            ChangeLanguageApp();

            AddIconBox = false;
            EnableConsoleBox = false;
            CreateOneFileBox = false;
        }
        
        private void ChangeLanguageApp(int IdLanguage = 0)
        {

            /*Настройка увидомлений*/
            NotificationsGroup.Text = LanguageApp[IdLanguage, 1];
            Status.Text = LanguageApp[IdLanguage, 2];
            /*Прочие настройки*/
            OtherSettings.Text = LanguageApp[IdLanguage, 3];
            AddIcon.Text = LanguageApp[IdLanguage, 4];
            LoadIcan.Text = LanguageApp[IdLanguage, 5];
            OnOffConsole.Text = LanguageApp[IdLanguage, 6];
            CompileOneFile.Text = LanguageApp[IdLanguage, 7];

            /*Компилятор*/
            Compiler.Text = LanguageApp[IdLanguage, 8];
            OpenFile.Text = LanguageApp[IdLanguage, 9];
            CompileFile.Text = LanguageApp[IdLanguage, 10];

            /*Язык*/
            LanguagePanel.Text = LanguageApp[IdLanguage, 11];
            ChangeLanguage.Text = LanguageApp[IdLanguage, 12];
            SaveSettings.Text = LanguageApp[IdLanguage, 13];
        }
        private void ChangeVariabels(string name, string value)
        {
            switch (name)
            {
                case "Language":
                    Language.SelectedIndex = int.Parse(value);
                    ChangeLanguageApp(int.Parse(value));
                    break;
                case "Add Icon":
                    AddIconBox = AddIcon.Checked = StringToBool(value);
                    break;
                case "Enabel console":
                    EnableConsoleBox = OnOffConsole.Checked = StringToBool(value);
                    break;
                case "Compile one file":
                    CreateOneFileBox = CompileOneFile.Checked = StringToBool(value);
                    break;

            }

        }
        
        private void SaveSettingsApp()
        {
            using (StreamWriter sw = new StreamWriter("Settings.cfg", false, System.Text.Encoding.Default))
            {
                sw.WriteLine($"Language:{Language.SelectedIndex}");
                sw.WriteLine($"Add Icon:{AddIconBox}");
                sw.WriteLine($"Enabel console:{EnableConsoleBox}");
                sw.Write($"Compile one file:{CreateOneFileBox}");
            }
        }
        private bool LoadSettingsApp()
        {
            if (File.Exists("Settings.cfg"))
            {
                using(StreamReader sr = new StreamReader("Settings.cfg"))
                {

                    string LineSettings = "";
                    while((LineSettings = sr.ReadLine()) != null)
                    {
                        string[] command = LineSettings.Split(':');
                        ChangeVariabels(command[0], command[1]);
                    }
                }
                return true;
            }
            else
                return false;
        }
        

        private void Start()
        {
            for(byte i = 0; i < LanguageApp.GetLength(0); i++)
            {
                Language.Items.Add(LanguageApp[i, 0]);
            }
            if (LoadSettingsApp() == false) { DefaultSettings(); SaveSettingsApp(); };
        }

        /*Нажатия кнопок*/
        private void ChangeLanguage_Click(object sender, EventArgs e)
        {
            int id = Language.SelectedIndex;
            ChangeLanguageApp(id);
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettingsApp();
        }

        private void AddIcon_CheckedChanged(object sender, EventArgs e)
        {
            AddIconBox = !AddIconBox;
            LoadIcan.Enabled = AddIconBox;
        }

        private void OnOffConsole_CheckedChanged(object sender, EventArgs e)
        {
            EnableConsoleBox = !EnableConsoleBox;
        }

        private void CompileOneFile_CheckedChanged(object sender, EventArgs e)
        {
            CreateOneFileBox = !CreateOneFileBox;
        }

        private void LoadIcan_Click(object sender, EventArgs e)
        {
            OpenIcon.Filter = "Image Files(*.BMP;*.JPG;*PNG)|*.BMP;*.JPG;*PNG";
            OpenIcon.FileName = String.Empty;
            OpenIcon.ShowDialog();
            Paths[1] = OpenIcon.FileName;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenScript.Filter = "Python file|*.py";
            OpenScript.FileName = String.Empty;
            OpenScript.ShowDialog();
            Paths[0] = OpenScript.FileName;
            PathToFile.Text = Paths[0];
        }

        private void CompileFile_Click(object sender, EventArgs e)
        {
            string command = "pyinstaller ";
            if (!EnableConsoleBox)
                command += "-w ";
            if (CreateOneFileBox)
                command += "-F ";
            if (AddIconBox && Paths[1] != "")
                command += $"-i \"{Paths[1]}\"";
            command += Paths[0];
            if (Paths[0] != "")
            {
                System.Diagnostics.Process.Start("CMD.exe", "/C " + command);
                System.Diagnostics.Process.Start("CMD.exe", "/C explorer dist");
            }
        }
    }
}
