using System.ComponentModel;
using System.Threading.Tasks;

namespace Zad_8_Iterator;

/// <summary>
/// Klasa odpowieddzialna za formularz kafelków.
/// </summary>
public partial class Tiles : Form
{
    /// <summary>
    /// Macierz kafelków.
    /// </summary>
    public Tile[][] matrix;

    /// <summary>
    /// Rozmiar kafelka.
    /// </summary>
    private int tileSize;

    /// <summary>
    /// Kafelek pordœwietlony mysz¹.
    /// </summary>
    private int hx = -1, hy = -1;

    /// <summary>
    /// KOnstuktor klasy Tiles.
    /// </summary>
    /// <param name="cols"></param>
    /// <param name="rows"></param>
    /// <param name="tileSize"></param>
    public Tiles(int cols, int rows, int tileSize)
    {
        this.InitializeComponent();
        this.MatrixInit(cols, rows, tileSize);
    }

    /// <summary>
    /// Inicjalizacja macierzy kafelków.
    /// </summary>
    /// <param name="cols"></param>
    /// <param name="rows"></param>
    /// <param name="tileSize"></param>
    private void MatrixInit(int cols, int rows, int tileSize)
    {
        this.Size = new Size(cols* tileSize, rows*tileSize);
        this.tileSize = tileSize;
        this.matrix = new Tile[rows][];

        for (int i = 0; i< rows; i++)
        {
            this.matrix[i] = new Tile[cols];
        }

        for (int i = 0; i< rows; i++)
        {
            for (int j = 0; j< cols; j++)
            {
                this.matrix[i][j] = new Tile();
            }
        }
    }

    private void PaintEvt(object sender, PaintEventArgs e)
    {
        var g = e.Graphics;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                var rec = new Rectangle(j * tileSize, i * tileSize + 1, tileSize - 1, tileSize - 1);
                if (i == hy && j == hx)
                {
                    g.FillRectangle(new SolidBrush(ControlPaint.Light(matrix[i][j].Color, 1.2f)), rec);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(matrix[i][j].Color), rec);
                }
            }
        }
    }

    private void MouseMoveEvt(object sender, MouseEventArgs e)
    {
        this.hx = e.X / tileSize;
        this.hy = e.Y / tileSize;
        this.Refresh();
    }

    private void MouseClick(object sender, MouseEventArgs e)
    {
        int x = e.X / tileSize;
        int y = e.Y / tileSize;
        // tutaj nowy wontek.
        var wontek = new TileThread(this, x, y);
        new Thread(new ThreadStart(wontek.Runnable)).Start();
    }
}