using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessForms.Figures;

namespace ChessForms;
public abstract class AbstractFigure : IFigure
{
    public static readonly int TILESIZE = 32;
    protected int index, x, y;

    public AbstractFigure(int idx, int xx, int yy)
    {
        index = idx;
        x = xx;
        y = yy;
    }

    public abstract void draw(Graphics g);

    public virtual int GetX()
    {
        return x;
    }

    public virtual int getY()
    {
        return y;
    }

    public virtual void moveTo(int xx, int yy)
    {
        x = xx;
        y = yy;
    }

    public IFigure Unbox()
    {
        return this;
    }
}
