namespace ObjectOrientedProject
{
    public class Student
    {
        private int id;
        private string name;
        private int rollNumber;

        private double gpa;

        public Student(){
        }

        public Student(int id, string name, int rollNumber, double gpa){
            this.id = id;
            this.name = name;
            this.rollNumber=rollNumber;
            this.gpa = gpa;

        }
        
        public int Id{
            get{
                return this.id;
                }
            set{
                this.id = value;
            }
        }
        public string Name {
            get{return this.name;}
        set{
            this.name = value;
        }}
        public int Roll {
            get{return this.rollNumber;}
        set{
            this.rollNumber = value;
        }}

        public double Gpa{
            get{
                return this.gpa;
            }

            set{

                this.gpa = value;
            }
        }

        

    }
}