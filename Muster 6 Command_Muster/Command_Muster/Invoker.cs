using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Muster
{
//dieser Invoker ist mit einer Reihe von Befehlen geladen
//je nach Methodenaufruf wird eins davon augelöst
  public class Invoker
    {
        public Command[] commands = new Command[5];
        //Letzten Befehl merken
        public Command lastCommand;

        public void undo()
        {
            if (lastCommand != null)
            {
                lastCommand.undo();
                lastCommand = null;
            }
        }

        public void executeCommand(int index)
        {
            commands[index].execute();
            lastCommand = commands[index];
        }

        //Methode, um Commands zu setzen....
        private Command com1; //default möglich
        private Command com2; //default möglich

        //Eine Variante: Methode, die für Auführung des Befehls sorgt.
        //kann z. B. durch ein Event ausgelöst werden
        public void doCom1()
        {
            ReceiverA r1 = new ReceiverA();
            com1 = new ComA(r1);
            com1.execute();
        }
        public void doCom2()
        {
            ReceiverB r2 = new ReceiverB();
            com2 = new ComB(r2);
            com2.execute();
        }

        //Methode, mit der der Invoker konfiguriert werden kann
        //bzw. mit der die Commands geladen werden
        public void setCom1(Command command1)
        {
            this.com1 = command1;
        }

        public void setCom2(Command command2)
        {
            this.com2 = command2;
        }
    }
}
