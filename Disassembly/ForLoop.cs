using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disassembly
{
    public static class ForLoop
    {
        public static void Initialize(int length)
        {
            /*
                 2: using System.Collections.Generic;
                 3: using System.Linq;
                 4: using System.Text;
                 5: using System.Threading.Tasks;
                 6: 
                 7: namespace Disassembly
                 8: {
                 9:     public static class ForLoop
                10:     {
                11:         public static void Initialize(int length)
                12:         {
            00007FFAC50C78C0 55                   push        rbp  
            00007FFAC50C78C1 57                   push        rdi  
            00007FFAC50C78C2 56                   push        rsi  
            00007FFAC50C78C3 48 83 EC 30          sub         rsp,30h  
            00007FFAC50C78C7 48 8B EC             mov         rbp,rsp  
            00007FFAC50C78CA 33 C0                xor         eax,eax  
            00007FFAC50C78CC 89 45 2C             mov         dword ptr [rbp+2Ch],eax  
            00007FFAC50C78CF 89 45 28             mov         dword ptr [rbp+28h],eax  
            00007FFAC50C78D2 89 4D 50             mov         dword ptr [rbp+50h],ecx  
            00007FFAC50C78D5 83 3D 14 59 0C 00 00 cmp         dword ptr [7FFAC518D1F0h],0  
            00007FFAC50C78DC 74 05                je          Disassembly.ForLoop.Initialize(Int32)+023h (07FFAC50C78E3h)  
            00007FFAC50C78DE E8 2D FE C2 5F       call        00007FFB24CF7710  
            00007FFAC50C78E3 90                   nop  
            */
            for (int i = 0; i < length; i++)
                /*
                00007FFAC5208CC8 8B 45 2C             mov         eax,dword ptr [rbp+2Ch]  
                00007FFAC5208CCB FF C0                inc         eax  
                00007FFAC5208CCD 89 45 2C             mov         dword ptr [rbp+2Ch],eax  
                00007FFAC5208CD0 8B 4D 2C             mov         ecx,dword ptr [rbp+2Ch]  
                00007FFAC5208CD3 3B 4D 50             cmp         ecx,dword ptr [rbp+50h]  
                00007FFAC5208CD6 0F 9C C1             setl        cl  
                00007FFAC5208CD9 0F B6 C9             movzx       ecx,cl  
                00007FFAC5208CDC 89 4D 28             mov         dword ptr [rbp+28h],ecx  
                00007FFAC5208CDF 83 7D 28 00          cmp         dword ptr [rbp+28h],0  
                00007FFAC5208CE3 75 D7                jne         Disassembly.ForLoop.Initialize(Int32)+02Ch (07FFAC5208CBCh) 
                */
            {
                /* 
                00007FFAC50C78E4 33 C9                xor         ecx,ecx  
                00007FFAC50C78E6 89 4D 2C             mov         dword ptr [rbp+2Ch],ecx  
                00007FFAC50C78E9 90                   nop  
                00007FFAC50C78EA EB 14                jmp         Disassembly.ForLoop.Initialize(Int32)+040h (07FFAC50C7900h)  
                */
                Console.WriteLine(i);
                /*
                00007FFAC50C78ED 8B 4D 2C             mov         ecx,dword ptr [rbp+2Ch]  
                00007FFAC50C78F0 FF 15 72 1E 2D 00    call        qword ptr [CLRStub[MethodDescPrestub]@00007FFAC5399768 (07FFAC5399768h)]  
                00007FFAC50C78F6 90                   nop  
                */
            }
            /* 
            00007FFAC52078F7 90                   nop
            */
        }
    }
}
