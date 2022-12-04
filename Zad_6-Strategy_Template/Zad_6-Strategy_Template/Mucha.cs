using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6_Strategy_Template;

internal class Mucha
{
    private readonly double k = 0.01;
    int x, y; // pozycja muchy
    int vx, vy; // predkosc muchy

    public Mucha()
    {
        var rand = new Random();
        x = rand.Next() % 600;
        y = rand.Next() % 600;
        vx = rand.Next() % 6;
        vy = rand.Next() % 6;
    }

    public void draw(Graphics g)
    {
        g.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(x, y, 5, 5));
    }

    public void move()
    {
        x += vx;
        y += vy;
        if (x < 0) { x += vx; vx = -vx; }
        if (x > 480) { x -= vx; vx = -vx; }
        if (y < 0) { y += vy; vy = -vy; }
        if (y > 480) { y -= vy; vy = -vy; }
    }
}
