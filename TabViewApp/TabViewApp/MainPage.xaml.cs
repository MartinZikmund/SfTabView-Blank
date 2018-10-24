using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabViewApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void RemoveClicked(object sender, EventArgs e)
        {
            
        }

        private TabContainer _tabContainer = null;

        private void ToggleClicked(object sender, EventArgs e)
        {
            
            if ( _tabContainer == null ) _tabContainer = new TabContainer();

            ContentFrame.Content = ContentFrame.Content is TabContainer ? new ContentView() : _tabContainer;
        }
    }
}
