using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace ModrenDentalClinic.Teeth
{
    public enum ToothStatus
    {
        Healthy,
        Caries,
        Missing,
        Filled,
        Crown,
        RootCanal
    }

    public class Tooth
    {
        public int Id { get; set; }
        public SKPoint CenterNorm { get; set; }
        public float RadiusPx { get; set; } = 18f;
        public bool Selected { get; set; }
        public ToothStatus Status { get; set; } = ToothStatus.Healthy;
        public string Notes { get; set; } = string.Empty;

        public SKPoint ToPixel(SKRect viewport)
        {
            return new SKPoint(
                viewport.Left + CenterNorm.X * viewport.Width,
                viewport.Top + CenterNorm.Y * viewport.Height
            );
        }
    }

    public class ToothBridge
    {
        public List<int> ToothIds { get; set; } = new List<int>();
    }

    public partial class frmTeeth : Form
    {
        private readonly List<Tooth> teeth = new List<Tooth>();
        private readonly List<ToothBridge> bridges = new List<ToothBridge>();
        private SKBitmap upperJawImage;
        private SKBitmap lowerJawImage;
        private SKGLControl skControl;
        private readonly ToolTip toolTip = new ToolTip();

        public frmTeeth()
        {
            InitializeComponent();
            Text = "Dental Tooth Chart";
            Width = 1000;
            Height = 700;

            TryLoadImages();
            BuildTeethLayout();

            skControl = new SKGLControl { Dock = DockStyle.Fill, BackColor = Color.White };
            skControl.PaintSurface += OnPaintSurface;
            skControl.MouseMove += OnMouseMove;
            skControl.MouseClick += OnMouseClick;
            skControl.MouseDoubleClick += OnMouseDoubleClick;
            Controls.Add(skControl);

            var cm = new ContextMenuStrip();
            foreach (ToothStatus st in Enum.GetValues(typeof(ToothStatus)))
            {
                cm.Items.Add(st.ToString(), null, (s, e) =>
                {
                    var t = HitTest(lastMousePoint);
                    if (t != null)
                    {
                        t.Status = (ToothStatus)Enum.Parse(typeof(ToothStatus), ((ToolStripItem)s).Text);
                        skControl.Invalidate();
                    }
                });
            }
            cm.Items.Add(new ToolStripSeparator());
            cm.Items.Add("Create Bridge", null, (s, e) => CreateBridge());
            cm.Items.Add("Remove Bridge", null, (s, e) => RemoveBridge());
            cm.Items.Add(new ToolStripSeparator());
            cm.Items.Add("Toggle Select", null, (s, e) => { var t = HitTest(lastMousePoint); if (t != null) { t.Selected = !t.Selected; skControl.Invalidate(); } });
            skControl.ContextMenuStrip = cm;
        }

        private void CreateBridge()
        {
            var selected = teeth.Where(t => t.Selected).OrderBy(t => t.Id).ToList();
            if (selected.Count < 2) return;

            var newBridge = new ToothBridge { ToothIds = selected.Select(t => t.Id).ToList() };
            bridges.Add(newBridge);
            skControl.Invalidate();
        }

        private void RemoveBridge()
        {
            var selectedIds = teeth.Where(t => t.Selected).Select(t => t.Id).ToList();
            bridges.RemoveAll(b => b.ToothIds.Any(id => selectedIds.Contains(id)));
            skControl.Invalidate();
        }

        private void TryLoadImages()
        {
            try
            {
                string basePath = System.IO.Path.Combine(Application.StartupPath, "Resources");
                upperJawImage = SKBitmap.Decode(System.IO.Path.Combine(basePath, "upper_jaw.png"));
                lowerJawImage = SKBitmap.Decode(System.IO.Path.Combine(basePath, "lower_jaw.png"));
            }
            catch { /* ignore */ }
        }


        private void BuildTeethLayout()
        {
            teeth.Clear();
            for (int i = 0; i < 16; i++)
            {
                float t = i / 15f;
                float x = 0.05f + 0.90f * t;
                float y = 0.30f - 0.08f * (1f - (float)Math.Pow(2 * t - 1, 2));
                teeth.Add(new Tooth { Id = i + 1, CenterNorm = new SKPoint(x, y) });
            }
            for (int i = 0; i < 16; i++)
            {
                float t = i / 15f;
                float x = 0.05f + 0.90f * t;
                float y = 0.70f + 0.08f * (1f - (float)Math.Pow(2 * t - 1, 2));
                teeth.Add(new Tooth { Id = 17 + i, CenterNorm = new SKPoint(x, y) });
            }
        }

        private void OnPaintSurface(object sender, SKPaintGLSurfaceEventArgs e)
        {
            var canvas = e.Surface.Canvas;
            var info = new SKSizeI(skControl.Width, skControl.Height);
            canvas.Clear(SKColors.White);

            var viewport = new SKRect(40, 40, info.Width - 40, info.Height - 40);

            if (upperJawImage != null)
                canvas.DrawBitmap(upperJawImage, new SKRect(viewport.Left, viewport.Top, viewport.Right, viewport.MidY - 20));
            if (lowerJawImage != null)
                canvas.DrawBitmap(lowerJawImage, new SKRect(viewport.Left, viewport.MidY + 20, viewport.Right, viewport.Bottom));

            DrawBridges(canvas, viewport);

            using (var border = new SKPaint { Color = new SKColor(60, 60, 60), Style = SKPaintStyle.Stroke, StrokeWidth = 2, IsAntialias = true })
            using (var fill = new SKPaint { IsAntialias = true })
            using (var sel = new SKPaint { Color = new SKColor(100, 160, 255, 120), Style = SKPaintStyle.Fill, IsAntialias = true })
            using (var textPaint = new SKPaint { Color = SKColors.Black, TextSize = 14, IsAntialias = true })
            {
                foreach (var t in teeth)
                {
                    var center = t.ToPixel(viewport);
                    if (t.Selected) canvas.DrawCircle(center, t.RadiusPx + 6, sel);

                    fill.Color = StatusColor(t.Status);
                    canvas.DrawCircle(center, t.RadiusPx, fill);
                    canvas.DrawCircle(center, t.RadiusPx, border);

                    var label = t.Id.ToString();
                    var bounds = new SKRect();
                    textPaint.MeasureText(label, ref bounds);
                    canvas.DrawText(label, center.X - bounds.MidX, center.Y - t.RadiusPx - 6, textPaint);
                }
            }
        }

        private void DrawBridges(SKCanvas canvas, SKRect viewport)
        {
            using (var bridgePaint = new SKPaint { Color = new SKColor(212, 175, 55), Style = SKPaintStyle.Stroke, StrokeWidth = 5, IsAntialias = true })
            {
                foreach (var bridge in bridges)
                {
                    var pts = bridge.ToothIds.Select(id => teeth.First(t => t.Id == id).ToPixel(viewport)).ToList();
                    if (pts.Count < 2) continue;

                    for (int i = 0; i < pts.Count - 1; i++)
                    {
                        var p1 = pts[i];
                        var p2 = pts[i + 1];
                        var midX = (p1.X + p2.X) / 2;
                        var midY = Math.Min(p1.Y, p2.Y) - 20;
                        using (var path = new SKPath())
                        {
                            path.MoveTo(p1);
                            path.QuadTo(midX, midY, p2.X, p2.Y);
                            canvas.DrawPath(path, bridgePaint);
                        }
                    }
                }
            }
        }

        private SKColor StatusColor(ToothStatus st)
        {
            switch (st)
            {
                case ToothStatus.Healthy: return new SKColor(245, 245, 245);
                case ToothStatus.Caries: return new SKColor(200, 90, 90);
                case ToothStatus.Missing: return new SKColor(180, 180, 180);
                case ToothStatus.Filled: return new SKColor(220, 220, 120);
                case ToothStatus.Crown: return new SKColor(180, 160, 120);
                case ToothStatus.RootCanal: return new SKColor(120, 160, 200);
                default: return SKColors.White;
            }
        }

        private SKPoint lastMousePoint;

        private Tooth HitTest(SKPoint pt)
        {
            var info = new SKSizeI(skControl.Width, skControl.Height);
            var viewport = new SKRect(40, 40, info.Width - 40, info.Height - 40);
            return teeth.FirstOrDefault(t => Distance(t.ToPixel(viewport), pt) <= t.RadiusPx);
        }

        private float Distance(SKPoint a, SKPoint b)
        {
            var dx = a.X - b.X; var dy = a.Y - b.Y; return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            var skPt = new SKPoint(e.X, e.Y);
            lastMousePoint = skPt;
            var t = HitTest(skPt);
            toolTip.SetToolTip(skControl, t != null ? $"Tooth {t.Id} | {t.Status}" : string.Empty);
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            var skPt = new SKPoint(e.X, e.Y);
            var t = HitTest(skPt);
            if (t == null) return;
            if (e.Button == MouseButtons.Left)
            {
                t.Selected = !t.Selected;
                skControl.Invalidate();
            }
        }

        private void OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
            var skPt = new SKPoint(e.X, e.Y);
            var t = HitTest(skPt);
            if (t == null) return;
            using (var dlg = new ToothDetailsForm(t))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    skControl.Invalidate();
                }
            }
        }
    }

    public class ToothDetailsForm : Form
    {
        private readonly Tooth tooth;
        private ComboBox cmbStatus;
        private TextBox txtNotes;
        private Button btnOk, btnCancel;

        public ToothDetailsForm(Tooth t)
        {
            tooth = t;
            Text = $"Tooth {t.Id} Details";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MinimizeBox = false;
            MaximizeBox = false;
            ClientSize = new Size(380, 220);

            var lbl1 = new Label { Text = "Status", Left = 20, Top = 20, Width = 80 };
            cmbStatus = new ComboBox { Left = 110, Top = 16, Width = 230, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbStatus.Items.AddRange(Enum.GetNames(typeof(ToothStatus)));
            cmbStatus.SelectedItem = t.Status.ToString();

            var lbl2 = new Label { Text = "Notes", Left = 20, Top = 60, Width = 80 };
            txtNotes = new TextBox { Left = 110, Top = 56, Width = 230, Height = 90, Multiline = true, ScrollBars = ScrollBars.Vertical, Text = t.Notes };

            btnOk = new Button { Text = "OK", Left = 190, Width = 70, Top = 160, DialogResult = DialogResult.OK };
            btnCancel = new Button { Text = "Cancel", Left = 270, Width = 70, Top = 160, DialogResult = DialogResult.Cancel };

            btnOk.Click += (s, e) =>
            {
                t.Status = (ToothStatus)Enum.Parse(typeof(ToothStatus), cmbStatus.SelectedItem.ToString());
                t.Notes = txtNotes.Text ?? string.Empty;
                DialogResult = DialogResult.OK;
                Close();
            };
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            Controls.AddRange(new Control[] { lbl1, cmbStatus, lbl2, txtNotes, btnOk, btnCancel });
        }
    }
}
