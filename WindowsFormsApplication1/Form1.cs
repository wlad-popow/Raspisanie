﻿//// Документ формы1
namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Microsoft.Office.Interop.Excel;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// Класс формы программы.
    /// </summary>
    public partial class Form1 : Form
    {
        int m;
        //int[,] pon = new int[7, 11];
        /// <summary>
        ///  Переменные используются при удалении по дням недели
        /// </summary>
        private int b, a;
        /// <summary>
        /// Метод удаления
        /// </summary>
        public void Ud()
        {
            for (; this.a < this.b; this.a++)
            {
                for (int j = 2; j < 13; j++)
                {
                    Tabl[j, this.a].Value = "";
                }
            }
        }

        /// <summary>
        /// Метод увеличения размера окна
        /// </summary>
        public void Toggle()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Конструктор таблицы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Tabl.ColumnCount = 13;
            Tabl.RowCount = 36;
        }

        /// <summary>
        /// Объект класса Input.
        /// </summary>
        private Input input = new Input();

        /// <summary>
        /// Объект класса Tabl.
        /// </summary>
        private Tabl t = new Tabl();

        /// <summary>
        /// Метод ввода в таблицу
        /// </summary>
        /// <param name="sender">Стандарт 11</param>
        /// <param name="e">Стандарт 12</param>
        private void Tabl_znach_MouseDown(object sender, MouseEventArgs e)
        {
            this.t.Inp(this);
            this.t.Spis(this);
        }

        /// <summary>
        /// Метод удаления
        /// </summary>
        /// <param name="sender">хз 1444</param>
        /// <param name="e">хз 414</param>
        private void DelClick(object sender, EventArgs e)
        {
            this.t.Dell(this);
        }

        /// <summary>
        /// Метод открытия
        /// </summary>
        /// <param name="sender">хз 78645</param>
        /// <param name="e">хз 996</param>
        private void ОткрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m = 1;
            missing_teachers.Text = null;
            this.input.Inp(this);
        }


        /// <summary>
        /// Метод открытия 2
        /// </summary>
        /// <param name="sender">йхз 545411</param>
        /// <param name="e">хз 4545125</param>
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Toggle();
        }

        /// <summary>
        /// Объект класса Algoritm.
        /// </summary>
        private Algoritm alg = new Algoritm();

        string[,] poned = new string[50, 50];
        string[,] vtor = new string[50, 50];
        string[,] sreda = new string[50, 50];
        string[,] chetv = new string[50, 50];
        string[,] pyat = new string[50, 50];
        /// <summary>
        /// Метод удаления по понедельникам
        /// </summary>
        /// <param name="sender">Стандарт 5</param>
        /// <param name="e">Стандарт 6</param>
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.a = 1;
                this.b = 8;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        poned[i, j] = (string)(Tabl[i, j].Value);
                    }
                }
                this.Ud();
            }
            else
            {
                for (int i = 2; i < 13; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (m == 1)
                            Tabl[i, j].Value = poned[i, j];
                        else
                            return;
                    }
                }
            }
        }

        /// <summary>
        /// Метод Удаления по вторникам
        /// </summary>
        /// <param name="sender">хз 1123</param>
        /// <param name="e">хз 1111</param>
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.a = 8;
                this.b = 15;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 8; j < 15; j++)
                    {
                        vtor[i, j] = (string)(Tabl[i, j].Value);
                    }
                }
                this.Ud();
            }
            else
            {
                for (int i = 2; i < 13; i++)
                {
                    for (int j = 8; j < 15; j++)
                    {
                        if (m == 1)
                            Tabl[i, j].Value = vtor[i,j];
                        else
                            return;
                    }
                }
            }
        }

        /// <summary>
        /// Метод Удаления по средам
        /// </summary>
        /// <param name="sender">хз 144</param>
        /// <param name="e">хз 12</param>
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.a = 15;
                this.b = 22;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 15; j < 22; j++)
                    {
                        sreda[i, j] = (string)(Tabl[i, j].Value);
                    }
                }
                this.Ud();
            }
            else
            {
                for (int i = 2; i < 13; i++)
                {
                    for (int j = 15; j < 22; j++)
                    {
                        if (m == 1)
                            Tabl[i, j].Value =sreda[i,j];
                        else
                            return;
                    }
                }
            }
        }

        /// <summary>
        /// Метод Удаления по четвергам
        /// </summary>
        /// <param name="sender">хз 112</param>
        /// <param name="e">хз 122</param>
        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                this.a = 22;
                this.b = 29;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 22; j < 29; j++)
                    {
                        chetv[i, j] = (string)(Tabl[i, j].Value);
                    }
                }
                this.Ud();
            }
            else
            {
                for (int i = 2; i < 13; i++)
                {
                    for (int j = 22; j < 29; j++)
                    {
                        if (m == 1)
                            Tabl[i, j].Value = chetv[i, j];
                        else
                            return;
                    }
                }
            }
        }

        /// <summary>
        /// Метод Удаления по пятницам
        /// </summary>
        /// <param name="sender">хз 14</param>
        /// <param name="e">хз 13</param>
        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                this.a = 29;
                this.b = 36;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 29; j < 36; j++)
                    {
                        pyat[i, j] = (string)(Tabl[i, j].Value);
                    }
                }
                this.Ud();
            }
            else
            {
                for (int i = 2; i < 13; i++)
                {
                    for (int j = 29; j < 36; j++)
                    {
                        if (m == 1)
                            Tabl[i, j].Value = pyat[i, j];
                        else
                            return;
                    }
                }
            }
        }

        /// <summary>
        /// Метод редактора расписания
        /// </summary>
        /// <param name="sender">1 2</param>
        /// <param name="e">2 3</param>
        private void Redaktor_Click(object sender, EventArgs e)
        {
            this.alg.Perestanovka(this);
        }

        /// <summary>
        /// О программе
        /// </summary>
        /// <param name="sender">Стандарт 2</param>
        /// <param name="e">Стандарт 1</param>
        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 secondForm = new Form3();
            secondForm.ShowDialog();
        }

        /// <summary>
        /// Метод справка
        /// </summary>
        /// <param name="sender">Стандарт 3</param>
        /// <param name="e">Стандарт 4</param>
        private void СправкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();
        }
        /// <summary>
        /// Метод сохранения расписания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\tmp";                        //Открытия диалога для сохранения
            saveFileDialog1.Filter = "Excel (*.XLS;*.XLSX)|*.XLS;*.XLSX";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();           //Открытие экселя
                excelApp.Visible = false;
                excelApp.Workbooks.Open(@"C:\R.xlsx");                          // Путь к файлу шаблона
                Excel.Worksheet workSheet = excelApp.ActiveSheet;
                for (int i = 1; i < 36; i++)
                    for (int j = 2; j < 13; j++)
                    {
                        workSheet.Cells[i+1, j+1] = Tabl.Rows[i].Cells[j].Value;
                    }
                string fileName = saveFileDialog1.FileName;
                workSheet.SaveAs(fileName);
                 excelApp.Visible = true;
                 excelApp.Quit();
                 GC.Collect();  
            }
        }

        private void отправитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailForm m = new MailForm();
            m.ShowDialog(); ;
        }
    }
}
