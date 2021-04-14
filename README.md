# Martian-Robot
A robot that moves and rotates based on a string input (WIP)


# 1 - Sobre o sistema
A área escolhida para análise é curiosamente retangular e os robôs devem andarpor ela com suas câmeras ligadas coletando todo tipo de informação. A posiçãode um robô é representada por uma combinação de coordenadas X e Y e também umaletra representando a direção que ele está olhando. A área é dividida em umgrid para simplificar a navegação. Um exemplo de posição poderia ser: 0,0,N,significando o robô está na parte inferior esquerda com a face para o norte.Use as orientações: N =norte, S = sul, L = leste, O = oeste. Para controlar o robô, a AEB envia simples strings com oscomandos. Letras possíveis são: E, D e M. As letras E e D fazem o robô virar 90graus para esquerda e direita respectivamente, sem sair do lugar. A letra Msignifica se mover uma posição no grid para frente, mantendo a mesmadireção. Assuma que mover o robô para frente, significa mover sua posiçãode (X, Y) para (X, Y+1). Por exemplo, um robô na posição (0,0) com a face parao norte, ao se mover uma posição, vai parar em (0,1).

# 2 - Entrada
O programa deve possuir os seguintes parâmetros: – A primeiralinha deve ser as coordenadas do canto superior direito da área. O cantoinferior esquerdo é sempre (0,0).– O resto dasentradas deve ser os comandos que o robô deve executar. Cada comando deve serenviado em 2 partes: a primeira parte é a posição inicial do robô e a segundauma série de instruções que aquele robô deve seguir para explorar a área. A posição é dada com 2 inteiros e uma letra, separados porespaços, correspondendo pelas coordenadas X e Y e a orientação do robô. Cadarobô vai executar as instruções de forma sequencial: o segundo robô só iniciarásuas ações quando o primeiro terminar.

# 3 - Saída

Para cada robô, a posição final e sua orientação depois de executada as instruções. 

# 4 - Exemplos

Input:  

5 5 

1 2 N 

EMEMEMEMM 

3 3 L 

MMDMMDMDDM

Output esperado:

1 3 N 

5 1 L
