
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace xam_onlineticket.Behaviors
{
    public class TicketBackgroundBehavior : Behavior<SKCanvasView>
    {
        protected override void OnAttachedTo(SKCanvasView bindable)
        {
            bindable.PaintSurface += AssociatedObject_PaintSurface;
        }

        protected override void OnDetachingFrom(SKCanvasView bindable)
        {
            bindable.PaintSurface -= AssociatedObject_PaintSurface;
        }

        private void AssociatedObject_PaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            using (SKPath path = new SKPath())
            {
                path.MoveTo(0, 20);
                path.QuadTo(0, 0, 20, 0);
                path.LineTo(info.Width * 0.27f, 0);
                path.CubicTo(info.Width * 0.275f, info.Height * 0.09f, info.Width * 0.305f, info.Height * 0.09f, info.Width * 0.31f, 0);
                path.LineTo(info.Width -20, 0);
                path.QuadTo(info.Width, 0, info.Width, 20);
                path.LineTo(info.Width, info.Height - 20);
                path.QuadTo(info.Width, info.Height, info.Width - 20, info.Height);
                path.LineTo(info.Width * 0.31f, info.Height);
                path.CubicTo(info.Width * 0.305f, info.Height * 0.91f, info.Width * 0.275f, info.Height * 0.91f, info.Width * 0.27f, info.Height);
                path.LineTo(20, info.Height);
                path.QuadTo(0, info.Height, 0, info.Height-20);
                path.Close();

                path.MoveTo(info.Width * 0.29f, info.Height * 0.1f);
                path.CubicTo(info.Width * 0.28f, info.Height * 0.12f,
                             info.Width * 0.28f, info.Height * 0.19f,
                             info.Width * 0.29f, info.Height * 0.2f);

                path.CubicTo(info.Width * 0.30f, info.Height * 0.19f,
                             info.Width * 0.30f, info.Height * 0.12f,
                             info.Width * 0.29f, info.Height * 0.1f);

                path.MoveTo(info.Width * 0.29f, info.Height * 0.24f);
                path.CubicTo(info.Width * 0.28f, info.Height * 0.25f,
                             info.Width * 0.28f, info.Height * 0.33f,
                             info.Width * 0.29f, info.Height * 0.34f);

                path.CubicTo(info.Width * 0.30f, info.Height * 0.33f,
                             info.Width * 0.30f, info.Height * 0.25f,
                             info.Width * 0.29f, info.Height * 0.24f);

                path.MoveTo(info.Width * 0.29f, info.Height * 0.38f);
                path.CubicTo(info.Width * 0.28f, info.Height * 0.39f,
                             info.Width * 0.28f, info.Height * 0.47f,
                             info.Width * 0.29f, info.Height * 0.48f);

                path.CubicTo(info.Width * 0.30f, info.Height * 0.47f,
                             info.Width * 0.30f, info.Height * 0.39f,
                             info.Width * 0.29f, info.Height * 0.38f);

                path.MoveTo(info.Width * 0.29f, info.Height * 0.52f);
                path.CubicTo(info.Width * 0.28f, info.Height * 0.53f,
                             info.Width * 0.28f, info.Height * 0.61f,
                             info.Width * 0.29f, info.Height * 0.62f);

                path.CubicTo(info.Width * 0.30f, info.Height * 0.61f,
                             info.Width * 0.30f, info.Height * 0.53f,
                             info.Width * 0.29f, info.Height * 0.52f);

                path.MoveTo(info.Width * 0.29f, info.Height * 0.66f);
                path.CubicTo(info.Width * 0.28f, info.Height * 0.67f,
                             info.Width * 0.28f, info.Height * 0.75f,
                             info.Width * 0.29f, info.Height * 0.76f);

                path.CubicTo(info.Width * 0.30f, info.Height * 0.75f,
                             info.Width * 0.30f, info.Height * 0.67f,
                             info.Width * 0.29f, info.Height * 0.66f);

                path.MoveTo(info.Width * 0.29f, info.Height * 0.8f);
                path.CubicTo(info.Width * 0.28f, info.Height * 0.81f,
                             info.Width * 0.28f, info.Height * 0.89f,
                             info.Width * 0.29f, info.Height * 0.9f);

                path.CubicTo(info.Width * 0.30f, info.Height * 0.89f,
                             info.Width * 0.30f, info.Height * 0.81f,
                             info.Width * 0.29f, info.Height * 0.8f);


                using (SKPaint paint = new SKPaint())
                {
                    paint.IsAntialias = true;
                    paint.Style = SKPaintStyle.Fill;
                    paint.Color = SKColor.Parse("#9b1d75");

                    paint.Shader = SKShader.CreateLinearGradient(
                                            new SKPoint(info.Width * 0.29f, 0),
                                            new SKPoint(0, 0),
                                            new SKColor[] { ((Color)App.Current.Resources["TertiaryColor"]).ToSKColor(), (Color.White).ToSKColor() },
                                            new float[] { 0, 0 },
                                            SKShaderTileMode.Clamp);
                    canvas.DrawPath(path, paint);
                }
            }
        }

    }
}
