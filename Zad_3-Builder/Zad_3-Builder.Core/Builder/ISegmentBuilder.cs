using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zad3_builder.Core.Segments;

namespace BuilderForms.Core.Builder;
public interface ISegmentBuilder
{
    List<Segment> Build();
    ISegmentBuilder AddSegmentC(int x, int y);
    ISegmentBuilder AddSegmentG(int x, int y);
    ISegmentBuilder AddSegmentA(int x, int y);
    ISegmentBuilder AddSegmentB(int x, int y);
}
