algoritmo "eleição"
// Função :
// Autor :  Pedro Antonio de Oliveira Alves
// Data : 18/03/2026
// Seção de Declarações 
var
F1, F2, TL, P1, P2:real
inicio
escreva("digite a quantidade de votos da faixa 1: ")
leia(F1)
escreva("digite a quantidade de votos da faixa 2: ")
leia(F2)
TL<-F1+F2
P1<-(F1*100)/TL
P2<-(F2*100)/TL
escreval("o percentual de votos da faixa 1 é: ", P1)
escreva("o percentual de votos da faixa 2 é: ", P2)
fimalgoritmo
