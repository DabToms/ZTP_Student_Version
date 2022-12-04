using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessForms.Figures;

namespace ChessForms.Decorators;
public class MouseDownDecorator : AbstractDecorator
{
    Matrix Mat;
    public MouseDownDecorator(IFigure fig, Matrix mat) : base(fig)
    {  
        Mat = mat;
    }
    public override void draw(Graphics g)
    {
        g.TranslateTransform(ChessboardForms.ZEROX, ChessboardForms.ZEROY);
        g.MultiplyTransform(Mat);
        base.draw(g);
        g.Transform = new Matrix();
    }
}
