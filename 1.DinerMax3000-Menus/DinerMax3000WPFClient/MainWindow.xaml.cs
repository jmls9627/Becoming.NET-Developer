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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DinerMax3000WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DinerMax3000.WPFClient.DinerMax3000ViewModel currentViewModel =
                (DinerMax3000.WPFClient.DinerMax3000ViewModel)DataContext;
            DinerMax3000.Business.MenuItem newMenuItem = currentViewModel.NewMenuItem;
            currentViewModel.SelectedMenu.SaveNewMenuItem(newMenuItem.Title, newMenuItem.Description, newMenuItem.Price);
            BindingOperations.GetBindingExpressionBase(cboAllMenus, ComboBox.ItemsSourceProperty).UpdateTarget();
        }
    }
}
