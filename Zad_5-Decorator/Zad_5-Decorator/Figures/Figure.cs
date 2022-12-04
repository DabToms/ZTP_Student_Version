using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChessForms.Figures;
public class Figure : AbstractFigure
{
    private readonly Image image = Image.FromFile("C:\\Users\\dabto\\Desktop\\Studia\\ZTP\\ChessForms\\ChessForms\\img\\pieces4.png");

    public Figure(int idx, int xx, int yy) : base(idx, xx, yy)
    {
        index = idx;
        x = xx;
        y = yy;
    }
    public override void draw(Graphics g)
    {
        Rectangle sourceRect = new Rectangle(TILESIZE * index, 0, TILESIZE, TILESIZE);
        g.DrawImage(image, x * TILESIZE, y*TILESIZE, sourceRect, GraphicsUnit.Pixel);
    }
}
