using System;
using System.Collections.Generic;
using System.Text;


namespace Person
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime date = new DateTime();
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public DateTime BirthdayDate { get; set; }
        public int ChangeYear {
            get { return BirthdayDate.Year; }
            set { BirthdayDate = new DateTime(value, BirthdayDate.Month, BirthdayDate.Day); }
        }

        public Person(string name, string surname, DateTime birth)
        {
            Name = name;
            Surname = surname;
            BirthdayDate = birth;
        }
        public Person()
        {
            Name = "Vadim";
            Surname = "Hnatyuk";
            BirthdayDate = new DateTime(2003, 07, 28);

        }
        public override string ToString()
        {
            return $"{Name} {Surname} {BirthdayDate}";
        }
        public virtual string ToShortString()
        {
            return Name + " " + Surname;
        }
    }
    
    public enum Education
    {
        Specialist,
        Bchelor,
        SecondEducation
    }
    
    class Exam { 
    public string ExamName
        {
            get;
            set;
        }
        public int Rate
        {
            get;
            set;
        }
        public DateTime DateExam
        {
            get;
            set;
        }
        public Exam(string exName,int rate,DateTime exDate)
        {
            ExamName = exName;
            Rate = rate;
            DateExam = exDate;
        } 
        public Exam()
        {
            ExamName = "Math";
            Rate = 3;
            DateExam = new DateTime(2000,11,1);
        }
        public override string ToString()
        {
            return ExamName + Rate + DateExam;
        }
    }
    
    class Student
    {
        private Person person = new Person();
        private Education education = new Education();
        private int number;
        private Exam exam = new Exam();
        
        public Student(Person p, Education ed, int a)
        {
            Person = p;
            Education = ed;
            Number = a;
            Exam = exam;
        }
        public Student()
        {
            Person = new Person("Vadim", "Gnatyuk", new DateTime(2000, 5, 3));
            Education = Education.Bchelor;
            Number = 151;
            Exam = new Exam();
        }

        public Person Person
        {
            get { return person; }
            set { person = value; }
        }
        public Education Education
        {
            get {return education;}
            set { education = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public Exam Exam
        {
            get { return exam; }
            set { exam = value; }
        }
        public double Average { get;set;}


        public List<Exam> listOfExams;
        public List<Exam> ListOfExams
        {
            get
            {
                return listOfExams;
            }
            set
            {
                listOfExams = value;
            }
        }

        public void AddExams(params Exam[] add)
        {

            listOfExams.AddRange(add);
        }
        public override string ToString()
        {
            return $"{ Person},{Education},{ListOfExams}";
        }
        public virtual string ToShortString()
        {
            return $"{ Person},{Education},{Average}";
        }
    }
}
