using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAGeriyeDegerDonduren_0
{
    public partial class Form1 : Form
    {
        /*
                    Geriye Deger Döndüren Metotlar

        Syntax

        Bir metot sadece tek bir deger döndürebilir...

         public <donüsTipi> <Adı> (varsa parametreleri)
        {

        }

        Geriye Deger Döndüren ve Parametre Almayan Metotlar

        En önemli Nokta : Siz geriye deger döndüren bir metot yarattıgınızda ilk basta bir syntax hatası alırsınız...Cünkü siz bir metodu yarattıgınızda compiler'a o metodun geriye deger döndürecegine dair bir söz verirsiniz...Dolayısıyla siz onun geriye ne deger döndürecegini söylemek zorundasınız...

        Geriye deger döndüren bir metodun ne deger döndürecegi return keyword'u ile verilmelidir...
        Geriye deger döndüren bir metodun döndürecegi degeri,  try catch gibi , if else gibi mekanizmalar varsa ve siz sadece bir blokta tanımlamıssanız ve diger blokları bos gecmişsseniz  o bos gectiginiz bloklarda ne deger döndürülecegi bilinmedigi icin syntax hatası alırsınız...

        Geriye deger döndüren metotların döndürdükleri degeri uygun tipteki alanlara atayabilir ve onlara uygun işlemleri de yapabilirsiniz...

        Geriye deger döndüren metotlardan tek bir deger döndürebilirsiniz...Cünkü siz o degeri döndürdügünüz anda metot sonlanır...

        Bir Metot syntax hatası veriyorsa

        1. Geriye deger döndürmeye söz verdiginiz metodun degerini döndürmemişsinizdir...Veya metodunuzun döndürdügü deger döndürmek istedigi veri tipine uyumlu degildir...Veya metodunuzun icerisindeki yasam alanlarından bir kısmı deger döndürmüyordur(not all code paths return a value)
        2. Geriye deger döndürmeyen metotta deger döndürmeye calısıyorsunuzdur.
        3. Metodun sizden istedigi parametreleri argüman olarak verirken eksik veya yanlıs vermişsinizdir..
        4. Döndüreceginiz degeri yanlıs tipte döndürmüssünüzdür
         
         
         */

        public void Selamla()
        {
            MessageBox.Show("Test");
            

        }



        public int DegerDondur()
        {
            int a = 1, b = 2;
            if(a < b)
            {
                return 3;
            }
            return 1;
           
        }

        public string MetinDondur()
        {
            return "Hello World";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = DegerDondur();
        }


        //Butona tıklandıgında kullanıcının textboxlara yazmıs oldugu sayıları alıp bunları toplayan ve toplamı geriye deger olarak döndüren (parametresiz yapın) bir metot yazın...Sonra bu metodun degerini Form'un Text'ine yazdırın...


        public int SayilariTopla()
        {
            //int sayi1 = Convert.ToInt32(TxtSayi1.Text);
            //int sayi2 = Convert.ToInt32(TxtSayi2.Text);

            //return sayi1 + sayi2;


            return Convert.ToInt32(TxtSayi1.Text) + Convert.ToInt32(TxtSayi2.Text);
            
           

                
            
            
        }

        //Metodun döndürdügü degerin tipi ile parametrelerinin tipi aynı olmak zorunda degildir!!!!

        public string Topla(int sayi1,int sayi2)
        {
            return (sayi1 + sayi2).ToString();
        }


        private void BtnTopla_Click(object sender, EventArgs e)
        {
            

            //int toplam = SayilariTopla();
            Text = SayilariTopla().ToString();

            Text = Topla(33, 1);


            try
            {
                Text = SayilariTopla().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
