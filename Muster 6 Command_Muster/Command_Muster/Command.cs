using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Muster
{
    //Befehlsinterface
    public interface Command
    {
          public void execute();
        public void undo();
    }
}
