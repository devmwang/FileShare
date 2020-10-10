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

namespace ReceivePanel
{
    /// <summary>
    /// Interaction logic for ReceivePanelView.xaml
    /// </summary>
    public partial class ReceivePanelView : UserControl
    {
        public ReceivePanelView()
        {
            InitializeComponent();
        }

        #region Server/Receive Logic
        private void StartServer(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Form Background Text Logic
        // On IP Address Bar enter, set content to empty
        private void FileLocBlockEnter(object sender, EventArgs e)
        {
            if (IPBlock.Text == "File Location")
            {
                IPBlock.Text = "";
            }
        }

        // On IP Address Bar leave, set content to "IP Address"
        private void FileLocBlockLeave(object sender, EventArgs e)
        {
            if (IPBlock.Text.Length == 0)
            {
                IPBlock.Text = "File Location";
            }
        }

        // On Port Bar enter, set content to empty
        private void RPortBlockEnter(object sender, EventArgs e)
        {
            if (PortBlock.Text == "Port")
            {
                PortBlock.Text = "";
            }
        }

        // On Port Bar leave, set content to "Port"
        private void RPortBlockLeave(object sender, EventArgs e)
        {
            if (PortBlock.Text.Length == 0)
            {
                PortBlock.Text = "Port";
            }
        }
        #endregion
    }
}
