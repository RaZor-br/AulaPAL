algoritmo "peso e nome 2 pessoas"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações
var
P1, P2, PMP:real
N1, N2: caracter
inicio
escreva("digite o nome da primeira pessoa: ")
leia(N1)
escreva("digite o peso da primeira pessoa: ")
leia(P1)
escreva("digite o nome da segunda pessoa: ")
leia(N2)
escreva("digite o peso da segunda pessoa: ")
leia(P2)
se(P1>=P2)entao
               se(P1=P2)entao
                             escreva("o peso de ambos é igual")
               senao
                             escreva("o peso de ", N1, " é maior, com", P1, " quilos")
               fimse
senao
     escreva("o peso de ", N2, " é maior, com", P2, " quilos")
fimse
fimalgoritmo
