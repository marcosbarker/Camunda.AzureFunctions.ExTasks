using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Helpers;
using Camunda.Functions.Models;
using Camunda.Functions.Servicos;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Camunda.Functions.Functions
{
    public class condicaoUM
    {
        private readonly ICamundaService _camundaService;
        public condicaoUM(ICamundaService camundaService)
        {
            _camundaService = camundaService;
        }

        [FunctionName("condicaoUM")]
        public async Task Run([ServiceBusTrigger("condicaoUM", Connection = "ServiceBusConnectionString")] ExternalTasks task, ILogger log)
        
        {
            //log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");

            //Execucao dos servicos AQUI (consultas BD, condicoes etc...;
           
            var variables = new Dictionary<string, Variables>
            {
                { "condicaoSim", new Variables{ Type = "boolean", Value = true }}
            };

           await _camundaService.CompleteExternalTask(task.Id.ToString(), new CompleteExternalTaskRequest { WorkerId = "ProcessoExternalTask", Variables = variables });

           log.LogInformation($"@@ BusinessKey: {task.BusinessKey} condicao UM realizada");
        }
    }
}