namespace Civil3dToolkit.Core.Interfaces;

public interface IUserInteractionService
{
    void WriteMessage(string message);
    (InputStatus Status, double X, double Y) GetPoint(string promptMessage, bool allowNone = false);
    (InputStatus Status, double Value) GetDouble(string promptMessage, double defaultValue, bool allowZero = false, bool allowNegative = false);
    
    // List<(double X, double Y)> GetMultiplePoints(string promptMessage);
}
