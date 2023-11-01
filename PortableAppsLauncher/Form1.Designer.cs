namespace PortableAppsLauncher
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxDirs = new ComboBox();
            buttonAddDir = new Button();
            buttonDelDir = new Button();
            listViewApps = new ListView();
            SuspendLayout();
            // 
            // comboBoxDirs
            // 
            comboBoxDirs.FormattingEnabled = true;
            comboBoxDirs.Location = new Point(8, 7);
            comboBoxDirs.Margin = new Padding(1, 1, 1, 1);
            comboBoxDirs.Name = "comboBoxDirs";
            comboBoxDirs.Size = new Size(658, 23);
            comboBoxDirs.TabIndex = 0;
            // 
            // buttonAddDir
            // 
            buttonAddDir.Location = new Point(672, 7);
            buttonAddDir.Margin = new Padding(1, 1, 1, 1);
            buttonAddDir.Name = "buttonAddDir";
            buttonAddDir.Size = new Size(79, 18);
            buttonAddDir.TabIndex = 1;
            buttonAddDir.Text = "Add";
            buttonAddDir.UseVisualStyleBackColor = true;
            // 
            // buttonDelDir
            // 
            buttonDelDir.Location = new Point(758, 7);
            buttonDelDir.Margin = new Padding(1, 1, 1, 1);
            buttonDelDir.Name = "buttonDelDir";
            buttonDelDir.Size = new Size(79, 18);
            buttonDelDir.TabIndex = 2;
            buttonDelDir.Text = "Remove";
            buttonDelDir.UseVisualStyleBackColor = true;
            // 
            // listViewApps
            // 
            listViewApps.Location = new Point(8, 34);
            listViewApps.Margin = new Padding(1, 1, 1, 1);
            listViewApps.Name = "listViewApps";
            listViewApps.Size = new Size(658, 331);
            listViewApps.TabIndex = 3;
            listViewApps.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 332);
            Controls.Add(listViewApps);
            Controls.Add(buttonDelDir);
            Controls.Add(buttonAddDir);
            Controls.Add(comboBoxDirs);
            Margin = new Padding(1, 1, 1, 1);
            Name = "FormMain";
            Text = "Portable Apps Launcher";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxDirs;
        private Button buttonAddDir;
        private Button buttonDelDir;
        private ListView listViewApps;
    }
}