using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Media;
namespace Saglik_Yardimcisi
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lbl_Bug�n.Text = "G�n�n Tarihi: " + DateTime.Now.ToLongDateString() + "\n Program�n a��l�� saati: " + DateTime.Now.ToShortTimeString();

            DTP.Value = DateTime.Today;
            timer1.Start();
        }

        bool butonKontrol = false;
        private void button1_Click(object sender, EventArgs e)
        {
            butonKontrol = true;
            timer1.Start();
        }

        int Dakika = 40;
        int Saniye = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Saniye--;

            MevcutZaman();

            if (Saniye == 0)
            {
                if (Dakika > 0)
                {
                    Dakika -= 1;
                    Saniye = 60;
                }
                MevcutZaman();

                if (Dakika == 0 && Saniye == 0)
                {


                    MevcutZaman();

                    timer1.Stop();
                    this.Hide();
                    TopMost = true;
                    System.Media.SystemSounds.Beep.Play();
                    DialogResult dr1 = MessageBox.Show("S�re doldu mola verip biraz y�r�y�� yapmak ve g�zlerini dinlendirmek senin i�in faydal� olur. Sayac� 5 dakika ertelemek ister misiniz ?", "Sa�l�k Yard�mc�s�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (dr1 == DialogResult.Yes)
                    {
                        Dakika = 5;
                        Saniye = 60;
                        DTP.Enabled = false;
                        Btn_Alarm_Ayarla.Enabled = false;
                        timer1.Start();
                    }

                    else if (dr1 == DialogResult.No)
                    {
                        timer1.Stop();

                        DTP.Enabled = true;
                        Btn_Alarm_Ayarla.Enabled = true;
                    }
                    this.Show();

                    TopMost = false;
                }

            }

            if (butonKontrol == true)
            {
                DTP.Enabled = false;
                Btn_Alarm_Ayarla.Enabled = false;



                DateTime AlinanZaman = DTP.Value;

                DateTime SimdikiZaman = DateTime.Now;

                TimeSpan KalanZaman = AlinanZaman - SimdikiZaman;

                Lbl_durum.Text = $"kalan saat: {KalanZaman.Hours} " + $" kalan dakika: {KalanZaman.Minutes} " + $" kalan saniye: {KalanZaman.Seconds}";

                if (KalanZaman.TotalSeconds < -1)
                {
                    timer1.Stop();
                    DTP.Enabled = true;
                    Btn_Alarm_Ayarla.Enabled = true;
                    Lbl_durum.Text = ($"kalan saat: !!! " + $" kalan dakika: !!!" + $" kalan saniye: !!!");
                    MessageBox.Show("Ge�ersiz de�er girdiniz!", "Sa�l�k Yard�mc�s�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (KalanZaman.Hours == 00 && KalanZaman.Minutes == 00 && KalanZaman.Seconds == 00)
                {
                    DialogResult dr = Dr_Bildirim();

                    if (dr == DialogResult.Yes)
                    {
                        DTP.Value = DateTime.Now.AddMinutes(5);
                        DTP.Enabled = false;
                        Btn_Alarm_Ayarla.Enabled = false;
                        timer1.Start();
                    }

                    else if (dr == DialogResult.No)
                    {
                        timer1.Stop();

                        DTP.Enabled = true;
                        Btn_Alarm_Ayarla.Enabled = true;
                    }

                }

                this.Show();

                TopMost = false;

            }
        }
        private DialogResult Dr_Bildirim()
        {
            timer1.Stop();
            this.Hide();

            TopMost = true;

            System.Media.SystemSounds.Beep.Play();
            DialogResult dr = MessageBox.Show("S�re doldu mola verip biraz y�r�y�� yapmak ve g�zlerini dinlendirmek senin i�in faydal� olur. Sayac� 5 dakika ertelemek ister misiniz ?", "Sa�l�k Yard�mc�s�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return dr;
        }

        private void MevcutZaman()
        {
            Lbl_durum.Text = $"kalan saat: {0} " + $" kalan dakika: {Dakika.ToString()} " + $" kalan saniye: {Saniye.ToString()}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DTP.Enabled = true;
            Btn_Alarm_Ayarla.Enabled = true;
        }


    }
}





