grammar gramaticaAutomata;

// Definicion de la regla para el aut�mata completo
automata: 'Automata:' tipo inicio aceptacion transiciones EOF;

// Definicin de la regla para el tipo de aut�mata
tipo: 'Tipo:' TipoAutomata;

// Definicion de la regla para el estado inicial
inicio: 'Inicio:' estado;

// Definicion de la regla para los estados de aceptaci�n
aceptacion: 'Aceptacion:' '{' estados '}';

// Definicion de la regla para las transiciones
transiciones: 'Transiciones:' transicion+;

// Definicion de la regla para una transici�n individual
transicion: estado '->' ( estado | '{' estados '}' ) ':' ( input | 'vacio' );

// Definicion de la regla para el input en una transici�n
input: DIGITO (',' DIGITO)*;

// Definicion de la regla para una lista de estados
estados: estado (',' estado)*;

estado: ID;

TipoAutomata: 'determinista' | 'no_determinista';

ID: [a-zA-Z][a-zA-Z0-9_]*;

DIGITO: [0-9];

WS: [ \t\r\n]+ -> skip;



