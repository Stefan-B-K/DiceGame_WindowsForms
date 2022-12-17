using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VSP_0463_imd_MyProject
{
    internal static class Utils
    {
        public static Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        public static Color BackColor(Color color) {
            return color == Color.Black ?
               SystemColors.Control :
               Utils.ChangeColorBrightness(color, (float)0.9);
        }
        public static Color ForeColor(Color color)
        {
            return color == Color.Black ?
           SystemColors.ControlText :
           Utils.ChangeColorBrightness(color, (float)-0.3);
        }

        public static Color LightRed = Color.FromArgb(255, 203, 202);


        // ==================   Thread issues   ==================

        delegate void SetEnabledCallback(Control c, bool value);
        public static void SetEnabled(Control control, bool value)
        {
            if (control.InvokeRequired)
            {
                SetEnabledCallback d = new(SetEnabled);
                control.Invoke(d, new object[] {control, value });
            }
            else
            {
                control.Enabled = value;
            }
        }

        delegate void SetVisibleCallback(Control c, bool value);
        public static void SetVisible(Control control, bool value)
        {
            if (control.InvokeRequired)
            {
                SetVisibleCallback d = new(SetVisible);
                control.Invoke(d, new object[] { control, value });
            }
            else
            {
                control.Visible = value;
            }
        }

        // Thread issues 
        delegate void SetTextCallback(Control control, string text);
        public static void SetText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextCallback d = new(SetText);
                control.Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }

        delegate void SetImageCallback(PictureBox control, Bitmap image);
        public static void SetImage(PictureBox control, Bitmap image)
        {
            if (control.InvokeRequired)
            {
                SetImageCallback d = new(SetImage);
                control.Invoke(d, new object[] { control, image });
            }
            else
            {
                control.Image = image;
            }
        }

        delegate void AddControlCallback(Control parent, Control child);
        public static void AddControl(Control parent, Control child)
        {
            if (parent.InvokeRequired)
            {
                AddControlCallback d = new(AddControl);
                parent.Invoke(d, new object[] { parent, child });
            }
            else
            {
                parent.Controls.Add(child);
            }
        }

        delegate void SetLocationCallback(Control c, Point value);
        public static void SetLocation(Control control, Point value)
        {
            if (control.InvokeRequired)
            {
                SetLocationCallback d = new(SetLocation);
                control.Invoke(d, new object[] { control, value });
            }
            else
            {
                control.Location = value;
            }
        }

        delegate void SetBackColorCallback(Control c, Color value);
        public static void SetBackColor(Control control, Color value)
        {
            if (control.InvokeRequired)
            {
                SetBackColorCallback d = new(SetBackColor);
                control.Invoke(d, new object[] { control, value });
            }
            else
            {
                control.BackColor = value;
            }
        }

    }

    
}
