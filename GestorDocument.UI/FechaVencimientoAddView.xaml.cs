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
using System.Windows.Shapes;
using GestorDocument.ViewModel;

namespace GestorDocument.UI
{
    /// <summary>
    /// Lógica de interacción para FechaVencimientoAddView.xaml
    /// </summary>
    public partial class FechaVencimientoAddView : Window
    {
        public FechaVencimientoAddView()
        {
            InitializeComponent();
            this.DataContext = new FechaVencimientoAddViewModel();
        }

        private FechaVencimientoAddViewModel GetViewModel()
        {
            return this.DataContext as FechaVencimientoAddViewModel;
        }

        private void btGuardar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
