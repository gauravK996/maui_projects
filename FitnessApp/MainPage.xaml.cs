namespace FitnessApp
{
    public partial class MainPage : ContentPage
    {
        int totalSteps = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnLogStepsClicked(object sender, EventArgs e)
        {
            if (int.TryParse(StepsEntry.Text, out int steps))
            {
                totalSteps += steps;
                StepsLabel.Text = $"{totalSteps} steps";
                StepsEntry.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter a valid number of steps.", "OK");
            }
        }

    }

}
