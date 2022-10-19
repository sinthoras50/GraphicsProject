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

        public float ka = 0.1f;
        public float kd = 0.4f;
        public float ks = 0.6f;
        public float shininess = 0.5f;

        public Vec4 position;
        public Vec4 color;
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
        public Vec4 GetColor(Face face, Vec4 view)
        {
            float x = 0, y = 0, z = 0;
            foreach (Vec4 vec in face.vertices)
            {
                x += vec.x;
                y += vec.y;
                z += vec.z;
            }

            Vec4 centroid = new Vec4(x / 3, y / 3, z / 3, 1);

            Vec4 lightDir = (position - centroid).Normal;
            Vec4 viewDir = (view - centroid).Normal;
            Vec4 halfDir = (lightDir + viewDir).Normal;

            Vec4 normal = face.SurfaceNormal.Normal;


            float ambient = ka;
            float diffuse = kd * (lightDir * face.SurfaceNormal.Normal);
            float specular = ks * MathF.Pow(MathF.Max(normal * halfDir, 0), shininess);

            float lightning = Clamp(ambient + diffuse + specular, 0, 1);

            Vec4 output = color * lightning;

            return output;

        }

    }
}
