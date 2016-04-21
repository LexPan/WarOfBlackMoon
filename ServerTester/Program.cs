using BsonCFServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ServerTester
{
    class Program
    {
        private static ServiceHost Host = null;
        static void Main(string[] args)
        {
            while (true)
            {
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "start":
                        StartServer();
                        break;
                    case "esc":
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Function not Exist.");
                        break;
                }
            }
        }

        private static void StartServer()
        {
            if (Host == null)
            {
                Host = new ServiceHost(typeof(BsonCFServer));

                //绑定
                System.ServiceModel.Channels.Binding httpBinding = new BasicHttpBinding();
                //终结点
                Host.AddServiceEndpoint(typeof(IBsonCFServer), httpBinding, "http://192.168.1.3:8002/");
                if (Host.Description.Behaviors.Find<System.ServiceModel.Description.ServiceMetadataBehavior>() == null)
                {
                    //行为
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;

                    //元数据地址
                    behavior.HttpGetUrl = new Uri("http://192.168.1.3:8002/IBsonCFServer");
                    Host.Description.Behaviors.Add(behavior);

                    //启动
                    Host.Open();
                }
            }
        }
    }
}
