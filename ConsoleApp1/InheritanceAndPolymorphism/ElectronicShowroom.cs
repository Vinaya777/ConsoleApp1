    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InheritanceAndPolymorphism
{
	class ElectronicsEquipments
	{
		static int gst=12;
		protected double price;
		protected String name;

	
	
	public ElectronicsEquipments(double price, String name)
	{
		this.price = price;
		this.name = name;
	}

	
	protected virtual void SaleEquipment()
	{
		double gstAmount = (price * ElectronicsEquipments.gst) / 100;
		double netAmount = price + gstAmount;
		Console.WriteLine("Name of equipment is " + name + " and its price is of Rs " + netAmount);
	}
        public override string ToString()
        {
			return $"Price Of Electronic Equiments{name}, Price{price}";
        }
    }


	class Television : ElectronicsEquipments
{
		double p;
		string n;
	public Television(double p, String n): base(8,"pqr")
	{
			

			this.p = p;
			this.n = n;
		
	}

	public new void SaleEquipment()
	{
		SaleEquipment();
        Console.WriteLine("Requires Equipment");
	}
}

	class Refrigerator : ElectronicsEquipments
{
		double p;
		string n;
	public Refrigerator(double p, String n):base(7,"xyz")
	{
		
	}
	public new void SaleEquipment()
	{
		SaleEquipment();
	}
}

class WashingMachine: ElectronicsEquipments
{
	public WashingMachine(double price, String name):base(5,"abc")
	{
			this.price = price;
			this.name = name;

	}
	protected new void SaleEquipment()
	{
		SaleEquipment();
	}
}
public class ElectronicShowroom
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter price of equipment: ");
			int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of elcetronic gadget: ");
			string name = "Oven";
            Console.WriteLine("Name is: "+name);
			ElectronicsEquipments ee = new ElectronicsEquipments(5000000, "Oven");
		
            Console.WriteLine(ee);
		
        }
    }
}
