using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Denise
{
    [Activity(Label = "Denise's App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            int textOutputPosition = 0;

            Button nextButton = FindViewById<Button>(Resource.Id.NextButton);
            TextView textView1 = FindViewById<TextView>(Resource.Id.TextView1);
            ImageView imageView1 = FindViewById<ImageView>(Resource.Id.ImageView1);

            nextButton.Click += (object sender, EventArgs e) =>
            {
                switch (textOutputPosition)
                {
                    case 0:
                        textView1.Text = "I want to show you something.";
                        textOutputPosition = 1;
                        break;
                    case 1:
                        textView1.Text = "I love you because you make me smile.";
                        imageView1.SetImageResource(Resource.Drawable.image5);
                        textOutputPosition = 2;
                        break;
                    case 2:
                        textView1.Text = "...and for many many more reasons.";
                        textOutputPosition = 3;
                        break;
                    case 3:
                        textView1.Text = "Anyway, I want to tell you something.";
                        textOutputPosition = 4;
                        break;
                    case 4:
                        textView1.Text = "You are so beautiful to me.";
                        imageView1.SetImageResource(Resource.Drawable.image6);
                        textOutputPosition = 5;
                        break;
                    case 5:
                        textView1.Text = "So sexy.";
                        imageView1.SetImageResource(Resource.Drawable.image3);
                        textOutputPosition = 6;
                        break;
                    case 6:
                        imageView1.SetImageResource(Resource.Drawable.image2);
                        textOutputPosition = 7;
                        break;
                    case 7:
                        imageView1.SetImageResource(Resource.Drawable.image9);
                        textOutputPosition = 8;
                        break;
                    case 8:
                        textView1.Text = "So strong.";
                        imageView1.SetImageResource(Resource.Drawable.image8);
                        textOutputPosition = 9;
                        break;
                    case 9:
                        textView1.Text = "So strong.";
                        imageView1.SetImageResource(Resource.Drawable.image10);
                        textOutputPosition = 10;
                        break;
                    case 10:
                        textView1.Text = "Plus you can fly.";
                        imageView1.SetImageResource(Resource.Drawable.image7);
                        textOutputPosition = 11;
                        break;
                    case 11:
                        textView1.Text = "And squirrel.";
                        imageView1.SetImageResource(Resource.Drawable.image1);
                        textOutputPosition = 12;
                        break;
                    case 12:
                        textView1.Text = "I love you Denise.";
                        imageView1.SetImageResource(Resource.Drawable.Love);
                        textOutputPosition = 12;
                        break;


                }
                /*if (textOutputPosition == 0)
                {
                    textView1.Text = "I want to show you something.";
                    textOutputPosition = 1;

                }
                else if (textOutputPosition == 1)
                {
                    textView1.Text = "I love you because you make me smile.";
                    imageView1.SetImageResource(Resource.Drawable.image5);
                    textOutputPosition = 2;
                }
                else if (textOutputPosition == 2)
                {
                    textView1.Text = "...and for many many more reasons.";
                    textOutputPosition = 3;
                }
                else if (textOutputPosition == 3)
                {
                    textView1.Text = "Anyway, I want to tell you something.";
                    textOutputPosition = 4;
                }
                else if (textOutputPosition == 4)
                {
                    textView1.Text = "You are so beautiful to me.";
                    imageView1.SetImageResource(Resource.Drawable.image6);
                    textOutputPosition = 5;
                }
                else if (textOutputPosition == 5)
                {
                    textView1.Text = "So sexy.";
                    imageView1.SetImageResource(Resource.Drawable.image3);
                    textOutputPosition = 5;
                }*/


            };

            
        }
    }
}

