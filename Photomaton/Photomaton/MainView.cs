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
                dlg.Filter = "bitmap image (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk, and assign it to our pictureboxes.
                    Bitmap bmp = new Bitmap(dlg.FileName);
                    pbSrc.Image = bmp;
                    pbDest.Image = bmp;

                    // When the image has been chosen, enable controls
                    btnStep.Enabled = true;
                    btnPlayPause.Enabled = true;
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

        }

        /// <summary>
        /// Steps forward in the transformation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStep_Click(object sender, EventArgs e)
        {
            // Create our transform image from the picturebox and get the effect from the listbox
            transformedImage = new TransformedImage(pbDest.Image, imageEffectsList[lbEffects.SelectedIndex]);
        }
    }
}
