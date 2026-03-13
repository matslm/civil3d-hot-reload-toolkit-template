# 02 - Adding a WPF View (MVVM)

Learn how to create a new window using WPF and bind it to a ViewModel using Dependency Injection and the Command Discovery pattern.

---

### Step 1: Create the ViewModel (Core)

In `src/Civil3dToolkit.Core/ViewModels/`, create `CircleViewModel.cs`:

```csharp
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Civil3dToolkit.Core.ViewModels
{
    public partial class CircleViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _radius = 10.0;

        [RelayCommand]
        private void Draw()
        {
            // Logic to draw...
        }
    }
}
```

### Step 2: Create the WPF View (Plugin)

In `src/Civil3dToolkit.Plugin/Views/`, create `CircleWindow.xaml`:

```xml
<Window x:Class="Civil3dToolkit.Plugin.Views.CircleWindow"
        Title="Draw Circle" Height="200" Width="300">
    <StackPanel Margin="20">
        <TextBox Text="{Binding Radius}" />
        <Button Command="{Binding DrawCommand}" Content="Draw!" />
    </StackPanel>
</Window>
```

### Step 3: Configure Dependency Injection (Plugin)

In `src/Civil3dToolkit.Plugin/DiContainer.cs`:

```csharp
services.AddTransient<CircleViewModel>();
services.AddTransient<CircleWindow>();
```

### Step 4: Create the Command Trigger

Create `src/Civil3dToolkit.Plugin/Commands/OpenCircleUiCommand.cs`:

```csharp
public class OpenCircleUiCommand : IToolkitCommand
{
    private readonly IServiceProvider _sp;
    public string CommandName => "TK_CIRCLE_UI";

    public OpenCircleUiCommand(IServiceProvider sp) => _sp = sp;

    public void Execute()
    {
        var win = _sp.GetRequiredService<CircleWindow>();
        Autodesk.AutoCAD.ApplicationServices.Application.ShowModalWindow(win);
    }
}
```

---

## 🏗️ Architectural Benefits
- **Separation of Concerns**: The View knows nothing about the CAD database.
- **Dependency Injection**: ViewModels are injected into Views via constructor injection.
- **Headless Testing**: You can test `CircleViewModel` in the Tests project without launching Civil 3D.
