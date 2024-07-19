using MiniAppConsoleProjectCode.Helper;
using Newtonsoft.Json;
using System.Threading.Channels;

namespace MiniAppConsoleProjectCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                1.Classroom yarat
            //    2.Student yarat
            //    3.Butun Telebeleri ekrana cixart
            //    4.Secilmis sinifdeki telebeleri ekrana cixart
            //    5.Telebe sil(Verilmis id olan telbeni taparaq silecek) eger telebe tapilmasa StudentNotFoundException(Ozunuz yaradirsiz) qaytaracaq
            Console.WriteLine("1. Classroom yarat");
            Console.WriteLine("2. Student yarat");
            Console.WriteLine("3. Butun telebeleri ekrana cixart");
            Console.WriteLine("4. Secilmis sinifdeki telebeleri ekrana cixart ");
            Console.WriteLine("5. Telebe sil ");

            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":




                    //string json = JsonConvert.SerializeObject(classroom);
                    string path = "C:\\Users\\namjoon\\source\\repos\\MiniAppConsoleProjectCode\\classrooms.json";


                    string result;
                    using (StreamReader sr = new StreamReader(path))
                    {
                        result = sr.ReadToEnd();
                    }
                   List<Classroom> classrooms = JsonConvert.DeserializeObject<List<Classroom>>(result);
                 // var json = JsonConvert.DeserializeObject<string>(result);
                    if (classrooms is null)
                    {
                        classrooms = new();
                    }

                restart:

                    Console.WriteLine("Please, enter name of classroom: ");
                    string classroomName = Console.ReadLine();
                    if (classroomName.IsValidNameSurName())
                    {
                        Console.WriteLine(classroomName);
                    }
                    else
                    {

                        Console.WriteLine("Salam");
                        goto restart;
                    }
                    Classroom classroom=new(ClassroomType.Frontend, classroomName); 

                    classrooms.Add(classroom);


                    var json = JsonConvert.SerializeObject(classrooms);
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(json);
                        Console.WriteLine("User succesfully added");
                    }
                    break;
            }




        }
    }
}
