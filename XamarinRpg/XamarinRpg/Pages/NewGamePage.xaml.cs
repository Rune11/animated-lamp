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
	public partial class NewGamePage : ContentPage
	{
		public NewGamePage ()
		{
			InitializeComponent ();
		}

        private void StartBtn_Clicked(object sender, EventArgs e)
        {
            string CharacterName = NameEntry.Text;

            if ( null != CharacterName || "" != CharacterName || "name" != CharacterName || "existing" != CharacterName) {
                // name of the current/last used character, it should help in quick loading with "continue game" button
                App.Current.Properties.Add("name", CharacterName);
                System.Diagnostics.Debug.WriteLine("Writning "+ CharacterName +" to -name- field");

                // create new character object
                System.Diagnostics.Debug.WriteLine("Generate new character object and save it to <character name> field");
                Character PlayerChar = new Character(CharacterName);
                // save it -- note: later the <charactername> key should point to a character + gamestate object
                App.Current.Properties[CharacterName] = PlayerChar;


                List<string> ExistingCharacters;
                if (App.Current.Properties.ContainsKey("existing"))
                {
                    System.Diagnostics.Debug.WriteLine("There are other saves");
                    ExistingCharacters = App.Current.Properties["existing"] as List<string>;
                    if (ExistingCharacters.Contains(CharacterName))
                    {
                        System.Diagnostics.Debug.WriteLine("WARNING: a character with this name already exists!");
                        //TODO
                        //Warn the user that he is about to overwrite a saved character
                        DisplayAlert("WARNING", "You are about to overwrite an existing character", "OK");
                        return;
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("There is no other character with that name");
                        ExistingCharacters.Add(CharacterName);
                    }
                }
                else {
                    System.Diagnostics.Debug.WriteLine("There are no other saves. Saving new character");
                    ExistingCharacters = new List<string>();
                    ExistingCharacters.Add(CharacterName);
                }
                App.Current.Properties.Add("existing", ExistingCharacters);
            }

            App.Current.SavePropertiesAsync();
            App.Current.MainPage = new CharacterPage();

        }
    }
}