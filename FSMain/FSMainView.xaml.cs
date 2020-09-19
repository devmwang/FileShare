﻿// Using System
using System;
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

namespace FSMain
{
    /// <summary>
    /// Interaction logic for FSMainView.xaml
    /// </summary>
    public partial class FSMainView : UserControl
    {
        public FSMainView()
        {
            InitializeComponent();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            tt_send.Visibility = Visibility.Visible;
            tt_receive.Visibility = Visibility.Visible;
            tt_settings.Visibility = Visibility.Visible;

        }
    }
}
