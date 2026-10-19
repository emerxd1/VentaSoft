using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ElipseControlLib
{
    [ProvideProperty("Dummy", typeof(Control))]
    public class ElipseControl : Component
    {
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        [DllImport("Gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);

        private Control control;
        private int cornerRadius = 25;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Control TargetControl
        {
            get { return control; }
            set
            {
                if (control != null)
                {
                    control.SizeChanged -= Control_SizeChanged;
                    control.HandleCreated -= Control_SizeChanged;
                }

                control = value;

                if (control != null)
                {
                    control.SizeChanged += Control_SizeChanged;
                    control.HandleCreated += Control_SizeChanged;
                    ApplyRegion();   // aplica de inmediato
                }
            }
        }

        [DefaultValue(25)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                ApplyRegion();
            }
        }

        private void Control_SizeChanged(object sender, EventArgs e)
        {
            ApplyRegion();
        }

        private void ApplyRegion()
        {
            if (control == null || control.Width <= 0 || control.Height <= 0)
                return;

            IntPtr hRgn = CreateRoundRectRgn(
                0, 0, control.Width, control.Height, cornerRadius, cornerRadius);

            try
            {
                control.Region?.Dispose();
                control.Region = Region.FromHrgn(hRgn);
            }
            finally
            {
                DeleteObject(hRgn);   // libera el handle GDI
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && control != null)
            {
                control.SizeChanged -= Control_SizeChanged;
                control.HandleCreated -= Control_SizeChanged;
            }
            base.Dispose(disposing);
        }
    }
}