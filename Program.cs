using exerciciopolimorfismo;


PagamentoPIX compraPIX = new PagamentoPIX();
compraPIX.ValorCompra = 15000;

float valorPagar = compraPIX.CalcularTotal();
Console.WriteLine($"Produto: Iphone");
Console.WriteLine($"Preço: {compraPIX.ValorCompra}");
Console.WriteLine($"Pagamento com Desconto: {valorPagar}");

PagamentoCartao compraCartao = new PagamentoCartao();
compraPIX.ValorCompra = 75;

float valorP Xagar = compraCartao.CalcularTotal();
Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preço: {compraCartao.ValorCompra}");
Console.WriteLine($"Pagamento com Desconto: {compraCartao.CalcularTotal()}");



