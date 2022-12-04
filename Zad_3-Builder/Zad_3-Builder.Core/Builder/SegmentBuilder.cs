using Zad3_builder.Core.Segments;

namespace BuilderForms.Core.Builder;
public class SegmentBuilder : AbstractSegmentBuilder
{
    public override ISegmentBuilder AddSegmentC(int x, int y)
    {
        var s = new Segment(x, y, "C:\\Users\\dabto\\Desktop\\Studia\\ZTP_Student_Version\\Zad_3-Builder\\Zad_3-Builder\\files\\images\\block3.png");
        this.map.Add(s);
        return this;
    }

    public override ISegmentBuilder AddSegmentG(int x, int y)
    {
        var s = new SegmentAnim(x, y, "C:\\Users\\dabto\\Desktop\\Studia\\ZTP_Student_Version\\Zad_3-Builder\\Zad_3-Builder\\files\\images\\bonus.png", new int[] { 0, 0, 0, 1, 1, 1, 2, 2, 3, 3, 2, 2, 1, 1, 1, 0, 0 });
        this.map.Add(s);
        return this;
    }

    public override ISegmentBuilder AddSegmentA(int x, int y)
    {
        var s = new SegmentBlock(x, y, "C:\\Users\\dabto\\Desktop\\Studia\\ZTP_Student_Version\\Zad_3-Builder\\Zad_3-Builder\\files\\images\\block1.png");
        this.map.Add(s);
        return this;
    }

    public override ISegmentBuilder AddSegmentB(int x, int y)
    {
        var s = new SegmentBlockV(x, y, "C:\\Users\\dabto\\Desktop\\Studia\\ZTP_Student_Version\\Zad_3-Builder\\Zad_3-Builder\\files\\images\\block2.png");
        this.map.Add(s);
        return this;
    }
}
