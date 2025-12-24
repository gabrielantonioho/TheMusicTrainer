using TheMusicTrainer.ViewModels;

namespace TheMusicTrainer.Views;

public partial class ExerciseSelectionPage : ContentPage
{
    public ExerciseSelectionPage()
    {
        InitializeComponent();
		BindingContext = new ExerciseSelectionMenuViewModel();
    }

}
