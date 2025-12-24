using System.Collections.ObjectModel;
using System.Windows.Input;
using TheMusicTrainer.Models;

namespace TheMusicTrainer.ViewModels;

public sealed class ExerciseSelectionMenuViewModel
{
    public ObservableCollection<ExerciseSelectionMenuGroup> Groups { get; } = new();

    public ICommand SelectExerciseCommand { get; }

    public ExerciseSelectionMenuViewModel()
    {
        SelectExerciseCommand = new Command<ExerciseSelectionMenuItem>(async item =>
            {
                if (item is null) return;

                await Shell.Current.GoToAsync(nameof(Views.ExerciseSettingsPage), new Dictionary<string, object>
                {
                    ["ExerciseName"] = item.Title,
                    ["ExerciseDescription"] = GetDescription(item.Kind)
                });
            });

        BuildMenu();
    }

    private static string GetDescription(ExerciseKind kind) => kind switch
        {
            ExerciseKind.IntervalIdentification => "Identify the interval between two notes.",
            ExerciseKind.ScaleIdentification    => "Identify the scale shown",
            ExerciseKind.NoteIdentification     => "Identify the note shown on the staff.",
            ExerciseKind.ChordIdentification    => "Identify the chord quality/type.",

            ExerciseKind.IntervalEarTraining    => "Listen and identify the interval.",
            ExerciseKind.NoteEarTraining        => "Listen and identify the note.",
            ExerciseKind.ChordEarTraining       => "Listen and identify the chord.",
            ExerciseKind.ScalesEarTraining      => "Listen and identify the scale.",
            ExerciseKind.MelodicDictation       => "Listen and reproduce/identify the melody.",

            ExerciseKind.RhythmTraining         => "Tap or identify rhythms accurately.",

            _ => ""
        };


    private void BuildMenu()
    {
        Groups.Add(new ExerciseSelectionMenuGroup( new[]
        {
            new ExerciseSelectionMenuItem(ExerciseKind.IntervalIdentification, "Interval Identification", "icon_interval.png", "#0000FF"),
            new ExerciseSelectionMenuItem(ExerciseKind.ScaleIdentification,    "Scale Identification",    "icon_scale.png",    "#0000FF"),
            new ExerciseSelectionMenuItem(ExerciseKind.NoteIdentification,     "Note Identification",     "icon_note.png",     "#0000FF"),
            new ExerciseSelectionMenuItem(ExerciseKind.ChordIdentification,    "Chord Identification",    "icon_chord.png",    "#0000FF"),
        }));

        Groups.Add(new ExerciseSelectionMenuGroup( new[]
        {
            new ExerciseSelectionMenuItem(ExerciseKind.IntervalEarTraining, "Interval Ear Training", "icon_ear_interval.png", "#800080"),
            new ExerciseSelectionMenuItem(ExerciseKind.NoteEarTraining,     "Note Ear Training",     "icon_ear_note.png",     "#800080"),
            new ExerciseSelectionMenuItem(ExerciseKind.ChordEarTraining,    "Chord Ear Training",    "icon_ear_chord.png",    "#800080"),
            new ExerciseSelectionMenuItem(ExerciseKind.ScalesEarTraining,   "Scales Ear Training",   "icon_ear_scale.png",    "#800080"),
            new ExerciseSelectionMenuItem(ExerciseKind.MelodicDictation,    "Melodic Dictation",     "icon_melodic.png",      "#800080"),
        }));

        Groups.Add(new ExerciseSelectionMenuGroup( new[]
        {
            new ExerciseSelectionMenuItem(ExerciseKind.RhythmTraining, "Rhythm Training", "icon_rhythm.png", "#FF0000"),
        }));
    }
}
