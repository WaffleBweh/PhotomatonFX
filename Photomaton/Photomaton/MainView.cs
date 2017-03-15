using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photomaton
{
    public partial class MainView : Form
    {
        bool isPlaying = false;
        TransformedImage transformedImage;
        List<ImageFX> imageEffectsList;
        int currentStep = 0;
        int maxStep = 0;

        public MainView()
        {
            InitializeComponent();

            // Initialize our list
            imageEffectsList = new List<ImageFX>();

            // Add some effects
            imageEffectsList.Add(new Photomaton());

            // Add them to the list
            foreach (ImageFX effect in imageEffectsList)
            {
                lbEffects.Items.Add(effect.ToString());
            }

            // Select the first one by default
            lbEffects.SelectedIndex = 0;
        }

        /// <summary>
        /// Plays or pauses automatic stepping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            // Check if we are auto-stepping
            if (isPlaying)
            {
                // Show pause icon
                btnPlayPause.Text = "4";
            }
            else
            {
                // Show play icon
                btnPlayPause.Text = ";";
            }

            // Invert the flag and enable / disable the timer
            isPlaying = !isPlaying;
            stepTimer.Enabled = !stepTimer.Enabled;
        }

        /// <summary>
        /// Allows the user to choose an image from a dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            // Create a new dialog
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "BMP, PNG, JPG (*.bmp, *.png, *.jpg)|*.bmp;*.jpg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk, and assign it to our pictureboxes.
                    Bitmap bmp = new Bitmap(dlg.FileName);
                    pbSrc.Image = bmp;
                    pbDest.Image = bmp;

                    // When the image has been chosen, enable controls
                    btnStep.Enabled = true;
                    btnPlayPause.Enabled = true;

                    // Create our transform image from the picturebox and get the effect from the listbox
                    transformedImage = new TransformedImage(pbDest.Image, imageEffectsList[lbEffects.SelectedIndex]);

                    // Update the step count
                    UpdateStep();
                }
            }
        }


        /// <summary>
        /// Function called every 16ms when enabled (60fps)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stepTimer_Tick(object sender, EventArgs e)
        {
            // Click on the step button
            btnStep_Click(sender, e);

            // We stop when we reach the end
            if (currentStep == maxStep - 1)
            {
                btnPlayPause_Click(sender, e);
            }
        }

        /// <summary>
        /// Steps forward in the transformation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStep_Click(object sender, EventArgs e)
        {
            // Update our transform image from the picturebox and get the effect from the listbox
            transformedImage = new TransformedImage(pbDest.Image, imageEffectsList[lbEffects.SelectedIndex]);

            // Step
            transformedImage.step();

            // Show the result
            pbDest.Image = transformedImage.Image;

            // Change the step count
            // Increment by one and reset when we reach the max amount
            currentStep = (currentStep + 1) % maxStep;
            UpdateStep();
        }

        /// <summary>
        /// Updates the step value at the top of the page
        /// </summary>
        private void UpdateStep()
        {
            // Get the max step
            maxStep = transformedImage.ImageHelper.getMaxSteps(pbDest.Image.Width, pbDest.Image.Height);
            
            // Draw the count
            lblStepCount.Text = String.Format("Step : {0}/{1}", currentStep, maxStep);
        }
    }
}
