namespace Main.Utilities
{
    // escala proporcionalmente los controles y la letra respecto a su tamaño de diseño
    public class EscaladoProporcional
    {
        private readonly Form _form;
        private readonly Size _tamOriginal;
        private readonly Dictionary<Control, (Rectangle Bounds, bool AutoSize)> _originales = new();
        private readonly Dictionary<Control, Font> _fontsOriginales = new();
        private readonly Dictionary<Control, Font> _fontsCreadas = new();
        private readonly Dictionary<Control, int> _simbolosOriginales = new();
        private float _ultimoFactorLetra = 1f;

        public EscaladoProporcional(Form form)
        {
            _form = form;
            _tamOriginal = form.ClientSize;
            Guardar(form);
            form.AutoScroll = false; // sin barras que empujen el contenido para que no se empujen los unos con los otros
            form.Resize += (s, e) => Escalar();
        }

        private void Guardar(Control padre)
        {
            foreach (Control c in padre.Controls)
            {
                bool esContenedor = c is Panel || c is GroupBox
                                 || c is Sunny.UI.UIGroupBox || c is Sunny.UI.UIPanel;

                bool autoSize = c is Label l && l.AutoSize; 
                _originales[c] = (c.Bounds, autoSize);

                if (c is not DataGridView) _fontsOriginales[c] = c.Font;
                if (c is Sunny.UI.UISymbolButton sb) _simbolosOriginales[c] = sb.SymbolSize;

                c.Dock = DockStyle.None;
                c.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                if (esContenedor) Guardar(c);
            }
        }

        public void Escalar()
        {
            if (_tamOriginal.Width == 0 || _tamOriginal.Height == 0) return;

            float sx = Math.Max(1f, (float)_form.ClientSize.Width / _tamOriginal.Width);
            float sy = Math.Max(1f, (float)_form.ClientSize.Height / _tamOriginal.Height);

            // la letra crece mas despacio que el layout dec 85 porciento asi siempre cabe en su caja
            float crecimiento = Math.Min(sx, sy); // NUEVO
            float sl = Math.Min(1.8f, 1f + (crecimiento - 1f) * 0.85f);
            bool cambiarLetra = Math.Abs(sl - _ultimoFactorLetra) >= 0.02f;

            _form.SuspendLayout();
            foreach (var par in _originales)
            {
                Rectangle r = par.Value.Bounds;

                // todo crece en ancho y alto las etiquetas AutoSize solo cambian de posición
                if (par.Value.AutoSize)
                    par.Key.Location = new Point((int)(r.X * sx), (int)(r.Y * sy));
                else 
                    par.Key.Bounds = new Rectangle((int)(r.X * sx), (int)(r.Y * sy), (int)(r.Width * sx), (int)(r.Height * sy));

                if (cambiarLetra && _fontsOriginales.TryGetValue(par.Key, out Font fo))
                {
                    Font nueva = new Font(fo.FontFamily, fo.Size * sl, fo.Style, fo.Unit);
                    par.Key.Font = nueva;
                    if (_fontsCreadas.TryGetValue(par.Key, out Font vieja)) vieja.Dispose();
                    _fontsCreadas[par.Key] = nueva;
                }

                // el icono de los botones tambien crece
                if (cambiarLetra && par.Key is Sunny.UI.UISymbolButton btn
                    && _simbolosOriginales.TryGetValue(par.Key, out int tam))
                    btn.SymbolSize = (int)(tam * sl);
            }
            if (cambiarLetra) _ultimoFactorLetra = sl;
            _form.ResumeLayout(true);
        }
    }
}