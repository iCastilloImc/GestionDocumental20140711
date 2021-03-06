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
using GestorDocument.ViewModel.v2;
using GestorDocument.UI.v2.Stock;


namespace GestorDocument.UI.v2
{
    /// <summary>
    /// Lógica de interacción para TableroView.xaml
    /// </summary>
    public partial class TableroView : UserControl
    {
        TableroViewModel tvm = new TableroViewModel();
        public TableroView()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            tvm.Init(10);
            this.DataContext = tvm;
        }

        private void grdUrgentes_MouseUp(object sender, MouseButtonEventArgs e)
        {
            #region Codigo Viejo
            //HistorialAsuntosDataGrid control=null;
            //if (StockSingleton.Instance.DictionaryControl.ContainsKey("HAU"))
            //    control = StockSingleton.Instance.DictionaryControl["HAU"] as HistorialAsuntosDataGrid;
            //else
            //{
            //    control = new HistorialAsuntosDataGrid();
            //    StockSingleton.Instance.DictionaryControl.Add("HAU", control);
            //}
            //StockSingleton.Instance.AddStack("HAU", control);
            //control = new HistorialAsuntosDataGrid("Asuntos pendientes");
            #endregion

            HistorialAsuntosDataGrid ha = new HistorialAsuntosDataGrid();
            ha.init("Asuntos Urgentes");
            StockSingleton.Instance.SelectedItem = ha;
          
            //    e.Handled = true;
            ////AU = Asuntos Urgentes
            //if (!StockSingleton.Instance.DictionaryControl.ContainsKey("AU"))
            //{
            //    StockSingleton.Instance.DictionaryControl.Add("AU", ha);
            //    StockSingleton.Instance.AgregarAPila("AU");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
            //else
            //{
            //    StockSingleton.Instance.AgregarAPila("AU");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}

        }

        private void grdAtendidos_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HistorialAsuntosDataGrid ha = new HistorialAsuntosDataGrid();
            ha.init("Asuntos Atendidos");
            StockSingleton.Instance.SelectedItem = ha;
            //AA = Asuntos Atendidos
            if (e.Source.Equals(sender))
                e.Handled = false;
            else
                e.Handled = true;
            //if (!StockSingleton.Instance.DictionaryControl.ContainsKey("AA"))
            //{
            //    StockSingleton.Instance.DictionaryControl.Add("AA", ha);
            //    StockSingleton.Instance.AgregarAPila("AA");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
            //else
            //{ StockSingleton.Instance.SelectedItem = ha;
            //StockSingleton.Instance.AgregarAPila("AA");
            //}
                
        }

        private void grdPendientes_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HistorialAsuntosDataGrid ha = new HistorialAsuntosDataGrid();
            ha.init("Asuntos Pendientes");
            StockSingleton.Instance.SelectedItem = ha;
            //AP = Asuntos Pendientes
            if (e.Source.Equals(sender))
                e.Handled = false;
            else
                e.Handled = true;
            //if (!StockSingleton.Instance.DictionaryControl.ContainsKey("AP"))
            //{
            //    StockSingleton.Instance.DictionaryControl.Add("AP", ha);
            //    StockSingleton.Instance.AgregarAPila("AP");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
            //else { StockSingleton.Instance.SelectedItem = ha;
            //StockSingleton.Instance.AgregarAPila("AP");
            //}
                
        }

        private void grdTodos_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HistorialAsuntosDataGrid ha = new HistorialAsuntosDataGrid();
            ha.init("Todos los Asuntos");
            StockSingleton.Instance.SelectedItem = ha;
            //TA = Todos Asuntos
            //if (!StockSingleton.Instance.DictionaryControl.ContainsKey("TA"))
            //{
            //    StockSingleton.Instance.DictionaryControl.Add("TA", ha);
            //    StockSingleton.Instance.AgregarAPila("TA");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
            //else
            //{
            //    StockSingleton.Instance.AgregarAPila("TA");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
        }

        private void GridPrioritarios_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HistorialAsuntosDataGrid ha = new HistorialAsuntosDataGrid();
            ha.init("Asuntos Prioritarios");
            StockSingleton.Instance.SelectedItem = ha;
            //APR = Asuntos PRioritarios
            //Detiene Cascada de eventos
            if (e.Source.Equals(sender))
                e.Handled = false;
            else
                e.Handled = true;
            //if (!StockSingleton.Instance.DictionaryControl.ContainsKey("APR"))
            //{
            //    StockSingleton.Instance.DictionaryControl.Add("APR", ha);
            //    StockSingleton.Instance.AgregarAPila("APR");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
            //else
            //{
            //    StockSingleton.Instance.AgregarAPila("APR");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
        }

        private void GridOrdinarios_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HistorialAsuntosDataGrid ha = new HistorialAsuntosDataGrid();
            ha.init("Asuntos Ordinarios");
            StockSingleton.Instance.SelectedItem = ha;
            //AO = Asuntos Ordinarios
            //Detiene Cascada de eventos
            if (e.Source.Equals(sender))
                e.Handled = false;
            else
                e.Handled = true;
            //if (!StockSingleton.Instance.DictionaryControl.ContainsKey("AO"))
            //{
            //    StockSingleton.Instance.DictionaryControl.Add("AO", ha);
            //    StockSingleton.Instance.AgregarAPila("AO");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
            //else
            //{
            //    StockSingleton.Instance.AgregarAPila("AO");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
        }

        private void GridDetroFechaLimite_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HistorialAsuntosDataGrid ha = new HistorialAsuntosDataGrid();
            ha.init("Asuntos Atendidos Dentro de Fecha");
            StockSingleton.Instance.SelectedItem = ha;
            //AADF = Asuntos Atendidos Dentro Fecha

            //Detiene Cascada de eventos
            if (e.Source.Equals(sender))
                e.Handled = false;
            else
                e.Handled = true;


            //if (!StockSingleton.Instance.DictionaryControl.ContainsKey("AADF"))
            //{
            //    StockSingleton.Instance.DictionaryControl.Add("AADF", ha);
            //    StockSingleton.Instance.AgregarAPila("AADF");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
            //else
            //{
            //    StockSingleton.Instance.AgregarAPila("AADF");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
        }

        private void GridFueraFechaLimite_MouseUp(object sender, MouseButtonEventArgs e)
        {
            HistorialAsuntosDataGrid ha = new HistorialAsuntosDataGrid();
            ha.init("Asuntos Atendidos Fuera de Fecha");
            StockSingleton.Instance.SelectedItem = ha;
            //AAFF = Asuntos Atendidos Fuera Fecha
            //Detiene Cascada de eventos
            if (e.Source.Equals(sender))
                e.Handled = false;
            else
                e.Handled = true;
            //if (!StockSingleton.Instance.DictionaryControl.ContainsKey("AAFF"))
            //{
            //    StockSingleton.Instance.DictionaryControl.Add("AAFF", ha);
            //    StockSingleton.Instance.AgregarAPila("AAFF");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
            //else
            //{
            //    StockSingleton.Instance.AgregarAPila("AAFF");
            //    StockSingleton.Instance.SelectedItem = ha;
            //}
        }
    }
}
