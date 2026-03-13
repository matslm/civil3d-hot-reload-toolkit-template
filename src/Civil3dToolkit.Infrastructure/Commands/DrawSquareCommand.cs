namespace Civil3dToolkit.Infrastructure.Commands;

using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Core.Interfaces;
using Civil3dToolkit.Shared;

/// <summary>
/// Implementation sample: A simple command that interacts with the editor 
/// and calls a service to modify the database.
/// </summary>
[ToolkitCommand(ToolkitCommands.DrawSquare)]
internal class DrawSquareCommand(IUserInteractionService ui, ICivilService civilService) : IToolkitCommand
{
    public void Execute()
    {
        // 1. Get user input via the abstract UI service (Headless-friendly!)
        var ptResult = ui.GetPoint("Pick the bottom-left corner of the square: ");
        if (ptResult.Status != InputStatus.Ok) return;

        var sideResult = ui.GetDouble("Enter the side length: ", 5.0);
        if (sideResult.Status != InputStatus.Ok) return;

        // 2. Call the infrastructure logic via the service
        bool success = civilService.DrawSquare(ptResult.X, ptResult.Y, sideResult.Value);

        if (success)
        {
            ui.WriteMessage("Square created successfully!");
        }
    }
}
