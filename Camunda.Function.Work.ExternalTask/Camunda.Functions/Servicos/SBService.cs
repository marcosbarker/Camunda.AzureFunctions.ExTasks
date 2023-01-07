using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Functions.Servicos
{
    public class SBService
    {
        private IDictionary<string, IQueueClient> _queuesClient;
        private readonly string _serviceBusConnectionString;


        public SBService()
        {
            _queuesClient = new Dictionary<string, IQueueClient>();
            _serviceBusConnectionString = Environment.GetEnvironmentVariable("ServiceBusConnectionString");
        }

        public async Task SendMessage(string queueName, string mensage)
        {
            IQueueClient queueClient = null;

            lock (_queuesClient)
            {
                if (!_queuesClient.TryGetValue(queueName, out queueClient))
                {
                    queueClient = new QueueClient(_serviceBusConnectionString, queueName);
                    _queuesClient.Add(queueName, queueClient);
                }
            }

            var messageFormatada = new Message(Encoding.UTF8.GetBytes(mensage));

            await queueClient.SendAsync(messageFormatada);
        }
    }
}