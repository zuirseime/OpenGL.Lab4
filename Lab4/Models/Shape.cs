using AuxiliaryLib;
using System.Collections.Generic;
using static Lab4.OpenGL;

namespace Lab4.Models;
public class Shape {
    public List<Vec2d> Vertices { get; protected set; } = new List<Vec2d>();
    public Limit XLimit { get; set; } = new(-5, 5);
    public Limit YLimit { get; set; } = new(-5, 5);
    public Vec2d Position { get; set; } = Vec2d.Zero;
    public uint Mode { get; set; } = GL_LINE_STRIP;
    public Color Color { get; set; } = Color.Black;

    /// <summary>
    /// Prepares the shape to be drawn.
    /// </summary>
    public virtual void Prepare() => Vertices.Clear();

    /// <summary>
    /// Updates the shape on the screen.
    /// </summary>
    public virtual void Update() {
        glPushMatrix();

        SetColor(Color);
        glLineWidth(4);

        glBegin(Mode);
        Vertices.ForEach(v => glVertex2d(v.X, v.Y));
        glEnd();

        glPopMatrix();
    }

    /// <summary>
    /// Sets the color of the vertex.
    /// </summary>
    /// <param name="color">The required <see cref="AuxiliaryLib.Color"/>.</param>
    protected void SetColor(Color color) => glColor3ub(color.R, color.G, color.B);
}
