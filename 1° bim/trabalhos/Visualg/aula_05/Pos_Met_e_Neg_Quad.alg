algoritmo "se positivo, metade, se negativo, ao quadrado"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações
var
N1, NF:real
inicio
// Seção de Comandos
escreva("digite um numero: ")
leia(N1)
se(N1>=0)entao
              NF<-N1/2
senao
     NF<-(N1*N1)*N1
fimse
escreva("o resultado da equação é:", NF)


fimalgoritmo
