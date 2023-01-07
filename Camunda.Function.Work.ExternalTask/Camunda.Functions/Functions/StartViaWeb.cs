using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Camunda.Functions.Servicos;
using Camunda.Functions.Models;

namespace Camunda.Functions.Functions
{
    public class StartViaWeb
    {
        private readonly ICamundaService _camundaService;
        public StartViaWeb(ICamundaService camundaService)
        {
            _camundaService = camundaService;
        }

        [FunctionName("StartViaWeb")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("@@ Solicitacao feita via Web.");

            string nome = req.Form["Nome"];
            string email = req.Form["Email"];
            string valor = req.Form["Valor"];
            string businessKey = req.Form["Chave da Operacao"];

            var pedidoAnalise = new StartProcess
            {
                BusinessKey = businessKey,
                Variables = null
            };

            await _camundaService.StartProcess("GenericMainId", pedidoAnalise);

            return new OkResult();
        }
    }
}