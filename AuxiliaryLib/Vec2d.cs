using System.Diagnostics.CodeAnalysis;

namespace AuxiliaryLib;

/// <summary>
/// Double 2D vector class.
/// </summary>
public class Vec2d {
    public double X { get; set; }
    public double Y { get; set; }

    /// <summary>
    /// The <see cref="Vec2d"/> with <b>x=0</b> and <b>y=0</b>.
    /// </summary>
    public static Vec2d Zero => new(0, 0);
    /// <summary>
    /// The <see cref="Vec2d"/> with <b>x=1</b> and <b>y=1</b>.
    /// </summary>
    public static Vec2d One => new(1);
    /// <summary>
    /// The <see cref="Vec2d"/> with <b>x=0</b> and <b>y=1</b>.
    /// </summary>
    public static Vec2d Up => new(0, 1);
    /// <summary>
    /// The <see cref="Vec2d"/> with <b>x=0</b> and <b>y=-1</b>.
    /// </summary>
    public static Vec2d Down => new(0, -1);
    /// <summary>
    /// The <see cref="Vec2d"/> with <b>x=-1</b> and <b>y=0</b>.
    /// </summary>
    public static Vec2d Left => new(-1, 0);
    /// <summary>
    /// The <see cref="Vec2d"/> with <b>x=1</b> and <b>y=0</b>.
    /// </summary>
    public static Vec2d Right => new(1, 0);

    public Vec2d(double value) : this(value, value) { }

    public Vec2d(double x, double y) {
        X = x; 
        Y = y;
    }

    /// <summary>
    /// Rounds X and Y values to a certain number of decimal places.
    /// </summary>
    /// <param name="value">The <see cref="Vec2d"/> value.</param>
    /// <param name="digits">The number of decimal places.</param>
    /// <returns>Rounded values.</returns>
    public static Vec2d Round(Vec2d value, int digits) => new(Math.Round(value.X, digits), Math.Round(value.Y, digits));

    /// <summary>
    /// Clamps the value within the minimum and maximum range.
    /// </summary>
    /// <param name="value">The value to be clamped.</param>
    /// <param name="min">The minimum boundary.</param>
    /// <param name="max">The maximum boundary.</param>
    /// <returns>The clamped value.</returns>
    public static Vec2d Clamp(Vec2d value, Vec2d min, Vec2d max) => Min(Max(value, min), max);

    /// <summary>
    /// Gives the smaller of two vectors.
    /// </summary>
    /// <param name="vec1">The first vector to be compared.</param>
    /// <param name="vec2">The second vector to be compared.</param>
    /// <returns>The smaller vector.</returns>
    public static Vec2d Min(Vec2d vec1, Vec2d vec2) =>
        new((vec1.X < vec2.X) ? vec1.X : vec2.X, (vec1.Y < vec2.Y) ? vec1.Y : vec2.Y);

    /// <summary>
    /// Gives the larger of two vectors.
    /// </summary>
    /// <param name="vec1">The first vector to be compared.</param>
    /// <param name="vec2">The second vector to be compared.</param>
    /// <returns>The larger vector.</returns>
    public static Vec2d Max(Vec2d vec1, Vec2d vec2) =>
        new((vec1.X > vec2.X) ? vec1.X : vec2.X, (vec1.Y > vec2.Y) ? vec1.Y : vec2.Y);

    /// <summary>
    /// Calculates distance between specific points.
    /// </summary>
    /// <param name="vec1">The first vector</param>
    /// <param name="vec2">The second vector</param>
    /// <returns>The distance between <b>vec1</b> and <b>vec2</b></returns>
    public static double Distance(Vec2d vec1, Vec2d vec2) => Math.Sqrt(DistanceSquared(vec1, vec2));

    /// <summary>
    /// Calculates squared distance between specific points.
    /// </summary>
    /// <param name="vec1">The first vector</param>
    /// <param name="vec2">The second vector</param>
    /// <returns>The squared distance between <b>vec1</b> and <b>vec2</b></returns>
    public static double DistanceSquared(Vec2d vec1, Vec2d vec2) => Dot(vec1 - vec2, vec1 - vec2);

    /// <summary>
    /// Calculates the length of the vector.
    /// </summary>
    /// <returns>The vector's length.</returns>
    public double Length() => Math.Sqrt(LengthSquared());

    /// <summary>
    /// Calculates the length of the vector squared.
    /// </summary>
    /// <returns>The vector's squared length.</returns>
    private double LengthSquared() => Dot(this, this);

    /// <summary>
    /// Returns the dot product of two specific points.
    /// </summary>
    /// <param name="vec1">The first vector</param>
    /// <param name="vec2">The second vector</param>
    /// <returns>The dot product.</returns>
    public static double Dot(Vec2d vec1, Vec2d vec2) => (vec1.X * vec2.X) + (vec1.Y * vec2.Y);


    #region Operators
    public static Vec2d operator +(Vec2d vec1, Vec2d vec2) => new(vec1.X + vec2.X, vec1.Y + vec2.Y);

    public static Vec2d operator -(Vec2d vec1, Vec2d vec2) => new(vec1.X - vec2.X, vec1.Y - vec2.Y);
    public static Vec2d operator -(Vec2d vector) => Zero - vector;

    public static Vec2d operator *(Vec2d vec1, Vec2d vec2) => new(vec1.X * vec2.X, vec1.Y * vec2.Y);
    public static Vec2d operator *(Vec2d vector, double factor) => vector * new Vec2d(factor);
    public static Vec2d operator *(double factor, Vec2d vector) => vector * new Vec2d(factor);

    public static Vec2d operator /(Vec2d vec1, Vec2d vec2) => new(vec1.X / vec2.X, vec1.Y / vec2.Y);
    public static Vec2d operator /(Vec2d vector, double factor) => vector / new Vec2d(factor);

    public static bool operator ==(Vec2d vec1, Vec2d vec2) => (vec1.X == vec2.X) && (vec1.Y == vec2.Y);

    public static bool operator !=(Vec2d vec1, Vec2d vec2) => !(vec1 == vec2);
    #endregion

    #region Overrides
    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is Vec2d other) && Equals(other);
    
    public bool Equals(Vec2d other) {
        return X.Equals(other.X) && Y.Equals(other.Y);
    }

    public override int GetHashCode() => HashCode.Combine(X, Y);
    #endregion
}