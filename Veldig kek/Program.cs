using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace nestenHelg
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var obj = new ikkeSåKlasse();
            obj.Run();
        }
    }

    public class ikkeSåKlasse
    {
        public List<Student> studentListe = new List<Student>
        {
            new Student("Alice", 20, "Økonomi"),
            new Student("Bob", 25, "Psykologi"),
            new Student("John", 30, "Fisker"),
        };

        public List<Student> kekListe = new List<Student>
        {
            new Student("Alice", 20, "Økonomi"),
            new Student("Bob", 25, "Psykologi"),
            new Student("John", 30, "Fisker"),
        };

        public List<Fag> fagListe = new List<Fag>
        {
            new Fag ( 101, "Math", 10 ),
            new Fag ( 102, "Science",  8 ),
            new Fag ( 103, "History", 6 )
        };

        public List<Karakter> karakterListe = new List<Karakter>
        {
            new Karakter ( "Alice",  "Math",  90 ),
            new Karakter (  "Bob", "Science", 85 ),
            new Karakter (  "Charlie",  "History", 88 )
        };

        public void Run()
        {
            foreach (var student in studentListe) Console.WriteLine($"{student.name} {student.age} {student.studyProgram}");
            foreach (var fag in fagListe) Console.WriteLine($"{fag.subjectCode} {fag.subjectName} {fag.studyPoints}");
            foreach (var karakter in karakterListe) Console.WriteLine($"{karakter.student} {karakter.subject} {karakter.grade}");
        }
    }

    public class Student
    {
        public string name;
        public int age;
        public string studyProgram;

        public Student(string Name, int Age, string StudyProgram)
        {
            name = Name;
            age = Age;
            studyProgram = StudyProgram;
        }
    }

    public class Fag
    {
        public int subjectCode;
        public string subjectName;
        public int studyPoints;

        public Fag(int StudyCode, string StudyName, int StudyPoints)
        {
            subjectCode = StudyCode;
            subjectName = StudyName;
            studyPoints = StudyPoints;
        }
    }

    public class Karakter
    {
        public string student;
        public string subject;
        public int grade;

        public Karakter(string Student, string Subject, int Grade)
        {
            student = Student;
            subject = Subject;
            grade = Grade;
        }
    }
}
