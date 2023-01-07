using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Camunda.Functions.Models;

namespace Camunda.Functions.Servicos
{
    public interface ICamundaService
    {
        Task StartProcess(string processKey, StartProcess startProcess);
        Task<List<ExternalTasks>> WorkerGetExternalTasks();
        Task CompleteExternalTask(string id, CompleteExternalTaskRequest request);
    }
}