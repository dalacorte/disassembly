namespace Disassembly
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ForLoopAsync();
        }

        static async Task ForLoopAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
    }
}
