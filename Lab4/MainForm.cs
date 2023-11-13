using System;
using System.Windows.Forms;
using AuxiliaryLib;
using static Lab4.OpenGL;


namespace Lab4;
public partial class MainForm : Form {
    public MainForm() {
        InitializeComponent();

        cRadius.Value = Convert.ToDecimal(renderer.CircleRadius);

        rScaleMultiplier.Value = renderer.ScaleMultiplier;
    }

    private void xParabolaValueChanged(object sender, EventArgs e) {
        renderer.ParabolaX = (double)pX.Value;
        renderer.RecalculateIntersections();
    }

    private void yParabolaValueChanged(object sender, EventArgs e) {
        renderer.ParabolaY = (double)pY.Value;
        renderer.RecalculateIntersections();
    }

    private void FactorValueChanged(object sender, EventArgs e) {
        renderer.ParabolaFactor = (double)pFactor.Value;
        renderer.RecalculateIntersections();
    }

    private void RenderScaleChanged(object sender, EventArgs e) {
        renderer.ChangeScale(rScaleMultiplier.Value);
    }

    private void StartValueChanged(object sender, EventArgs e) {
        double x = (double)sStartX.Value;
        double y = (double)sStartY.Value;
        renderer.SegmentStart = new Vec2d(x, y);
        renderer.RecalculateIntersections();
    }

    private void EndValueChanged(object sender, EventArgs e) {
        double x = (double)sEndX.Value;
        double y = (double)sEndY.Value;
        renderer.SegmentEnd = new Vec2d(x, y);
        renderer.RecalculateIntersections();
    }

    private void xCircleValueChanged(object sender, EventArgs e) {
        renderer.CircleX = (double)cX.Value;
        renderer.RegenerateCircle();
    }

    private void yCircleValueChanged(object sender, EventArgs e) {
        renderer.CircleY = (double)cY.Value;
        renderer.RegenerateCircle();
    }

    private void RadiusValueChanged(object sender, EventArgs e) {
        renderer.CircleRadius = (double)cRadius.Value;
        renderer.RegenerateCircle();
    }
}