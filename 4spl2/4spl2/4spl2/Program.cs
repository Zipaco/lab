using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4spl2
{
    public enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }

    public class Exam
    {
        public string NameObj { get; set; }
        public int Grade 
        { 
            get 
            {
                return Grade;
                //1-5            
            }

            set 
            {
                if (value >= 1 && value <= 5)
                {
                    Grade = value;
                }
            } 
        }
        public DateTime DateExam { get; set; }

        public Exam(string nameobj, int grade, DateTime dateexam)
        {
            NameObj = nameobj;
            Grade = grade;
            DateExam = dateexam;
        }

        

        public Exam()
        {
            NameObj = "Название по умолчанию";
            Grade = 0;
            DateExam = DateTime.Now;
        }

        public string ToFullString()
        {
            return $"Название: {NameObj}, Оценка: {Grade}, Дата экзамена: {DateExam}";
        }
    }

    public class Student
    {
        private Person studentData;
        private Education educationForm;
        private int groupNumber;
        private Exam[] exams;

        public Student(Person studentData, Education educationForm, int groupNumber)
        {
            this.studentData = studentData;
            this.educationForm = educationForm;
            this.groupNumber = groupNumber;
            this.exams = new Exam[0];
        }

        public Student()
        {
            this.studentData = new Person();
            this.educationForm = Education.Bachelor;
            this.groupNumber = 0;
            this.exams = new Exam[0];
        }

        public Person StudentData
        {
            get { return studentData; }
        }

        public Education EducationForm
        {
            get { return educationForm;  }
        }

        public int GroupNimber
        {
            get { return groupNumber;  }
        }

        public Exam[] Exams
        {
            get { return exams;  }
        }

        public double GPA
        {
            get
            {
                double sum = 0;
                
                foreach (Exam exam in exams)
                {
                    sum += exam.Grade;
                }
                return sum / exams.Length;
            }
        }

        public void AddExams(params Exam[] newExams)
        {
            Array.Resize(ref exams, exams.Length + newExams.Length);
            Array.Copy(newExams, 0, exams, exams.Length - newExams.Length, newExams.Length);
        }

        public string ToFullString()
        {
            string allmean = $"Данные студента:\n{studentData.ToFullString()}\nФорма обучения: {educationForm}\nНомер группы: {groupNumber}\nЭкзамены:\n";
            if (exams != null && exams.Length > 0)
            {
                foreach (Exam exam in exams)
                {
                    allmean += $"{exam.ToFullString()}\n";
                }
            }
            else
            {
                allmean += "Экзамены отсутствуют.\n";
                
            }
            return allmean;
        }
        public string ToShrortString()
        {
            return $"Данные студента:{studentData.ToShortString()}\nФорма обучения: {educationForm}\nНомер группы: {groupNumber}\nСредний балл: {GPA}";
        }

    } /// <summary>
    /// 
    /// </summary>

    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Dob { get; set; }


        public Person(string name, string surname, DateTime dob)
        {
            Name = name;
            Surname = surname;
            Dob = dob;
        }

        public Person()
        {
            Name = "Имя по умолчанию";
            Surname = "Фамилия по умолчанию";
            Dob = new DateTime(2000,1,1);
        }

        public int BirthYear
        {
            get { return Dob.Year; }
            set { Dob = new DateTime(value, Dob.Month, Dob.Day); }
        }
        public string ToFullString()
        {
            return $"ФИ: {Name} {Surname}, Возраст: {Dob}";
        }

        public string ToShortString()
        {
            return $"Имя: {Name}, Фамилия: {Surname}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine(student1.ToFullString());

            Person personData = new Person("Иван", "Соболев", new DateTime(2000, 5, 1));
            Student student2 = new Student(personData, Education.Specialist, 2);

            Exam exam1 = new Exam("Программирование", 90, new DateTime(2024, 5, 15));
            Exam exam2 = new Exam("Математика", 85, new DateTime(2024, 6, 1));

            student2.AddExams(exam1, exam2);

            Console.WriteLine(student2.ToFullString());

            Console.ReadLine();
        }
    }
}
