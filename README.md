
Projeto que expõe problemas de design e propõe soluções usando os princípios SOLID.

SOLID é um acrônimo de cinco princípios da orientação a objetos e design de código definidos por Robert C. Martin.

Nas palavras do próprio "Uncle Bob":
    
    "Dependency Management is an issue that most of us have faced. Whenever we bring up on our screens a nasty batch of tangled legacy code, 
    we are experiencing the results of poor dependency management. Poor dependency managment leads to code that is hard to change, fragile,
    and non-reusable. Indeed, I talk about several different design smells in the PPP book, all relating to dependency management. 
    On the other hand, when dependencies are well managed, the code remains flexible, robust,and reusable. So dependency management, 
    and therefore these principles, are at the foudation of the -ilities that software developers desire."
    
Resumindo, ao aplicarmos os princípios Solid buscamos criar aplicações com responsabilidades segregadas, dimunição de dependências, mais flexíveis para crescerem, com rosbustez e reuso de código. Isso tudo facilita muito a implantação de testes unitários também. 

O Que vem a ser cada letra do Acrônimo. Segue Abaixo:

Single Responsibility Principle -> Princípio de única responsabilidade 
  "uma classe deve ter apenas uma única responsabilidade (mudanças em apenas uma parte da especificação do software, devem ser capaz de afetar a 
   especificação da classe)."
   
Open-Closed Principle - Princípio de aberto/fechado
  "entidades de software devem ser abertas para extensão, mas fechadas para modificação."

Princípio da substituição de Liskov  
  "objetos em um programa devem ser substituíveis por instâncias de seus subtipos, sem alterar a funcionalidade do programa." deve ser capaz de 
  afetar apenas a especificação da classe.

Princípio da segregação de Interface
  "muitas interfaces de clientes específicas, são melhores do que uma para uma infinidade de propósitos."

Princípio da inversão de dependência
  "deve-se depender de abstrações, não de objetos concretos.

No meu projeto coloquei um problema e uma solução para cada um dos princípios em C#. Em breve quero abordar mais detalhadamente esse assunto.
