namespace Zad3_builder.Core.Segments;
public class SegmentBlockV : Segment
{
    public SegmentBlockV(int x, int y, string file)
        : base(x, y, file)
    {
    }

    public override void collisionV(Sprite sprite)
    {
        if (sprite.IsJumpingDown() && sprite.getBottomY() == this.Top)
        {
            sprite.StopJumping();
        }
    }
}
