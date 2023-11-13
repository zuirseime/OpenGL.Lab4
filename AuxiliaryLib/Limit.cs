namespace AuxiliaryLib;

/// <summary>
/// Structure that limits value from <b>Min</b> to <b>Max</b>.
/// </summary>
public class Limit {
    public double Minimum { get; set; }
    public double Maximum { get; set; }

    public Limit(double value1, double value2) {
        Minimum = Math.Min(value1, value2);
        Maximum = Math.Max(value1, value2);
    }

    public double Length => Maximum - Minimum;

    /// <summary>
    /// Checks whether the limit contains a value.
    /// </summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns><see langword="true"/> if the limit contains the value; otherwise, <see langword="false"/>.</returns>
    public bool Contains(double value) => Contains(value, 0d);

    /// <summary>
    /// Checks whether the limit contains a value including fields.
    /// </summary>
    /// <param name="value">The value to be checked.</param>
    /// <param name="field">The field size.</param>
    /// <returns><see langword="true"/> if the limit contains the value; otherwise, <see langword="false"/>.</returns>
    public bool Contains(double value, double field) => value >= (Minimum - field) && value <= (Maximum + field);

    /// <summary>
    /// Approximates the value to the nearest boundary.
    /// </summary>
    /// <param name="value">The value to be approximated.</param>
    /// <returns>The approximated value.</returns>
    public double ApproximateToBoundary(double value) {
        double newValue = 0d;

        if (value - Minimum < Maximum - value) newValue = Minimum;
        else if (Maximum - value < value - Minimum) newValue = Maximum;
        
        return newValue;
    }

    /// <summary>
    /// Checks if the value lies on one of the boundaries.
    /// </summary>
    /// <param name="value">The value to be checked.</param>
    /// <returns><see langword="true"/> if the value lies on one of the edges of the limit; otherwise, <see langword="false"/>.</returns>
    public bool IsOnTheBoundary(double value) => value == Minimum || value == Maximum;
}