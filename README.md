# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
As classes e métodos foram implementados conforme as regras de validação descritas acima. A classe abstrata `Smartphone` serve como modelo base, enquanto as classes `Nokia` e `Iphone` herdam de `Smartphone` e implementam suas próprias versões do método `InstalarAplicativo`.

## O que foi trabalhado no projeto
Neste projeto, foram aplicados os seguintes conceitos de Programação Orientada a Objetos (POO):

- **Abstração**: A abstração é o processo de simplificar um sistema complexo, destacando apenas os aspectos essenciais e ocultando os detalhes desnecessários. No projeto, criamos uma classe abstrata `Smartphone` que define um modelo genérico para celulares, especificando atributos e métodos comuns a todos os tipos de celulares, sem se preocupar com as particularidades de cada marca.

- **Herança**: Herança é um mecanismo que permite criar uma nova classe a partir de uma classe existente, reutilizando e estendendo suas funcionalidades. No projeto, as classes `Nokia` e `Iphone` herdam da classe `Smartphone`, aproveitando os atributos e métodos definidos na classe base e adicionando comportamentos específicos de cada marca.

- **Polimorfismo**: Polimorfismo é a capacidade de um método ou objeto se comportar de diferentes maneiras, dependendo do contexto. No projeto, o método `InstalarAplicativo` é sobrescrito nas classes `Nokia` e `Iphone`, permitindo que cada tipo de celular tenha sua própria maneira de instalar aplicativos, mesmo que o método tenha o mesmo nome.

- **Classes Abstratas**: Classes abstratas são classes que não podem ser instanciadas diretamente e servem como modelo para outras classes. Elas podem conter métodos abstratos (sem implementação) que devem ser implementados pelas classes derivadas. No projeto, a classe `Smartphone` é abstrata, servindo como um modelo base para as classes `Nokia` e `Iphone`, que implementam suas próprias versões dos métodos definidos na classe abstrata.

Esses conceitos permitem criar um código mais modular, reutilizável e fácil de manter, facilitando a evolução e manutenção do sistema ao longo do tempo.

