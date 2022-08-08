using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasör_İşlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klasör oluşturma.

            string folderName = @"d:/mitheim";
            System.IO.Directory.CreateDirectory(folderName);


            //Alt klasör oluşturma.

            string folderName = @"d:/mitheim";
            System.IO.Directory.CreateDirectory(folderName);

            string subFolderName = System.IO.Path.Combine(folderName, "Software Folder");
            System.IO.Directory.CreateDirectory(subFolderName);


            //Klasör silme işlemi. Klasör mevcut değilse kullanıcıya bilgi veriyor.

            string folderPath = @"d:/mitheim";
            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
                Console.WriteLine("Klasör bütün içerikleriyle beraber silindi");
            }
            else
            {
                Console.WriteLine("Warning!");
                Console.WriteLine("Silinmek istenilen klasör mevcut değil");    
            }
            Console.ReadKey();


            //Tüm klasör içeriği kopyalama.

            string sourceFolder = @"d:/Secret Folder";
            string targetFolder = @"d:/backup";
            string targetFolderPath;
            if (System.IO.Directory.Exists(sourceFolder))
            {
                //source folder yolundaki tüm dosyaları bir diziye aktarma satırı.
                string[] files = System.IO.Directory.GetFiles(sourceFolder);

                string fileName;
                foreach (string personel in files)
                {
                    fileName = System.IO.Path.GetFileName(personel);
                    targetFolderPath = System.IO.Path.Combine(targetFolder, fileName);
                    //Dosya kopyalama işlemi burada gerçekleşiyor.
                    System.IO.File.Copy(personel, targetFolderPath, true);
                }
            }
            else
            {
                Console.WriteLine("Warning!");
                Console.WriteLine("Kaynak dosya bulunamadı.");
            }
            Console.ReadKey();

            //Klasör taşıma.

            string sourceFile = @"d:/Software Dev";
            string targerFile = @"d:/Class/Softare Dev";

            System.IO.Directory.Move(sourceFile, targerFile);




        }
    }
}
