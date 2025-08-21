# Sistema de Celular 📲

## Visão Geral

Este projeto foi desenvolvido em C# para demonstrar os pilares mais avançados da **Programação Orientada a Objetos (POO)**. Ele simula a criação e o uso de diferentes marcas de smartphones.

## Conceitos Aplicados

* **Herança:** As classes `Nokia` e `Iphone` herdam da classe base `Smartphone`, reutilizando comportamentos comuns como `Ligar()` e `ReceberLigacao()`.
* **Polimorfismo:** O método `InstalarAplicativo` é um exemplo de polimorfismo. Embora o nome do método seja o mesmo, a implementação é diferente em cada classe filha (`Nokia` e `Iphone`), permitindo um comportamento único para cada marca.
* **Classe Abstrata:** A classe `Smartphone` é definida como `abstract`, o que significa que ela não pode ser instanciada diretamente. Ela existe apenas para ser herdada por outras classes, garantindo que os métodos abstratos sejam sempre implementados.

## Como Executar

Para rodar a aplicação, compile e execute o arquivo `Program.cs`.
