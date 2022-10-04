using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsProject
{
    public class Canvas
    {
        private const float SCALE = 4;
        private float width, height;
        public float x;
        public float y;
        public Canvas(float width, float height)
        {
            this.width = width;
            this.height = height;

            x = width / 2;
            y = height / 2;

            Console.WriteLine($"middle x = {x}, middle y = {y}");
        }

        private float Rescale(float x)
        {
            return this.x * x / SCALE;
        }

        public void Paint(Graphics g)
        {
            g.DrawLine(Pens.LightGray, x, 0, x, height);
            g.DrawLine(Pens.LightGray, 0, y, width, y);

            int c = 15;
            var axes = new Dictionary<PointF, String>()
            {
                { new PointF(c, y+c), $"-{SCALE}" },
                { new PointF(width-c, y+c), $"{SCALE}" },
                { new PointF(x-c, height-c), $"-{SCALE}" },
                { new PointF(x-10, c), $"{SCALE}"}
            };

            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            foreach (var entry in axes)
            {
                g.DrawString(entry.Value, new Font("Arial", 16), Brushes.Gray, entry.Key, format);
            }


        }

        public void DrawMesh(Mesh mesh, float scalingFactor, Graphics g)
        {

            foreach (Face face in mesh.faces)
            {

                PointF[] points = face.vertices
                    .Select(vertex => new PointF(Rescale(vertex.x) * scalingFactor + x, (-Rescale(vertex.y) * scalingFactor + y)))
                    .ToArray();

                //Console.WriteLine(String.Join(" ", points));


                g.DrawPolygon(Pens.Blue, points);

            }

        }

        public void DrawMesh(Mesh mesh, Mat4 transform, Graphics g)
        {
            foreach (Face face in mesh.faces)
            {

                PointF[] points = face.vertices
                    .Select(vertex => new PointF(Rescale((transform * vertex).x) + x, (-Rescale((transform * vertex).y) + y)))
                    .ToArray();

                //Console.WriteLine(String.Join(" ", points));


                g.DrawPolygon(Pens.Blue, points);

            }
        }
    }
}
