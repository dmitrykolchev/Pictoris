using static Managed.Win32.Graphics.Direct2d.D2D1_PATH_SEGMENT;

namespace Managed.Graphics.Direct2d;

[Flags]
public enum PathSegment : int
{
    None = D2D1_PATH_SEGMENT_NONE,
    ForceUnstroked = D2D1_PATH_SEGMENT_FORCE_UNSTROKED,
    ForceRoundLineJoin = D2D1_PATH_SEGMENT_FORCE_ROUND_LINE_JOIN
}

