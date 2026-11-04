using System;
using System.Globalization;
using System.Text;

namespace Main.Utilities
{
    // ignora tildes y mayusculas
    public static class TextoUtil
    {
        // Convierte "Café", "CAFÉ" y "cafe" en el mismo texto: "CAFE" todo en mayuscula muy util para buscar
        public static string Normalizar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return string.Empty;

            // Descompone cada letra con tilde: "é" pasa a ser "e" + el acento suelto
            string descompuesto = texto.Normalize(NormalizationForm.FormD);

            var sb = new StringBuilder(descompuesto.Length);
            foreach (char c in descompuesto)
            {
                // Se descarta solo el acento suelto y se conserva la letra
                if (CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark) continue;

                sb.Append(c);
            }

            // Se vuelve a componer y se pasa a mayúsculas sin depender del idioma del equipo
            return sb.ToString().Normalize(NormalizationForm.FormC).Trim().ToUpperInvariant();
        }
    }
}
