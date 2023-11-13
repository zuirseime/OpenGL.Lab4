using AuxiliaryLib;
using System;
using System.Collections.Generic;

namespace Lab4.Models;
public class Circle : Shape {
    public double Radius { get; set; } = 5;

    private int accuracy = 1000;
    
    public override void Prepare() {
        base.Prepare();

        XLimit = new Limit(-Radius + Position.X, Radius + Position.X);

        double step = (double)(XLimit.Length * 2d / accuracy);

        List<Vec2d> positiveVertices = new();
        List<Vec2d> negativeVertices = new();

        for (double x = XLimit.Minimum; x <= XLimit.Maximum; x += step) {
            GetVertices(x, ref positiveVertices, ref negativeVertices);
        }

        negativeVertices.Reverse();
        Vertices.AddRange(positiveVertices);
        Vertices.AddRange(negativeVertices);
    }

    /// <summary>
    /// Gives positive and negative Y-axis values by the X-axis value.
    /// </summary>
    /// <param name="x">The required X-axis value.</param>
    /// <param name="posVertices">List where positive Y-axis value should be passed.</param>
    /// <param name="negVertices">List where negative Y-axis value should be passed.</param>
    public void GetVertices(double x, ref List<Vec2d> posVertices, ref List<Vec2d> negVertices) {
        double root = Math.Sqrt((Radius * Radius -  (x - Position.X) * (x - Position.X)));

        if (root != 0) {
            double y1 = Position.Y + root;
            double y2 = Position.Y - root;

            posVertices.Add(new Vec2d(x, y1));
            negVertices.Add(new Vec2d(x, y2));
        } else {
            negVertices.Add(new Vec2d(x, Position.Y));
        }
    }
}