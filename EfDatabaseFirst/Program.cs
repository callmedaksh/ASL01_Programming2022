using EfDatabaseFirst;

using (var context = new AdventureWorksContext())
{
	foreach (var product in context.Products)
	{
		Console.WriteLine(product.Name);
	}
}