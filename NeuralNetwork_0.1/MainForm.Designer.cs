namespace NeuralNetwork_0._1
{
    partial class MainForm
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
            this.OpenImagesDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgramMenu = new System.Windows.Forms.MenuStrip();
            this.Menu_NeuralNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_CreateNeuralNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Learn = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenImagesFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_TestNeuralNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_TestNeuralNetwork_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_TestNeuralNetwork_Open_ImageFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DeleteNeuralNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_TestNeuralNetwork_Open_Image = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageFile = new System.Windows.Forms.OpenFileDialog();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenImagesDirectory
            // 
            this.OpenImagesDirectory.ShowNewFolderButton = false;
            // 
            // ProgramMenu
            // 
            this.ProgramMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_NeuralNetwork});
            this.ProgramMenu.Location = new System.Drawing.Point(0, 0);
            this.ProgramMenu.Name = "ProgramMenu";
            this.ProgramMenu.Size = new System.Drawing.Size(584, 24);
            this.ProgramMenu.TabIndex = 0;
            this.ProgramMenu.Text = "Menu";
            // 
            // Menu_NeuralNetwork
            // 
            this.Menu_NeuralNetwork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_CreateNeuralNetwork,
            this.Menu_Learn,
            this.Menu_TestNeuralNetwork,
            this.Menu_Save,
            this.Menu_DeleteNeuralNetwork});
            this.Menu_NeuralNetwork.Name = "Menu_NeuralNetwork";
            this.Menu_NeuralNetwork.Size = new System.Drawing.Size(74, 20);
            this.Menu_NeuralNetwork.Text = "Нейронка";
            // 
            // Menu_CreateNeuralNetwork
            // 
            this.Menu_CreateNeuralNetwork.Name = "Menu_CreateNeuralNetwork";
            this.Menu_CreateNeuralNetwork.Size = new System.Drawing.Size(180, 22);
            this.Menu_CreateNeuralNetwork.Text = "Создать";
            this.Menu_CreateNeuralNetwork.Click += new System.EventHandler(this.Menu_CreateNeuralNetwork_Click);
            // 
            // Menu_Learn
            // 
            this.Menu_Learn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Open});
            this.Menu_Learn.Enabled = false;
            this.Menu_Learn.Name = "Menu_Learn";
            this.Menu_Learn.Size = new System.Drawing.Size(180, 22);
            this.Menu_Learn.Text = "Обучение";
            // 
            // Menu_Open
            // 
            this.Menu_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OpenImagesFolder});
            this.Menu_Open.Name = "Menu_Open";
            this.Menu_Open.Size = new System.Drawing.Size(121, 22);
            this.Menu_Open.Text = "Открыть";
            // 
            // Menu_OpenImagesFolder
            // 
            this.Menu_OpenImagesFolder.Name = "Menu_OpenImagesFolder";
            this.Menu_OpenImagesFolder.Size = new System.Drawing.Size(186, 22);
            this.Menu_OpenImagesFolder.Text = "Папку с картинками";
            this.Menu_OpenImagesFolder.Click += new System.EventHandler(this.Menu_OpenImagesFolder_Click);
            // 
            // Menu_TestNeuralNetwork
            // 
            this.Menu_TestNeuralNetwork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_TestNeuralNetwork_Open});
            this.Menu_TestNeuralNetwork.Enabled = false;
            this.Menu_TestNeuralNetwork.Name = "Menu_TestNeuralNetwork";
            this.Menu_TestNeuralNetwork.Size = new System.Drawing.Size(180, 22);
            this.Menu_TestNeuralNetwork.Text = "Тестировать";
            // 
            // Menu_TestNeuralNetwork_Open
            // 
            this.Menu_TestNeuralNetwork_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_TestNeuralNetwork_Open_ImageFolder,
            this.Menu_TestNeuralNetwork_Open_Image});
            this.Menu_TestNeuralNetwork_Open.Name = "Menu_TestNeuralNetwork_Open";
            this.Menu_TestNeuralNetwork_Open.Size = new System.Drawing.Size(180, 22);
            this.Menu_TestNeuralNetwork_Open.Text = "Открыть";
            // 
            // Menu_TestNeuralNetwork_Open_ImageFolder
            // 
            this.Menu_TestNeuralNetwork_Open_ImageFolder.Name = "Menu_TestNeuralNetwork_Open_ImageFolder";
            this.Menu_TestNeuralNetwork_Open_ImageFolder.Size = new System.Drawing.Size(186, 22);
            this.Menu_TestNeuralNetwork_Open_ImageFolder.Text = "Папку с картинками";
            this.Menu_TestNeuralNetwork_Open_ImageFolder.Click += new System.EventHandler(this.Menu_TestNeuralNetwork_Open_ImageFolder_Click);
            // 
            // Menu_DeleteNeuralNetwork
            // 
            this.Menu_DeleteNeuralNetwork.Enabled = false;
            this.Menu_DeleteNeuralNetwork.Name = "Menu_DeleteNeuralNetwork";
            this.Menu_DeleteNeuralNetwork.Size = new System.Drawing.Size(180, 22);
            this.Menu_DeleteNeuralNetwork.Text = "Удалить";
            this.Menu_DeleteNeuralNetwork.Click += new System.EventHandler(this.Menu_DeleteNeuralNetwork_Click);
            // 
            // Menu_TestNeuralNetwork_Open_Image
            // 
            this.Menu_TestNeuralNetwork_Open_Image.Name = "Menu_TestNeuralNetwork_Open_Image";
            this.Menu_TestNeuralNetwork_Open_Image.Size = new System.Drawing.Size(186, 22);
            this.Menu_TestNeuralNetwork_Open_Image.Text = "Картинку";
            this.Menu_TestNeuralNetwork_Open_Image.Click += new System.EventHandler(this.Menu_TestNeuralNetwork_Open_Image_Click);
            // 
            // OpenImageFile
            // 
            this.OpenImageFile.Filter = "Image|*.jpg;*.png";
            this.OpenImageFile.Title = "OpenImage";
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.Size = new System.Drawing.Size(180, 22);
            this.Menu_Save.Text = "Сохранить";
            this.Menu_Save.Click += new System.EventHandler(this.Menu_Save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ProgramMenu);
            this.Name = "MainForm";
            this.Text = "Основное окно программы";
            this.ProgramMenu.ResumeLayout(false);
            this.ProgramMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog OpenImagesDirectory;
        private System.Windows.Forms.MenuStrip ProgramMenu;
        private System.Windows.Forms.ToolStripMenuItem Menu_NeuralNetwork;
        private System.Windows.Forms.ToolStripMenuItem Menu_Learn;
        private System.Windows.Forms.ToolStripMenuItem Menu_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_CreateNeuralNetwork;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenImagesFolder;
        private System.Windows.Forms.ToolStripMenuItem Menu_DeleteNeuralNetwork;
        private System.Windows.Forms.ToolStripMenuItem Menu_TestNeuralNetwork;
        private System.Windows.Forms.ToolStripMenuItem Menu_TestNeuralNetwork_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_TestNeuralNetwork_Open_ImageFolder;
        private System.Windows.Forms.ToolStripMenuItem Menu_TestNeuralNetwork_Open_Image;
        private System.Windows.Forms.OpenFileDialog OpenImageFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
    }
}

