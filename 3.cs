using System;
namespace lb4task3
{
    public class Student
    {
        protected string name;
        protected int course;
        protected string gradeBook;
        public Student(string Name, int course, string gradeBook)
        {
            this.Name = Name;
            this.course = course;
            this.gradeBook = gradeBook;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        public string GradeBook
        {
            get { return gradeBook; }
            set { gradeBook = value; }
        }
        public void Print()
        {
            Console.WriteLine("The values of fields are:");
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Course = {course}");
            Console.WriteLine($"GradeBook = {gradeBook}");
        }
    }
    public class Aspirant : Student
    {
        protected string topic;

        public Aspirant(string name, int course, string gradeBook, string topic) :
        base(name, course, gradeBook)
        {
            base.name = name;
            this.course = course;
            this.gradeBook = gradeBook;
            this.topic = topic;
        }

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Topic = {topic}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Garbarenko.Y.O", 2, "34/19-304");
            Console.WriteLine("The instance of st1:");
            st1.Print();
            Aspirant asp1 = new Aspirant(st1.Name, st1.Course, st1.GradeBook, "Hello world!"-------);
            Console.WriteLine("---------------------");
            Console.WriteLine("The instance of asp1:");
            asp1.Print();
        }
    }
}
