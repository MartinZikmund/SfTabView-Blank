using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabViewApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabContainer : ContentView
	{
		public TabContainer ()
		{
			InitializeComponent ();
		}
	}
}