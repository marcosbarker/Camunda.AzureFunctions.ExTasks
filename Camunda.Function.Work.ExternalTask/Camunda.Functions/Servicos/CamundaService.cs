using Camunda.Functions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Camunda.Functions.Functions;
using Newtonsoft.Json;

namespace Camunda.Functions.Servicos
{
    public class CamundaService : ICamundaService
    {
        private readonly UserAgent _userAgent;
        private readonly string _url;

        public CamundaService(UserAgent userAgent)
        {
            _userAgent = userAgent;
            _url = Environment.GetEnvironmentVariable("CamundaUrl");
        }

        public async Task CompleteExternalTask(string id, CompleteExternalTaskRequest request)
        {
            await _userAgent.PostAsJsonAsync<List<Dictionary<string, Variables>>>($"{_url}/external-task/{id}/complete", JsonConvert.SerializeObject(request));
        }

        public async Task<List<ExternalTasks>> WorkerGetExternalTasks()
        {
            var request = new
            {
                workerId = "ProcessoCredito",
                maxTasks = 10,
                topics = new[]
                   {
                        new {
                            topicName = "condicaoUM",
                            lockDuration = 1000
                        },
                        new {
                            topicName = "condicaoTRES",
                            lockDuration = 1000
                        },
                         new {
                            topicName = "condicaoDOIS",
                            lockDuration = 1000
                        },
                    }
            };
            var requestBoddy = JsonConvert.SerializeObject(request);

            return await _userAgent.PostAsJsonAsync<List<ExternalTasks>>($"{_url}/external-task/fetchAndLock", requestBoddy);
        }
              
        public async Task StartProcess(string processKey, StartProcess startProcess)
        {
            await _userAgent.PostAsJsonAsync($"{_url}/process-definition/key/{processKey}/start", startProcess);
        }
    }
}
