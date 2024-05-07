using Calculadora;

Operacoes op = new Operacoes();

Operacoes.Soma delegSoma = new Operacoes.Soma(op.Somar);

Operacoes.Subtracao delegSubtrair = new Operacoes.Subtracao(op.Subtrair);

Operacoes.Divisao delegDivisao = new Operacoes.Divisao(op.Dividir);

Operacoes.Multiplicacao delegMultiplicacao = new Operacoes.Multiplicacao(op.Multiplicar);


delegSoma(5, 10);
delegSubtrair(10, 4);
delegDivisao(10, 2);
delegMultiplicacao(10, 5);



