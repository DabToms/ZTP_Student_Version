using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessForms.Figures;

namespace ChessForms.Decorators;
public class TransformatedDecorator : AbstractDecorator
{
    public TransformatedDecorator(IFigure fig) : base(fig)
    {
    }
    public override void draw(Graphics g)
    {
        g.Transform = new Matrix();
        g.TranslateTransform(ChessboardForms.ZEROX,ChessboardForms.ZEROY);
        base.draw(g);
    }
}
