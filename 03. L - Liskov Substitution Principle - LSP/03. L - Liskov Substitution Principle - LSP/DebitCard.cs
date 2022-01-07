class DebitCard : NubankCard
{
    public override void Validate()
    {
        Console.WriteLine("Verificando o sado da conta...");
        Console.WriteLine("Saldo OK!");
    }
}