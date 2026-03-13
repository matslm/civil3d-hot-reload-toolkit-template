namespace Civil3dToolkit.Core.ViewModels;

using Civil3dToolkit.Core.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class CustomBandViewModel(ICivilService civilService) : ObservableObject
{
    public List<(double X, double Y)> Midpoints { get; set; } = [];

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

    public void Initialize()
    {
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
        catch (Exception)
        {
            // Headless test or error loading
        }
    }

    [RelayCommand]
    private void Execute()
    {
        if (Midpoints.Count == 0)
        {
            CloseAction?.Invoke();
            return;
        }

        string[] texts = string.IsNullOrEmpty(ValuesText) 
            ? [] 
            : ValuesText.Split([Delimiter], StringSplitOptions.None);

        var textList = new List<string>(texts);

        civilService.DrawCustomBandTexts(
            Midpoints, 
            textList, 
            SelectedLayer, 
            SelectedTextStyle,
            TextSize, 
            UseBackgroundMask);

        CloseAction?.Invoke();
    }
}
