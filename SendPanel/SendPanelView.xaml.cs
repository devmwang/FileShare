// Using System
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
using System.Xml;

namespace SendPanel
{
    /// <summary>
    /// Interaction logic for SendPanelView.xaml
    /// </summary>
    public partial class SendPanelView : UserControl
    {
        public SendPanelView()
        {
            InitializeComponent();
        }

        // FORM EVENT MAGIC CRAP
        // On IP Address Bar enter, set content to empty
        private void IPBlockEnter(object sender, EventArgs e)
        {
            if (IPBlock.Text == "IP Address")
            {
                IPBlock.Text = "";
            }
        }

        // On IP Address Bar leave, set content to "IP Address"
        private void IPBlockLeave(object sender, EventArgs e)
        {
            if (IPBlock.Text.Length == 0)
            {
                IPBlock.Text = "IP Address";
            }
        }

        // On Port Bar enter, set content to empty
        private void PortBlockEnter(object sender, EventArgs e)
        {
            if (PortBlock.Text == "Port")
            {
                PortBlock.Text = "";
            }
        }

        // On Port Bar leave, set content to "Port"
        private void PortBlockLeave(object sender, EventArgs e)
        {
            if (PortBlock.Text.Length == 0)
            {
                PortBlock.Text = "Port";
            }
        }

        // On IP Address Bar enter, set content to empty
        private void BufferBlockEnter(object sender, EventArgs e)
        {
            if (BufferBlock.Text == "Buffer Size")
            {
                BufferBlock.Text = "";
            }
        }

        // On IP Address Bar leave, set content to "IP Address"
        private void BufferBlockLeave(object sender, EventArgs e)
        {
            if (BufferBlock.Text.Length == 0)
            {
                BufferBlock.Text = "Buffer Size";
            }
        }

    }
}
