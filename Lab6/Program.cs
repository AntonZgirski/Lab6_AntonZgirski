using System;
using System.Collections.Generic;

namespace Lab6
{
  class Program
  {
    static void Main(string[] args)
    {

      ShowRoom room = new ShowRoom();
      Action<string> print = s => Console.WriteLine(s);

      room.AddAuto("Model1", "Brend1");
      room.AddAuto("Model2", "Brend2");
      room.AddAuto("Model3", "Brend3");
      room.AddAuto("Model4", "Brend4");

      room.ShowInfAllAuto(print);
      room.SaleAllAuto += room.Notify;

      room.SaleAuto();

      room.Raise(x => Console.WriteLine(x));

      Hospital hos = new Hospital();
      hos.AddPatient("Anton", 26);
      hos.AddPatient("Alex", 26);
      hos.AddPatient("Maks", 27);
      hos.AddPatient("Julia", 22);
      hos.AddPatient("Anna", 23);
      hos.AddPatient("Jeck", 23);
      hos.AddPatient("Barak", 26);
      hos.AddPatient("Oleg", 26);
      hos.AddPatient("Volga", 26);
      hos.AddPatient("Inna", 26);
      hos.AddPatient("Jeremy", 36);
      hos.AddPatient("Jaime", 46);
      hos.AddPatient("Daenerys", 46);
      hos.AddPatient("Jon", 53);
      hos.AddPatient("Robb", 40);
      hos.AddPatient("Sansa", 28);

      hos.OverflowPlace += hos.ShowInfAllPatient;
      hos.OverflowPlace += hos.Notify;

      hos.Raise(x => Console.WriteLine(x));
    }
  }
}
