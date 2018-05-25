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

namespace PPE3_Daltons.Employees.Main_technicien
{
    /// <summary>
    /// Logique d'interaction pour MainTechnicienView.xaml
    /// </summary>
    public partial class MainTechnicienView : UserControl
    {
        public MainTechnicienView()
        {
            InitializeComponent();
        }

        public MainTechnicienView(MainTechnicienViewModel model)
          : this()
        {
            this.DataContext = model;
        }
    }
}
