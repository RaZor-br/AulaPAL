algoritmo "estoque mercado"
// Função :
// Autor :    Pedro Antonio
// Data : 18/03/2026
// Seção de Declarações 
var
   QC, PU, T:real
   NM:caracter
inicio
escreva("digite o nome do produto: ")
leia(NM)
escreva("preço unitario: ")
leia(PU)
escreva("produtos comprados: ")
leia(QC)
T<-QC*PU
escreva("o produto ", NM, "custa ", T, "Reais(R$)")
fimalgoritmo
