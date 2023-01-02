using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab6
{
  public class Auto
  {
    public string model;
    public string brend;
    
    public Auto(string model, string brend)
    {
      this.brend = brend;
      this.model = model;
    }

    public string PrintAuto()
    {
      return $"{brend} - {model}";
    }
  }

  public class ShowRoom : INotifyable
  {
    public event Action<Action<string>> SaleAllAuto;
    public List<Auto> listOfAuto = new List<Auto>();

    public void Notify(Action<string> output)
    {
      output("Sold all the car in the showroom.");
    }
    
    public void Raise(Action<string> output)
    {
      if (listOfAuto.Count == 0) SaleAllAuto.Invoke(output);
    }

    public void AddAuto(string model, string brend)
    {
      listOfAuto.Add(new Auto(model, brend));
    }

    public void SaleAuto()
    {
      listOfAuto.Clear();
    }

    public void ShowInfAllAuto(Action<string> output)
    {
      foreach(var car in listOfAuto)
      {
        output($"Sale auto : {car.PrintAuto()}");        
      }
    }
  }
}
