algoritmo "azulejo e parede"
// Função :
// Autor :
// Data : 01/04/2026
// Seção de Declarações
var
AP, LP, AA, LA : Real
ArP, ArA, QtA : Real
inicio
escreva("altura da parede: ")
leia(AP)
escreva("largura da parede: ")
leia(LP)
escreva("altura do azulejo: ")
leia(AA)
escreva("largura do azulejo: ")
leia(LA)
ArP <- AP * LP
ArA <- AA * LA
QtA <- ArP / ArA
escreval("area parede: ", ArP)
escreval("area azulejo: ", ArA)
escreva("quantidade azulejo: ", QtA)
fimalgoritmo
