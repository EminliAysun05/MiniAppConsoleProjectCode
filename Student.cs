
using MiniAppConsoleProjectCode.Helper;

namespace MiniAppConsoleProjectCode
{
    public class Student
    {
        //        Student classinda olacaqlar
        //Id oz-oz luyunde artacaq
        //Name,
        //SurName

        private static int _id;
        public int Id { get; set; }
        public int ClassId {  get; set; }
        
        public string Name
        {
            get;
            set;
        }
        public string Surname;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = ++_id;
        }
    }
}
