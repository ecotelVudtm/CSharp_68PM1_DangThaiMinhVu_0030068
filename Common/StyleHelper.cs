using System.Drawing;

namespace QL_SinhVIen.Common
{
    public static class StyleHelper
    {
        public static readonly Color PrimaryBlue = ColorTranslator.FromHtml("#1976D2");
        public static readonly Color PrimaryBlueHover = ColorTranslator.FromHtml("#1565C0");
        
        public static readonly Color SuccessGreen = ColorTranslator.FromHtml("#2E7D32");
        public static readonly Color SuccessGreenHover = ColorTranslator.FromHtml("#1B5E20");
        
        public static readonly Color DangerRed = ColorTranslator.FromHtml("#D32F2F");
        public static readonly Color DangerRedHover = ColorTranslator.FromHtml("#C62828");
        
        public static readonly Color SecondaryGrey = ColorTranslator.FromHtml("#757575");
        public static readonly Color SecondaryGreyHover = ColorTranslator.FromHtml("#616161");
        
        public static readonly Color SearchDark = ColorTranslator.FromHtml("#37474F");
        public static readonly Color SearchDarkHover = ColorTranslator.FromHtml("#263238");
        
        public static readonly Color BackgroundColor = ColorTranslator.FromHtml("#F5F6FA");
        public static readonly Color PanelColor = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color ZebraColor = ColorTranslator.FromHtml("#F9FAFB");
        public static readonly Color SelectionColor = ColorTranslator.FromHtml("#E3F2FD");
        public static readonly Color BorderColor = ColorTranslator.FromHtml("#E0E0E0");
        
        public static readonly Font HeaderFont = new Font("Segoe UI", 12, FontStyle.Bold);
        public static readonly Font DefaultFont = new Font("Segoe UI", 10, FontStyle.Regular);
        public static readonly Font LabelFont = new Font("Segoe UI", 10, FontStyle.Bold);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10, FontStyle.Bold);
        
        public static readonly int InputPanelWidth = 350;
    }
}
