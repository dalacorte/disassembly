namespace Disassembly
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 1: namespace Disassembly
                 2: {
                 3:     class Program
                 4:     {
                 5:         static void Main(string[] args)
                 6:         {
            00007FFAC50C76B0 55                   push rbp
            00007FFAC50C76B1 57                   push rdi
            00007FFAC50C76B2 56                   push rsi
            00007FFAC50C76B3 48 83 EC 20          sub rsp,20h  
            00007FFAC50C76B7 48 8B EC             mov rbp, rsp
            00007FFAC50C76BA 48 89 4D 40          mov qword ptr[rbp + 40h],rcx  
            00007FFAC50C76BE 83 3D 2B 5B 0C 00 00 cmp dword ptr[7FFAC518D1F0h],0  
            00007FFAC50C76C5 74 05                je Disassembly.Program.Main(System.String[])+01Ch(07FFAC50C76CCh)
            00007FFAC50C76C7 E8 44 00 C3 5F       call        00007FFB24CF7710  
            00007FFAC50C76CC 90                   nop
            */
            ForLoop.Initialize(10);
        }
    }
}
