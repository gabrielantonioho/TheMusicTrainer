namespace TheMusicTrainer.Views;

public partial class ExerciseSettingsPage : ContentPage, IQueryAttributable
{
    public ExerciseSettingsPage()
    {
        InitializeComponent();
    }

    private string _selectedLength = "Medium";

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        // These keys must match what you pass from the ViewModel
        if (query.TryGetValue("ExerciseName", out var nameObj))
            ExerciseNameLabel.Text = nameObj?.ToString();

        if (query.TryGetValue("ExerciseDescription", out var descObj))
            ExerciseDescriptionLabel.Text = descObj?.ToString();
    }

    private void OnQuestionLengthChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton rb && e.Value)
        {
            _selectedLength = rb.Content?.ToString() ?? "Medium";
        }
    }

    private async void OnStartExerciseClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Starting Exercise", $"Length: {_selectedLength}", "OK");
    }
}
