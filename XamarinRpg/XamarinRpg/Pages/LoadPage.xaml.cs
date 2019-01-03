using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinRpg
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoadPage : ContentPage
	{
		public LoadPage ()
		{
			InitializeComponent ();
            //debug
            //var DebugList = new List<string>();
            //DebugList.Add("Dummy1");
            //DebugList.Add("Dummy2");
            //DebugList.Add("Dummy3");
            //App.Current.Properties["existing"] = DebugList;
            //debug end

            if (App.Current.Properties.ContainsKey("existing"))
            {
                List<string> ExistingList = App.Current.Properties["existing"] as List<string>;

                foreach (string e in ExistingList)
                {
                    Button btn = new Button { Text = e };
                    LoadLayout.Children.Add(btn);
                }
                
            }
		}
	}
}