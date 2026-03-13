namespace Civil3dToolkit.Infrastructure.Services;

using Civil3dToolkit.Core.Interfaces;

internal class AutoCadInteractionService : IUserInteractionService
{
    private Editor? Editor => Application.DocumentManager.MdiActiveDocument?.Editor;

    public void WriteMessage(string message)
    {
        Editor?.WriteMessage($"\n{message}");
    }

    public (InputStatus Status, double X, double Y) GetPoint(string promptMessage, bool allowNone = false)
    {
        if (Editor == null) return (InputStatus.Cancel, 0, 0);

        PromptPointOptions options = new($"\n{promptMessage}")
        {
            AllowNone = allowNone
        };
        PromptPointResult result = Editor.GetPoint(options);

        if (result.Status == PromptStatus.OK)
            return (InputStatus.Ok, result.Value.X, result.Value.Y);
        
        if (result.Status == PromptStatus.None)
            return (InputStatus.None, 0, 0);

        return (InputStatus.Cancel, 0, 0);
    }

    public (InputStatus Status, double Value) GetDouble(string promptMessage, double defaultValue, bool allowZero = false, bool allowNegative = false)
    {
        if (Editor == null) return (InputStatus.Cancel, 0);

        PromptDoubleOptions options = new($"\n{promptMessage}")
        {
            AllowZero = allowZero,
            AllowNegative = allowNegative,
            DefaultValue = defaultValue
        };

        PromptDoubleResult result = Editor.GetDouble(options);

        if (result.Status == PromptStatus.OK)
            return (InputStatus.Ok, result.Value);

        if (result.Status == PromptStatus.None)
            return (InputStatus.None, defaultValue);

        return (InputStatus.Cancel, 0);
    }

    public List<(double X, double Y)> GetMultiplePoints(string promptMessage)
    {
        List<(double X, double Y)> points = [];
        if (Editor == null) return points;

        PromptPointOptions options = new($"\n{promptMessage}")
        {
            AllowNone = true
        };

        while (true)
        {
            PromptPointResult result = Editor.GetPoint(options);

            if (result.Status == PromptStatus.OK)
            {
                points.Add((result.Value.X, result.Value.Y));
                WriteMessage($"Point {points.Count} registered.");
            }
            else if (result.Status == PromptStatus.None)
            {
                break;
            }
            else
            {
                WriteMessage("Command cancelled.");
                return []; // Return empty list if canceled
            }
        }

        return points;
    }
}
