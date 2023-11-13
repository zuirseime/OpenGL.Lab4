using AuxiliaryLib;
using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab4;
public static class IntersectionCalculator {
    /// <summary>
    /// Finds the intersection points of the segment and the parabola.
    /// </summary>
    /// <param name="segment">The segment.</param>
    /// <param name="parabola">The parabola.</param>
    /// <returns>The list of the intersection points.</returns>
    public static List<Vec2d> FindIntersectionVertices(Segment segment, Parabola parabola) {
        List<Vec2d> points = new();

        double a = parabola.Factor;
        double b = -(2 * a * parabola.Position.X + segment.Slope);
        double c = a * Math.Pow(parabola.Position.X, 2) + parabola.Position.Y - segment.YIntercept;

        double[] roots = GetRoots(a, b, c);

        if (roots != null) {
            foreach (double x in roots) {
                double y = segment.GetY(x);
                Vec2d vertex = new(x, y);
                if (segment.Contains(Vec2d.Round(vertex, 4))) {
                    points.Add(vertex);
                }
            }
        }

        return points;
    }

    /// <summary>
    /// Gives the roots of the quadratic equation.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <param name="complex">Whether to look for complex roots.</param>
    /// <returns>The array of the roots.</returns>
    private static double[] GetRoots(double a, double b, double c, bool complex = false) {
        if (a != 0) {
            double D = b * b - 4 * a * c;

            if (D < 0) {
                if (complex) {
                    Complex x1 = (-b + Complex.Sqrt(D)) / (2 * a);
                    Complex x2 = (-b - Complex.Sqrt(D)) / (2 * a);

                    return new double[] { x1.Imaginary, x2.Imaginary };
                } else return null;
            } else if (D > 0) {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                return new double[] { x1, x2 };
            } else {
                double x = -b / (2 * a);

                return new double[] { x };
            }
        } else {
            double x = -c / b;

            return new double[] { x };
        }
    }
}