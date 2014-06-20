﻿using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using LuceneSearchLibrary.Model;

namespace LuceneSearchClient.Views
{

    public partial class AllPagesView : Page
    {    
        public AllPagesView()
        {
            InitializeComponent();
        }
        private void OnLoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex();
        }    
    }
}