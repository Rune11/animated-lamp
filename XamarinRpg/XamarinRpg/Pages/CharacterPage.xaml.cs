using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinRpg.Model;

namespace XamarinRpg
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CharacterPage : ContentPage
	{
		public CharacterPage ()
		{
			InitializeComponent ();
            if (App.Current.Properties.ContainsKey("name"))
            {
                string CharacterName = App.Current.Properties["name"] as string;
                if (App.Current.Properties.ContainsKey(CharacterName))
                {
                    Character PlayerCharacter = Utils.Serializer.DeserializeFromJson<Character>(App.Current.Properties[CharacterName] as string);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR: <CharacterName> key missing from properties!");
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("ERROR: -name- key missing from properties!");
            }
		}
	}
}