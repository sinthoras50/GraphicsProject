using System;
using System.Drawing;
using System.Windows.Forms;


namespace GraphicsProject
{


    public partial class Form1 : Form
    {

        private readonly Utils utils = Utils.Instance;
        private readonly Canvas canvas;
        private float scalingFactor = 1;
        private bool linkXY = false;
        private bool scaleTranslation = false;
        private Model? model = null;
        public Form1()
        {
            InitializeComponent();
            canvas = new Canvas(panel2.Width, panel2.Height);

            Console.WriteLine($"panel width = {panel2.Width}, panel height = {panel2.Height}");
        }

        private void EnableControls()
        {
            checkBox1.Enabled = true;
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

        private void RegisterScaleChange()
        {
            if (linkXY)
            {
                numericUpDownY.Value = numericUpDownX.Value;
            }


            ((Model)model).transform.Scale((float)numericUpDownX.Value, (float)numericUpDownY.Value, (float)numericUpDownZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            RegisterScaleChange();
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            RegisterScaleChange();
        }

        private void numericUpDownZ_ValueChanged(object sender, EventArgs e)
        {
            RegisterScaleChange();
        }
        private void RegisterTranslateChange()
        {
            float avg = ((float)numericUpDownX.Value + (float)numericUpDownY.Value) / 2;
            float dx = (scaleTranslation) ? (float)numericUpDownTranslateX.Value / avg : (float)numericUpDownTranslateX.Value;
            float dy = (scaleTranslation) ? (float)numericUpDownTranslateY.Value / avg : (float)numericUpDownTranslateY.Value;
            float dz = (scaleTranslation) ? (float)numericUpDownTranslateZ.Value / avg : (float)numericUpDownTranslateZ.Value;

            ((Model)model).transform.Translate(dx, dy, dz);
            panel2.Invalidate();
        }
        private void numericUpDownTranslateX_ValueChanged(object sender, EventArgs e)
        {
            RegisterTranslateChange();
        }

        private void numericUpDownTranslateY_ValueChanged(object sender, EventArgs e)
        {
            RegisterTranslateChange();
        }

        private void numericUpDownTranslateZ_ValueChanged(object sender, EventArgs e)
        {
            RegisterTranslateChange();
        }

        private void RegisterRotationChange()
        {
            ((Model)model).transform.Rotate((float)numericUpDownRotationX.Value, (float)numericUpDownRotationY.Value, (float)numericUpDownRotationZ.Value);
            panel2.Invalidate();
        }

        private void numericUpDownRotationX_ValueChanged(object sender, EventArgs e)
        {
            RegisterRotationChange();
        }

        private void numericUpDownRotationY_ValueChanged(object sender, EventArgs e)
        {
            RegisterRotationChange();
        }

        private void numericUpDownRotationZ_ValueChanged(object sender, EventArgs e)
        {
            RegisterRotationChange(); ;
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
            panel2.Invalidate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) ((Model)model).transform.mode = Mode.SRT;
            panel2.Invalidate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ActiveControl = null;

            linkXY = checkBox1.Checked;
            numericUpDownY.Enabled = !numericUpDownY.Enabled;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ActiveControl = null;

            scaleTranslation = checkBox2.Checked;

            panel2.Invalidate();

        }

        private void RegisterLightningTranslationChange()
        {
            canvas.SetLightningPosition((float)numericUpDownLightningX.Value, (float)numericUpDownLightningY.Value, (float)numericUpDownLightningZ.Value);

            panel2.Invalidate();
        }

        private void numericUpDownLightningX_ValueChanged(object sender, EventArgs e)
        {
            RegisterLightningTranslationChange();
        }

        private void numericUpDownLightningY_ValueChanged(object sender, EventArgs e)
        {
            RegisterLightningTranslationChange();
        }

        private void numericUpDownLightningZ_ValueChanged(object sender, EventArgs e)
        {
            RegisterLightningTranslationChange();
        }
    }


    




   
}
