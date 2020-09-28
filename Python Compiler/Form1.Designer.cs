namespace Python_Compiler
{
    partial class RootForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));
            this.NotificationsGroup = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.Label();
            this.MainGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.OtherSettings = new System.Windows.Forms.GroupBox();
            this.CompileOneFile = new System.Windows.Forms.CheckBox();
            this.OnOffConsole = new System.Windows.Forms.CheckBox();
            this.LoadIcan = new System.Windows.Forms.Button();
            this.AddIcon = new System.Windows.Forms.CheckBox();
            this.Compiler = new System.Windows.Forms.GroupBox();
            this.CompileFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.PathToFile = new System.Windows.Forms.TextBox();
            this.LanguagePanel = new System.Windows.Forms.GroupBox();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.Language = new System.Windows.Forms.ComboBox();
            this.ChangeLanguage = new System.Windows.Forms.Button();
            this.OpenIcon = new System.Windows.Forms.OpenFileDialog();
            this.OpenScript = new System.Windows.Forms.OpenFileDialog();
            this.NotificationsGroup.SuspendLayout();
            this.MainGroup.SuspendLayout();
            this.OtherSettings.SuspendLayout();
            this.Compiler.SuspendLayout();
            this.LanguagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotificationsGroup
            // 
            this.NotificationsGroup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NotificationsGroup.Controls.Add(this.Status);
            resources.ApplyResources(this.NotificationsGroup, "NotificationsGroup");
            this.NotificationsGroup.Name = "NotificationsGroup";
            this.NotificationsGroup.TabStop = false;
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.ForeColor = System.Drawing.Color.Brown;
            this.Status.Name = "Status";
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.NotificationsGroup);
            this.MainGroup.Controls.Add(this.OtherSettings);
            this.MainGroup.Controls.Add(this.Compiler);
            this.MainGroup.Controls.Add(this.LanguagePanel);
            resources.ApplyResources(this.MainGroup, "MainGroup");
            this.MainGroup.Name = "MainGroup";
            // 
            // OtherSettings
            // 
            this.OtherSettings.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.OtherSettings.Controls.Add(this.CompileOneFile);
            this.OtherSettings.Controls.Add(this.OnOffConsole);
            this.OtherSettings.Controls.Add(this.LoadIcan);
            this.OtherSettings.Controls.Add(this.AddIcon);
            resources.ApplyResources(this.OtherSettings, "OtherSettings");
            this.OtherSettings.Name = "OtherSettings";
            this.OtherSettings.TabStop = false;
            // 
            // CompileOneFile
            // 
            resources.ApplyResources(this.CompileOneFile, "CompileOneFile");
            this.CompileOneFile.Checked = true;
            this.CompileOneFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompileOneFile.Name = "CompileOneFile";
            this.CompileOneFile.UseVisualStyleBackColor = true;
            this.CompileOneFile.CheckedChanged += new System.EventHandler(this.CompileOneFile_CheckedChanged);
            // 
            // OnOffConsole
            // 
            resources.ApplyResources(this.OnOffConsole, "OnOffConsole");
            this.OnOffConsole.Name = "OnOffConsole";
            this.OnOffConsole.UseVisualStyleBackColor = true;
            this.OnOffConsole.CheckedChanged += new System.EventHandler(this.OnOffConsole_CheckedChanged);
            // 
            // LoadIcan
            // 
            resources.ApplyResources(this.LoadIcan, "LoadIcan");
            this.LoadIcan.Name = "LoadIcan";
            this.LoadIcan.UseVisualStyleBackColor = true;
            this.LoadIcan.Click += new System.EventHandler(this.LoadIcan_Click);
            // 
            // AddIcon
            // 
            resources.ApplyResources(this.AddIcon, "AddIcon");
            this.AddIcon.Name = "AddIcon";
            this.AddIcon.UseVisualStyleBackColor = true;
            this.AddIcon.CheckedChanged += new System.EventHandler(this.AddIcon_CheckedChanged);
            // 
            // Compiler
            // 
            this.Compiler.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Compiler.Controls.Add(this.CompileFile);
            this.Compiler.Controls.Add(this.OpenFile);
            this.Compiler.Controls.Add(this.PathToFile);
            resources.ApplyResources(this.Compiler, "Compiler");
            this.Compiler.Name = "Compiler";
            this.Compiler.TabStop = false;
            // 
            // CompileFile
            // 
            resources.ApplyResources(this.CompileFile, "CompileFile");
            this.CompileFile.Name = "CompileFile";
            this.CompileFile.UseVisualStyleBackColor = true;
            this.CompileFile.Click += new System.EventHandler(this.CompileFile_Click);
            // 
            // OpenFile
            // 
            resources.ApplyResources(this.OpenFile, "OpenFile");
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // PathToFile
            // 
            resources.ApplyResources(this.PathToFile, "PathToFile");
            this.PathToFile.Name = "PathToFile";
            // 
            // LanguagePanel
            // 
            this.LanguagePanel.Controls.Add(this.SaveSettings);
            this.LanguagePanel.Controls.Add(this.Language);
            this.LanguagePanel.Controls.Add(this.ChangeLanguage);
            resources.ApplyResources(this.LanguagePanel, "LanguagePanel");
            this.LanguagePanel.Name = "LanguagePanel";
            this.LanguagePanel.TabStop = false;
            // 
            // SaveSettings
            // 
            resources.ApplyResources(this.SaveSettings, "SaveSettings");
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // Language
            // 
            this.Language.FormattingEnabled = true;
            resources.ApplyResources(this.Language, "Language");
            this.Language.Name = "Language";
            // 
            // ChangeLanguage
            // 
            resources.ApplyResources(this.ChangeLanguage, "ChangeLanguage");
            this.ChangeLanguage.Name = "ChangeLanguage";
            this.ChangeLanguage.UseVisualStyleBackColor = true;
            this.ChangeLanguage.Click += new System.EventHandler(this.ChangeLanguage_Click);
            // 
            // OpenIcon
            // 
            this.OpenIcon.FileName = "openFileDialog1";
            // 
            // OpenScript
            // 
            this.OpenScript.FileName = "openFileDialog1";
            // 
            // RootForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.MainGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RootForm";
            this.NotificationsGroup.ResumeLayout(false);
            this.NotificationsGroup.PerformLayout();
            this.MainGroup.ResumeLayout(false);
            this.OtherSettings.ResumeLayout(false);
            this.OtherSettings.PerformLayout();
            this.Compiler.ResumeLayout(false);
            this.Compiler.PerformLayout();
            this.LanguagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NotificationsGroup;
        private System.Windows.Forms.FlowLayoutPanel MainGroup;
        private System.Windows.Forms.GroupBox OtherSettings;
        private System.Windows.Forms.CheckBox CompileOneFile;
        private System.Windows.Forms.CheckBox OnOffConsole;
        private System.Windows.Forms.Button LoadIcan;
        private System.Windows.Forms.CheckBox AddIcon;
        private System.Windows.Forms.OpenFileDialog OpenIcon;
        private System.Windows.Forms.GroupBox Compiler;
        private System.Windows.Forms.Button CompileFile;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.TextBox PathToFile;
        private System.Windows.Forms.GroupBox LanguagePanel;
        private System.Windows.Forms.ComboBox Language;
        private System.Windows.Forms.Button ChangeLanguage;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.OpenFileDialog OpenScript;
    }
}

