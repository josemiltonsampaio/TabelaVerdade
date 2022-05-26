Console.WriteLine("TABELA OU");

var situacao1 = true;
var situacao2 = false;

Console.WriteLine($"situação1 = verdadeiro\tOU\tsituação2 = falso\tResultado: {situacao1 | situacao2}");

situacao1 = false;
situacao2 = true;

Console.WriteLine($"situação1 = falso\tOU\tsituação2 = verdadeiro\tResultado: {situacao1 | situacao2}");

situacao1 = true;
situacao2 = true;

Console.WriteLine($"situação1 = verdadeiro\tOU\tsituação2 = verdadeiro\tResultado: {situacao1 | situacao2}");

situacao1 = false;
situacao2 = false;

Console.WriteLine($"situação1 = falso\tOU\tsituação2 = falso\tResultado: {situacao1 | situacao2}");

Console.WriteLine();

var clienteEspecial = false;
var cupomDesconto = true;

Console.WriteLine("EXEMPLO:");
Console.WriteLine("clienteEspecial = falso");
Console.WriteLine("cupomDesconto = verdadeiro");
Console.WriteLine();

if (clienteEspecial | cupomDesconto)
{
    Console.WriteLine("DAR DESCONTO!");
}
else
{
    Console.WriteLine("NÃO DAR DESCONTO!");
}

Console.WriteLine();
Console.WriteLine("**************************************************************************");
Console.WriteLine();

Console.WriteLine("TABELA OU EXCLUSIVO");

situacao1 = true;
situacao2 = false;

Console.WriteLine($"situação1 = verdadeiro\tXOR\tsituação2 = falso\tResultado: {situacao1 ^ situacao2}");

situacao1 = false;
situacao2 = true;

Console.WriteLine($"situação1 = falso\tXOR\tsituação2 = verdadeiro\tResultado: {situacao1 ^ situacao2}");

situacao1 = true;
situacao2 = true;

Console.WriteLine($"situação1 = verdadeiro\tXOR\tsituação2 = verdadeiro\tResultado: {situacao1 ^ situacao2}");

situacao1 = false;
situacao2 = false;

Console.WriteLine($"situação1 = falso\tXOR\tsituação2 = falso\tResultado: {situacao1 ^ situacao2}");


Console.WriteLine();

var optouPorFreteGratis = false;
cupomDesconto = true;

Console.WriteLine("EXEMPLO:");
Console.WriteLine("optouPorFreteGratis = falso");
Console.WriteLine("cupomDesconto = verdadeiro");
Console.WriteLine();

if (optouPorFreteGratis ^ cupomDesconto)
{
    Console.WriteLine("EMITIR NOTA FISCAL!");
}
else
{
    Console.WriteLine("VOCÊ DEVE SELECIONAR APENAS UMA OPÇÃO!");
}

Console.WriteLine();
Console.WriteLine("**************************************************************************");
Console.WriteLine();

Console.WriteLine("TABELA E");

situacao1 = true;
situacao2 = false;

Console.WriteLine($"situação1 = verdadeiro\tE\tsituação2 = falso\tResultado: {situacao1 & situacao2}");

situacao1 = false;
situacao2 = true;

Console.WriteLine($"situação1 = falso\tE\tsituação2 = verdadeiro\tResultado: {situacao1 & situacao2}");

situacao1 = true;
situacao2 = true;

Console.WriteLine($"situação1 = verdadeiro\tE\tsituação2 = verdadeiro\tResultado: {situacao1 & situacao2}");

situacao1 = false;
situacao2 = false;

Console.WriteLine($"situação1 = falso\tE\tsituação2 = falso\tResultado: {situacao1 & situacao2}");


Console.WriteLine();

clienteEspecial = false;
cupomDesconto = true;

Console.WriteLine("EXEMPLO:");
Console.WriteLine("clienteEspecial = falso");
Console.WriteLine("cupomDesconto = verdadeiro");
Console.WriteLine();

if (clienteEspecial & cupomDesconto)
{
    Console.WriteLine("DAR DESCONTO!");
}
else
{
    Console.WriteLine("NÃO DAR DESCONTO!");
}

Console.WriteLine();
Console.WriteLine("**************************************************************************");
Console.WriteLine();

Console.WriteLine("TABELA NÃO");

situacao1 = true;

Console.WriteLine($"situação = verdadeiro\tINVERTE\t\t\t\tResultado: {!situacao1}");

situacao1 = false;

Console.WriteLine($"situação = falso\tINVERTE\t\t\t\tResultado: {!situacao1}");


Console.WriteLine();

clienteEspecial = true;

Console.WriteLine("EXEMPLO:");
Console.WriteLine("clienteEspecial = verdadeiro");
Console.WriteLine();

if (!clienteEspecial)
{
    Console.WriteLine("DAR DESCONTO!");
}
else
{
    Console.WriteLine("NÃO DAR DESCONTO!");
}