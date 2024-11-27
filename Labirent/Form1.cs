using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Labirent
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");
        public Form1()
        {
            InitializeComponent();//Form bileşenlerini başlatıyor.
            this.KeyPreview = true;//Klavyeden gelen olayalrın önce form tarafından yakalanmasını sağlar.
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            MoveToStart();//Oyuncuyu başlangıç pozisyonuna taşır.
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!");
            Close();
        }

        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingPoint = panel1.Location;//Başlangıç posiyonunu alır.
            startingPoint.Offset(10, 27);//Başlangıç posiyonunu düzenlemeye belirli bir yerden başlatmyaı sağlar.
            Cursor.Position = PointToScreen(startingPoint);//Cursor.Position fare imlecini belirli bir pozisyona taşır.PointToScreen ise form içindeki bir pozisyonu ekran koordinatlarına dönüştürür.


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moveAmount = 10;//her bir tuşa basıldığında hareket etme miktarı.
            Point currentPosition = Cursor.Position;//Mevcut fare pozisyonu
            switch (e.KeyCode)
            {
                case Keys.Up:
                    currentPosition.Y -= moveAmount;
                    break;
                case Keys.Down:
                    currentPosition.Y += moveAmount;
                    break;
                case Keys.Left:
                    currentPosition.X -= moveAmount;
                    break;
                case Keys.Right:
                    currentPosition.X += moveAmount;
                    break;
            }
            Cursor.Position = currentPosition;//Yeni pozisyona getirme.
            //Duvara çarpma kontrolü
            //PointToClient(Cursor.Position):Ekran koordinatlarını formun iç koordinatlarına dönüştürür. Çünkü formdaki GetChildAtPoint metodu, formun iç koordinat sistemini kullanır
            Control controlUnderCursor = GetChildAtPoint(PointToClient(Cursor.Position));//GetChildAtPoint ile fare pozisyonundaki kontrol alınır.
            if(controlUnderCursor!= null&& controlUnderCursor.Tag?.ToString() == "Wall")
            {
                //Tag özelliği wall ise karakter başa döner.
                MoveToStart();
            }
        }
        private void wallMouse(object sender, EventArgs e)
        {

            MoveToStart();
        }

       
    }
}
