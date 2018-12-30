//This is a c# program that demonstrates set and get properties.

using System;
namespace Properties{
   class Student {
      private string id = "none";
      private string name = "none"; 
     
      // Id property of type string:
      public string Id{
         get {
            return id
         }
         set {
            id = value;
         }
      }
      
      // Name property of type string:
      public string Name {
         get {
            return name;
         }
         set {
            name = value;
         }
      }
      
     
      public override string ToString() {
         return "Id = " + Id +", Name = " + Name;
      }
   }
   
   class Prop {
      public static void Main() {
      
         // Create a new Student object:
         Student stud = new Student();
     
         // Setting id and name of the student
         stud.Id = "01";
         stud.Name = "Lulit";
         Console.WriteLine("Student Info: {0}", stud);
         Console.ReadKey();
      }
   }
}