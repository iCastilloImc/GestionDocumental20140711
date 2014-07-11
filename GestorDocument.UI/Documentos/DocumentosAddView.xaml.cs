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
using GestorDocument.ViewModel;

namespace GestorDocument.UI.Documentos
{
    /// <summary>
    /// Lógica de interacción para DocumentosAddView.xaml
    /// </summary>
    public partial class DocumentosAddView : UserControl
    {

        public DocumentosAddView()
        {
            InitializeComponent();
            this.Loaded += delegate
            {
                Keyboard.Focus(this.textBox1);
                this.textBox1.SelectAll();

            };
            //this.DataContext = new DocumentosAddViewModel();
        }

        private DocumentosAddViewModel GetViewModel()
        {
            return this.DataContext as DocumentosAddViewModel;
        }

        private void btGuardar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow res = GetParetWindows();
            if (res != null)
            {
                res.CallNew();
            }
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        public void GetDocumentos(DocumentosViewModel viewModel)
        {
            try
            {
                this.DataContext = new DocumentosAddViewModel(viewModel);
            }
            catch (Exception)
            {
                ;
            }

        }

        // Accede a los controles de la pantalla principal.
        public MainWindow GetParetWindows()
        {
            MainWindow res = null;
            try
            {
                object query = Application.Current.Windows[0];
                res = query as MainWindow;
            }
            catch (Exception)
            {
                ;
            }
            return res;
        }

    }
}
