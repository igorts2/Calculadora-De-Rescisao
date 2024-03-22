# Calculadora de Rescisão

## Introdução
Este projeto consiste em uma calculadora de rescisão trabalhista desenvolvida em C# utilizando o framework ASP.NET Core MVC. A aplicação permite calcular os valores de rescisão a serem pagos ao empregado com base em diversos parâmetros, como data de início e fim da relação de trabalho, motivo da demissão, salário, aviso prévio e férias pendentes.

## Funcionalidades
- **Cálculo de Rescisão**: A partir dos dados fornecidos pelo usuário, a aplicação calcula o saldo do salário, aviso prévio, férias proporcionais, décimo terceiro e FGTS com multa rescisória (se aplicável).
- **Exibição de Resultados**: Após o cálculo, os resultados são apresentados em uma página com os valores detalhados para cada componente da rescisão.

## Estrutura do Projeto
O projeto é organizado em três principais partes:

1. **Models**: Contém as classes que representam os dados da rescisão, como a classe `Rescisao`, que define os atributos relacionados à rescisão trabalhista.
   
2. **Services**: Neste diretório estão os serviços responsáveis por realizar os cálculos da rescisão. A classe `CalculoRescisao` contém os métodos para calcular o saldo do salário, aviso prévio, férias proporcionais, décimo terceiro e FGTS.

3. **Controllers**: Aqui estão os controladores da aplicação. O `RescisaoController` recebe as requisições HTTP, chama os métodos de cálculo apropriados e retorna os resultados para a visualização.

## Utilização
Para utilizar a calculadora de rescisão, siga os passos abaixo:

1. **Preencher Formulário**: Acesse a página inicial da aplicação e preencha o formulário com os dados referentes à relação de trabalho e motivo da demissão.

2. **Enviar Requisição**: Após preencher o formulário, clique no botão "Calcular" para enviar os dados.

3. **Visualizar Resultados**: Os resultados da rescisão serão exibidos em uma nova página, mostrando o saldo do salário, aviso prévio, férias proporcionais, décimo terceiro e FGTS com multa rescisória, se aplicável.

## Requisitos do Sistema
- **ASP.NET Core 8 ou superior**
- **Navegador Web**

## Como Executar
Para executar o projeto em seu ambiente local, siga as instruções abaixo:

1. Clone o repositório do GitHub para o seu computador.
2. Certifique-se de ter o SDK do .NET Core instalado em sua máquina.
3. Abra o terminal na pasta raiz do projeto.
4. Execute o comando `dotnet run`.

## Contribuições
Contribuições são bem-vindas! Se você encontrar algum problema, ou tiver alguma melhoria para sugerir, sinta-se à vontade para abrir uma issue ou enviar um pull request.

---

Espero que essa documentação ajude a compreender e utilizar o projeto. Se precisar de mais informações ou tiver alguma dúvida, não hesite em entrar em contato.
![Cadastro](Calculadora-De-Rescisao/Images/cadastro.png)

![Resultado](Calculadora-De-Rescisao/Images/resultado.png)
