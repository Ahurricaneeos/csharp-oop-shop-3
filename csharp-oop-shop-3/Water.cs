using csharp_oop_shop_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3
{
    public class Water : Product
{
    private double liters;
    private int ph;
    private string spring;

    public Water(string name, string description, double price, int iva, double liters, int ph, string spring) : base(name, description, price, iva)
    {
        SetLiters(liters);
        SetPh(ph);
        this.spring = spring;
    }

    public double GetLiters() { return liters; }
    public int GetPh() { return ph; }
    public string GetSpring() { return spring; }

    public void SetLiters(double liters)
    {
      if (liters > 1.5 || liters <= 0)
      {
        throw new Exception("I litri devono essere compresi tra 0 e 1.5");
      }
      else
      {
        this.liters = liters;
      }
    }

        public void SetPh(int ph)
    {
        if (ph < 0 || ph > 10)
        {
          throw new Exception("Il ph deve essere compreso tra 0 e 10");
        }
        else
        {
          this.ph = ph;
        }
    } 

        public void SetSpring(string spring)
        {
            this.spring = spring;
        }

        // Metodi
        public void DrinkWater(double drunkWater)
        {
            if (this.liters - drunkWater < 0)
            {
                throw new Exception("Non puoi bere più acqua di quanta ce n'è");
            }
            else
            {
                this.liters = this.liters - drunkWater;
                Console.WriteLine("L'acqua rimanente nella bottiglia è " +  this.liters);
            }
        }

        public void RefillWater(double insertedWater)
        {
            if (this.liters + insertedWater > 1.5)
            {
                throw new Exception("hai superato la capienza massima dell'acqua riempendo");
            }
            else
            {
                this.liters = this.liters + insertedWater;
            }
        }
        public void EmptyBottle()
        {
            this.liters = 0;
        }


        public override string ToString()
    {
        string rappStr = base.GetProductString();
        rappStr += "Litri: " + this.liters + "\n";
        rappStr += "Ph: " + this.ph + "\n";
        rappStr += "La sorgente è: " + this.spring;

        return rappStr;
    }
}
}

