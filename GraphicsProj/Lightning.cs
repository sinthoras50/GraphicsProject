using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsProject
{
    public sealed class Lightning
    {
        private static readonly Lightning instance = new Lightning();

        public static Vec4 position;
        public static Vec4 color;
        private Lightning() 
        {
            position = new Vec4(0, 0, 4);
            color = new Vec4(102, 153, 255);
        }

        public static Lightning Instance 
        {
            get 
            { 
                return instance; 
            } 
        }

        public void SetPosition(float x, float y, float z)
        {
            position = new Vec4(x, y, z);
        }

        public void SetGlobalColor(float x, float y, float z, float alpha=1)
        {
            color = new Vec4(x, y, z, alpha);
        }

        private float Clamp(float x, float min, float max)
        {
            return MathF.Min(MathF.Max(x, min), max);
        }

        public Vec4 GetDiffuseColor(Face face)
        {

            Vec4 toLight = (position - face.SurfaceNormal).Normal;
            Console.WriteLine(toLight);

            float angle = toLight * face.SurfaceNormal.Normal;
            //Console.WriteLine($"angle = {angle}");
            angle = Clamp(angle, 0, 1);
            //angle = Math.Abs(angle);
            //Console.WriteLine($"angle = {angle}");



            return new Vec4(color.x * angle, color.y * angle, color.z * angle, color.z);
        }

        public Vec4 GetDiffuseColor(Face face, Vec4 view)
        {
            Vec4 toLight = (position - face.SurfaceNormal).Normal;
            Vec4 normal = face.SurfaceNormal.Normal;
            Vec4 temp = (toLight + view).Normal;
            Vec4 half = new Vec4(temp.x / 2, temp.y / 2, temp.z / 2, temp.w / 2).Normal;

            float angle = (toLight * normal) + (half * normal);
            Console.WriteLine(angle);
            angle = Clamp(angle, 0, 1);
            Console.WriteLine(angle);

            return new Vec4(color.x * angle, color.y * angle, color.z * angle, color.z);
        }

    }
}
