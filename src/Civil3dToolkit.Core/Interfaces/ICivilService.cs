namespace Civil3dToolkit.Core.Interfaces;

public enum InputStatus
{
    Ok,
    Cancel,
    None
}

/// <summary>
/// Defines the contract for interactions with the Civil 3D / AutoCAD API.
/// Acts as the Domain Abstraction Layer, allowing ViewModels to request CAD actions 
/// without referencing Autodesk DLLs.
/// </summary>
public interface ICivilService
{
    /// <summary>
    /// Retrieves the names of all layers in the current document.
    /// </summary>
    IEnumerable<string> GetDocumentLayers();
    
    /// <summary>
    /// Retrieves the names of all text styles in the current document.
    /// </summary>
    IEnumerable<string> GetDocumentTextStyles();

    /// <summary>
    /// Implementation sample: Draws a closed polyline square.
    /// </summary>
    bool DrawSquare(double x, double y, double side);
    
    /// <summary>
    /// Implementation sample: Draws a sequence of MTEXT entities and groups them.
    /// </summary>
    bool DrawCustomBandTexts(
        List<(double X, double Y)> midpoints, 
        List<string> texts, 
        string layerName, 
        string textStyleName,
        double textSize, 
        bool useMask);
}
