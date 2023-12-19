<h1> Sistema de Estacionamento em C#</h1>

<p>Um sistema de estacionamento desenvolvido em C# para gerenciar entradas, saídas e pagamentos de veículos. Este é meu primeiro projeto utilizando C#, e o material base foi retirado de um curso de .NET oferecido pela Digital Innovation One (DIO).</p>


<h2> Instalação </h2>

Abra o projeto no Visual Studio Code ou em seu ambiente de desenvolvimento preferido.
Compile e execute o projeto.

```bash
git clone https://github.com/rafael-santos201/Sistema-estacionamento
dotnet build
dotnet run
```

<h2> Proposta </h2>
  <img src="https://github.com/leonardo-buta/trilha-net-fundamentos-desafio/blob/main/diagrama_classe_estacionamento.png">


<h3> Funcionalidades </h3>

<h4>A classe contém três variáveis, sendo:</h4>

- **precoInicial:** Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

- **precoPorHora:** Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

- **veiculos:** É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

<h4>A classe contém três métodos, sendo:</h4>

- **Adicionar Veículos:** Cadastre as placas dos veículos que entram no estacionamento, utilizando uma lista para armazenar essas informações.

- **Remover Veículos:** Verifique se a placa do veículo está estacionada, calcule o valor a ser pago (se necessário) e remova o veículo do sistema.

- **Listar Veículos:** Exiba a lista de placas de todos os veículos atualmente estacionados.
