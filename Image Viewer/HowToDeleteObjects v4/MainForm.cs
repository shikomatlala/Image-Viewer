using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HowToDeleteObjects
{
    public partial class MainForm : Form
    {
        const int SIZABLEHEIGHT = 38;
        public MainForm()
        {
            InitializeComponent();
        }
        List<PictureBox> pictureList = new List<PictureBox>();

        private void RemoveObjects_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pictureList.Count.ToString());
            for (int x = 0; x < pictureList.Count; x++)
            {
                
                MainForm.ActiveForm.Controls.Remove(pictureList[x]);   
                
            }
            pictureList.Clear();
            //MessageBox.Show(pictureList.Count.ToString());
            //MainForm.ActiveForm.Controls.Remove(picSelected);

            btnRight.Enabled = false;
            btnLeft.Enabled = false;

        }
        public static Point initailPoint = new Point();
        public static Point locOfPicSelected = new Point();
        public Size picSize = new Size();
        public static int jpegIndex = 0;
        private void BtnCreatePictures_Click(object sender, EventArgs e)
        {
            
            //Get the bottom location of the Balloon
            //Point initailPoint = new Point();
            //Size picSize = new Size();
            picSize.Height = 50;
            picSize.Width = 50;
            initailPoint.X = 0;
            initailPoint.Y = this.Height - SIZABLEHEIGHT - picSize.Height;
            for (int x = 0; x < this.Width / picSize.Width; x++)
            {
                //MessageBox.Show((this.Width / picSize.Width).ToString());

                pictureList.Add(new PictureBox {Parent= this, Size = picSize, Location = new Point(initailPoint.X + picSize.Width*x, initailPoint.Y), Image = Image.FromFile(setPicture(x +1))});
                pictureList[x].ImageLocation = setPicture(x + 1);
                jpegIndex = x + 1;
                pictureList[x].Click += new System.EventHandler(this.PictureClicked);
                
                //pictureList[x].Click += 
            }
            removeObjects.Enabled = true;
            btnRight.Enabled = true;
            btnLeft.Enabled = true;
        }
        public string setPicture(int pictureNumber)
        {
            return "F:\\C#\\Flowers Image Viewer\\flowers\\_ (" + pictureNumber.ToString() + ").jpg";
        }
        public static bool mainPictureSet;
        public void mainPicSet(bool status)
        {
            mainPictureSet = status;
        }
        static int lastPicLocation = new int();
        public void PictureClicked(object sender, EventArgs e)
        {
            //But who did I click?
            //MessageBox.Show("You Clicked me");
            PictureBox clickedPicture = sender as PictureBox;
            picSelected.Image = clickedPicture.Image;
            locOfPicSelected = clickedPicture.Location;
           // MessageBox.Show(clickedPicture.Location.X.ToString()+  " = " + ((pictureList.Count-1)*50).ToString()); //This is how we can get the location of the picture that has been selected
            
            //pictureList.S
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int picIndex = LocationOfPictureSelected(initailPoint);
            string firstImageLocation = pictureList[picIndex].ImageLocation;
            string editedImageLocationStr = "";
            int numImageIndex = 1;
            for (int x = 0; x < firstImageLocation.Length; x++)
            {
                if (char.IsNumber(firstImageLocation[x]))
                {
                    editedImageLocationStr += firstImageLocation[x];
                }
            }
            numImageIndex = Convert.ToInt32(editedImageLocationStr);
            //MessageBox.Show(numImageIndex.ToString());

            if (numImageIndex != 1)
            {

                for (int x = 0; x < pictureList.Count(); x++)
                {
                    pictureList[x].Location = new Point(pictureList[x].Location.X + 50, pictureList[x].Location.Y);
                    //which picture are we currently at?
                    //- Which picture are we currently at?
                    //- How can we get our current picture
                    //- Which point on the Active form are we at?
                    //- How do we move to the next picture
                    //- 
                }

            }
            else
            {
                mySound.Play();
            }
            //Now the qustion that I have is how to we create


        }
        /// <summary>
        /// This method returns the index of the picture that has been selected - the idea is that we can use this index to  call the picture that is at this specific point in the index
        /// </summary>
        /// <param name="locOfPicSelected"></param>
        /// <returns></returns>
        public int LocationOfPictureSelected(Point locOfPicSelected)
        {
            
            int indexOfImage = 0;
            for(int x=0;  x< pictureList.Count(); x++)
            {
                if(locOfPicSelected == pictureList[x].Location)
                {
                    indexOfImage = x;
                    x = pictureList.Count();
                }
            }
            //MessageBox.Show(indexOfImage.ToString());
            return indexOfImage;
        }
        SoundPlayer mySound = new SoundPlayer();
        private void btnRight_Click(object sender, EventArgs e)
        {
            //if(xLocationLastPicture();
            
            //if(pictureList[pictureList.Count()-1] )
            //If the last visible picture is equal to 
            //if( xLocationLastPicture() == )
                //Find the initial point 
                //But we can reason that we know that the intial point is found in the 
                //Move The collection of picture that are on the form
                //Get the first location
                //Point firstLocation = 
                //pictureList[0].

            //int picIndex = LocationOfPictureSelected(initailPoint);
            //string firstImageLocation = pictureList[picIndex].ImageLocation;
            //MessageBox.Show(x.ToString() + " == " +  pictureList.Count().ToString() + " == " + firstImageLocation);
            //MessageBox.Show(pictureList[x-1].Location.X.ToString() + " + 50 = " + (pictureList[x - 1].Location.X + 50).ToString());
            //pictureList.Add(new PictureBox { Parent = this, Size = picSize, Location = new Point(pictureList[x - 1].Location.X + 50, initailPoint.Y), Image =  Image.FromFile(setPicture(x + 1)) });
            int lastPicture = pictureList.Count() - 1;
            ///MessageBox.Show(pictureList[lastPicture].Location.X.ToString() +  " == " +  xLocationLastPicture().ToString());
            //Find the index of the location at the location x
            //for(int x = 0; x < )
            int indexOfLastVisiblePicture = indexOfPictureatxPosition(xLocationLastPicture(), pictureList);
             
            if (pictureList[indexOfLastVisiblePicture].Location.X == xLocationLastPicture())
            {

                //string lastImageLocation = pictureList[pictureList.Count() - 1].ImageLocation;
                //lastImageLocation.Substring(lastImageLocation.IndexOf('(') + 1, 1);
                //if ()
                //PictureBox clickedPicture = sender as PictureBox;
                int x = 0;
                //If the picture is the last picture then do not scrooll
                //int lastPic = pictureList.Count - 1 ; 
                for (x = 0; x < pictureList.Count(); x++)
                {
                    //Here we move the pictures -- 

                    pictureList[x].Location = new Point(pictureList[x].Location.X - 50, pictureList[x].Location.Y);
                }
                string lastImageLocation = pictureList[pictureList.Count() - 1].ImageLocation;
                string editedImageLocationStr = "";
                int numImageIndex = 1;
                
                for (int i = 0; i < lastImageLocation.Length; i++)
                {
                    if (char.IsNumber(lastImageLocation[i]))
                    {
                        editedImageLocationStr += lastImageLocation[i];
                    }
                }
                numImageIndex = Convert.ToInt32(editedImageLocationStr);
                //MessageBox.Show(numImageIndex.ToString());
                if (numImageIndex < 30)
                {
                    pictureList.Add(new PictureBox { Parent = this, Size = picSize, Location = new Point(pictureList[x - 1].Location.X + 50, initailPoint.Y), Image = Image.FromFile(setPicture(x + 1)) });
                    pictureList[x].ImageLocation = setPicture(x + 1);
                    pictureList[x].Click += new System.EventHandler(this.PictureClicked);
                }
                //else
                //{
                //    mySound.Play();
                //}
            }
            //else
            //{
            //    int x = 0;
            //    for (x = 0; x < pictureList.Count(); x++)
            //    {
            //        //
            //        pictureList[x].Location = new Point(pictureList[x].Location.X - 50, pictureList[x].Location.Y);
            //    }
            //}


        }
        public int xLocationLastPicture()
        {
            int numOfPicBoxes = this.Width / picSize.Width;
            int xLocationOfLastPicture = (numOfPicBoxes - 1) * picSize.Width;
            //MessageBox.Show(xLocationOfLastPicture.ToString());
            return xLocationOfLastPicture;
            
        }
        public int indexOfPictureatxPosition(int xLocation, List<PictureBox> pictureBoxes)
        {
            int indexOfPic = 0;
            for(int x = 0; x < pictureBoxes.Count(); x++)
            {
                if(pictureBoxes[x].Location.X == xLocation)
                {
                    indexOfPic = x;
                    x = pictureBoxes.Count();
                }
            }
            return indexOfPic;
        }
    }
}
////The goal is to stop moving forward-- OK to the problem is that 
////We are not using the 
////int picIndex = LocationOfPictureSelected();
//string lastImageLocation = pictureList[pictureList.Count()-1].ImageLocation;
////string editedImageLocationStr = "";
////int numImageIndex = firstImageLocation.ToString();
//string firstImageLocation = pictureList[pictureList.Count()-1].ImageLocation;
//string editedImageLocationStr = "";
//int numImageIndex = 1;
//for (int x = 0; x < firstImageLocation.Length; x++)
//{
//    if (char.IsNumber(firstImageLocation[x]))
//    {
//        editedImageLocationStr += firstImageLocation[x];
//    }
//}
//numImageIndex = Convert.ToInt32(editedImageLocationStr);
//if (pictureList.Count() <= 30)
//{
//if (numImageIndex <= 30)
//{

//        MessageBox.Show(pictureList.Count().ToString());
//    }
//}
//else
//{
//    mySound.Play();
//}





//Find the Picture at the Location 0,0

//If the PictureBox at location 0 - Is equal to  - picture
//The goal is to find the picture that is at the location 0, on the parent form and then take the picture and find out if the ImageLocation  = 1
//Find the Location of the image that has been selected- 
//for(int x = 0; x < pictureList.Count(); x++)
//{
//    if(locOfPicSelected == pictureList[x].Location)
//    {

//    }
//}

//string firstImageLocation = pictureList[0].ImageLocation;
////Get The first image - number
//if (firstImageLocation.Substring(firstImageLocation.IndexOf('(') + 1, 1) != "1")
//{
//    for (int x = 0; x < pictureList.Count(); x++)
//    {
//        //Make sure that you cannot scroll to the left if we have reached the last picture....
//        pictureList[x].Location = new Point(pictureList[x].Location.X + 50, pictureList[x].Location.Y);
//        //string image_Location = pictureList[x].ImageLocation;
//        //MessageBox.Show(image_Location);
//        //Now the interesting questionis how do we find the index of the picture in the location 0,0


//    }
//}