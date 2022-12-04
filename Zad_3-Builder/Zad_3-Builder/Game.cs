using System.ComponentModel;

using Zad3_builder;
using Zad3_builder.Core.Segments;
using Zad3_builder.Core;
using System.Configuration;
using BuilderForms.Core.Builder;

namespace BuilderForms;

public partial class Game : Form
{
    private readonly int TILESIZE = 32;
    private readonly List<Segment> map;
    private readonly Sprite sprite;
    private readonly SpriteController spriteController;

    public Game()
    {
        InitializeComponent();
    }

    public Game(string path)
    {
        InitializeComponent();

        // ustawienie rozmieru okna
        this.Size = new Size(424, 268);

        // stworzenie planszy(tutaj u¿yæ builder-a)
        ISegmentBuilder builder = new SegmentBuilder();
        builder = stworzPlansze(path, builder);
        map = BuilderService.Build(builder);

        // stworzenie spriteu(mario)
        sprite = new Sprite(map, "C:\\Users\\dabto\\Desktop\\Studia\\ZTP_Student_Version\\Zad_3-Builder\\Zad_3-Builder\\files\\images\\mario.png");

        // wystartowanie gry
        this.spriteController = new SpriteController(sprite, map, this);

        this.GameTimer.Start();

    }

    // to powinno siê samo wywo³ywaæ
    private void MainGameTimerEvent(object sender, EventArgs e)
    {
        spriteController.run();
    }

    // to powinno samo siê wywo³ywaæ
    private void Game_Paint(object sender, PaintEventArgs e)
    {
        //base.OnPaint(e);
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        foreach (var s in map)
        {
            s.draw(e.Graphics);
        }
        sprite.draw(e.Graphics);
    }

    // key handlery
    private void KeyIsDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Left:
                sprite.MoveLeft();
                break;
            case Keys.Right:
                sprite.MoveRight();
                break;
            case Keys.Up:
            case Keys.Space:
                sprite.Jump();
                break;
        }
    }

    private void KeyIsUp(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.Left:
            case Keys.Right:
                sprite.Stop();
                break;
        }
    }


    private ISegmentBuilder stworzPlansze(string plik, ISegmentBuilder buider)
    {
        try
        {
            var br = File.ReadLines(plik);
            int x;
            int y = 4;
            int liczba;
            int znaki;
            char znak;
            char cyfra1;
            char cyfra2;
            foreach (string linia in br)
            {
                x = 4;
                znaki = 0;
                while ((linia.Length - znaki) >= 3)
                {
                    znak = linia.ElementAt(znaki++);
                    cyfra1 = linia.ElementAt(znaki++);
                    cyfra2 = linia.ElementAt(znaki++);
                    liczba = (cyfra1 - '0') * 10 + (cyfra2 - '0');
                    switch (znak)
                    {
                        case 'X':
                            x += liczba * TILESIZE;
                            break;
                        case 'A':
                            for (int i = 0; i < liczba; ++i)
                            {
                                buider.AddSegmentA(x, y);
                                x += TILESIZE;
                            }
                            break;
                        case 'B':
                            for (int i = 0; i < liczba; ++i)
                            {
                                buider.AddSegmentB(x, y);
                                x += TILESIZE;
                            }
                            break;
                        case 'C':
                            for (int i = 0; i < liczba; ++i)
                            {
                                buider.AddSegmentC(x, y);
                                x += TILESIZE;
                            }
                            break;
                        case 'G':
                            for (int i = 0; i < liczba; ++i)
                            {
                                buider.AddSegmentG(x, y);
                                x += TILESIZE;
                            }
                            break;
                    }
                }
                y += TILESIZE;
            }

            return buider;
        }
        catch (IOException e)
        {
            Console.WriteLine("Blad wczytania planszy");
            Console.WriteLine(e.StackTrace);
        }

        return buider;
    }
}
