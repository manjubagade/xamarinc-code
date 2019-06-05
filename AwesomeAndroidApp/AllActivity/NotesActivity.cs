using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using AwesomeAndroidApp.model;
using Firebase.Database;

namespace AwesomeAndroidApp.AllActivity
{
    [Activity(Label = "NotesActivity")]
    public class NotesActivity : AppCompatActivity
    {
        Android.Support.Design.Widget.TextInputEditText title;
        Android.Support.Design.Widget.TextInputEditText notes;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Notespage);

             title = FindViewById<Android.Support.Design.Widget.TextInputEditText>(Resource.Id.textInputEditText1);
             notes = FindViewById<Android.Support.Design.Widget.TextInputEditText>(Resource.Id.textInputEditText1);
        }
        public override async void OnBackPressed()
        {

            Toast.MakeText(this, "notes added in database", ToastLength.Short).Show();
            base.OnBackPressed();
        }
    }
}