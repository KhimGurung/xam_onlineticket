
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace xam_onlineticket.Behaviors
{
    public class TicketDividerBehavior : Behavior<SKCanvasView>
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
                path.MoveTo(0, 0);
                path.LineTo(info.Width, 0);
                path.CubicTo(info.Width * 0.96f, info.Height * 0.1f, info.Width * 0.96f, info.Height * 0.9f, info.Width, info.Height);
                path.LineTo(0, info.Height);
                path.CubicTo(info.Width * 0.04f, info.Height * 0.9f, info.Width * 0.04f, info.Height * 0.1f, 0, 0);
                path.Close();

                path.MoveTo(info.Width * 0.08f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.09f, info.Height * 0.8f,
                            info.Width * 0.12f, info.Height * 0.8f,
                            info.Width * 0.13f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.12f, info.Height * 0.2f,
                            info.Width * 0.09f, info.Height * 0.2f,
                            info.Width * 0.08f, info.Height * 0.5f);

                path.MoveTo(info.Width * 0.18f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.19f, info.Height * 0.8f,
                            info.Width * 0.22f, info.Height * 0.8f,
                            info.Width * 0.23f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.22f, info.Height * 0.2f,
                            info.Width * 0.19f, info.Height * 0.2f,
                            info.Width * 0.18f, info.Height * 0.5f);

                path.MoveTo(info.Width * 0.28f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.29f, info.Height * 0.8f,
                            info.Width * 0.32f, info.Height * 0.8f,
                            info.Width * 0.33f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.32f, info.Height * 0.2f,
                            info.Width * 0.29f, info.Height * 0.2f,
                            info.Width * 0.28f, info.Height * 0.5f);

                path.MoveTo(info.Width * 0.38f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.39f, info.Height * 0.8f,
                            info.Width * 0.42f, info.Height * 0.8f,
                            info.Width * 0.43f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.42f, info.Height * 0.2f,
                            info.Width * 0.39f, info.Height * 0.2f,
                            info.Width * 0.38f, info.Height * 0.5f);

                path.MoveTo(info.Width * 0.48f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.49f, info.Height * 0.8f,
                            info.Width * 0.52f, info.Height * 0.8f,
                            info.Width * 0.53f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.52f, info.Height * 0.2f,
                            info.Width * 0.49f, info.Height * 0.2f,
                            info.Width * 0.48f, info.Height * 0.5f);

                path.MoveTo(info.Width * 0.58f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.59f, info.Height * 0.8f,
                            info.Width * 0.62f, info.Height * 0.8f,
                            info.Width * 0.63f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.62f, info.Height * 0.2f,
                            info.Width * 0.59f, info.Height * 0.2f,
                            info.Width * 0.58f, info.Height * 0.5f);

                path.MoveTo(info.Width * 0.68f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.69f, info.Height * 0.8f,
                            info.Width * 0.72f, info.Height * 0.8f,
                            info.Width * 0.73f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.72f, info.Height * 0.2f,
                            info.Width * 0.69f, info.Height * 0.2f,
                            info.Width * 0.68f, info.Height * 0.5f);

                path.MoveTo(info.Width * 0.78f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.79f, info.Height * 0.8f,
                            info.Width * 0.82f, info.Height * 0.8f,
                            info.Width * 0.83f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.82f, info.Height * 0.2f,
                            info.Width * 0.79f, info.Height * 0.2f,
                            info.Width * 0.78f, info.Height * 0.5f);

                path.MoveTo(info.Width * 0.88f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.89f, info.Height * 0.8f,
                            info.Width * 0.92f, info.Height * 0.8f,
                            info.Width * 0.93f, info.Height * 0.5f);
                path.CubicTo(info.Width * 0.92f, info.Height * 0.2f,
                            info.Width * 0.89f, info.Height * 0.2f,
                            info.Width * 0.88f, info.Height * 0.5f);


                using (SKPaint paint = new SKPaint())
                {
                    paint.IsAntialias = true;
                    paint.Style = SKPaintStyle.Fill;
                    paint.Color = SKColor.Parse("#9b1d75");

                    paint.Shader = SKShader.CreateLinearGradient(
                                            new SKPoint(0 , info.Height * 0.5f),
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
