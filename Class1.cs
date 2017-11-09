using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class Delete
    {
        static void delete()
        {
        string f=Get.Files=Path("C:\\Users\\opilane\\Desktop\\notes\\geodwad - Copy (2)");
            File.Delete(f); 

        }
    }
}
