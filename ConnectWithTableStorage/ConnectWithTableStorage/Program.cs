using Azure;
using Azure.Data.Tables;
using System;

namespace ConnectWithTableStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new TableClient(new Uri("https://levelupsolutions.table.core.windows.net"), "tblSample",new TableSharedKeyCredential("levelupsolutions", "o1BI0aWmaCWS7/pp7OiljEQdRORQA/rZA474QOW1X56JUz+CEPOXymF1nHnEaZ3dLIYwfewPmAcQ+AStqmDWVQ=="));
            Pageable<TableEntity> queryableTable = client.Query<TableEntity>();
            foreach (TableEntity item in queryableTable)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}
