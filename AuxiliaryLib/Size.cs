namespace AuxiliaryLib;

/// <summary>
/// Structure that specifies the size of the object
/// </summary>
public struct Size {
    public double Width { get; set; }
    public double Height { get; set; }

    public Size(double width, double height) {
        Width = width;
        Height = height;
    }
}