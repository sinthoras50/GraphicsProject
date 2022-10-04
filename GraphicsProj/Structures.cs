﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsProject
{

    public struct Model
    {
        public string name;
        public Mesh mesh;
        public Transform transform;

        public Model(string name, Mesh mesh, Transform transform)
        {
            this.name = name;
            this.mesh = mesh;
            this.transform = transform;
        }

        public Model(Mesh mesh, Transform transform)
        {
            this.name = "model";
            this.mesh = mesh;
            this.transform = transform;
        }
    }
    public struct Mesh
    {
        public string name;
        public Vec4[] vertices;
        public Face[] faces;

        public Mesh(string name, Vec4[] vertices, Face[] faces)
        {
            this.name = name;
            this.vertices = vertices;
            this.faces = faces;
        }

    }

    public struct Face
    {
        public Vec4[] vertices;
        public int[] indices;

        public Face(Vec4[] vertices, int[] indices)
        {
            this.vertices = vertices;
            this.indices = indices;
        }
    }

    public struct Vec4
    {
        public float x, y, z, w;

        public Vec4(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 1;
        }

        public Vec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public override string ToString()
        {
            return $"Vec4({x}, {y}, {z}, {z})";
        }

        public static float operator *(Vec4 vec1, Vec4 vec2)
        {
            return vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z + vec1.w * vec2.w;
        }

        public float this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
                    default: throw new IndexOutOfRangeException();
                }
            }

            set
            {
                switch (i)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }
    }

    public struct Mat4
    {
        public readonly float[,] matrix;

        public Mat4(float[,] matrix)
        {
            this.matrix = matrix;
        }

        public override string ToString()
        {
            string res = "";

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    res += $"{matrix[row, col]} ";
                }
                res = res.Trim() + "\n";
            }

            return res.Trim();
        }

        public Vec4 GetRow(int i)
        {
            return new Vec4(matrix[i, 0], matrix[i, 1], matrix[i, 2], matrix[i, 3]);
        }

        public Vec4 GetCol(int i)
        {
            return new Vec4(matrix[0, i], matrix[1, i], matrix[2, i], matrix[3, i]);
        }


        public static Vec4 operator *(Mat4 mat, Vec4 vec)
        {
            return new Vec4(mat.GetRow(0) * vec, mat.GetRow(1) * vec, mat.GetRow(2) * vec, mat.GetRow(3) * vec);
        }


        public static Mat4 operator *(Mat4 mat1, Mat4 mat2)
        {
            float[,] matrix = new float[4, 4];

            for (int row = 0; row < 4; row++)
            {
                Vec4 vec1 = mat1.GetRow(row);

                for (int col = 0; col < 4; col++)
                {
                    Vec4 vec2 = mat2.GetCol(col);
                    matrix[row, col] = vec1 * vec2;
                }
            }

            return new Mat4(matrix);
        }


    }
}