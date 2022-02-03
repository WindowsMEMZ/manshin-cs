using System.Drawing;
using System.Windows.Forms;

namespace manshin
{

    /// <summary>
    /// 本项目定制的进度条（灰色）
    /// </summary>
    public class AimProgressBar : ProgressBar
    {
        public AimProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;
            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(Brushes.Gray, 2, 2, rec.Width, rec.Height);
        }
    }
}
