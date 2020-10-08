using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ASCIITableGenerator
{
    interface IApplicationTheme
    {
        string ThemeName { get; }
        Color BackgroundColor { get; }
        Color ForegroundColor{ get; }
        Color ControlBackgroundColor { get; }
        Color ControlForegroundColor { get; }
        Color ButtonBackgroundColor { get; }
        Color ButtonForegroundColor { get; }
    }

    class DarkTheme : IApplicationTheme
    {
        public string ThemeName { get; } = "Dark";
        public Color BackgroundColor { get; } = Color.Black;
        public Color ForegroundColor { get; } = Color.White;
        public Color ControlBackgroundColor { get; } = Color.Gray;
        public Color ControlForegroundColor { get; } = Color.Firebrick;
        public Color ButtonBackgroundColor { get; } = Color.DimGray;
        public Color ButtonForegroundColor { get; } = Color.White;
    }

    class LightTheme : IApplicationTheme
    {
        public string ThemeName { get; } = "Light";
        public Color BackgroundColor { get; } = Color.White;
        public Color ForegroundColor { get; } = Color.Black;
        public Color ControlBackgroundColor { get; } = Color.White;
        public Color ControlForegroundColor { get; } = Color.Black;
        public Color ButtonBackgroundColor { get; } = Color.White;
        public Color ButtonForegroundColor { get; } = Color.Black;
    }

    class GrayTheme : IApplicationTheme
    {
        public string ThemeName { get; } = "Gray";
        public Color BackgroundColor { get; } = Color.LightGray;
        public Color ForegroundColor { get; } = Color.Black;
        public Color ControlBackgroundColor { get; } = Color.Gray;
        public Color ControlForegroundColor { get; } = Color.Black;
        public Color ButtonBackgroundColor { get; } = Color.DimGray;
        public Color ButtonForegroundColor { get; } = Color.Black;
    }

    static class ApplicationThemes
    {
        public static IApplicationTheme DarkTheme { get; } = new DarkTheme();
        public static IApplicationTheme LightTheme { get; } = new LightTheme();
        public static IApplicationTheme GrayTheme { get; } = new GrayTheme();
    }
}
