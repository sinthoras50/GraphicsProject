using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject
{
    // helper methods for working with float
    public static class MathF
    {
        public static Func<float, float> Cos = angleR => (float)Math.Cos(angleR);
        public static Func<float, float> Sin = angleR => (float)Math.Sin(angleR);
    }

    public class Transform
    {
        public Mat4 scale;
        public Mat4 rotation;
        public Mat4 translation;

        public Transform()
        {
            Reset();
        }

        public Mat4 Transformation
        {
            get
            {
                return scale * rotation * translation;
            }

        }

        public void Reset()
        {
            float[,] id = new float[,]
                {
                    { 1, 0, 0, 0 },
                    { 0, 1, 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 }
                };

            scale = new Mat4((float[,])id.Clone());
            rotation = new Mat4((float[,])id.Clone());
            translation = new Mat4((float[,])id.Clone());
        }

        // order of transformations SRT
        public void Scale(float x, float y, float z)
        {
            scale.matrix[0, 0] = x;
            scale.matrix[1, 1] = y;
            scale.matrix[2, 2] = z;
        }

        public void Rotate(float x, float y, float z)
        {

            Mat4 rotateX = new Mat4
                (
                    new float[,]
                    {
                        { 1, 0, 0, 0 },
                        { 0, MathF.Cos(x), MathF.Sin(x), 0 },
                        { 0, -MathF.Sin(x), MathF.Cos(x), 0 },
                        { 0, 0, 0, 1 }
                    }
                );

            Mat4 rotateY = new Mat4
                (
                    new float[,]
                    {
                        { MathF.Cos(y), 0, -MathF.Sin(y), 0 },
                        { 0, 1, 0, 0 },
                        { MathF.Sin(y), 0, MathF.Cos(y), 0 },
                        { 0, 0, 0, 1 }
                    }
                );

            Mat4 rotateZ = new Mat4
                (
                    new float[,]
                    {
                        { MathF.Cos(z), -MathF.Sin(z), 0, 0 },
                        { MathF.Sin(z), MathF.Cos(z), 0, 0 },
                        { 0, 0, 1, 0 },
                        { 0, 0, 0, 1 }
                    }
                );

            rotation = rotateX * rotateY * rotateZ;
        }

        public void Translate(float x, float y, float z)
        {
            translation.matrix[0, 3] = x;
            translation.matrix[1, 3] = y;
            translation.matrix[2, 3] = z;
        }


    }
}
