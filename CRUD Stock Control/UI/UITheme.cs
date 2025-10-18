using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD_Stock_Control.UI
{
    public static class UITheme
    {
        
        

        public static void ApplyNeonStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 239);
            btn.BackColor = Color.FromArgb(20, 20, 20);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(0, 174, 239);
                btn.ForeColor = Color.Black;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(20, 20, 20);
                btn.ForeColor = Color.White;
            };
        }

        public static void ApplyDangerStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.DarkRed;
            btn.BackColor = Color.FromArgb(60, 0, 0);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.Black;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(60, 0, 0);
                btn.ForeColor = Color.White;
            };
        }

        public static void ApplySuccessStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 239);
            btn.BackColor = Color.FromArgb(20, 20, 20);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(0, 174, 239);
                btn.ForeColor = Color.Black;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(20, 20, 20);
                btn.ForeColor = Color.White;
            };
        }

        public static void ApplyTooltip(Control ctrl, string message)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(ctrl, message);
        }
    }
}
