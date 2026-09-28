namespace Dictionary3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> misCabeceras = new Dictionary<string, object>();
            misCabeceras.Add("ID", 1);
            misCabeceras.Add("Usuario", "Irina");
            misCabeceras.Add("Rol", "Administrador");

            foreach (var item in misCabeceras.Keys)
            {
                Console.WriteLine(item);
            }
        }
    }
}