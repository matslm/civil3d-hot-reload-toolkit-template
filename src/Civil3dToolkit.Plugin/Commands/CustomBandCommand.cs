namespace Civil3dToolkit.Plugin.Commands;

using Civil3dToolkit.Core.Commands;
using Civil3dToolkit.Core.Interfaces;
using Civil3dToolkit.Core.ViewModels;
using Civil3dToolkit.Plugin.Views;

internal class CustomBandCommand(IServiceProvider serviceProvider, IUserInteractionService ui) : IToolkitCommand
{
    public string CommandName => "TK_CUSTOMBAND";

    public void Execute()
    {
        List<(double X, double Y)> midpoints = [];
        int pairCount = 1;

        ui.WriteMessage("\n>>> Starting Custom Band Command. Press Enter to finish or Esc to cancel.");

        while (true)
        {
            // P1: Allow none (Enter) to finish selection
            var p1 = ui.GetPoint($"\nSelect Point 1 for Pair {pairCount}: ", allowNone: true);
            
            if (p1.Status == InputStatus.Cancel) return; // User pressed ESC
            if (p1.Status == InputStatus.None) break;   // User pressed ENTER -> Proceed to window

            // P2: Must be a point if P1 was selected
            var p2 = ui.GetPoint($"\nSelect Point 2 for Pair {pairCount}: ");
            
            if (p2.Status != InputStatus.Ok) 
            {
                ui.WriteMessage("\nSecond point not selected. Pair discarded.");
                break; 
            }

            // Calculate Midpoint
            double midX = (p1.X + p2.X) / 2.0;
            double midY = (p1.Y + p2.Y) / 2.0;

            midpoints.Add((midX, midY));
            ui.WriteMessage($"\nPair {pairCount} registered. Midpoint: ({midX:F2}, {midY:F2})");
            pairCount++;
        }

        if (midpoints.Count == 0)
        {
            ui.WriteMessage("\nNo pairs selected. Command finished.");
            return;
        }

        // Open the WPF Window and pass the midpoints
        CustomBandWindow window = serviceProvider.GetRequiredService<CustomBandWindow>();
        CustomBandViewModel viewModel = (CustomBandViewModel)window.DataContext;
        viewModel.Midpoints = midpoints;
        viewModel.Initialize();

        Application.ShowModalWindow(window);
    }
}
