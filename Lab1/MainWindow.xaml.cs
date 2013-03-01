﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections;
using Microsoft.Win32;

namespace Lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(textBox1.Text);
            Random rnd1 = new Random();
            int number;
            listBox1.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                listBox1.Items.Add(number);
            }
        }
            else listBox1.Items.Add("Введите значение");

        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                ArrayList myAL = new ArrayList();
                int index;
                int itemCount = Convert.ToInt32(textBox1.Text);
                Random rnd1 = new Random();
                int number;
                listBox1.Items.Clear();
                listBox1.Items.Add("Исходный массив");
                for (index = 1; index <= itemCount; index++)
                {
                    number = -100 + rnd1.Next(200);
                    myAL.Add(number);
                    listBox1.Items.Add(number);
                }
                myAL.Sort();
                listBox1.Items.Add("Отсортированный массив");
                foreach (int elem in myAL)
                {
                    listBox1.Items.Add(elem);
                }
            }
            else listBox1.Items.Add("Введите значение");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in listBox1.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
