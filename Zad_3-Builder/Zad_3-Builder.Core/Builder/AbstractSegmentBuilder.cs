using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zad3_builder.Core.Segments;

namespace BuilderForms.Core.Builder;
public abstract class AbstractSegmentBuilder : ISegmentBuilder
{
    protected List<Segment> map = new List<Segment>();

    public List<Segment> Build()
    {
        return map;
    }

    public abstract ISegmentBuilder AddSegmentC(int x, int y);
    public abstract ISegmentBuilder AddSegmentG(int x, int y);
    public abstract ISegmentBuilder AddSegmentA(int x, int y);
    public abstract ISegmentBuilder AddSegmentB(int x, int y);
}
