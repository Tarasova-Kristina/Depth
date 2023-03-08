﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Depth
{
    /// <summary>
    /// Логика взаимодействия для Termin.xaml
    /// </summary>
    public partial class Termin : Window
    {
        public Termin()
        {
            InitializeComponent();
        }
        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private void Move_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}