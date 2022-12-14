using Microsoft.Win32.SafeHandles;
using System;


namespace GraphicsProject
{

    public enum Mode
    { 
        SRT,
        STR
    }

    public class Transform
    {
        public Mat4 scale;
        public Mat4 rotation;
        public Mat4 translation;
        public Mode mode;

        public Transform()
        {
            Reset();
            mode = Mode.STR;
        }

        public Mat4 Transformation
        {
            get
            {
                return (mode == Mode.SRT) ? scale * rotation * translation : scale * translation * rotation;
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
                        { 1, 0,             0,            0 },
                        { 0, MathF.Cos(x), MathF.Sin(x),  0 },
                        { 0, -MathF.Sin(x), MathF.Cos(x), 0 },
                        { 0, 0,             0,            1 }
                    }
                );

            Mat4 rotateY = new Mat4
                (
                    new float[,]
                    {
                        { MathF.Cos(y), 0, -MathF.Sin(y), 0 },
                        { 0,            1,  0,            0 },
                        { MathF.Sin(y), 0, MathF.Cos(y),  0 },
                        { 0,            0,  0,            1 }
                    }
                );

            Mat4 rotateZ = new Mat4
                (
                    new float[,]
                    {
                        { MathF.Cos(z), -MathF.Sin(z), 0, 0 },
                        { MathF.Sin(z), MathF.Cos(z),  0, 0 },
                        { 0,            0,             1, 0 },
                        { 0,            0,             0, 1 }
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
