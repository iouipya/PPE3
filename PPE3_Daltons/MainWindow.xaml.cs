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
using PPE3_Daltons.Accueil;


namespace PPE3_Daltons
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowsViewModel mainWindowsViewModel = new MainWindowsViewModel(); 

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = mainWindowsViewModel;

        }
    }
}
