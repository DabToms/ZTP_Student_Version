using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8_Iterator;
internal class TileThread
{
    private Tiles form;
    private int x;
    private int y;
    public TileThread(Tiles form, int x, int y)
    {
        this.form=form;
        this.x=x;
        this.y=y;
    }
    public void Runnable()
    {
        for (int i = y; i< form.matrix.Length; i++)
        {
            int j;
            if (i == y)
            {
                j=x;
            }
            else
            {
                j=0;
            }
            for (; j< form.matrix[0].Length; j++)
            {
                form.matrix[i][j].Flip();
                //this.Paint();
                try
                {
                    Thread.Sleep(100); // tutaj powinno być current thread
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}
