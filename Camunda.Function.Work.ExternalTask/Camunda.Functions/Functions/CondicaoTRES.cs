using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Functions.Models;
using Camunda.Functions.Servicos;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Camunda.Functions.Functions
{
    public class condicaoTRES
    {
        private readonly ICamundaService _camundaService;
        public condicaoTRES(ICamundaService camundaService)
        {
            _camundaService = camundaService;
        }

        [FunctionName("CondicaoTRES")]
        public async Task Run([ServiceBusTrigger("condicaoTRES", Connection = "ServiceBusConnectionString")] ExternalTasks task, ILogger log)
        {
            //log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");

            //Execucao dos servicos AQUI (consultas BD, condicoes etc...;

            var variables = new Dictionary<string, Variables>
            {
                //{ "condicaoSim", new Variables{ Type = "boolean", Value = true }}
            };

            await _camundaService.CompleteExternalTask(task.Id.ToString(), new CompleteExternalTaskRequest { WorkerId = "ProcessoExternalTask", Variables = variables });

            log.LogInformation($"@@ BusinessKey: {task.BusinessKey} condicao TRES realizada");

        }
    }
}