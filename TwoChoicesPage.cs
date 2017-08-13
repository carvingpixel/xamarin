using System;
using Xamarin.Forms;

namespace ChooseAdventure
{
    // ClASS: CIST2381 Mobile App Development-----------------------------------//
    // A TALE OF TWO BUTTONS - A QUEST BEGINS, OR RATHER ENDS-------------------//
    // APP CREATED BY LOKIN CROOK & I DID NOT COPY OTHER WORK-------------------//
    // FICTIONAL STORY ALSO BY LOKIN CROOK--------------------------------------//
    // Code was created by the techniques and material we covered this semester-//

    // I opted to have fun and be creative and wanted to make a choose your own adventure game like Zork and the old time dos games.--//
    // based on the older zork type dos terminal games, I made the heading and text and responses green as tribute -------------------//
    // SIDENOTE: I wanted to create new pages on clicks with more story text but had too much difficulty and running out of time------//
    // A battle with dice rolls would have been really sweet too.   ------------------------------------------------------------------//

    public class TwoChoicesPage : ContentPage
    {

        //Declare Buttons and StackLayout---------------------
        Button sleepBTN, wakeBTN, quitBTN;
        StackLayout adventureLayout = new StackLayout();

        // The story begins ----------------------------------
        public TwoChoicesPage()  {


            // Label Heading ---------------------------------------------------------------------     
            Label header = new Label
            {
                Text = "Choose Your Own Adventure Game",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Lime,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Margin = new Thickness(0, 10, 5, 5)
            };

            // Label Main Text ----------------------------------------------------------------------------     
            Label bodyText = new Label         {
                Text = "It was a long day being selected for this dangerous quest. " +
                    "Finally, snuggling down for some much-needed sleep you wonder how long it will be before you return home. " +
                    "Nestled in this deep dark forest, you slowly fall into a lulling sleep as the crickets and distant owl serenade you. " +
                    "But suddenly, like a flash of lightening, a forboding presence arrives. " +
                    "A sage in somber robes stands above you and the dying embers of your fire looking up. " +
                    "Jagged black shadows of tall reaching evergreens pierce a sky full of twinkling stars. " +
                    "With a voice like the wind through dry leaves, he whispers \n" +
                    "\"Your search has reached its end, come with me...\" ",
                Margin = new Thickness(20, 10, 15, 15),
                FontAttributes = FontAttributes.Italic,
                TextColor = Color.Lime,            
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Label Choose ---------------------------------------------------------------------     
            Label choose = new Label
            {
                Text = "WHAT WILL YOU CHOOSE?",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Margin = new Thickness(5, 5, 5, 5)
            };




            // sleepButton + shared handler --------------------------------------------------------------------------------
            sleepBTN = new Button
            {
                Text = "Decline, and return to sleep",
                TextColor = Color.Black,
                Margin = new Thickness(20, 0, 20, 0)
            };
            sleepBTN.Clicked += OnButtonClicked;


            // wakeButton + shared handler ---------------------------------------------------------------------------------
            wakeBTN = new Button
            {
                Text = "Wake up and follow him",
                TextColor = Color.Black,
                Margin = new Thickness(20, 0, 20, 0)
            };
            wakeBTN.Clicked += OnButtonClicked;


            // Redo + shared handler ---------------------------------------------------------------------------------
            quitBTN = new Button
            {
                Text = "Clear Choice, Go Back",
                TextColor = Color.Black,
                Margin = new Thickness(20, 0, 20, 0)
            };
            quitBTN.Clicked += OnButtonClicked;


            
            
            // Assemble the page ----------------------------------------------------------------------------
            this.Content = new StackLayout
            {
                BackgroundColor = Color.Black,

                // build stackLayout - Add Children
                Children =
                {
                    // stacklayout ---------------------------------------------------------------------------                
                    new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        Children = { header, bodyText, choose, sleepBTN, wakeBTN, quitBTN }
                    }, 

                    // ScrollView ----------------------------------------------------------------------------                
                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = adventureLayout,
                    }
                } //children
            }; 
                }//stacklayout 





        // Button Handler - Click Events -----------------------------------------------------------------------                
        void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;



            // Back to Sleep -----------------------------------------------------------------------------------          
            if (button == sleepBTN)
            {
               //Add Label to scrollable StackLayout
               adventureLayout.Children.Add
                   (new Label
                   {
                       Text = "As you decline, the jagged blackness creeps in and embraces you in death!",
                       Margin = new Thickness(20, 5, 20, 0),
                       TextColor = Color.Green
                   }
                   );
            }

            

            // Wake up Follow -----------------------------------------------------------------------------------            
            if (button == wakeBTN)
            {
                // Add Label to scrollable StackLayout
                adventureLayout.Children.Add
                    (new Label
                    {
                        Text = "As you follow the sage, you realize, it's to your doom!",
                        Margin = new Thickness(20, 5, 20, 0),
                        TextColor = Color.Green
                    }
                    );
            }

            
            
            // Clear Child Add -----------------------------------------------------------------------------------            
            if (button == quitBTN)
            {
                // Remove Child From StackLayout
                adventureLayout.Children.Clear();
            }


            // WELCOME TO YOUR DEATH AND THANKS FOR PLAYING ------------------------------------------------------
        }
    }
}
