using System.Globalization;
using Main;

namespace VentaSoft
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var es = new CultureInfo("es-ES");
            CultureInfo.DefaultThreadCurrentCulture = es;
            CultureInfo.DefaultThreadCurrentUICulture = es;

            // Primero el proveedor, luego el idioma
            AntdUI.Localization.Provider = new LocalizadorEs();
            AntdUI.Localization.SetLanguage("es-ES");

            Application.Run(new LoginM());
        }
    }

    public class LocalizadorEs : AntdUI.ILocalization
    {
        public string? GetLocalizedString(string key)
        {
            switch (key)
            {
                case "ToDay": return "Hoy";
                case "Now": return "Ahora";
                case "OK": return "Aceptar";

                case "YearFormat": return "yyyy";
                case "MonthFormat": return "MMM";

                case "Mon": return "Lun";
                case "Tue": return "Mar";
                case "Wed": return "Mié";
                case "Thu": return "Jue";
                case "Fri": return "Vie";
                case "Sat": return "Sáb";
                case "Sun": return "Dom";

                default: return null; // el resto queda como estaba
            }
        }
    }
}
    