using SOLID.L.Certo;
using SOLID.S.Certo;

/* "S" Principio da responsabilidade única
 O objetivo deste principio é reduzir a complexidade

 Nesse exemplo separamos a responsabilidade de gerar relatório do empregado */

Empregado empregado = new Empregado("João");
empregado.ExibirNome();
empregado.GerarRelatorio(empregado);


/* "O" Principio aberto/fechado
   Aberta para extensão e fechada para modificação 
   O objetivo deste principio é prevenir que o código existente quebre quando você implementa novas funcionalidades */

/* "L" Principio da substituição de Liskov 
   você deve ser capaz de passar objetos da subclasse em lugar de objetos da classe mãe sem quebrar o código         
 */

Conta conta = new Conta(1);
conta.Saque();
Conta conta2 = new ContaPoupanca(1);
conta2.Saque();

/* "I" Principio da segregação de interface 
    Clientes não devem ser forçados a depender de métodos que não usam
 */

/* "D" Principio da inversão de dependência
    Classes de alto nível não deveriam depender de classes de baixo nível. Ambas devem depender de abstrações. As abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.
 */

//AddSingleton = unico para toda aplicação, AddScoped = Até o fim da requisão, AddTransient = ele crie uma instancia sempre foi chamado