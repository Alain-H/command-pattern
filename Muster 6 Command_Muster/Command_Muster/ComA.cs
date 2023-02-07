using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Muster
{
    public class ComA : Command
    {
       public ReceiverA receiverA;

        public ComA(ReceiverA receiver)
        {
            this.receiverA = receiver;
        }
        public void undo()
        {
            Console.WriteLine("\n UNDO ComA");
        }
        public void execute()
        {
            receiverA.action1();
            receiverA.action2();
        }
    }
}
