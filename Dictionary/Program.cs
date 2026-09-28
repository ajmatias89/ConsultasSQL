namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> datosInventario = new Dictionary<string, object>
            {
                {"Nombre", "Laptop HP Envy"},
                {"Precio", 850.99m},
                {"Cantidad", 15}
            };

            var setParts = new List<string>();
            foreach (var key in datosInventario.Keys)
            {
                setParts.Add($"{key} = @{key}");
            }

            string setClause = string.Join(", ", setParts);

            Console.WriteLine($"Cláusula SET generada: {setClause}");
        }
    }
}
