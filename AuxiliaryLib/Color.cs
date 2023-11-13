using System.Globalization;

namespace AuxiliaryLib;

/// <summary>
/// Color in byte values.
/// </summary>
public struct Color {
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }
    public byte A { get; set; }

    public Color(byte r, byte g, byte b, byte a = 255) {
        R = r;
        G = g;
        B = b;
        A = a;
    }

    public Color(string hex) {
        if (!hex.StartsWith("#")) {
            this = Empty;
        } else {
            hex = hex[1..];
        }

        if (hex.Length != 6 && hex.Length != 8) {
            this = Empty;
        }

        byte red = byte.Parse(hex[..2], NumberStyles.HexNumber);
        byte green = byte.Parse(hex[2..4], NumberStyles.HexNumber);
        byte blue = byte.Parse(hex[4..6], NumberStyles.HexNumber);

        byte alpha = 255;
        if (hex.Length == 8) {
            alpha = byte.Parse(hex[6..8], NumberStyles.HexNumber);
        }

        this = new Color(red, green, blue, alpha);
    }

    public static readonly Color Empty;

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Gray { get; } = new Color(127, 127, 127);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Green { get; } = new Color(0, 255, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Cyan { get; } = new Color(0, 255, 255);
    public static Color Magenta { get; } = new Color(255, 0, 255);
}