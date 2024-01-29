namespace Collections
{

    internal class Supplier
    {
        //delegate void Writter(string text);

        

        internal void Talk(Action<string> writter = null)
        {
            Console.WriteLine("--- start from Supplier ---");
            
            writter?.Invoke("teste supplier");
            
            Console.WriteLine("--- end from Supplier ---");
        }
    }
}
