using NeuralNetwork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork_0._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private NeuralController neural;
        private void Menu_CreateNeuralNetwork_Click(object sender, EventArgs e)
        {
            neural = new NeuralController(784, 16, 2, 10, new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            // Visualing
            Menu_CreateNeuralNetwork.Enabled = false;

            Menu_Learn.Enabled = true;
            Menu_TestNeuralNetwork.Enabled = true;
            Menu_Save.Enabled = true;
            Menu_DeleteNeuralNetwork.Enabled = true;
        }

        private void Menu_DeleteNeuralNetwork_Click(object sender, EventArgs e)
        {
            neural = null;

            // Visualing
            Menu_CreateNeuralNetwork.Enabled = true;

            Menu_Learn.Enabled = false;
            Menu_TestNeuralNetwork.Enabled = false;
            Menu_Save.Enabled = false;
            Menu_DeleteNeuralNetwork.Enabled = false;
        }
        private void Menu_OpenImagesFolder_Click(object sender, EventArgs e)
        {
            if (OpenImagesDirectory.ShowDialog() == DialogResult.OK)
            {
                string DirectoryPath = OpenImagesDirectory.SelectedPath;
            }
        }
        private void Menu_TestNeuralNetwork_Open_ImageFolder_Click(object sender, EventArgs e)
        {
            if (OpenImagesDirectory.ShowDialog() == DialogResult.OK)
            {
                string DirectoryPath = OpenImagesDirectory.SelectedPath;
            }
        }

        private void Menu_TestNeuralNetwork_Open_Image_Click(object sender, EventArgs e)
        {
            if (OpenImageFile.ShowDialog() == DialogResult.OK)
            {
                double[] InputData = new double[784];
                int place = 0;
                string ImagePath = OpenImageFile.FileName;

                Bitmap img = new Bitmap(ImagePath);
                for (int h = 0; h < img.Height; h++)
                {
                    for (int w = 0; w < img.Width; w++)
                    {
                        Color pixel = img.GetPixel(w, h);
                        double brightness = Math.Abs((Math.Floor((((pixel.R + pixel.G + pixel.B) / 3) / 2.55)) / 100) - 1);
                        InputData[place] = brightness;
                        place++;
                    }
                }

                // Image Debug
                ///*
                Bitmap outputImg = new Bitmap(img.Width, img.Height);
                int i = 0;
                for (int h = 0; h < img.Height; h++)
                {
                    for (int w = 0; w < img.Width; w++)
                    {
                        if (InputData[i] == 1)
                        {
                            outputImg.SetPixel(w, h, Color.Red);
                        }
                        else if (InputData[i] == 0)
                        {
                            outputImg.SetPixel(w, h, Color.Black);
                        }
                        else
                        {
                            outputImg.SetPixel(w, h, Color.Blue);
                        }
                        i++;
                    }
                }
                outputImg.Save("1.jpg");//*/

                // Calculate
                MessageBox.Show(neural.TestNeuralNetwork(InputData));
                //neural.LearnNeuralNetwork(InputData, "1", 200);
                //MessageBox.Show(neural.TestNeuralNetwork(InputData));
            }
        }

        private void Menu_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
