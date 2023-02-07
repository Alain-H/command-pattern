using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Muster
{
    class ComB :Command
    {
        private ReceiverB receiverB;

        public ComB(ReceiverB receiver)
        {
            this.receiverB = receiver;
        }
        public void undo()
        {
            Console.WriteLine("\n UNDO ComB");
        }
        public void execute()
        {
            receiverB.action1();
            
        }
    }
}
