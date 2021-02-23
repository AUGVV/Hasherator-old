namespace HASHerator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.FBD2 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.helpProv = new System.Windows.Forms.HelpProvider();
            this.Reditor = new System.Windows.Forms.CheckBox();
            this.ErrorLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GOST Common", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Откуда берем";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("GOST Common", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(10, 30);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Путь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 139);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("GOST Common", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(93, 30);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 36);
            this.textBox2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("GOST Common", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(180, 97);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(154, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Считать хэши";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Lime;
            this.helpProv.SetHelpKeyword(this.checkBox1, "");
            this.helpProv.SetHelpString(this.checkBox1, "Формирует новую PDF из старой но с текстовыми полями(Новые УЛ с префиксом -new)");
            this.checkBox1.Location = new System.Drawing.Point(10, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpProv.SetShowHelp(this.checkBox1, true);
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Автозаполнение УЛ(Тестовое)";
            this.toolTip1.SetToolTip(this.checkBox1, "Формирует новую PDF из старой но с текстовыми полями(Новые УЛ с префиксом -new)");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.ForeColor = System.Drawing.Color.Lime;
            this.helpProv.SetHelpString(this.checkBox2, "(!На свой страх и риск!) Заменяет уже существующие УЛ");
            this.checkBox2.Location = new System.Drawing.Point(10, 95);
            this.checkBox2.Name = "checkBox2";
            this.helpProv.SetShowHelp(this.checkBox2, true);
            this.checkBox2.Size = new System.Drawing.Size(110, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Замена файлов(!)";
            this.toolTip1.SetToolTip(this.checkBox2, "(!На свой страх и риск!) Заменяет уже существующие УЛ");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Reditor
            // 
            this.Reditor.AutoSize = true;
            this.Reditor.Enabled = false;
            this.Reditor.ForeColor = System.Drawing.Color.Lime;
            this.helpProv.SetHelpString(this.Reditor, "Открыть все новые УЛ на редактирование");
            this.Reditor.Location = new System.Drawing.Point(10, 116);
            this.Reditor.Name = "Reditor";
            this.helpProv.SetShowHelp(this.Reditor, true);
            this.Reditor.Size = new System.Drawing.Size(126, 17);
            this.Reditor.TabIndex = 6;
            this.Reditor.Text = "Открывать для ред.";
            this.toolTip1.SetToolTip(this.Reditor, "Открыть все новые УЛ на редактирование");
            this.Reditor.UseVisualStyleBackColor = true;
            // 
            // ErrorLab
            // 
            this.ErrorLab.AutoSize = true;
            this.ErrorLab.ForeColor = System.Drawing.Color.Red;
            this.ErrorLab.Location = new System.Drawing.Point(186, 13);
            this.ErrorLab.Name = "ErrorLab";
            this.ErrorLab.Size = new System.Drawing.Size(0, 13);
            this.ErrorLab.TabIndex = 2;
            this.toolTip1.SetToolTip(this.ErrorLab, "ОИТ Aug V.V. Костыльное погроммирование");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Куда пихаем";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("GOST Common", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(10, 138);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(51, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "HELP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(341, 175);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Reditor);
            this.Controls.Add(this.ErrorLab);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("GOST Common", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProv.SetShowHelp(this, false);
            this.Text = "Хэшератор MD5 v3";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.FolderBrowserDialog FBD2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.HelpProvider helpProv;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label ErrorLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Reditor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}

