Console.WriteLine("*** Atribuição:");
int a = 10;
int b = 20;

int c = a + b;

//c = c + 5;
c += 5;

Console.WriteLine(c);

Console.WriteLine("*** Conversão de tipos (casting):");
// usando o Convert, se vier um valor nulo (null), converterá para zero
// e não dá erro
// então é melhor usar o Convert e não o Parse
int d = Convert.ToInt32("5");
int dd = Convert.ToInt32(null);
Console.WriteLine(d);
Console.WriteLine(dd);

// o exemplo acima também poderia ser feito assim:
// já o Parse, não aceita valor nulo (null), dá erro
int e = int.Parse("5");
Console.WriteLine(e);


