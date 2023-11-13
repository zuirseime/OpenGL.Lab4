using AuxiliaryLib;
using static Lab4.OpenGL;

namespace Lab4.Models;

/// <summary>
/// The coordinate grid class.
/// </summary>
public class CoordinateGrid : Shape {
    public Vec2d Step { get; set; } = Vec2d.Zero;

    /// <summary>
    /// Draws the coordinate grid.
    /// </summary>
    public override void Update() {
        DrawGrid();
        DrawAxis();
    }

    /// <summary>
    /// Draws the axes.
    /// </summary>
    private void DrawAxis() {
        double centerCoord = 0;
        SetLineAppearance(centerCoord);

        glBegin(GL_LINES);

        glVertex2d(centerCoord, YLimit.Minimum);
        glVertex2d(centerCoord, YLimit.Maximum);

        glVertex2d(XLimit.Minimum, centerCoord);
        glVertex2d(XLimit.Maximum, centerCoord);

        glEnd();
    }

    /// <summary>
    /// Draws the coordinate grid.
    /// </summary>
    private void DrawGrid() {
        for (double x = 0; x <= XLimit.Maximum; x += Step.X) {
            // Draws lines only if they are within the screen
            if (x >= XLimit.Minimum) {
                SetLineAppearance(x);
                DrawVerticalLine(x);
            }
        }
        for (double x = 0; x >= XLimit.Minimum; x -= Step.X) {
            // Draws lines only if they are within the screen
            if (x <= XLimit.Maximum) {
                SetLineAppearance(x);
                DrawVerticalLine(x);
            }
        }

        for (double y = 0; y <= YLimit.Maximum; y += Step.Y) {
            // Draws lines only if they are within the screen
            if (y >= YLimit.Minimum) {
                SetLineAppearance(y);
                DrawHorizontalLine(y);
            }
        }
        for (double y = 0; y >= YLimit.Minimum; y -= Step.Y) {
            // Draws lines only if they are within the screen
            if (y <= YLimit.Maximum) {
                SetLineAppearance(y);
                DrawHorizontalLine(y);
            }
        }
    }

    /// <summary>
    /// Draws a vertical line.
    /// </summary>
    /// <param name="x">The Y-axis coordinate of the line.</param>
    private void DrawVerticalLine(double x) {
        glBegin(GL_LINES);
        DrawLine(new Limit(x, x), YLimit);
        glEnd();
    }

    /// <summary>
    /// Draws a horizontal line.
    /// </summary>
    /// <param name="y">The Y-axis coordinate of the line.</param>
    private void DrawHorizontalLine(double y) {
        glBegin(GL_LINES);
        DrawLine(XLimit, new Limit(y, y));
        glEnd();
    }

    /// <summary>
    /// Draws lines by its coordinates.
    /// </summary>
    /// <param name="xChanging">The limit that defines values within which the line be drawn by X-axis.</param>
    /// <param name="yChanging">The limit that defines values within which the line be drawn by Y-axis.</param>
    private void DrawLine(Limit xChanging, Limit yChanging) {
        glVertex2d(xChanging.Minimum, yChanging.Minimum);
        glVertex2d(xChanging.Maximum, yChanging.Maximum);
    }

    /// <summary>
    /// Sets a specific appearance of the line depending on the value of the coordinate where it lies.
    /// </summary>
    /// <param name="value">The value of the coordinate where the line lies.</param>
    private void SetLineAppearance(double value) {
        if (value == 0) {
            glLineWidth(3);
            SetColor(Color.Black);
        } else if (value % 5 == 0) {
            glLineWidth(2);
            SetColor(Color.Gray);
        } else {
            glLineWidth(1);
            SetColor(new Color("#BBBBBB"));
        }
    }
}