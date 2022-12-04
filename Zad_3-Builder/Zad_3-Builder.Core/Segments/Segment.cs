using System;
using System.Drawing;

using static System.Net.Mime.MediaTypeNames;

namespace Zad3_builder.Core.Segments;
public class Segment: PictureBox
{
    public Segment(int x, int y, string file)
    {
        this.Left = x;
        this.Top = y;
        this.Image = System.Drawing.Image.FromFile(file);
        this.Size = new Size(this.Image.Width, this.Image.Height);
    }

    public Rectangle getBounds()
    {
        return new Rectangle(this.Left, this.Top, this.Size.Width, this.Size.Height);
    }

    public virtual void draw(Graphics g)
    {
        g.DrawImage(this.Image,new Point(this.Left,this.Top));
    }

    public virtual void tick()
    {
    }

    public virtual void collisionV(Sprite sprite)
    {
    }

    public virtual void collisionH(Sprite sprite)
    {
    }
}
