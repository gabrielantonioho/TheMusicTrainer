using TheMusicTrainer.Views;

namespace TheMusicTrainer;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ExerciseSettingsPage), typeof(ExerciseSettingsPage));

	}
}
