using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsProject
{
    public sealed class Utils
    {

        private static readonly Utils instance = new Utils();
        private Utils() { }

        public static Utils Instance
        {
            get
            {
                return instance;
            }
        }

        private string[] LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = ".obj|*.obj"
            };
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;

                try
                {
                    return File.ReadAllLines(file);
                }
                catch (IOException err)
                {
                    Console.WriteLine(err);
                }

            }

            throw new Exception("File selection cancelled.");

            //return content;
        }

        public Mesh BuildMesh()
        {
            string[] content = LoadFile();

            //if (content == null) throw new Exception("Unable to build mesh.");

            List<Vec4> vertices = new List<Vec4>();
            List<Face> faces = new List<Face>();
            string name = "mesh";

            foreach (string line in content)
            {
                string[] parts = Regex.Split(line.Trim(), @"\s+");

                switch (parts[0])
                {
                    case "o":
                        name = String.Join(" ", parts.Skip(1));
                        break;
                    case "v":
                        vertices.Add(new Vec4(float.Parse(parts[1]), float.Parse(parts[2]), float.Parse(parts[3])));
                        break;
                    case "f":
                        int[] indices = parts // filter out vn and vt indices convert to 0 indexed system
                            .Skip(1)
                            .Select(str => int.Parse(Regex.Split(str, @"/+")[0]) - 1)
                            .ToArray();

                        Vec4[] faceVertices = indices // retrieve vertices given indices
                            .Select(index => vertices[index])
                            .ToArray();

                        faces.Add(new Face(faceVertices, indices));
                        break;

                }

            }

            Console.WriteLine($"object name = {name}");
            return new Mesh(name, vertices.ToArray(), faces.ToArray());
        }

    }
}
