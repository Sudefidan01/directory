using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230826_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory
            //Directory sınıfını kullanabilmemiz için System.IO kütüphanesini projemize eklememiz gerekmektedir
            //Directory sınıfı static bir sınıftır.Class isminden sonra içeirisindeki özelliklere .(nokta) ile erişim sağlayabiliriz

            //string yol = "C:\\Users\\pcc\\Desktop";
            //Bir string ifade önüne yazılan @ işareti string içerisindeki tanımlanan özel karakterleri devre dışı bırakır
            string yol = @"C:\Users\pcc\Desktop\Yeni Klasör";


            //Klasör oluşturmak için CreateDirectory() metodunu kullanırız
            //Directory.CreateDirectory(yol);

            //Belirtilen dizin içerisinde kalsör var mı yok mu kontrolü için Exists() metodunu kullanırız.Geriye bool veritipinde değer döndürür
            //bool varMi=Directory.Exists(yol);
            //if (varMi)
            //{
            //    Console.WriteLine("Klasör Zaten Var");
            //}
            //else 
            //{
            //    Console.WriteLine("Klasör Bulunamadı");
            //}
            //Klasör Silme İşlemi İçin Delete() metodunu kullanırız
            Directory.Delete(yol);
            Console.ReadKey();
        }
    }
}
