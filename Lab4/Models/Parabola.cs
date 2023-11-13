using AuxiliaryLib;
using System;

namespace Lab4.Models;
public class Parabola : Shape {
    public double Factor { get; set; }
    public double Step => (double)(XLimit.Length / (accuracy - 1));

    private int accuracy = 1000;

    public override void Prepare() {
        base.Prepare();

        if (Factor != 0) {
            double y = Factor > 0 ? YLimit.Maximum * 1.5d : YLimit.Minimum * 1.5d;
            double[] xLimits = GetXs(y);
            XLimit = new Limit(xLimits[0], xLimits[1]);
        }

        for (double t = XLimit.Minimum; t <= XLimit.Maximum; t += Step) {
            double x = t;
            double y = GetY(t);
            Vec2d vertex = new(x, y);
            Vertices.Add(vertex);
        }
    }

    /// <summary>
    /// Gives the Y-axis value by the X-axis value.
    /// </summary>
    /// <param name="x">The required X-axis value.</param>
    /// <returns>The Y-axis value.</returns>
    public double GetY(double x) => Factor * Math.Pow(x - Position.X, 2) + Position.Y;

    /// <summary>
    /// Gives the array of the X-axis values by the Y-axis value.
    /// </summary>
    /// <param name="y">The required Y-axis value.</param>
    /// <returns>The array of the X-axis values.</returns>
    public double[] GetXs(double y) {
        double root = Math.Sqrt((y - Position.Y) / Factor);

        double x1 = Position.X - root;
        double x2 = Position.X + root;

        return new double[] { x1, x2 };
    }
}