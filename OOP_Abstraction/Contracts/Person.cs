namespace OOP_Abstraction.Contracts
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDate { get; set; }

        public abstract void Save();
        public abstract void Delete();
    }
    public class Student : Person
    {
        public int Grade { get; set; }
        public override void Save()
        {
            Console.WriteLine($"{nameof(Student)} saved");
        }

        public override void Delete()
        {
            Console.WriteLine($"{nameof(Student)} deleted");
        }
    }
    public class Teacher : Person
    {
        public string Department { get; set; }
        public override void Save()
        {
            Console.WriteLine($"{nameof(Teacher)} saved");
        }

        public override void Delete()
        {
            Console.WriteLine($"{nameof(Teacher)} deleted");
        }
    }

}
