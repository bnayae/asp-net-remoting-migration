using System;
using System.Threading.Tasks;
using System.Net.Http;
using Common;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var items = new DataObjectCollection
            //{
            //    new DataObject{ Id = 1, Name = "bnaya"},
            //    new DataObject{ Id = 2, Name = "aline"}
            //};
            var items = new SysParamCollection
            {
                new SysParam{ Id = 1, Name = "bnaya", Score = 5},
                new SysParam{ Id = 2, Name = "aline", Score = 10}
            };

            var x = await RestHelper.Proxy.PostAsync("http://localhost:2711/api/values/", items, RestHelper.DefaultFormatter);
            var y = await x.Content.ReadAsAsync<DataObjectCollection>(RestHelper.DefaultFormatters);
            var z = y[0];
            Console.WriteLine($"Value = {z}");

            Console.ReadKey();
        }
    }
}
