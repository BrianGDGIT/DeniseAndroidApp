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
                if (textOutputPosition == 0)
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
                }


            };

            
        }
    }
}

