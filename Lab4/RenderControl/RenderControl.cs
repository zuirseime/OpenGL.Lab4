using AuxiliaryLib;
using Lab4.Models;
using System;
using System.Collections.Generic;

namespace Lab4;
public partial class RenderControl : OpenGL {
    private Parabola parabola;
    private Circle circle;
    private CoordinateGrid grid;
    private Segment segment;

    private List<Vec2d> intesectionPoints = new();

    #region Screen settings
    private double scale = 1d;
    public int ScaleMultiplier { get; private set; } = 10;
    public double GraphScale => scale * ScaleMultiplier;

    private double AspectRatio => (double)Width / Height;
    public double xMin => (AspectRatio > 1) ? -GraphScale * AspectRatio : -GraphScale;
    public double xMax => (AspectRatio > 1) ? GraphScale * AspectRatio : GraphScale;
    public double yMin => (AspectRatio < 1) ? -GraphScale / AspectRatio : -GraphScale;
    public double yMax => (AspectRatio < 1) ? GraphScale / AspectRatio : GraphScale;

    public Limit XLimit => new(xMin, xMax);
    public Limit YLimit => new(yMin, yMax);
    #endregion

    #region Circle settings
    public double CircleRadius { get; set; } = 5;
    public double CircleX { get; set; } = 0;
    public double CircleY { get; set; } = 0;
    public Vec2d CirclePosition => new(CircleX, CircleY);
    #endregion

    #region Parabola settings
    public double ParabolaFactor { get; set; } = 1;
    public double ParabolaX { get; set; } = 0;
    public double ParabolaY { get; set; } = 0;
    public Vec2d ParabolaPosition => new(ParabolaX, ParabolaY);
    #endregion

    #region Segment settings
    public Vec2d SegmentStart { get; set; } = new(-5);
    public Vec2d SegmentEnd { get; set; } = new(5);
    #endregion

    public RenderControl() {
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e) {
        grid = new CoordinateGrid();
        circle = new Circle() { Mode = GL_LINE_LOOP, Color = Color.Red };
        parabola = new Parabola() { Color = new Color("#00DD00") };
        segment = new Segment() { Color = Color.Blue };

        PrepareAll();
    }

    private void OnResize(object sender, EventArgs e) {
        if (grid != null && circle != null && parabola != null && segment != null)
            PrepareAll();
    }

    private void OnRender(object sender, EventArgs e) {
        glClear(GL_COLOR_BUFFER_BIT);
        glLoadIdentity();

        glViewport(0, 0, Width, Height);
        gluOrtho2D(xMin, xMax, yMin, yMax);

        grid.Update();
        circle.Update();
        parabola.Update();
        segment.Update();

        DrawIntesections();
    }

    /// <summary>
    /// Regenerates the circle.
    /// </summary>
    public void RegenerateCircle() {
        if (circle != null) {
            circle.Radius = CircleRadius;
            circle.Position = CirclePosition;
            circle.Prepare();
            Invalidate();
        }
    }

    /// <summary>
    /// Regenerates the parabola.
    /// </summary>
    public void RegenerateParabola() {
        if (parabola != null) {
            parabola.Factor = ParabolaFactor;
            parabola.Position = ParabolaPosition;
            parabola.XLimit = XLimit;
            parabola.YLimit = YLimit;
            parabola.Prepare();
            Invalidate();
        }
    }

    /// <summary>
    /// Regenerates the segment.
    /// </summary>
    public void RegenerateSegment() {
        if (segment != null) {
            segment.Start = SegmentStart;
            segment.End = SegmentEnd;
            segment.Prepare();
            Invalidate();
        }
    }

    /// <summary>
    /// Recalculates the intersection points of the line and the parabola.
    /// </summary>
    public void RecalculateIntersections() {
        RegenerateParabola();
        RegenerateSegment();

        if (segment != null && parabola != null) {
            intesectionPoints = IntersectionCalculator.FindIntersectionVertices(segment, parabola);
        }
    }

    /// <summary>
    /// Draws the intersection points of the line and the parabola.
    /// </summary>
    private void DrawIntesections() {
        glColor3ub(127, 0, 127);
        glEnable(GL_POINT_SMOOTH);
        glPointSize(10);

        glBegin(GL_POINTS);
        intesectionPoints.ForEach(v => glVertex2d(v.X, v.Y));
        glEnd();

        glDisable(GL_POINT_SMOOTH);
    }

    /// <summary>
    /// Changes scale of the scene.
    /// </summary>
    /// <param name="multiplier">The scale multiplier.</param>
    public void ChangeScale(int multiplier) {
        ScaleMultiplier = multiplier;
        PrepareAll();
    }

    /// <summary>
    /// Prepare all the objects on the scene.
    /// </summary>
    private void PrepareAll() {
        RecalculateIntersections();
        RegenerateCircle();

        grid.Step = new Vec2d(1);
        grid.XLimit = XLimit;
        grid.YLimit = YLimit;
    }

    private void OnUnload(object sender, EventArgs e) {
        grid = null;
        circle = null;
        parabola = null;
        segment = null;

        intesectionPoints = null;
    }
}