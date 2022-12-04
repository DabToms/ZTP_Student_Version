using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.AccessControl;

using ChessForms.Decorators;
using ChessForms.Figures;

namespace ChessForms;

public partial class ChessboardForms : Form
{
    public static readonly int ZEROX = 23;
    public static readonly int ZEROY = 7;

    private Dictionary<Point, IFigure> board = new Dictionary<Point, IFigure>();

    private Image image;
    private IFigure? current = null;
    private Point? mouse = null;
    private Matrix mat = new Matrix();

    public ChessboardForms()
    {
        InitializeComponent();
        board.Add(new Point(0, 2), new Figure(11, 0, 2));
        board.Add(new Point(0, 6), new Figure(0, 0, 6));
        board.Add(new Point(1, 4), new Figure(6, 1, 4));
        board.Add(new Point(1, 5), new Figure(5, 1, 5));
        board.Add(new Point(3, 7), new Figure(1, 3, 7));
        board.Add(new Point(4, 3), new Figure(6, 4, 3));
        board.Add(new Point(4, 4), new Figure(7, 4, 4));
        board.Add(new Point(5, 4), new Figure(6, 5, 4));
        board.Add(new Point(5, 6), new Figure(0, 6, 5));
        board.Add(new Point(7, 4), new Figure(0, 7, 4));

        try
        {
            image = Image.FromFile("C:\\Users\\dabto\\Desktop\\Studia\\ZTP\\ChessForms\\ChessForms\\img\\board3.png");
        }
        catch
        {
            throw new Exception("Brak pliku szachownicy.");
        }
        this.Size = new Size(400, 460);

        Undo.Image = Image.FromFile("C:\\Users\\dabto\\Desktop\\Studia\\ZTP\\ChessForms\\ChessForms\\img\\undo.png");
        Redo.Image = Image.FromFile("C:\\Users\\dabto\\Desktop\\Studia\\ZTP\\ChessForms\\ChessForms\\img\\redo.png");
        Undo.Enabled = false;
        Redo.Enabled = false;
    }

    private void ChessboardForms_MouseDown(object sender, MouseEventArgs e)
    {
        var takenFigure = take((e.X - ZEROX) / Figure.TILESIZE, (e.Y - ZEROY) / Figure.TILESIZE);
        if (takenFigure != null)
        {
            mat = new Matrix();
            current = new MouseDownDecorator(takenFigure, mat);
        }
        this.mouse = e.Location;
    }

    private void ChessboardForms_MouseUp(object sender, MouseEventArgs e)
    {
        if (current != null)
        {
            drop(current.Unbox(), (e.X - ZEROX) / Figure.TILESIZE, (e.Y - ZEROY) / Figure.TILESIZE);
            current = null;
            Undo.Enabled = true;
        }
    }

    private void ChessboardForms_MouseMove(object sender, MouseEventArgs e)
    {
        if (mouse != null)
        {
            mat.Translate(e.X - this.mouse.Value.X, e.Y - this.mouse.Value.Y);
        }
        this.mouse = e.Location;
        this.Refresh();
    }

    private void Undo_Click(object sender, EventArgs e)
    {
        Console.WriteLine("UNOD");
        Redo.Enabled = true;
    }

    private void Redo_Click(object sender, EventArgs e)
    {
        Console.WriteLine("REDO");
    }

    public void drop(IFigure p, int x, int y)
    {
        this.Refresh();
        p.moveTo(x, y);
        if (board.ContainsKey(new Point(x, y)))
        {
            board.Remove(new Point(x, y));
            board.Add(new Point(x, y), p);
        }
        else
        {
            board.Add(new Point(x, y), p);
        }
    }

    public IFigure? take(int x, int y)
    {
        this.Refresh();

        if (board.ContainsKey(new Point(x, y)))
        {
            return board[new Point(x, y)];
        }
        return null;
    }

    private void ChessboardForms_Paint(object sender, PaintEventArgs e)
    {
        //base.OnPaint(e);
        var graphic = e.Graphics;
        graphic.DrawImage(image, new Point(0, 0));

        foreach (var hash in board)
        {
            var decoratedFigure = new TransformatedDecorator(hash.Value);
            decoratedFigure.draw(graphic);
        }

        if (mouse != null && current != null)
        {
            var decoratedFigure = new TransformatedDecorator(this.current);
            decoratedFigure.draw(graphic);
        }
    }
}