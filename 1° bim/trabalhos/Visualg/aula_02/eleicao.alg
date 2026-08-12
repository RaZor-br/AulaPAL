algoritmo "eleição"
// Função :
// Autor :
// Data : 11/03/2026
// Seção de Declarações 
var
VB, VN, VV, TE, PB, PN, PV, P:real
inicio
escreva("digite a quantidade de votos brancos: ")
leia(VB)
escreva("digite a quantidade de votos nulos: ")
leia(VN)
escreva("digite a quantidade de votos válidos: ")
leia(VV)
escreva("digite a quantidade de pessoas: ")
leia(P)
PB<-(VB*100)/P
PN<-(VN*100)/P
PV<-(VV*100)/P
escreval("O percentual de votos validos é: ", PV)
escreval("O percentual de votos nulos é: ", PN)
escreva("O percentual de votos brancos é: ", PB)
fimalgoritmo
