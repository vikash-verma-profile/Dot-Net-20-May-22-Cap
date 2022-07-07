using Azure.Storage.Queues;
using System;

namespace ConnectwithQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertMessage("Order with ORD13234 is proccessed");
        }

        public static void InsertMessage(string message)
        {
            string connectionstring = "DefaultEndpointsProtocol=https;AccountName=levelupsolutions;AccountKey=o1BI0aWmaCWS7/pp7OiljEQdRORQA/rZA474QOW1X56JUz+CEPOXymF1nHnEaZ3dLIYwfewPmAcQ+AStqmDWVQ==;EndpointSuffix=core.windows.net";
            QueueClient queueClient = new QueueClient(connectionstring,"sample-queue");
            queueClient.CreateIfNotExists();
            if (queueClient.Exists())
            {
                queueClient.SendMessage(message);
            }
            Console.WriteLine("Message is inserted");
        }
    }
}
