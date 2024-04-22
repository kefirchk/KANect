using System;
using Newtonsoft.Json;

namespace KANect
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            string output = JsonConvert.SerializeObject(msg);
            //{ "UserName":"System","MessageText":"Server is running...","TimeStamp":"2024-04-22T22:21:43.8230604+03:00"}

            Console.WriteLine(msg.ToString());
            Console.WriteLine(output);

            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);

            Console.WriteLine(deserializedMsg);
        }
    }
}