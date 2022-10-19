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
        private Vec4 view = new Vec4(0, 0, SCALE, 1);
        private readonly float width, height, x, y;
        private readonly Lightning lightning;
        private bool isLightningEnabled = true;
        private bool isDepthSortEnabled = true;

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

        public void ToggleLightning()
        {
            isLightningEnabled = !isLightningEnabled;
        }

        public void ToggleDepthSort()
        {
            isDepthSortEnabled = !isDepthSortEnabled;
        }

        public void SetLightningPosition(float x, float y, float z)
        {
            lightning.SetPosition(x, y, z);
        }

        public void SetGlobalColor(Color c)
        {
            lightning.SetGlobalColor(c.R, c.G, c.B, c.A);
        }

        public void SetAmbientConstant(float n)
        {
            lightning.ka = n;
        }

        public void SetDiffuseConstant(float n)
        {
            lightning.kd = n;
        }

        public void SetSpecularConstant(float n)
        {
            lightning.ks = n;
        }

        public void SetShininessConstant(float n)
        {
            lightning.shininess = n;
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

        private bool CullFace(PointF[] points)
        {
            Vec4 camera = new Vec4(width, height, SCALE, 1); // left handed system, assume camera z > 0

            Vec4 v1 = new Vec4(points[0].X, points[0].Y, 0);
            Vec4 v2 = new Vec4(points[1].X, points[1].Y, 0);
            Vec4 v3 = new Vec4(points[2].X, points[2].Y, 0);
            Face face = new Face(new Vec4[] { v1, v2, v3 }, new int[3]);

            float product = (v1 - camera) * face.SurfaceNormal;

            //Console.WriteLine(product);

            return product <= 0;

        }


        public void DrawMesh(Mesh mesh, Mat4 transform, Graphics g)
        {

            int culled = 0;
            int drawn = 0;

            Image buffer = new Bitmap((int)width, (int)height);
            Graphics gr = Graphics.FromImage(buffer);

            var start = DateTime.Now;

            // apply transform to all faces
            Face[] faces = mesh.faces
                    .Select(face => face.ApplyTransform(transform))
                    .ToArray();


            // sort by average z, render from back to front -> depth sort
            if (isDepthSortEnabled)
            {
                faces = faces
                    .OrderBy(face => face.vertices.Average(vertex => vertex.z))
                    .ToArray();
            }


            foreach (Face face in faces)
            {

                // move x, y points to the middle of the screen
                PointF[] points = face.vertices
                    .Select(vertex => new PointF(Rescale(vertex.x) + x, -Rescale(vertex.y) + y))
                    .ToArray();

                if (!CullFace(points))
                {

                    if (isLightningEnabled)
                    {
                        Vec4 color = lightning.GetColor(face, view);
                        Brush brush = new SolidBrush(Color.FromArgb((int)color.x, (int)color.y, (int)color.z));
                        gr.FillPolygon(brush, points);
                    }
                    else
                    {
                        gr.DrawPolygon(Pens.Blue, points);
                    }


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
