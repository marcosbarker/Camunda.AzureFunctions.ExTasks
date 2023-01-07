using System.Threading.Tasks;
using Camunda.Functions.Servicos;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

//Worker (ouvinte)
namespace Camunda.Functions.Functions
{
    public class WorkerGetExternalTask
    {
        private readonly SBService _sbService;
        private readonly ICamundaService _camundaService;

        public WorkerGetExternalTask(ICamundaService camundaService, SBService sbService)
        {
            _sbService = sbService;
            _camundaService = camundaService;
        }

        [FunctionName("WorkerGetExternalTask")]
        public async Task Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            //log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var response = await _camundaService.WorkerGetExternalTasks();
            foreach(var task in response)
            {
                //publica no SB
                await _sbService.SendMessage(task.TopicName, JsonConvert.SerializeObject(task));
            }

            log.LogInformation($"@@Processando: {response.Count} recebidas do Camunda (tarefas externas).");
        }
    }
}
