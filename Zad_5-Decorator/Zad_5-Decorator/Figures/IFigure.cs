using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessForms.Figures;
public interface IFigure
{
    void draw(Graphics g);

    int GetX();

    int getY();

    void moveTo(int xx, int yy);

    IFigure Unbox();
}
