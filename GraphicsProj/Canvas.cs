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
        private readonly Lightning lightning;

        public Canvas(float width, float height)
        {
            this.width = width;
            this.height = height;
            lightning = Lightning.Instance;

            x = width / 2;
            y = height / 2;

            Console.WriteLine($"middle x = {x}, middle y = {y}");
        }

        private float Rescale(float x)
        {
            return this.x * x / SCALE;
        }

        public void SetLightningPosition(float x, float y, float z)
        {
            lightning.SetPosition(x, y, z);
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

            Face[] faces = mesh.faces.OrderByDescending(face => face.vertices.Average(vertex => vertex.z)).ToArray();


            foreach (Face face in faces)
            {

                PointF[] points = face.vertices
                    .Select(vertex => new PointF(Rescale(vertex.x) * scalingFactor + x, (-Rescale(vertex.y) * scalingFactor + y)))
                    .ToArray();

                //Console.WriteLine(String.Join(" ", points));
                Console.WriteLine(face.vertices.Average(vertex => vertex.z));

                if (!CullFace2D(points)) g.DrawPolygon(Pens.Blue, points);

                g.DrawPolygon(Pens.Blue, points);

            }

        }

        public void DrawMesh(Mesh mesh, Mat4 transform, Graphics g)
        {

            int culled = 0;
            int drawn = 0;

            Image buffer = new Bitmap((int)width, (int)height);
            Graphics gr = Graphics.FromImage(buffer);

            var start = DateTime.Now;


            // apply transform to all faces, sort by average z, render from back to front
            Face[] faces = mesh.faces
                .Select(face => face.ApplyTransform(transform))
                .OrderBy(face => face.vertices.Average(vertex => vertex.z)).ToArray();


            foreach (Face face in faces)
            {

                //PointF[] points = face.vertices
                //    .Select(vertex => new PointF(Rescale((transform * vertex).x) + x, (-Rescale((transform * vertex).y) + y)))
                //    .ToArray();

                // move x, y points to the middle of the screen
                PointF[] points = face.vertices
                    .Select(vertex => new PointF(Rescale(vertex.x) + x, -Rescale(vertex.y) + y))
                    .ToArray();

                //Console.WriteLine(String.Join(" ", points));

                //Console.WriteLine(face.vertices.Average(vertex => vertex.z));

                //Vec4[] tempVertices = face.vertices
                //    .Select(vertex => new Vec4((transform * vertex).x, (transform * vertex).y, (transform * vertex).z, vertex.w))
                //    .ToArray();


                //Face tempFace = new Face(tempVertices, face.indices);

                if (!CullFace3D(points))
                {

                    Vec4 color = lightning.GetDiffuseColor(face);
                    //Vec4 color = lightning.GetDiffuseColor(face, new Vec4(0, 0, 4));
                    Brush brush = new SolidBrush(Color.FromArgb((int)color.x, (int)color.y, (int)color.z));
                    gr.FillPolygon(brush, points);
                    //gr.DrawPolygon(Pens.Blue, points);
                    drawn++;

                }
                else culled++;
                
            }
            var end = DateTime.Now - start;

            Console.WriteLine($"execution time = {end}");
            Console.WriteLine($"culled count = {culled}, drawn count = {drawn}");

            gr.Dispose();
            g.DrawImage(buffer, 0, 0);
            buffer.Dispose();
            
        }
    }
}
