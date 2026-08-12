algoritmo "semnome"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações 
var
M1, M2, M:real
inicio
// Seção de Comandos 
escreva("digite a primeira nota do aluno: ")
leia(M1)
escreva("digite a segunda nota do aluno: ")
leia(M2)
M<- (M1 + M2)/2
se(M >= 7.00)entao
       escreva("o aluno esta aprovado, com", M, " pontos na materia")
senao
     se( (M >=5) e (M <=6.9) )entao
         escreva("o aluno esta de recuperação, com", M, " pontos")
     senao
       escreva("o aluno esta reprovado, com", M, " pontos na materia")
       fimse
fimse

fimalgoritmo
