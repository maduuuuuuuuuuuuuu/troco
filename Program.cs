Double valordacompra;
Double valorpago;
Double troco;
Console.WriteLine("digite o valor da sua compra");
valordacompra = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o valor pago");
valorpago = Convert.ToDouble(Console.ReadLine());
troco = valorpago - valordacompra;
Console.WriteLine($"o seu troco é de R${ troco } ");


