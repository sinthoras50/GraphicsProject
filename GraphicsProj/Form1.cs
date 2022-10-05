using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Http.Headers;
using System.CodeDom;

namespace GraphicsProject
{


    public partial class Form1 : Form
    {

        private readonly Utils utils = Utils.Instance;
        private readonly Canvas canvas;
        private float scalingFactor = 1;
        private Model? model = null;
        public Form1()
        {
            InitializeComponent();
            canvas = new Canvas(panel2.Width, panel2.Height);
            Console.WriteLine($"panel width = {panel2.Width}, panel height = {panel2.Height}");
        }

        private void EnableControls()
        {
            numericUpDownRotationX.Enabled = true;
            numericUpDownRotationY.Enabled = true;
            numericUpDownRotationZ.Enabled = true;
            numericUpDownTranslateX.Enabled = true;
            numericUpDownTranslateY.Enabled = true;
            numericUpDownTranslateZ.Enabled = true;
            numericUpDownX.Enabled = true;
            numericUpDownY.Enabled = true;
            numericUpDownZ.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mesh m = utils.BuildMesh();
                model = new Model(m.name, m, new Transform());
                panel2.Invalidate();
                ResetControls();
                EnableControls();
            }
            catch (Exception err) {
                Console.WriteLine(err);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            canvas.Paint(e.Graphics);
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);

            if (model != null)
            {
                canvas.DrawMesh(((Model)model).mesh, ((Model)model).transform.Transformation, e.Graphics);
            }

        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Scale((float)numericUpDownX.Value, (float)numericUpDownY.Value, (float)numericUpDownZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Scale((float)numericUpDownX.Value, (float)numericUpDownY.Value, (float)numericUpDownZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownZ_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Scale((float)numericUpDownX.Value, (float)numericUpDownY.Value, (float)numericUpDownZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownTranslateX_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Translate((float)numericUpDownTranslateX.Value, (float)numericUpDownTranslateY.Value, (float)numericUpDownTranslateZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownTranslateY_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Translate((float)numericUpDownTranslateX.Value, (float)numericUpDownTranslateY.Value, (float)numericUpDownTranslateZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownTranslateZ_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Translate((float)numericUpDownTranslateX.Value, (float)numericUpDownTranslateY.Value, (float)numericUpDownTranslateZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownRotationX_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Rotate((float)numericUpDownRotationX.Value, (float)numericUpDownRotationY.Value, (float)numericUpDownRotationZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownRotationY_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Rotate((float)numericUpDownRotationX.Value, (float)numericUpDownRotationY.Value, (float)numericUpDownRotationZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownRotationZ_ValueChanged(object sender, EventArgs e)
        {
            ((Model)model).transform.Rotate((float)numericUpDownRotationX.Value, (float)numericUpDownRotationY.Value, (float)numericUpDownRotationZ.Value);
            panel2.Invalidate();
        }

        private void ResetControls()
        {
            numericUpDownRotationX.Value = 0;
            numericUpDownRotationY.Value = 0;
            numericUpDownRotationZ.Value = 0;
            numericUpDownTranslateX.Value = 0;
            numericUpDownTranslateY.Value = 0;
            numericUpDownTranslateZ.Value = 0;
            numericUpDownX.Value = 1;
            numericUpDownY.Value = 1;
            numericUpDownZ.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (model == null) return;

            ResetControls();

            ((Model)model).transform.Reset();
            panel2.Invalidate();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) ((Model)model).transform.mode = Mode.STR;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) ((Model)model).transform.mode = Mode.SRT;
        }
    }


    




   
}
