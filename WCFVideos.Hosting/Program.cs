using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCFVideos.Contratos;
using WCFVideos.Servico;

namespace WCFVideos.Hosting
{
    //baseado em https://youtu.be/ch1RMlxOZUg
    // testar em C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\WcfTestClient.exe
    class Program
    {
        static void Main(string[] args)
        {

            var uris = new Uri[] {
                new Uri("net.tcp://localhost:9876"),
                new Uri("http://localhost:9877")

            };

            // Configuração Imperativa
            // Parâmetros informados no código
            using (ServiceHost host = new ServiceHost(typeof(ServicoDeGestaoDeCredito), uris))
            {
                // para gerar wsdl
                host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });

                // abc => address / binding / contract
                host.AddServiceEndpoint(typeof(IGestorDeCredito), new NetTcpBinding(), "srv");
                host.AddServiceEndpoint(typeof(IGestorDeCredito), new BasicHttpBinding(), "srv");

                // disponibilizando o wsdl
                host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");


                host.Open();
                Console.ReadLine();
            }

        }
    }
}
