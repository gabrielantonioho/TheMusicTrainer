namespace TheMusicTrainer.Models;

public enum ExerciseKind
    {
        IntervalIdentification,
        ScaleIdentification,
        NoteIdentification,
        ChordIdentification,

        IntervalEarTraining,
        NoteEarTraining,
        ChordEarTraining,
        ScalesEarTraining,
        MelodicDictation,

        RhythmTraining
    }

public sealed class ExerciseSelectionMenuItem
    {
        public ExerciseKind Kind { get; }
        public string Title { get; }
        public string Icon { get; }
        public Color AccentColor { get; }

        public ExerciseSelectionMenuItem(ExerciseKind kind, string title, string icon, string accentHex)
        {
            Kind = kind;
            Title = title;
            Icon = icon;
            AccentColor = Color.FromArgb(accentHex);
        }
    }
