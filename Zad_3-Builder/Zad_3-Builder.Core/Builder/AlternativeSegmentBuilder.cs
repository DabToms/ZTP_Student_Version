using Zad3_builder.Core.Segments;

namespace BuilderForms.Core.Builder;
public class AlternativeSegmentBuilder : SegmentBuilder
{
    public override ISegmentBuilder AddSegmentC(int x, int y)
    {
        var s = new SegmentBlock(x, y, "C:\\Users\\dabto\\Desktop\\Studia\\ZTP_Student_Version\\Zad_3-Builder\\Zad_3-Builder\\files\\images\\block3.png");
        this.map.Add(s);
        return this;
    }
}
