using System;

namespace NETFinal22
{
    public class Program
    {
        public static void Main()
        {
            Sample sample = new Sample();
      
            Example eg = new Example();

            eg.ExampleCall += sample.ExampleCallFunc;
       
            eg.createNotification("Show Notification ");

            Console.ReadLine();

        }
    }

    public class Sample
    {
        public void ExampleCallFunc(object sender, ExampleInfo e)
        {
            Console.WriteLine("Create Event: " + e.address);
        }

    }

    public class Example
    {
        public event ExampleEvent ExampleCall;

        public void createNotification(string msg)
        {
            if (ExampleCall != null)
            {
                ExampleCall(this, new ExampleInfo(msg));
            }
        }
    }

    public delegate void ExampleEvent(object sender, ExampleInfo e);

    public class ExampleInfo : EventArgs
    {
        public string address { get; set; }
        public ExampleInfo(string Address)
        {
            address = Address;
        }
    }
}
