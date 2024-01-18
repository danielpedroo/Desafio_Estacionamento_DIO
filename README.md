# Projeto de Estacionamento em C# - DIO Trilha .NET - Fundamentos

Este projeto faz parte do módulo de fundamentos da trilha .NET oferecida pela DIO (Digital Innovation One). O objetivo é construir um sistema de estacionamento para gerenciar veículos estacionados e realizar operações como adição, remoção e listagem de veículos.

## Estrutura do Projeto
O projeto consiste em uma classe chamada "Estacionamento", conforme o diagrama de classe fornecido.

### Classe `Estacionamento`

A classe contém três variáveis:

- `precoInicial`: Tipo decimal. Representa o preço cobrado para deixar um veículo estacionado.
- `precoPorHora`: Tipo decimal. Representa o preço por hora que o veículo permanece estacionado.
- `veiculos`: Lista de strings. Representa os veículos estacionados, contendo apenas as placas dos veículos.

A classe possui três métodos:

- `AdicionarVeiculo`: Método para receber uma placa digitada pelo usuário e armazená-la na lista `veiculos`.
- `RemoverVeiculo`: Método para verificar se um veículo está estacionado, solicitar a quantidade de horas que ele permaneceu e calcular o valor cobrado, exibindo-o para o usuário.
- `ListarVeiculos`: Método para listar todos os veículos presentes no estacionamento. Se não houver veículos, exibe a mensagem "Não há veículos estacionados".

## Implementação do Código
O código do projeto está pela metade, e a implementação deve ser concluída seguindo as regras descritas acima. Procure pela palavra comentada "TODO" no código, e em seguida, implemente conforme as regras estabelecidas.

O código-fonte e instruções detalhadas podem ser encontrados [aqui](https://github.com/digitalinnovationone/trilha-net-fundamentos-desafio). Este projeto contribui para o aprendizado dos fundamentos na trilha .NET da DIO.
