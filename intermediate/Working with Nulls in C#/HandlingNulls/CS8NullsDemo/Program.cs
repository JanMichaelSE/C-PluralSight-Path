using System;

namespace CS8NullsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var message = new Message() 
            {
                Text = "Hi",
                From = null
            };

            MessagePopulator.Populate(message);
            
            Console.WriteLine(message.From!.Length);
            Console.WriteLine(message.Text);
            Console.WriteLine(message.From ?? "From is null");


            Console.ReadLine();
        }
    }
}
