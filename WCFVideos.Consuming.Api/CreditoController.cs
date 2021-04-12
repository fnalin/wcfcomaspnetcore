using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WCFVideos.Consuming.Api
{
    // baseado em https://youtu.be/BSCVYf7bjZc

    [Route("api/credito")]
    [ApiController]
    public class CreditoController: ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            ServiceDeGestaoDeCredito.GestorDeCreditoClient proxy =
                    new ServiceDeGestaoDeCredito.GestorDeCreditoClient(ServiceDeGestaoDeCredito.GestorDeCreditoClient.EndpointConfiguration.BasicHttpBinding_IGestorDeCredito);
            var data = await proxy.RecuperarQuantidadeDeRecursoDisponivelAsync();
            return Ok(data);
        }
        
    }
}
