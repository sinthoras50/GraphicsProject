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
        private readonly float width, height, x, y;

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

        private bool CullFace3D(PointF[] points)
        {
            Vec4 camera = new Vec4(0, 0, -SCALE, 1);

            Vec4 v1 = new Vec4(points[0].X, points[0].Y, 0);
            Vec4 v2 = new Vec4(points[1].X, points[1].Y, 0);
            Vec4 v3 = new Vec4(points[2].X, points[2].Y, 0);
            Face face = new Face(new Vec4[] { v1, v2, v3 }, new int[3]);

            float product = (v1 - camera) * face.SurfaceNormal;

            //Console.WriteLine(product);

            return product >= 0;

        }

        private bool CullFace2D(PointF[] points)
        {

            Vec4 v1 = new Vec4(points[0].X, points[0].Y, 0);
            Vec4 v2 = new Vec4(points[1].X, points[1].Y, 0);
            Vec4 v3 = new Vec4(points[2].X, points[2].Y, 0);

            float x1 = v3.x - v1.x;
            float y1 = v3.y - v1.y;
            float x2 = v3.x - v2.x;
            float y2 = v3.y - v2.y;

            float product = (x1 * y2) - (y1 * x2);

            //Console.WriteLine(product);

            return product >= 0;

        }

        public void DrawMesh(Mesh mesh, float scalingFactor, Graphics g)
        {

            foreach (Face face in mesh.faces)
            {

                PointF[] points = face.vertices
                    .Select(vertex => new PointF(Rescale(vertex.x) * scalingFactor + x, (-Rescale(vertex.y) * scalingFactor + y)))
                    .ToArray();

                //Console.WriteLine(String.Join(" ", points));

                if (!CullFace2D(points)) g.DrawPolygon(Pens.Blue, points);

            }

        }

        public void DrawMesh(Mesh mesh, Mat4 transform, Graphics g)
        {

            Image buffer = new Bitmap((int)width, (int)height);
            Graphics gr = Graphics.FromImage(buffer);

            foreach (Face face in mesh.faces)
            {

                PointF[] points = face.vertices
                    .Select(vertex => new PointF(Rescale((transform * vertex).x) + x, (-Rescale((transform * vertex).y) + y)))
                    .ToArray();

                //Console.WriteLine(String.Join(" ", points));

                if (!CullFace2D(points)) gr.DrawPolygon(Pens.Blue, points);

            }

            gr.Dispose();
            g.DrawImage(buffer, 0, 0);
            buffer.Dispose();
        }
    }
}
