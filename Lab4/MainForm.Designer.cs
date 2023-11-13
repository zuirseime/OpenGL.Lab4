namespace Lab4;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        renderer = new RenderControl();
        parabolaGB = new System.Windows.Forms.GroupBox();
        pFactorText = new System.Windows.Forms.Label();
        pFactor = new System.Windows.Forms.NumericUpDown();
        pXText = new System.Windows.Forms.Label();
        pX = new System.Windows.Forms.NumericUpDown();
        pYText = new System.Windows.Forms.Label();
        pY = new System.Windows.Forms.NumericUpDown();
        segmentGB = new System.Windows.Forms.GroupBox();
        segmentEndGB = new System.Windows.Forms.GroupBox();
        sEndXText = new System.Windows.Forms.Label();
        sEndX = new System.Windows.Forms.NumericUpDown();
        sEndYText = new System.Windows.Forms.Label();
        sEndY = new System.Windows.Forms.NumericUpDown();
        segmentStartGB = new System.Windows.Forms.GroupBox();
        sStartXText = new System.Windows.Forms.Label();
        sStartX = new System.Windows.Forms.NumericUpDown();
        sStartYText = new System.Windows.Forms.Label();
        sStartY = new System.Windows.Forms.NumericUpDown();
        scaleGB = new System.Windows.Forms.GroupBox();
        rScaleMultiplier = new System.Windows.Forms.TrackBar();
        circleGB = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        cRadius = new System.Windows.Forms.NumericUpDown();
        label2 = new System.Windows.Forms.Label();
        cX = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        cY = new System.Windows.Forms.NumericUpDown();
        parabolaGB.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pFactor).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pY).BeginInit();
        segmentGB.SuspendLayout();
        segmentEndGB.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)sEndX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)sEndY).BeginInit();
        segmentStartGB.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)sStartX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)sStartY).BeginInit();
        scaleGB.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)rScaleMultiplier).BeginInit();
        circleGB.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)cRadius).BeginInit();
        ((System.ComponentModel.ISupportInitialize)cX).BeginInit();
        ((System.ComponentModel.ISupportInitialize)cY).BeginInit();
        SuspendLayout();
        // 
        // renderer
        // 
        renderer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        renderer.BackColor = System.Drawing.Color.White;
        renderer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        renderer.CircleRadius = 5D;
        renderer.CircleX = 0D;
        renderer.CircleY = 0D;
        renderer.ForeColor = System.Drawing.Color.White;
        renderer.Location = new System.Drawing.Point(12, 12);
        renderer.Name = "renderer";
        renderer.ParabolaFactor = 1D;
        renderer.ParabolaX = 0D;
        renderer.ParabolaY = 0D;
        renderer.Size = new System.Drawing.Size(480, 506);
        renderer.TabIndex = 0;
        renderer.TextCodePage = 1251;
        // 
        // parabolaGB
        // 
        parabolaGB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        parabolaGB.Controls.Add(pFactorText);
        parabolaGB.Controls.Add(pFactor);
        parabolaGB.Controls.Add(pXText);
        parabolaGB.Controls.Add(pX);
        parabolaGB.Controls.Add(pYText);
        parabolaGB.Controls.Add(pY);
        parabolaGB.Location = new System.Drawing.Point(507, 127);
        parabolaGB.Name = "parabolaGB";
        parabolaGB.Size = new System.Drawing.Size(205, 110);
        parabolaGB.TabIndex = 1;
        parabolaGB.TabStop = false;
        parabolaGB.Text = "Parabola";
        // 
        // pFactorText
        // 
        pFactorText.AutoSize = true;
        pFactorText.Location = new System.Drawing.Point(33, 20);
        pFactorText.Name = "pFactorText";
        pFactorText.Size = new System.Drawing.Size(40, 15);
        pFactorText.TabIndex = 2;
        pFactorText.Text = "Factor";
        // 
        // pFactor
        // 
        pFactor.DecimalPlaces = 2;
        pFactor.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        pFactor.Location = new System.Drawing.Point(79, 18);
        pFactor.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        pFactor.Name = "pFactor";
        pFactor.Size = new System.Drawing.Size(120, 23);
        pFactor.TabIndex = 1;
        pFactor.Value = new decimal(new int[] { 1, 0, 0, 0 });
        pFactor.ValueChanged += FactorValueChanged;
        // 
        // pXText
        // 
        pXText.AutoSize = true;
        pXText.Location = new System.Drawing.Point(59, 53);
        pXText.Name = "pXText";
        pXText.Size = new System.Drawing.Size(14, 15);
        pXText.TabIndex = 4;
        pXText.Text = "X";
        // 
        // pX
        // 
        pX.DecimalPlaces = 2;
        pX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        pX.Location = new System.Drawing.Point(79, 51);
        pX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        pX.Name = "pX";
        pX.Size = new System.Drawing.Size(120, 23);
        pX.TabIndex = 3;
        pX.ValueChanged += xParabolaValueChanged;
        // 
        // pYText
        // 
        pYText.AutoSize = true;
        pYText.Location = new System.Drawing.Point(59, 82);
        pYText.Name = "pYText";
        pYText.Size = new System.Drawing.Size(14, 15);
        pYText.TabIndex = 6;
        pYText.Text = "Y";
        // 
        // pY
        // 
        pY.DecimalPlaces = 2;
        pY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        pY.Location = new System.Drawing.Point(79, 80);
        pY.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        pY.Name = "pY";
        pY.Size = new System.Drawing.Size(120, 23);
        pY.TabIndex = 5;
        pY.ValueChanged += yParabolaValueChanged;
        // 
        // segmentGB
        // 
        segmentGB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        segmentGB.Controls.Add(segmentEndGB);
        segmentGB.Controls.Add(segmentStartGB);
        segmentGB.Location = new System.Drawing.Point(507, 243);
        segmentGB.Name = "segmentGB";
        segmentGB.Size = new System.Drawing.Size(205, 198);
        segmentGB.TabIndex = 2;
        segmentGB.TabStop = false;
        segmentGB.Text = "Segment";
        // 
        // segmentEndGB
        // 
        segmentEndGB.Controls.Add(sEndXText);
        segmentEndGB.Controls.Add(sEndX);
        segmentEndGB.Controls.Add(sEndYText);
        segmentEndGB.Controls.Add(sEndY);
        segmentEndGB.Location = new System.Drawing.Point(7, 110);
        segmentEndGB.Name = "segmentEndGB";
        segmentEndGB.Size = new System.Drawing.Size(192, 82);
        segmentEndGB.TabIndex = 1;
        segmentEndGB.TabStop = false;
        segmentEndGB.Text = "End";
        // 
        // sEndXText
        // 
        sEndXText.AutoSize = true;
        sEndXText.Location = new System.Drawing.Point(46, 24);
        sEndXText.Name = "sEndXText";
        sEndXText.Size = new System.Drawing.Size(14, 15);
        sEndXText.TabIndex = 8;
        sEndXText.Text = "X";
        // 
        // sEndX
        // 
        sEndX.DecimalPlaces = 2;
        sEndX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        sEndX.Location = new System.Drawing.Point(66, 22);
        sEndX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        sEndX.Name = "sEndX";
        sEndX.Size = new System.Drawing.Size(120, 23);
        sEndX.TabIndex = 7;
        sEndX.Value = new decimal(new int[] { 5, 0, 0, 0 });
        sEndX.ValueChanged += EndValueChanged;
        // 
        // sEndYText
        // 
        sEndYText.AutoSize = true;
        sEndYText.Location = new System.Drawing.Point(46, 53);
        sEndYText.Name = "sEndYText";
        sEndYText.Size = new System.Drawing.Size(14, 15);
        sEndYText.TabIndex = 10;
        sEndYText.Text = "Y";
        // 
        // sEndY
        // 
        sEndY.DecimalPlaces = 2;
        sEndY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        sEndY.Location = new System.Drawing.Point(66, 51);
        sEndY.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        sEndY.Name = "sEndY";
        sEndY.Size = new System.Drawing.Size(120, 23);
        sEndY.TabIndex = 9;
        sEndY.Value = new decimal(new int[] { 5, 0, 0, 0 });
        sEndY.ValueChanged += EndValueChanged;
        // 
        // segmentStartGB
        // 
        segmentStartGB.Controls.Add(sStartXText);
        segmentStartGB.Controls.Add(sStartX);
        segmentStartGB.Controls.Add(sStartYText);
        segmentStartGB.Controls.Add(sStartY);
        segmentStartGB.Location = new System.Drawing.Point(7, 22);
        segmentStartGB.Name = "segmentStartGB";
        segmentStartGB.Size = new System.Drawing.Size(192, 82);
        segmentStartGB.TabIndex = 0;
        segmentStartGB.TabStop = false;
        segmentStartGB.Text = "Start";
        // 
        // sStartXText
        // 
        sStartXText.AutoSize = true;
        sStartXText.Location = new System.Drawing.Point(46, 24);
        sStartXText.Name = "sStartXText";
        sStartXText.Size = new System.Drawing.Size(14, 15);
        sStartXText.TabIndex = 8;
        sStartXText.Text = "X";
        // 
        // sStartX
        // 
        sStartX.DecimalPlaces = 2;
        sStartX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        sStartX.Location = new System.Drawing.Point(66, 22);
        sStartX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        sStartX.Name = "sStartX";
        sStartX.Size = new System.Drawing.Size(120, 23);
        sStartX.TabIndex = 7;
        sStartX.Value = new decimal(new int[] { 5, 0, 0, int.MinValue });
        sStartX.ValueChanged += StartValueChanged;
        // 
        // sStartYText
        // 
        sStartYText.AutoSize = true;
        sStartYText.Location = new System.Drawing.Point(46, 53);
        sStartYText.Name = "sStartYText";
        sStartYText.Size = new System.Drawing.Size(14, 15);
        sStartYText.TabIndex = 10;
        sStartYText.Text = "Y";
        // 
        // sStartY
        // 
        sStartY.DecimalPlaces = 2;
        sStartY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        sStartY.Location = new System.Drawing.Point(66, 51);
        sStartY.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        sStartY.Name = "sStartY";
        sStartY.Size = new System.Drawing.Size(120, 23);
        sStartY.TabIndex = 9;
        sStartY.Value = new decimal(new int[] { 5, 0, 0, int.MinValue });
        sStartY.ValueChanged += StartValueChanged;
        // 
        // scaleGB
        // 
        scaleGB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        scaleGB.Controls.Add(rScaleMultiplier);
        scaleGB.Location = new System.Drawing.Point(507, 447);
        scaleGB.Name = "scaleGB";
        scaleGB.Size = new System.Drawing.Size(205, 73);
        scaleGB.TabIndex = 13;
        scaleGB.TabStop = false;
        scaleGB.Text = "Scale Multiplier";
        // 
        // rScaleMultiplier
        // 
        rScaleMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        rScaleMultiplier.Cursor = System.Windows.Forms.Cursors.Hand;
        rScaleMultiplier.Location = new System.Drawing.Point(7, 22);
        rScaleMultiplier.Maximum = 50;
        rScaleMultiplier.Minimum = 1;
        rScaleMultiplier.Name = "rScaleMultiplier";
        rScaleMultiplier.Size = new System.Drawing.Size(192, 45);
        rScaleMultiplier.TabIndex = 3;
        rScaleMultiplier.TickFrequency = 5;
        rScaleMultiplier.Value = 10;
        rScaleMultiplier.Scroll += RenderScaleChanged;
        // 
        // circleGB
        // 
        circleGB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
        circleGB.Controls.Add(label1);
        circleGB.Controls.Add(cRadius);
        circleGB.Controls.Add(label2);
        circleGB.Controls.Add(cX);
        circleGB.Controls.Add(label3);
        circleGB.Controls.Add(cY);
        circleGB.Location = new System.Drawing.Point(507, 12);
        circleGB.Name = "circleGB";
        circleGB.Size = new System.Drawing.Size(205, 109);
        circleGB.TabIndex = 9;
        circleGB.TabStop = false;
        circleGB.Text = "Circle";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(33, 20);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(42, 15);
        label1.TabIndex = 2;
        label1.Text = "Radius";
        // 
        // cRadius
        // 
        cRadius.DecimalPlaces = 2;
        cRadius.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        cRadius.Location = new System.Drawing.Point(79, 18);
        cRadius.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
        cRadius.Name = "cRadius";
        cRadius.Size = new System.Drawing.Size(120, 23);
        cRadius.TabIndex = 1;
        cRadius.Value = new decimal(new int[] { 1, 0, 0, 0 });
        cRadius.ValueChanged += RadiusValueChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(59, 53);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(14, 15);
        label2.TabIndex = 4;
        label2.Text = "X";
        // 
        // cX
        // 
        cX.DecimalPlaces = 2;
        cX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        cX.Location = new System.Drawing.Point(79, 51);
        cX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        cX.Name = "cX";
        cX.Size = new System.Drawing.Size(120, 23);
        cX.TabIndex = 3;
        cX.ValueChanged += xCircleValueChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(59, 82);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(14, 15);
        label3.TabIndex = 6;
        label3.Text = "Y";
        // 
        // cY
        // 
        cY.DecimalPlaces = 2;
        cY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
        cY.Location = new System.Drawing.Point(79, 80);
        cY.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
        cY.Name = "cY";
        cY.Size = new System.Drawing.Size(120, 23);
        cY.TabIndex = 5;
        cY.ValueChanged += yCircleValueChanged;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(724, 531);
        Controls.Add(circleGB);
        Controls.Add(scaleGB);
        Controls.Add(segmentGB);
        Controls.Add(parabolaGB);
        Controls.Add(renderer);
        Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        Name = "MainForm";
        Text = "Main Form";
        parabolaGB.ResumeLayout(false);
        parabolaGB.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pFactor).EndInit();
        ((System.ComponentModel.ISupportInitialize)pX).EndInit();
        ((System.ComponentModel.ISupportInitialize)pY).EndInit();
        segmentGB.ResumeLayout(false);
        segmentEndGB.ResumeLayout(false);
        segmentEndGB.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)sEndX).EndInit();
        ((System.ComponentModel.ISupportInitialize)sEndY).EndInit();
        segmentStartGB.ResumeLayout(false);
        segmentStartGB.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)sStartX).EndInit();
        ((System.ComponentModel.ISupportInitialize)sStartY).EndInit();
        scaleGB.ResumeLayout(false);
        scaleGB.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)rScaleMultiplier).EndInit();
        circleGB.ResumeLayout(false);
        circleGB.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)cRadius).EndInit();
        ((System.ComponentModel.ISupportInitialize)cX).EndInit();
        ((System.ComponentModel.ISupportInitialize)cY).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private RenderControl renderer;
    private System.Windows.Forms.GroupBox parabolaGB;
    private System.Windows.Forms.Label pFactorText;
    private System.Windows.Forms.NumericUpDown pFactor;
    private System.Windows.Forms.Label pYText;
    private System.Windows.Forms.NumericUpDown pY;
    private System.Windows.Forms.Label pXText;
    private System.Windows.Forms.NumericUpDown pX;
    private System.Windows.Forms.GroupBox segmentGB;
    private System.Windows.Forms.TrackBar rScaleMultiplier;
    private System.Windows.Forms.GroupBox scaleGB;
    private System.Windows.Forms.GroupBox segmentStartGB;
    private System.Windows.Forms.GroupBox segmentEndGB;
    private System.Windows.Forms.Label sEndYText;
    private System.Windows.Forms.NumericUpDown sEndY;
    private System.Windows.Forms.Label sEndXText;
    private System.Windows.Forms.NumericUpDown sEndX;
    private System.Windows.Forms.Label sStartYText;
    private System.Windows.Forms.NumericUpDown sStartY;
    private System.Windows.Forms.Label sStartXText;
    private System.Windows.Forms.NumericUpDown sStartX;
    private System.Windows.Forms.GroupBox circleGB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown cRadius;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown cX;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown cY;
}

