using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Modeling.Diagrams;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TuringPatternLibrary;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Turing
{
    public partial class Form1 : Form
    {
        public float hue1 = 0;
        public float saturation1 = 0;
        public float lightness1 = 0;

        public float hue2 = 0;
        public float saturation2 = 0;
        public float lightness2 = 0;

        // Default
        public int d0 = 1;
        public int d1 = 1;
        public int h = 1;
        public int maxt = 1000;
        public int Sizex = 100;
        public int Sizey = 100;

        public Form1()
        {
            InitializeComponent();
        }

        // End Time
        public void EndTime(object sender, EventArgs e)
        {
            end_time_bar.DecimalPlaces = 0;
            maxt = (int)end_time_bar.Value;
        }

        // Time step
        public void TimeStep(object sender, EventArgs e)
        {   
            timestep_bar.DecimalPlaces = 0; 
            h = (int)timestep_bar.Value;
        }

        // d0
        public void d0_value(object sender, EventArgs e)
        {
            d0_bar.DecimalPlaces = 0;
            d0 = (int)d0_bar.Value;
        }

        // d1
        public void d1_value(object sender, EventArgs e)
        {
            d1_bar.DecimalPlaces = 0;
            d1 = (int)d1_bar.Value;
        }

        // Size N
        public void SizeN_ValueChanged(object sender, EventArgs e)
        {   
            SizeN.DecimalPlaces = 0;
            Sizex = (int)SizeN.Value;
        }

        // Size M
        public void SizeM_ValueChanged(object sender, EventArgs e)
        {
            SizeM.DecimalPlaces = 0;
            Sizey = (int)SizeM.Value;
        }


        // Source: https://stackoverflow.com/questions/359612/how-to-convert-rgb-color-to-hsv
        float getBrightness(Color c)
        { return (c.R * 0.299f + c.G * 0.587f + c.B * 0.114f) / 256f; }

        public void color1(object sender, EventArgs e)
        {
            // Create an instance of the ColorDialog
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.Color = Color.LightBlue;

            // Show the dialog
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // The user selected a color
                Color selectedColor1 = colorDialog.Color;

                // Retrieve the RGB components
                int red1 = selectedColor1.R;
                int green1 = selectedColor1.G;
                int blue1 = selectedColor1.B;

                Color originalColor1 = Color.FromArgb(red1, green1, blue1);
                hue1 = originalColor1.GetHue();
                saturation1 = originalColor1.GetSaturation();
                lightness1 = getBrightness(originalColor1);
                Console.WriteLine(saturation1);
                Console.WriteLine(lightness1);

            }
        }

        public void color2(object sender, EventArgs e)
        {
            // Create an instance of the ColorDialog
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.Color = Color.LightCoral;

            // Show the dialog
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // The user selected a color
                Color selectedColor2 = colorDialog.Color;

                // Retrieve the RGB components
                int red2 = selectedColor2.R;
                int green2 = selectedColor2.G;
                int blue2 = selectedColor2.B;

                Color originalColor2 = Color.FromArgb(red2, green2, blue2);
                hue2 = originalColor2.GetHue();
                saturation2 = originalColor2.GetSaturation();
                lightness2 = getBrightness(originalColor2);
                Console.WriteLine(saturation2);
                Console.WriteLine(lightness2);

            }
        }

        private void Start_Button(object sender, EventArgs e)
        {
            // Disable the button to prevent multiple clicks
            StartButton.Enabled = false;

            // Create progress reporting object
            var progress = new Progress<int>(percent =>
            {
                // Update the progress bar on the UI thread
                ProgressBar.Value = percent;
            });


            TuringPattern_NamespaceNative.TuringPattern_Class ms = new TuringPattern_NamespaceNative.TuringPattern_Class();

            // Initialize progress bar
            ProgressBar.Value = 0;
            ProgressBar.Maximum = 100;


            object[] retval = ms.TuringPattern(1, d0, d1, h, maxt, Sizex, Sizey);
            double[,] TuringPattern = (double[,])retval[0];

            // Display size
            int displaySize = 1000;
            Bitmap bitmap = new Bitmap(displaySize, displaySize, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // Normalize the matrix and map it to the image
            double maxValue = TuringPattern.Cast<double>().Max();

            for (int row = 0; row < displaySize; row++)
            {
                for (int col = 0; col < displaySize; col++)
                {
                    // Scale the matrix indices to the larger image size
                    int originalRow = Math.Min((int)(row * ((Sizex - 1) / (double)displaySize)), Sizex);
                    int originalCol = Math.Min((int)(col * ((Sizey - 1) / (double)displaySize)), Sizey);

                    double value = TuringPattern[originalRow, originalCol];

                    // Interpolate hue between color1 and color2
                    float interpolatedHue = (float)(hue1 + value * (hue2 - hue1));

                    // Convert HSL to RGB
                    var (R, G, B) = ColorScaleChange.ColorFromHSL(interpolatedHue, 1, 0.5f);

                    Color color = Color.FromArgb(255, R, G, B);

                    // Set the pixel in the bitmap
                    bitmap.SetPixel(row, col, color);

                    // Report progress every row to keep the UI responsive
                    int progressPercent = (int)((float)row / displaySize * 100);
                    ((IProgress<int>)progress).Report(progressPercent);
                    }
            }

            TuringPicturebox.SizeMode = PictureBoxSizeMode.Zoom;
            TuringPicturebox.Image = bitmap;
            ((IProgress<int>)progress).Report(0);
            StartButton.Enabled = true; 
        }
    }
}
