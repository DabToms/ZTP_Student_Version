using System.Drawing;
using System.Text.Json.Serialization;

using Zad3_builder.Core.Segments;

namespace Zad3_builder.Core;
public class Sprite : PictureBox
{
    private int[] anim = { 0, 1, 2, 1 };
    private int frame = 2; // klatka animacji
    private bool mirror = false; // postac patrzy w lewo/ prawo
    private int moving = 0; // ruch w poziomie
    private int jumping = 0; // ruch w pionie
    private readonly List<Segment> plansza;

    public Sprite(List<Segment> pl, string imageName)
    {
        plansza = pl;
        this.Image = Image.FromFile(imageName);
        this.Left = 150;
        this.Top = 0;
        /*int h = 27;
        int w = 16;
        this.Size = new Size(h,w);*/
        this.Size = new Size(Image.Width, Image.Height);
    }

    public int GetX() => this.Left;

    public int GetY() => this.Top;

    public int getBottomY() => this.Top + this.Image.Height;

    public void Jump()
    {
        // poruszanie postacia
        if (jumping == 0)
        {
            jumping = 10;
        }
    }

    public bool IsJumping() => jumping > 0;

    public bool IsJumpingDown() => jumping < 0;

    public void StopJumping() => jumping = 0;

    public void StopMoving() => moving = 0;


    public void MoveLeft()
    {
        moving = -3;
        mirror = false;
    }

    public void MoveRight()
    {
        moving = 3;
        mirror = true;
    }

    public void Stop()
    {
        moving = 0;
        frame = 2;
    }

    private bool canGo(int dx, int dy)
    {
        foreach (var s in plansza)
        {
            if (s.getBounds().IntersectsWith(new Rectangle(this.Left + dx, this.Top + dy, this.Image.Width, this.Image.Height)))
            {
                return false;
            }
        }
        return true;
    }

    private void collide(int dx, int dy)
    {
        foreach (var s in plansza)
        {
            if (s.getBounds().IntersectsWith(new Rectangle(this.Left + dx, this.Top + dy, this.Image.Width, this.Image.Height)))
            {
                if (dx != 0)
                {
                    s.collisionH(this);
                }
                if (dy != 0)
                {
                    s.collisionV(this);
                }
            }
        }
    }

    public void tick()
    {
        if (moving != 0)
        {
            // animacja ruchu
            frame++;
            while (frame >= anim.Length)
            {
                frame -= anim.Length;
            }
        }

        // przesuniecie w poziomie
        for (int i = 0; i < Math.Abs(moving); ++i)
        {
            collide((int)Math.Sign(moving), 0);
            this.Left += (int)Math.Sign(moving);
        }

        // przesuniecie w pionie
        for (int i = 0; i < Math.Abs(jumping); ++i)
        {
            collide(0, -(int)Math.Sign(jumping));
            this.Top -= (int)Math.Sign(jumping);
        }

        // czy mamy grunt pod nogami?
        jumping--;
        collide(0, 1);
        if (jumping != 0)
        {
            frame = 0;
        }
        if (jumping == 0 && moving == 0)
        {
            frame = 2;
        }
    }

    public void draw(Graphics g)
    {
        var bitMap = new Bitmap(this.Image);
        foreach (int i in anim)
        {
            var rectangel = new Rectangle((this.Image.Width / this.anim.Length) * i, 0, this.Image.Width / this.anim.Length, this.Image.Height );
            var cloneBitmap = bitMap.Clone(rectangel, bitMap.PixelFormat);

            g.DrawImage(cloneBitmap, new Point(this.Left + (mirror ? this.Image.Width : 0), this.Top));// x + (mirror ? W : 0), y, x + (mirror ? 0 : W), y + H, anim[frame] * W, 0, anim[frame] * W + W, H, null);
        }
    }
}
