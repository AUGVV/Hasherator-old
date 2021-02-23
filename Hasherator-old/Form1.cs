using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace HASHerator
{
    public partial class Form1 : Form
    {
        string path = "";
        int i = 0;
        string md = "";
        string datas2 = "";
        int full = 0;
        string forSize = "";
        //PDF edit

        string FileForULin = "";
    

        public Form1()
        {
            InitializeComponent();
        }
        //Откуда берем
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLab.Text = "";
                FBD.ShowNewFolderButton = false;
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = FBD.SelectedPath; // Запись пути в TextBox из выбранного окна
                    Console.WriteLine("|Выбор пути произведен| " + FBD.SelectedPath + " |");
                }
                path = textBox2.Text;
                path = path.Replace("/", "\\");
            }
            //ErrorLab инфа о ошибке для самой формы
            catch { Console.WriteLine("BUTTON PATH ERROR!!"); ErrorLab.Text = "Проблема с кнопкой 0-O"; }
        }
        //Считать хэши
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorLab.Text = "";
                path = textBox2.Text;
                path = path.Replace("/", "\\");

                var dir = new DirectoryInfo(path);
                dir = new DirectoryInfo(path);



                foreach (FileInfo file in dir.GetFiles())
                {
                    if (file.FullName.IndexOf(".docx") == -1 && file.FullName.IndexOf("-УЛ") == -1 && file.FullName.IndexOf("1.txt") == -1)
                    {
                        full++;
                    }
                }
                progressBar1.Maximum = full;

                StreamWriter sw = new StreamWriter(path + "\\1.txt", false, System.Text.Encoding.Default);
                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine(file);
                    if (file.FullName.IndexOf(".docx") == -1 && file.FullName.IndexOf("-УЛ") == -1 && file.FullName.IndexOf("1.txt") == -1)
                    {
                        i++;

                        Console.WriteLine(FileForULin);
                        using (FileStream ORFile = System.IO.File.OpenRead(file.FullName))
                        {
                            MD5 md5 = new MD5CryptoServiceProvider();
                            byte[] fileData = new byte[ORFile.Length];
                            ORFile.Read(fileData, 0, (int)ORFile.Length);
                            byte[] checkSum = md5.ComputeHash(fileData);
                            md = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                        }
                        sw.WriteLine(" ");
                        sw.WriteLine("================== " + i + " ===================");
                        sw.WriteLine(" ");
                        Console.WriteLine("=================================================");
                        Console.WriteLine("| | " + file.Name + " | |");
                        sw.WriteLine(file.Name);
                        sw.WriteLine(" ");
                        Console.WriteLine("| | " + md + " | |");
                        sw.WriteLine(md);
                        sw.WriteLine(" ");
                        int Size = File.ReadAllBytes(file.FullName).Length;
                        Console.WriteLine("| | " + Size + " | |");
                        forSize = Size.ToString();
                        sw.WriteLine(Size + " байт");
                        sw.WriteLine(" ");
                        DateTime datas = File.GetLastWriteTime(file.FullName);
                        datas2 = datas.ToString("HH:mm:ss yyyy-MM-dd");

                        Console.WriteLine("| | " + datas2 + " | |");
                        sw.WriteLine(datas2);

                        //Часть де все интегрируется в пдф
                        if (checkBox1.Checked == true)
                        {
                            try
                            {
                                PDFRecreator(file.FullName);                    
                            }
                            catch { };
                        }
                        progressBar1.Value = i;
                    }
                }
                sw.Close();
                Process.Start("notepad.exe", path + "\\1.txt");
                i = 0;
                progressBar1.Value = 0;
                progressBar1.Maximum = 0;
            }
            catch { Console.WriteLine("!CORE! ERROR!!!"); ErrorLab.Text = "Проверьте путь"; }
        }

        private void PDFRecreator(string name)
        {
            try
            {
                string Format = "-УЛ-new.pdf"; 
                //получаю полный путь файла срезаю кусок .pdf(Этот метод только для pdf)
                FileForULin = name;
                FileForULin = FileForULin.Substring(0, FileForULin.Length - 4);
                //Console.WriteLine(FileForULin);
                //Читать уже существующий PDF
                PdfReader READ = new PdfReader(FileForULin + "-УЛ.pdf");
                //получить размер документа
                iTextSharp.text.Rectangle size = READ.GetPageSizeWithRotation(1);
                Document DOC = new Document(size);
                //Поток с инфой из файла в библиотеку iText
                if(checkBox2.Checked == true)
                { Format = "-УЛ-format.pdf"; }
                else if(checkBox2.Checked == false)
                { Format = "-УЛ-new.pdf"; }
                FileStream fs = new FileStream(FileForULin + Format, FileMode.Create, FileAccess.Write);
                PdfWriter writer = PdfWriter.GetInstance(DOC, fs);
                //документ на редактирование
                DOC.Open();
                //Элементы PDF
                PdfContentByte CONTENT = writer.DirectContent;
                PdfContentByte CONTENTData = writer.DirectContent;
                PdfContentByte CONTENTSize = writer.DirectContent;
                //Шрифт элементов вносимых в PDF программно
                BaseFont FONT = BaseFont.CreateFont("c:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                //Цвет шрифта
                CONTENT.SetColorFill(BaseColor.BLACK);
                //Размер шрифта
                CONTENT.SetFontAndSize(FONT, 13);
                //Создать страницу в новом PDF
                PdfImportedPage page = writer.GetImportedPage(READ, 1);
                CONTENT.AddTemplate(page, 0, 0);
                //Вставить текст по координатам 
                //MD5
                CONTENT.BeginText();
                CONTENT.ShowTextAligned(1, md, 420, 652, 0);
                CONTENT.EndText();
                //Размер
                CONTENTData.BeginText();
                CONTENTData.ShowTextAligned(1, forSize + " байт", 420, 620, 0);
                CONTENTData.EndText();
                //Даты
                CONTENTSize.BeginText();
                CONTENTSize.ShowTextAligned(1, datas2, 420, 590, 0);
                CONTENTSize.EndText();
                //Закрыть все потоки
                DOC.Close();
                fs.Close();
                writer.Close();
                READ.Close();
                if (checkBox2.Checked == true)
                {
                    //Удаляем старый, переименовываем новый.
                   System.IO.File.Delete(FileForULin + "-УЛ.pdf");
                   File.Move(FileForULin + Format, FileForULin + "-УЛ.pdf");
                }




                Console.WriteLine(FileForULin + Format);
                //открыть PDF файлы(ОТКРЫВАЕТ ПРОГРАММОЙ ПО УМОЛЧАНИЮ!)
                if (Reditor.Checked == true)
                {
                    if (checkBox2.Checked == true)
                        Process.Start(FileForULin + "-УЛ.pdf");
                    else if (checkBox2.Checked == false)
                        Process.Start(FileForULin + Format);
                }
            }
            catch { Console.WriteLine("PDFRecreator !EX! ERROR!!!"); ErrorLab.Text = "PDF файл не обработан"; }
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Reditor.Enabled = true;
                checkBox2.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                Reditor.Enabled = false;
                Reditor.Checked = false;
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для адекватной работы дополнительных функций: \n 1.Имя УЛ и файла должны быть идентичны \n 2.УЛ должен оканчиваться на -УЛ.pdf не иначе \n (пример) \n 009-ПТ2-ПЗ1 Раздел ПД №1 ч.1.pdf \n 009-ПТ2-ПЗ1 Раздел ПД №1 ч.1-УЛ.pdf \n и т.д");
        }
    }
}
