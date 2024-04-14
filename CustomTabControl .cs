using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

public class CustomTabControl : TabControl
{
    public CustomTabControl()
    {
        // 设置为false以通过OnDrawItem绘制TabPages
        this.DrawMode = TabDrawMode.OwnerDrawFixed;
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        // 获取当前TabPage
        TabPage page = base.TabPages[e.Index];

        // 设置绘制样式
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // 填充背景
        using (Brush br = new SolidBrush(page.BackColor))
        {
            e.Graphics.FillRectangle(br, e.Bounds);
        }

        // 绘制边框
        // e.Graphics.DrawRectangle(new Pen(Color.Black), e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);

        // 设置TabText的布局
        StringFormat sf = new StringFormat();
        sf.Alignment = StringAlignment.Center;
        sf.LineAlignment = StringAlignment.Center;

        // 绘制文本
        using (Brush br = new SolidBrush(page.ForeColor))
        {
            e.Graphics.DrawString(page.Text, this.Font, br, e.Bounds, sf);
        }

        // 如果需要，可以绘制更多的装饰，例如：
        // e.Graphics.DrawLine(new Pen(Color.Black), e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right - 1, e.Bounds.Bottom - 1);

        // 默认TabControl不会绘制焦点轮廓，如果需要可以手动绘制
        if (base.Focused)
        {
            Rectangle focusRect = new Rectangle(e.Bounds.Left, e.Bounds.Top, e.Bounds.Width - 1, e.Bounds.Height - 1);
            //e.Graphics.DrawFocusRectangle(new Pen(Color.Black), focusRect);
        }
    }
}