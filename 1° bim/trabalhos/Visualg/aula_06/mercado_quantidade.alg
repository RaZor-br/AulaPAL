algoritmo "mercado"
// Função :
// Autor :    Pedro Antonio
// Data : 18/03/2026
// Seção de Declarações 
var
NM: caracter
QAC, QM, QE: real
inicio

escreva("nome do produto: ")
leia(NM)
escreva("quantidade maxima do produto: ")
leia(QM)
escreva("quantidade do produto em estoque: ")
leia(QE)
QAC<-QM - QE
escreva("voce precisa comprar", QAC, " do produto ", NM)

fimalgoritmo
