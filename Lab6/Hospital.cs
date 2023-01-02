using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
  public class Patient
  {
    public string firstName;    
    public int age;

    public Patient(string fname, int age)
    {
      this.firstName = fname;
      this.age = age;
    }

    public string ShowInfoPatient()
    {
      return $"First name {firstName}. Age {age}";
    }
  }

  public class Hospital : INotifyable
  {
    public event Action<Action<string>> OverflowPlace;
    public List<Patient> listOfPatient = new List<Patient>();

    public void Notify(Action<string> output)
    {
      output("The hospital is overwhelmed.");
    }

    public void Raise(Action<string> output)
    {
      if (listOfPatient.Count > 15) OverflowPlace.Invoke(output);
    }

    public void AddPatient(string fname, int age)
    {
      listOfPatient.Add(new Patient(fname, age));
    }

    public void ShowInfAllPatient(Action<string> output)
    {
      foreach (var p in listOfPatient)
      {
        output(p.ShowInfoPatient());
      }
    }
  }
}
