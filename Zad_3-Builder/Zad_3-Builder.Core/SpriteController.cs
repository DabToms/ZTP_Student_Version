using Zad3_builder.Core.Segments;

namespace Zad3_builder.Core;
public class SpriteController
{
    private readonly Sprite sprite;
    private readonly List<Segment> map;
    private readonly Form form;

    public SpriteController(Sprite sp, List<Segment> map, Form form)
    {
        sprite = sp;
        this.map = map;
        this.form = form;
    }

    public void run()
    {
        sprite.tick();
        foreach (var s in map)
        {
            s.tick();
        }
        form.Refresh();
        Thread.Yield();
        try
        {
            Thread.Sleep(30);
        }
        catch (ThreadInterruptedException e)
        {
            Console.WriteLine(e.StackTrace);
        }
    }

}
