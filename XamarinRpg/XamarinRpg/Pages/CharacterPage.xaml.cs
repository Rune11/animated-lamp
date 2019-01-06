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
                Character PlayerCharacter;
                if (App.Current.Properties.ContainsKey(CharacterName))
                {
                    PlayerCharacter = Utils.Serializer.DeserializeFromJson<Character>(App.Current.Properties[CharacterName] as string);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ERROR: <CharacterName> key missing from properties!");
                    return;
                }
                Label NameLabel = new Label { Text = CharacterName };
                CharacterPageLayout.Children.Add(NameLabel);

                Label LevelLabel = new Label { Text = "Level: " + PlayerCharacter.Lvl };
                CharacterPageLayout.Children.Add(LevelLabel);

                Label HealthLabel = new Label { Text = "HP: " + PlayerCharacter.CurrHP + "/" + PlayerCharacter.MaxHP };
                CharacterPageLayout.Children.Add(HealthLabel);

                Label StrengthLabel = new Label { Text = "Strength: " + PlayerCharacter.Str };
                CharacterPageLayout.Children.Add(StrengthLabel);

                Label EnduranceLabel = new Label { Text = "Endurance: " + PlayerCharacter.End};
                CharacterPageLayout.Children.Add(EnduranceLabel);

                Label AgilityLabel = new Label { Text = "Agility: " + PlayerCharacter.Agi};
                CharacterPageLayout.Children.Add(AgilityLabel);

                Label WisdomLabel = new Label { Text = "Wisdom: " + PlayerCharacter.Wis};
                CharacterPageLayout.Children.Add(WisdomLabel);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("ERROR: -name- key missing from properties!");
            }
		}
	}
}