<div align="center">
<img height="200px" src="https://camunda.com/wp-content/uploads/2020/07/camunda-logo-social-update.jpg" alt="logoC#" />
</div>
<h1 align="center">External Tasks<br>
(Azrure Functions, Servicebus, .NET, C#)</h1>
<a name="back-to-top">
<div align="center">
  <p>
    <a href="https://azure.microsoft.com/pt-br/products/functions">
      <img height="50" src="https://user-images.githubusercontent.com/57602117/211108014-33fac232-1fc8-4914-b06f-c4b83452a640.png">
    </a>     
    <a href="https://azure.microsoft.com/pt-br/products/service-bus">
      <img height="50" src="https://user-images.githubusercontent.com/57602117/211107676-a7fe948f-1ebf-4fe3-b33b-51dfa77d089c.png" loading="lazy"/>
    </a>
    <a href="https://dotnet.microsoft.com/pt-br/">
      <img height="50" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ_7BUSHtcFk76HbyVo2uHja9qLaowmxyzAKw&usqp=CAU" loading="lazy"/>
    </a>
    <a href="https://dotnet.microsoft.com/en-us/learn/csharp">
      <img height="50" src="https://cdn.icon-icons.com/icons2/2415/PNG/512/csharp_original_logo_icon_146578.png" loading="lazy"/>
    </a>
    <a href="https://camunda.com/">
      <img height="50" src="https://camunda.com/wp-content/uploads/2020/12/Camunda-workflow-engine-gradient.png" loading="lazy"/>
    </a>
    <a href="https://camunda.com/">
      <img height="50" src="https://camunda.com/wp-content/uploads/2021/07/dmn.svg" loading="lazy"/>
    </a>
    <a href="https://camunda.com/">
      <img height="50" src="https://camunda.com/wp-content/uploads/2020/05/cockpit.svg" loading="lazy"/> 
    </a>  
  </p> 
</div>
<br>
<p>

  ## 🔎 Índice
  - [BPMN Base](#bpmn-base)
  - [Estrutura do Projeto](#estrutura-projeto)
  - [Collection](#collection)
  - [Filas e Comunicação com Servicebus](#filas-servicebus)
  - [Tecnologias Utilizadas](#tec-utilizadas)
  - [Console execução Functions](#exec-function)
  - [Visualização Funcionamento do Processo (log)](#exec-function-log)
  - [Como Rodar o Projeto](#rodar-projeto)
</p>
<br>
<p>
<a name="bpmn-base">

  ## 📄 BPMN Base 
<a href="">
    <img height="340" align="center" src="assets/BPMNBase.png">
  </a> 
</p>
<br>
<p>
<a name="estrutura-projeto">

  ## 👨‍💻 Estrutura do Projeto
  #### _(Worker(ouvinte) + quatro Functions genéricas referentes a estrutura da BPMN)_
<a href="">
  <img height="580" align="center" src="assets/EstruturadoProjeto.png">
</a> 
</p>
<br>
<p>
<a name="collection">

  ## 📚 Collection
  <a href="">
    <img height="" align="center" src="assets/Collection.png">
  </a> 
</p>  
<br>
<p>
<a name="exec-function">

  ## ⚡ Console execução Functions
  #### _(Filas e Worker, todas as etapas possuem log. São precedidos por "@@")_ 
  <a href="">
    <img height="300" align="center" src="assets/ConsoleexecuçãoFunctions.png">
  </a> 
</p>  
<br>
<p>
<a name="exec-function-log">

  ## ⚡ Visualização Funcionamento do Processo (log)  
  <a href="">
    <img height="545" align="center" src="assets/Processolog.png">
  </a> 
</p>  
<br>
<p>
<a name="filas-servicebus">

  ## 🚌 Filas e Comunicação com Servicebus 
  <a href="">
    <img height="" align="center" src="assets/servicebus.png">
  </a> 
</p>  
<br>
<p>
<a name="rodar-projeto">

  ## ⚙️ Como Rodar o Projeto
  <h4><i>(Tópico genérico para ser usado como tasklist)</i></h4>
  <h4><i>(Pré requisitos: SDK .NET e JDK 15)</i></h4>

- Clonar repositório
- incluir as seguintes propriedades no local.settings.json com os seus respectivos dados:
  - CamundaUrl
  - ServiceBusConnectionString
- Criar Servicebus com as seguintes filas (Nomes genéricos utilizados no projeto): 
  - condicaoum
  - condicaodois
  - condicaotres
- Iniciar o projeto
- Importar Collection no Postman
- Abrir arquivo BPMN no Camunda: genenericMain.bpmn
- Iniciar servidor escolhido: Tomcat, Docker(image) ou Camunda Run
- Implantar Camunda
- Iniciar um processo atraves da rota POST|StartProcess
</p>
<br>
<br>
<a name="tec-utilizadas">

  ## <img height="45px" align="center" src="https://github.com/OsZeressemos/zeroCommerce/blob/main/public/assets/readme/stockrocketgif.gif">    Tecnologias Utilizadas
<div align="left">

  - [**Azure Functions**](https://azure.microsoft.com/pt-br/products/functions)    [(*Documentação*)](https://learn.microsoft.com/pt-BR/azure/azure-functions/)
  - [**Camunda**](https://camunda.com/)    [(*Documentação*)](https://docs.camunda.io/)
  - [**Camunda Desktop Modeler**](https://camunda.com/download/modeler/)    [(*Documentação*)](https://docs.camunda.org/manual/latest/introduction/third-party-libraries/?__hstc=252030934.4ac1f27b1db0ceeb20f17898b27cf3ba.1673104365466.1673104365466.1673104365466.1&__hssc=252030934.11.1673104365467&__hsfp=1123496843)
  - [**Camunda Platform Run**](https://camunda.com/download/)    [*(Documentação)*](https://docs.camunda.org/manual/latest/installation/full/)
    - Outras opções de servidores:
      - [**Docker**](https://www.docker.com/)    [*(Documentação)*](https://docs.camunda.org/manual/latest/installation/docker/?__hstc=252030934.4ac1f27b1db0ceeb20f17898b27cf3ba.1673104365466.1673104365466.1673104365466.1&__hssc=252030934.13.1673104365467&__hsfp=1123496843)
      - [**Tomcat**](https://tomcat.apache.org/)    [(*Documentação*)](https://docs.camunda.org/manual/latest/installation/full/tomcat/pre-packaged/?__hstc=252030934.4ac1f27b1db0ceeb20f17898b27cf3ba.1673104365466.1673104365466.1673104365466.1&__hssc=252030934.13.1673104365467&__hsfp=1123496843)
  - [**C#**](https://dotnet.microsoft.com/en-us/learn/csharp)    [(*Documentação*)](https://learn.microsoft.com/pt-br/dotnet/csharp/?WT.mc_id=dotnet-35129-website)
  - [**JDK 15**](https://jdk.java.net/)    [(*Documentação*)](https://www.oracle.com/java/technologies/javase/jdk15-archive-downloads.html)
  - [**.NET**](https://dotnet.microsoft.com/pt-br/)    [(*Documentação*)](https://learn.microsoft.com/pt-br/dotnet/?WT.mc_id=dotnet-35129-website)
  - [**Postman**](https://www.postman.com/)    [(*Documentação*)](https://learning.postman.com/docs/getting-started/introduction/)
  - [**Servicebus**](https://azure.microsoft.com/pt-br/products/service-bus)    [(*Documentação*)](https://learn.microsoft.com/pt-BR/azure/service-bus-messaging/service-bus-dotnet-get-started-with-queues?tabs=passwordless)
</div>
<br> 

&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;⬆️[**Back to top**](#back-to-top)⬆️
