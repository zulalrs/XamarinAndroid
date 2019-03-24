using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using static Android.Views.View;
using Android.Views;
using Android.Util;

namespace Android2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity,IOnClickListener
    {
        private Button btn1,btn2;    // Burada bir button nesnesi tanımladık.
        private Switch swtch;    // Burada bir switch nesnesi tanımladık.
       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // View kısmında tanımladığımız button ve switch ile burada tanımladığımız button ve switch nesnelerini bağlamamız lazım bunun için de view kısımdaki nesnelerimizi idlerinde bulup burada tanımladığımız nesnelerimize atıyoruz.
            btn1 = FindViewById<Button>(Resource.Id.button1);
            btn2 = FindViewById<Button>(Resource.Id.button2);
            swtch = (Switch)FindViewById(Resource.Id.switch1);

            btn1.SetOnClickListener(this);
            btn2.SetOnClickListener(this);

            // Event tetikletmenin iki yontemi var 1)
            //btn1.Click += Btn1_Click;   // Click eventini buradan tetikliyoruz.

        }

        // Event tetikletmenin iki yontemi var 2)
        private int a = 0;
        public void OnClick(View v)
        {
            Button btn = (Button)v;
            if(btn.Id==Resource.Id.button1)
            {
                Toast.MakeText(this, "Button1 e tıklandı", ToastLength.Long).Show();
                try
                {
                    int b = a / a;
                }
                catch (System.Exception ex)
                {
                    Log.Error("Bölmede hata",ex.Message);   // Console.log gibi mesaj veriyor.Bu mesajları Device Log ta  görebiliyoruz.
                }
            }
            else
            {
                Toast.MakeText(this, "Button2 e tıklandı", ToastLength.Long).Show();
            }
        }
        private void Btn1_Click(object sender, System.EventArgs e)  // Sender bu event ne ile tetiklendiyse onu tutuyor yani burada button nesnesini tutuyor.
        {
            Toast.MakeText(this, "Button1 e tıklandı", ToastLength.Long).Show();    // Button1 e tıklandığında bu mesaj gösterilecek.
        }


        // OnStart a birşey yazmak istediğimizde onu buradaki gibi override etmeliyiz.
        /*
        protected override void OnStart()
        {
            base.OnStart();
        }
        */
    }
}