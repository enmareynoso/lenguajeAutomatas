grammar gramaticaAutomata;

automata: 'Automata:' tipo inicio aceptacion transiciones;

tipo: 'Tipo:' TipoAutomata;

inicio: 'Inicio:' estado;

aceptacion: 'Aceptacion:' '{' estados '}';

transiciones: 'Transiciones:' transicion (':' transicion)*;

transicion: estado '->' ( estado | '{' estados '}' ) ':' ( input | 'vacio' );

input: DIGITO+ | ',';

estados: estado (',' estado)*;

estado: ID;

TipoAutomata: 'determinista' | 'no_determinista';

ID: [a-zA-Z][a-zA-Z0-9_]*;

DIGITO: [0-9];

WS: [ \t\r\n]+ -> skip;