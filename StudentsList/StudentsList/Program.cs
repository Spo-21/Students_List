// See https://aka.ms/new-console-template for more information
using StudentsList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<Student> studentsList = new LinkedList<Student>();

        populateWithData(studentsList);

        int length = studentsList.Count;
        Student firstStudentInList = studentsList.First.Value;
        Student lastStudentInList = studentsList.Last.Value;

        while (true)
        {
            displayMenu();
            try
            {
                int selection = Int32.Parse(Console.ReadLine());

                if (selection == 1 || selection == 2 || selection == 3 || selection == 4 || selection == 5 || selection == 6)
                {
                    menuActions(studentsList, selection, length);
                }
                else if (selection == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please read menu carefully, there is no such option");
                    Console.ReadKey();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please read carefully, there is no such option");
                Console.ReadKey();
            }
        }
    }





    static void populateWithData(LinkedList<Student> students)
    {
        Student student1 = new Student("Armen", "Hakobyan", "123", 54);
        students.AddLast(student1);
        Student student2 = new Student("Hayk", "Serobyan", "5678", 81);
        students.AddLast(student2);
        Student student3 = new Student("tatev", "Harutyunyan", "8902", 63);
        students.AddLast(student3);
        Student student4 = new Student("Gevorg", "Goginyan", "32456", 89);
        students.AddLast(student4);
        Student student5 = new Student("Vardkes", "Terteryan", "124", 23);
        students.AddLast(student5);
        Student student6 = new Student("Arman", "Vardanyan", "8976", 81);
        students.AddLast(student6);
        Student student7 = new Student("Ashot", "Seryanyan", "3321", 65);
        students.AddLast(student7);
        Student student8 = new Student("Sargis", "Pashinyan", "44000", 37);
        students.AddLast(student8);
        Student student9 = new Student("Vardan", "Kirakosyan", "0148", 54);
        students.AddLast(student9);
        Student student10 = new Student("Ani", "Petrosyan", "28936", 74);
        students.AddLast(student10);
        Student student11 = new Student("Anna", "Umityan", "9931", 32);
        students.AddLast(student11);
        Student student12 = new Student("Meri", "Sargsyan", "2934", 55);
        students.AddLast(student12);
        Student student13 = new Student("Edgar", "Tonoyan", "6789", 92);
        students.AddLast(student13);
        Student student14 = new Student("Artur", "Sahakyan", "67893", 48);
        students.AddLast(student14);
        Student student15 = new Student("Arpi", "Nersisyan", "5678", 71);
        students.AddLast(student15);
    }

    static void displayMenu()
    {
        Console.Clear();
        Console.WriteLine("PLease select one of the folowing options");
        Console.WriteLine();
        Console.WriteLine("Please press 1 to add a new student");
        Console.WriteLine("Please press 2 to get information about the student you chose by index");
        Console.WriteLine("Please press 3 to remove a student you chose by index from the list");
        Console.WriteLine("Please press 4 to remove the first student from the list");
        Console.WriteLine("Please press 5 to remove the last student from the list");
        Console.WriteLine("Please press 6 to see all students");
        Console.WriteLine("PLease press 0 to Exit");
        Console.WriteLine();
    }

    static void menuActions(LinkedList<Student> students, int selection, int listLength)
    {
        switch(selection)
        {
            case 1:
                addStudent(students);
                break;

            case 2:
                getStudentByIndex(students, listLength);
                break;

            case 3:
                removeStudentByIndex(students, listLength);
                break;

            case 4:
                removeFirstStudent(students);
                break;

            case 5:
                removeLastStudent(students);
                break;

            case 6:
                displayAllStudents(students);
                break;
        }
        Console.WriteLine("Please press any key to see menu");
        Console.ReadKey();
    }

    static void addStudent(LinkedList<Student> students)
    {
        Student student = new Student();

        Console.Write("Please enter the student's first name:  ");
        student.FirstName = Console.ReadLine();

        Console.Write("Please enter the student's last name:  ");
        student.LastName = Console.ReadLine();

        Console.Write("Please enter the student's number:  ");
        student.StudentNumber = Console.ReadLine();
        while(true)
        {
            try
            {
                Console.Write("Please enter the student's average score:  ");
                student.AverageScore = float.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Sorry the score supposed to be a number, please try again");
            }
        }
        
        students.AddLast(student);

        Console.WriteLine();
        Console.WriteLine("The student " + student.FirstName + " has been successfully added to the list");
        Console.WriteLine();
    }

    static void getStudentByIndex(LinkedList<Student> students, int listLength)
    {
        while(true)
        {
            Console.Write("Please enter the student's index you wish to get information about:  ");
            int index = int.Parse(Console.ReadLine()) - 1;
            try
            {
                Console.Write("Student's first name-  " + students.ElementAt(index).FirstName + ", ");
                Console.Write("Student's last name-  " + students.ElementAt(index).LastName + ", ");
                Console.Write("Student's number-  " + students.ElementAt(index).StudentNumber + ", ");
                Console.WriteLine("Student's average score-  " + students.ElementAt(index).AverageScore);
                break;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry there is no such student with this index, there are only " + listLength + " students, please try again");
                Console.WriteLine();
            }
        }
    }

    static void removeStudentByIndex(LinkedList<Student> students, int listLength)
    {
        while (true)
        {
            Console.Write("Please enter the student's index you wish to remove:  ");

            int index = Int32.Parse(Console.ReadLine()) - 1;

            try
            {
                students.Remove(students.ElementAt(index));
                Console.WriteLine("The student with index " + (index + 1) + " has been successfully removed");
                break;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine();
                Console.WriteLine("Sorry there is no such student with this index, there are only " + listLength + " students, please try again");
                Console.WriteLine();
            }
        }
    }

    static void removeFirstStudent(LinkedList<Student> students)
    {
        students.RemoveFirst();
        Console.WriteLine("The first student of the list has been successfully removed");
        Console.WriteLine();
    }

    static void removeLastStudent(LinkedList<Student> students)
    {
        Console.WriteLine("The last student of the list has been successfully removed");
        Console.WriteLine();
        students.RemoveLast();
    }

    static void displayAllStudents(LinkedList<Student> students)
    {
        for (int i = 0; i < students.Count; i++)
        {
            int num = i + 1;
        
            Console.Write(num + ".  " + "Student's first name-  " + students.ElementAt(i).FirstName + ", ");
            Console.Write("Student's last name-  " + students.ElementAt(i).LastName + ", ");
            Console.Write("Student's number-  " + students.ElementAt(i).StudentNumber + ", ");
            Console.WriteLine("Student's average score-  " + students.ElementAt(i).AverageScore);
            Console.WriteLine();
        }
    }


}





