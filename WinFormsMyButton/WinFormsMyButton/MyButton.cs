using System.Drawing;
using System.Windows.Forms;

namespace WinFormsMyButton
{
    class MyButton : Button
    {
        int paints = 0;
        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            paints++;
            //base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(SystemBrushes.Control, ClientRectangle);
            pevent.Graphics.FillEllipse(Brushes.Pink, ClientRectangle);

            if (this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
                pevent.Graphics.DrawEllipse(new Pen(Brushes.HotPink, 6), ClientRectangle);

            var sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            pevent.Graphics.DrawString($"Paints: {paints}", SystemFonts.DefaultFont, Brushes.Black, ClientRectangle, sf);
        }
    }
}
