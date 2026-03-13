namespace Civil3dToolkit.Core.ViewModels;

using Civil3dToolkit.Core.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class CustomBandViewModel(ICivilService civilService, IUserMessageService messageService) : ObservableObject
{
    private List<(double X, double Y)> _midpoints = [];

    [ObservableProperty]
    private string _valuesText = "";

    [ObservableProperty]
    private string _delimiter = ";";

    [ObservableProperty]
    private double _textSize = 1.0;

    [ObservableProperty]
    private bool _useBackgroundMask = false;

    [ObservableProperty]
    private ObservableCollection<string> _availableLayers = [];

    [ObservableProperty]
    private string _selectedLayer = "0";

    [ObservableProperty]
    private ObservableCollection<string> _availableTextStyles = [];

    [ObservableProperty]
    private string _selectedTextStyle = "Standard";

    public Action? CloseAction { get; set; }

    public void Initialize(IEnumerable<(double X, double Y)> midpoints)
    {
        _midpoints = new List<(double X, double Y)>(midpoints);
        LoadDocumentData();
    }

    private void LoadDocumentData()
    {
        try
        {
            var layers = civilService.GetDocumentLayers();
            foreach (var layer in layers)
            {
                AvailableLayers.Add(layer);
            }

            var textStyles = civilService.GetDocumentTextStyles();
            foreach (var style in textStyles)
            {
                AvailableTextStyles.Add(style);
            }
        }
        catch (Exception ex)
        {
            messageService.ShowError("Data Load Error", "Failed to load layers or text styles from AutoCAD.", ex);
        }
    }

    [RelayCommand]
    private void Execute()
    {
        if (_midpoints.Count == 0)
        {
            CloseAction?.Invoke();
            return;
        }

        string[] texts = string.IsNullOrEmpty(ValuesText) 
            ? [] 
            : ValuesText.Split([Delimiter], StringSplitOptions.None);

        var textList = new List<string>(texts);

        bool success = civilService.DrawCustomBandTexts(
            _midpoints, 
            textList, 
            SelectedLayer, 
            SelectedTextStyle,
            TextSize, 
            UseBackgroundMask);

        if (!success)
        {
            messageService.ShowError("Execution Error", "Failed to create texts in AutoCAD.");
        }

        CloseAction?.Invoke();
    }
}
