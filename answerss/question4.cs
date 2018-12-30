//c# program
// Override keyword is used in the derived class of the base class in order to override the base class method.
// The Override keyword is used with the virtual keyword.
    using System;  
    using System.Collections.Generic;  
    using System.Linq;  
    using System.Text;  
    using System.Threading.Tasks;  
      
    namespace VirtualOverride  
    {  
        // Base Class    
        class Function1
        {  
            public virtual void Print_Message()  
            {  
                Console.WriteLine("Inside Function1");  
            }  
        }  
      
        class Function2: Function1
        {  
            public override void Print_Message()  
            {  
                Console.WriteLine("Inside Function2");  
      
            }  
        }  
      
        class Program  
        {  
            static void Main(string[] args)  
            {  
                Function1 Obj1 = new Function1();  
                Obj1.Print_Message();  
                Function2 Obj2 = new Function2();  
                Obj2.Print_Message();  
                Function1 Obj3 = new Function2();  
                Obj3.Print_Message() 
                Console.ReadLine();  
            }  
        }  
    }  