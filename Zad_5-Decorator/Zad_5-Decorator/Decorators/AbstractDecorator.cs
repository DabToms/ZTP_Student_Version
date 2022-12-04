using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessForms.Figures;

namespace ChessForms.Decorators;
public class AbstractDecorator : IFigure
{
    private IFigure Figure;
    public AbstractDecorator(IFigure fig)
    {
        Figure = fig;
    }

    public virtual void draw(Graphics g)
    {
        Figure.draw(g);
    }

    public virtual int GetX()
    {
        return Figure.GetX();
    }

    public virtual int getY()
    {
        return Figure.GetX();
    }

    public virtual void moveTo(int xx, int yy)
    {
        Figure.moveTo(xx, yy);
    }

    public virtual IFigure Unbox()
    {
        return Figure.Unbox();
    }
}
