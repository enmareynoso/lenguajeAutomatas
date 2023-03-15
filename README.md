# Lenguaje de definicion de automatas finitos

Este proyecto consiste en un lenguaje que permite definir autómatas finitos. El lenguaje acepta la especificación de un tipo de autómata, estado inicial, estados de aceptación y transiciones. El proyecto toma como entrada un archivo que contiene la especificación de un autómata en el lenguaje definido y genera un archivo de salida en formato DOT, que representa el autómata especificado

## Syntax de nuestro lenguaje
El lenguaje de definición de autómatas finitos tiene la siguiente sintaxis:

    Automata:
      Tipo: TipoAutomata
      Inicio: Estado
      Aceptacion: Estados
      Transiciones:
          Estado -> Estado: Input
          Estado -> {Estado}: Input
          Estado -> Estado: vacio
          Estado -> {Estado}: vacio


## Ejemplo de automata realizado en el lenguaje

L = { w | w tiene un 1 en la décima posición }  para Σ = {0, 1}

    Automata:
      Tipo: determinista
      Inicio: p0
      Aceptacion: {p3}
      Transiciones:
          p0 -> p1: 0, 1
          p1 -> p2: 0, 1
          p2 -> p3: 0, 1
          p3 -> p4: 0, 1
          p4 -> p5: 0, 1
          p5 -> p6: 0, 1
          p6 -> p7: 0, 1
          p7 -> p8: 0, 1
          p8 -> p9: 0, 1
          p9 -> pa: 1
          p9 -> pr: 0
          pa -> pa: 0, 1
          pr -> pr: 0, 1
          
# Guia de uso

1. Clonar el repositorio en su máquina

2. Crear un input file con la extension .fa en el root directory que incluya un automata creado por usted utilizando la syntax del lenguaje. **Ejemplo:** miautomata1.fa
4. Correr el proyecto que se encuentra dentro de la carpeta programa llamado ConsoleApp1


Al correr ConsoleApp1 se generará un output file llamado prueba.dot con la traducción del input file creado anteriormente  al formato DOT.

Para visualizar el diagrama, puede usar la siguiente página web:
[Graphviz Online ](https://dreampuf.github.io/GraphvizOnline/#digraph%20G%20%7B%0A%0A%20%20subgraph%20cluster_0%20%7B%0A%20%20%20%20style=filled;%0A%20%20%20%20color=lightgrey;%0A%20%20%20%20node%20%5Bstyle=filled,color=white%5D;%0A%20%20%20%20a0%20-%3E%20a1%20-%3E%20a2%20-%3E%20a3;%0A%20%20%20%20label%20=%20%22process%20#1%22;%0A%20%20%7D%0A%0A%20%20subgraph%20cluster_1%20%7B%0A%20%20%20%20node%20%5Bstyle=filled%5D;%0A%20%20%20%20b0%20-%3E%20b1%20-%3E%20b2%20-%3E%20b3;%0A%20%20%20%20label%20=%20%22process%20#2%22;%0A%20%20%20%20color=blue%0A%20%20%7D%0A%20%20start%20-%3E%20a0;%0A%20%20start%20-%3E%20b0;%0A%20%20a1%20-%3E%20b3;%0A%20%20b2%20-%3E%20a3;%0A%20%20a3%20-%3E%20a0;%0A%20%20a3%20-%3E%20end;%0A%20%20b3%20-%3E%20end;%0A%0A%20%20start%20%5Bshape=Mdiamond%5D;%0A%20%20end%20%5Bshape=Msquare%5D;%0A%7D)