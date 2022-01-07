class PaymentProcess
{
    public void Pay(string id)
    {
        SQLServerProduct product = new SQLServerProduct();
        string productData = product.GetProductById(id);
        Console.WriteLine(productData);
    }
}