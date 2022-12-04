using Zad3_builder.Core.Segments;

namespace BuilderForms.Core.Builder;
public static class BuilderService
{
    public static ISegmentBuilder Create()
    {
        return new SegmentBuilder();
    }

    public static List<Segment> Build(ISegmentBuilder builder)
    {
        return builder.Build();
    }
}
