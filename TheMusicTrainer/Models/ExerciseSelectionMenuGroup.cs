using System.Collections.ObjectModel;

namespace TheMusicTrainer.Models;

public sealed class ExerciseSelectionMenuGroup
{
    public ObservableCollection<ExerciseSelectionMenuItem> Items { get; }

    public ExerciseSelectionMenuGroup(IEnumerable<ExerciseSelectionMenuItem> items)
    {
        Items = new ObservableCollection<ExerciseSelectionMenuItem>(items);
    }
}