using AuxiliaryLib;

namespace Lab4.Models;
public class Segment : Shape {
    private const double MAX_SLOPE = 1.25e7d;

    public double Slope { get; private set; } = 1d;
    public double YIntercept { get; private set; } = 0d;

    public Vec2d Start { get; set; } = Vec2d.Zero;
    public Vec2d End { get; set; } = Vec2d.Zero;

    public bool Vertical => End.X - Start.X == 0;

    public override void Prepare() {
        base.Prepare();

        XLimit = new Limit(Start.X, End.X);
        YLimit = new Limit(Start.Y, End.Y);

        Slope = !Vertical ? (End.Y - Start.Y) / (End.X - Start.X) : MAX_SLOPE;
        YIntercept = Start.Y - Slope * Start.X;

        Vec2d[] vertices = new Vec2d[2] { Start, End };
        Vertices.AddRange(vertices);
    }

    /// <summary>
    /// Gives the Y-axis value by the X-axis value.
    /// </summary>
    /// <param name="x">The required X-axis value.</param>
    /// <returns>The Y-axis value.</returns>
    public double GetY(double x) => Slope * x + YIntercept;

    /// <summary>
    /// Checks if the segment contains the vertex.
    /// </summary>
    /// <param name="vertex">The vertex to be checked.</param>
    /// <returns><see langword="true"/> if the segment contains the vertex; otherwise, <see langword="false"/>.</returns>
    public bool Contains(Vec2d vertex) => XLimit.Contains(vertex.X) && YLimit.Contains(vertex.Y);
}