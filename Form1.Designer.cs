namespace Lesson_2023_11_01
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьБдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.правкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGAutor = new System.Windows.Forms.DataGridView();
            this.DGBoocks = new System.Windows.Forms.DataGridView();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBoocks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьБдToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выбратьБдToolStripMenuItem
            // 
            this.выбратьБдToolStripMenuItem.Name = "выбратьБдToolStripMenuItem";
            this.выбратьБдToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выбратьБдToolStripMenuItem.Text = "Выбрать БД";
            this.выбратьБдToolStripMenuItem.Click += new System.EventHandler(this.выбратьБдToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // правкаToolStripMenuItem1
            // 
            this.правкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьТаблицыToolStripMenuItem,
            this.сохранитьИзмененияToolStripMenuItem});
            this.правкаToolStripMenuItem1.Name = "правкаToolStripMenuItem1";
            this.правкаToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem1.Text = "Правка";
            // 
            // создатьТаблицыToolStripMenuItem
            // 
            this.создатьТаблицыToolStripMenuItem.Name = "создатьТаблицыToolStripMenuItem";
            this.создатьТаблицыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьТаблицыToolStripMenuItem.Text = "Создать таблицы";
            this.создатьТаблицыToolStripMenuItem.Click += new System.EventHandler(this.создатьТаблицыToolStripMenuItem_Click);
            // 
            // DGAutor
            // 
            this.DGAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGAutor.Location = new System.Drawing.Point(13, 38);
            this.DGAutor.Name = "DGAutor";
            this.DGAutor.Size = new System.Drawing.Size(209, 400);
            this.DGAutor.TabIndex = 1;
            // 
            // DGBoocks
            // 
            this.DGBoocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBoocks.Location = new System.Drawing.Point(265, 38);
            this.DGBoocks.Name = "DGBoocks";
            this.DGBoocks.Size = new System.Drawing.Size(523, 400);
            this.DGBoocks.TabIndex = 2;
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGBoocks);
            this.Controls.Add(this.DGAutor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBoocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьБдToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьТаблицыToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGAutor;
        private System.Windows.Forms.DataGridView DGBoocks;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
    }
}

