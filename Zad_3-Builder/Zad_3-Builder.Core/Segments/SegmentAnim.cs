using System;
using System.Drawing;

using static System.Net.Mime.MediaTypeNames;

namespace Zad3_builder.Core.Segments;

public class SegmentAnim : Segment
{
    private readonly int[] anim;

    public int frame = 0;

    public SegmentAnim(int x, int y, string file, int[] sequence)
        : base(x, y, file)
    {
        anim = sequence;
    }


    public override void tick()
    {
        frame++;
        while (frame >= anim.Length)
        {
            frame -= anim.Length;
        }
    }

    public override void draw(Graphics g)
    {
        foreach (int i in anim)
        {
            Rectangle sourceRect = new Rectangle(0, (this.Image.Height / this.anim.Length) * i, this.Image.Width, this.Image.Height/this.anim.Length);
            g.DrawImage(this.Image, this.Left, this.Top, sourceRect, GraphicsUnit.Pixel);
        }
    }
}