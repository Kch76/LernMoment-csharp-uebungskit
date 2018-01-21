using csharp_canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_uebungskit
{
    class DrawingArea
    {
        CsharpCanvas canvas;
        public DrawingArea()
        {
            // erzeuge ein neues Canvas
            canvas = new CsharpCanvas();
            
            // Vorder- und Hintergrund definieren
            canvas.SetBackgroundColor(0x00, 0xA8, 0xC6);
            canvas.SetForegroundColor(System.Drawing.Color.Blue);

            // Draw Event abonieren
            canvas.Draw += Canvas_Draw;

            // Initialisieren für kontinuierliches Zeichnen mit 30 Frames
            canvas.Setup(30);        
        }

        private void Canvas_Draw()
        {
            // Hier können Elemente gezeichnet werden
        }        
    }
}
