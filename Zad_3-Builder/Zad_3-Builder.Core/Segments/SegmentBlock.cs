namespace Zad3_builder.Core.Segments;
public class SegmentBlock : Segment
{
    public SegmentBlock(int x, int y, string file)
        : base(x, y, file)
    {
    }
    public override void collisionV(Sprite sprite)
    {
        sprite.StopJumping();
    }


    public override void collisionH(Sprite sprite)
    {
        sprite.StopMoving();
    }
}
