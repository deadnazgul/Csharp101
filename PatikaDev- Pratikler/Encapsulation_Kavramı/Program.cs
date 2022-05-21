// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 
Student student_1 = new Student();
Console.WriteLine("&&&&&&&& GRIFINDOR &&&&&&&&");
student_1.Name = "Harry";
student_1.Surname = "Potter";
student_1.Student_id = 64;
student_1.Grade = 4;
student_1.Fetch_Student_Information();
Console.WriteLine("***************************");
student_1.Next_Grade();
student_1.Fetch_Student_Information();
Console.WriteLine("######### SILITERIN ########");
Student student_2 = new Student("Draco","Malfoy",63,4);
student_2.Fetch_Student_Information();
Console.WriteLine("***************************");
student_2.Next_Grade();
student_2.Fetch_Student_Information();
Console.WriteLine("&&&&&&&& GRIFINDOR &&&&&&&&");
Student student_3 = new Student("Hermony","Granger",65,1);
student_3.Prior_Grade();
student_3.Prior_Grade();
student_3.Prior_Grade();
student_3.Fetch_Student_Information();




class Student{
    private string name;
    private string surname;
    private int student_id;
    private int grade;

    public string Name{
        get { return name;}
        set { name = value;}
    }
    public string Surname{ get => surname; set => surname = value;}
    public int Student_id{ get => student_id; set => student_id = value;}
    public int Grade{
          get => grade; 
          set{
              if(value < 1){
                  Console.WriteLine("Grade must be greater or equal to 1 !");
                  grade = 1;
              }else{grade = value;}
          }
        }

    public Student(string name, string surname, int student_id, int grade){
        this.Name = name;
        this.Surname = surname;
        this.Student_id = student_id;
        this.Grade = grade;
    }
    public Student(){ }

    public void Fetch_Student_Information(){
        Console.WriteLine("Student Name: {0}",this.Name);
        Console.WriteLine("Student SurName: {0}",this.Surname);
        Console.WriteLine("Student ID: {0}",this.Student_id);
        Console.WriteLine("Student Grade: {0}",this.Grade);
    }

    public void Next_Grade(){
        this.Grade = this.Grade + 1;
    }
    public void Prior_Grade(){
        this.Grade = this.Grade - 1;
    }
}