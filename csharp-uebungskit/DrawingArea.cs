
using Lernmoment.CsharpCanvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_uebungskit
{
    class DrawingArea
    {
        private CsharpCanvas canvas;
        public DrawingArea(CsharpCanvas aCanvas)
        {
            canvas = aCanvas;
            // Vorder- und Hintergrund definieren
            canvas.SetBackgroundColor(0x00, 0xA8, 0xC6);
            canvas.SetForegroundColor(System.Drawing.Color.Blue);

            // Draw Event abonieren
            canvas.Draw += Canvas_Draw;

            // Startwerte für den i-Punkt setzten
            GoesUp = true;
            DotLocation = 225;

            // initialisiert das canvas
            canvas.Init(30);
        }

        private bool GoesUp { get; set; }
        private int DotLocation { get; set; }

        private void Canvas_Draw()
        {
            // Hier können Elemente gezeichnet werden

            // Zuerst erstellen wir einen Strich
            canvas.AddRectangle(275, 300, 50, 300, Fill.Fill);

            // einen Punkt an die aktuelle Position zeichnen
            canvas.AddCircle(300, DotLocation, 50, Fill.Fill);

            // Richtung überprüfen und die nächste Position festlegen
            if (GoesUp)
            {
                // um nach oben zu wnadern, muss die Position kleiner werden
                DotLocation = DotLocation - 5;

                // wenn der i-Punkt eine Position höher als 150 erreicht hat, wechslen wir die Richtung
                if (DotLocation <= 150)
                    GoesUp = false;
            }
            else
            {
                // um nach unten zu wnadern, muss die Position größer werden
                DotLocation = DotLocation + 5;

                // wenn der i-Punkt eine Position tiefer als 225 erreicht hat, wechslen wir die Richtung
                if (DotLocation >= 225)
                    GoesUp = true;
            }
        }
    }
}
