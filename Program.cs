Console.Clear();

double valor, rendaMensal, porcentagem;
int quantParcelas;

Console.Write("Digite o valor do empréstimo solicitado: ");
valor = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de parcelas: ");
quantParcelas = Convert.ToInt16(Console.ReadLine());

Console.Write("Digite a renda mensal comprovada: ");
rendaMensal = Convert.ToDouble(Console.ReadLine());

porcentagem = rendaMensal * 0.3;

if (valor > porcentagem) {
    Console.WriteLine("O empréstimo não foi aceito");
}
else{
    Console.WriteLine("Empréstimo aceito");
}