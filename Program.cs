using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim ="Ayşe";
            ogrenci.Soyisim ="Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur(); //burada hata verecek çünkü sınıfı 1, 0 olamaz aşağıdaki if yapısından dolayı.
            ogrenci.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci 
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get => isim; //getter ismi return ediyor, get{return isim} get=>isim ile aynı şey
            set=> isim = value; //setter isme bir value atıyor, set{isim = value} set=>isim=value ile aynı şey
        } 

        public string Soyisim
        {
            get => soyisim; //getter ismi return ediyor, get{return soyisim} get=>soyisim ile aynı şey
            set=> soyisim = value; //setter isme bir value atıyor, set{soyisim = value} set=>soyisim=value ile aynı şey
        } 

        public int OgrenciNo
        {
            get => ogrenciNo; //getter sayiyi return ediyor, get{return ogrenciNo} get=>isim ile aynı şey
            set=> ogrenciNo = value; //setter sayiyi bir value atıyor, set{ogrenciNo = value} set=>isim=value ile aynı şey
        } 

        public int Sinif
        {
            get => sinif; //getter sayiyi return ediyor, get{return sinif} get=>isim ile aynı şey
            set
            {
                if(value<=1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir");
                    sinif = 1;
                }
                else
                    sinif = value;
            } //setter sayiyi bir value atıyor, set{sinif = value} set=>isim=value ile aynı şey
        } 

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif) //kurucusu //parametreli buradan çalışacak
        {
            Isim= isim; //bunu this.Isim diyerek de yapabiliyorduk aynı zamanda
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        } 

        public Ogrenci() {} // boş olarak buradan çalışacak

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("****Öğrenci Bilgileri****");
            Console.WriteLine("Öğrenci Adı      :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı   :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci No       :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   :{0}",this.Sinif); 

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif +1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif -1;
        }
    }
}

