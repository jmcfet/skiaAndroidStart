using Android.App;
using Android.Widget;
using Android.OS;
using SkiaSharp.Views.Android;
using SkiaSharp;
using System.Collections.Generic;
using System.Drawing;

namespace androidSkia
{
    [Activity(Label = "androidSkia", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        List<EllipseDrawingFigure> completedFigures = new List<EllipseDrawingFigure>();
        SKCanvasView canvasView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            canvasView = FindViewById<SKCanvasView>(Resource.Id.canvasView);
                       
            canvasView.PaintSurface += CanvasView_PaintSurface;
        }
        private void CanvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            SKCanvas canvas = e.Surface.Canvas;
            canvas.Clear();
            var circleFill = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                Color = SKColors.Blue
            };
            
            // DRAWING SHAPES


            // draw the circle fill
             canvas.DrawCircle(100, 100, 40, circleFill);
        }

       

    }
}

