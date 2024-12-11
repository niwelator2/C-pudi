//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

//namespace Forms_good
//{
//    public partial class imagelist : Form
//    {
//        // List of PictureBoxes
//        private PictureBox[] pictureBoxes;
//        //public  Image1 = "menu.jpg";
//        //public Image2 = "menu.jpg";
//        //public Image3 = "menu.jpg";
//        public imagelist()
//        {
//            InitializeComponent();
           
//        }

//        private void imagelist_Load(object sender, EventArgs e)
//        {
//            // Add your PictureBox controls to an array for easier management
//            pictureBoxes = new[] { pictureBox1, pictureBox2, pictureBox3 };

//            // Attach click event handlers to all PictureBoxes
//            foreach (var pictureBox in pictureBoxes)
//            {
//                pictureBox.Click += PictureBox_Click;
//            }
//        }

//        // Event handler for PictureBox click
//        private void PictureBox_Click(object sender, EventArgs e)
//        {
//            // Get the clicked PictureBox
//            PictureBox selectedPictureBox = sender as PictureBox;

//            // Highlight the selected PictureBox and gray out the others
//            foreach (var pictureBox in pictureBoxes)
//            {
//                if (pictureBox == selectedPictureBox)
//                {
//                    // Restore the original image for the selected PictureBox
//                    pictureBox.Image = (Image)pictureBox.Tag; // Assume the original image is stored in Tag
//                }
//                else
//                {
//                    // Set the image to a grayscale version for unselected PictureBoxes
//                    pictureBox.Image = GrayscaleImage((Image)pictureBox.Tag);
//                }
//            }
//        }

//        // Grayscale conversion method
//        private Bitmap GrayscaleImage(Image image)
//        {
//            Bitmap grayImage = new Bitmap(image);
//            for (int y = 0; y < grayImage.Height; y++)
//            {
//                for (int x = 0; x < grayImage.Width; x++)
//                {
//                    Color pixelColor = grayImage.GetPixel(x, y);
//                    int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
//                    Color grayColor = Color.FromArgb(pixelColor.A, grayValue, grayValue, grayValue);
//                    grayImage.SetPixel(x, y, grayColor);
//                }
//            }
//            return grayImage;
//        }

//        // Example of setting images to PictureBoxes during form load
//        private void LoadImages()
//        {

//            // Load your images into PictureBoxes and save the original images in the Tag property
//            //pictureBox1.Image = Properties.Resources.Image1; // Replace with your actual image
//            //pictureBox1.Tag = Properties.Resources.Image1;   // Save original image in Tag
//            //pictureBox2.Image = Properties.Resources.Image2; // Replace with your actual image
//            //pictureBox2.Tag = Properties.Resources.Image2;   // Save original image in Tag
//            //pictureBox3.Image = Properties.Resources.Image3; // Replace with your actual image
//            //pictureBox3.Tag = Properties.Resources.Image3;   // Save original image in Tag
//        }
//    }
//}
