using System;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

public class Item
{
    public string Id { get; set; }
    public string Content { get; set; }
    public Brush Colour { get; set; }
}

public class Library
{
    private Random random = new Random((int)DateTime.Now.Ticks);
    private Color stringToColour(string value)
    {
        return Color.FromArgb(
            Byte.Parse(value.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
            Byte.Parse(value.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
            Byte.Parse(value.Substring(4, 2), System.Globalization.NumberStyles.HexNumber),
            Byte.Parse(value.Substring(6, 2), System.Globalization.NumberStyles.HexNumber));
    }

    public static Rect getElementRect(FrameworkElement element)
    {
        GeneralTransform buttonTransform = element.TransformToVisual(null);
        Point point = buttonTransform.TransformPoint(new Point());
        return new Rect(point, new Size(element.ActualWidth, element.ActualHeight));
    }

}