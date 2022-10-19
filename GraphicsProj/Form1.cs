using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;


namespace GraphicsProject
{


    public partial class Form1 : Form
    {

        // enable double buffering for all controls -> fixes flickering
        // https://stackoverflow.com/questions/8046560/how-to-stop-flickering-c-sharp-winforms
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private readonly Utils utils = Utils.Instance;
        private readonly Canvas canvas;
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

        private void RegisterScaleChange(object sender, EventArgs e)
        {
            if (linkXY)
            {
                numericUpDownY.Value = numericUpDownX.Value;
            }


            ((Model)model).transform.Scale((float)numericUpDownX.Value, (float)numericUpDownY.Value, (float)numericUpDownZ.Value);
            panel2.Invalidate();
        }

        private (float dx, float dy, float dz) CalculateTranslation()
        {
            float avg = ((float)numericUpDownX.Value + (float)numericUpDownY.Value) / 2;
            float dx = (scaleTranslation) ? (float)numericUpDownTranslateX.Value / avg : (float)numericUpDownTranslateX.Value;
            float dy = (scaleTranslation) ? (float)numericUpDownTranslateY.Value / avg : (float)numericUpDownTranslateY.Value;
            float dz = (scaleTranslation) ? (float)numericUpDownTranslateZ.Value / avg : (float)numericUpDownTranslateZ.Value;

            return (dx, dy, dz);
        }

        private void RegisterTranslateChange(object sender, EventArgs e)
        {

            var (dx, dy, dz) = CalculateTranslation();

            ((Model)model).transform.Translate(dx, dy, dz);
            panel2.Invalidate();
        }

        private void RegisterRotationChange(object sender, EventArgs e)
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
            checkBox1.Checked = false;

            numericUpDownKA.Value = 0.1m;
            numericUpDownKD.Value = 0.4m;
            numericUpDownKS.Value = 0.6m;
            numericUpDownShininess.Value = 0.5m;
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

            var (dx, dy, dz) = CalculateTranslation();

            ((Model)model).transform.Translate(dx, dy, dz);
            panel2.Invalidate();

        }

        private void RegisterLightningTranslationChange(object sender, EventArgs e)
        {
            canvas.SetLightningPosition((float)numericUpDownLightningX.Value, (float)numericUpDownLightningY.Value, (float)numericUpDownLightningZ.Value);

            panel2.Invalidate();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownLightningX.Enabled = !numericUpDownLightningX.Enabled;
            numericUpDownLightningY.Enabled = !numericUpDownLightningY.Enabled;
            numericUpDownLightningZ.Enabled = !numericUpDownLightningZ.Enabled;
            checkBox4.Enabled = !checkBox4.Enabled;
            numericUpDownKA.Enabled = !numericUpDownKA.Enabled;
            numericUpDownKD.Enabled = !numericUpDownKD.Enabled;
            numericUpDownKS.Enabled = !numericUpDownKS.Enabled;
            numericUpDownShininess.Enabled = !numericUpDownShininess.Enabled;

            canvas.ToggleLightning();
            panel2.Invalidate();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            canvas.ToggleDepthSort();
            panel2.Invalidate();
        }

        private void numericUpDownKA_ValueChanged(object sender, EventArgs e)
        {
            canvas.SetAmbientConstant((float)numericUpDownKA.Value);
            panel2.Invalidate();
        }

        private void numericUpDownKD_ValueChanged(object sender, EventArgs e)
        {
            canvas.SetDiffuseConstant((float)numericUpDownKD.Value);
            panel2.Invalidate();
        }

        private void numericUpDownKS_ValueChanged(object sender, EventArgs e)
        {
            canvas.SetSpecularConstant((float)numericUpDownKS.Value);
            panel2.Invalidate();
        }

        private void numericUpShininess_ValueChanged(object sender, EventArgs e)
        {
            canvas.SetShininessConstant((float)numericUpDownShininess.Value);
            panel2.Invalidate();
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            ActiveControl = null;

            ColorDialog diag = new ColorDialog();

            if (diag.ShowDialog() == DialogResult.OK)
            {
                colorPicker.BackColor = diag.Color;
                canvas.SetGlobalColor(diag.Color);
                panel2.Invalidate();
            }
        }

        private void SuppressSound(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
            }
        }

    }


    




   
}
