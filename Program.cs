// See https://aka.ms/new-console-template for more information

using System.Xml.XPath;

class Program
{
	static void Main()
	{
		Console.WriteLine("Hello, World!");
		
		Cat robert = new Cat();
		robert.color = "Yellow";
		
		Cat kiko = new Cat();
		kiko.color = "Black";
		
		// Get Value
		Console.WriteLine($"Robert color: {robert.color}");
		Console.WriteLine($"Kiko color: {kiko.color}");
		
	}	
}

 class Cat
 {
 	// Fields
	public string color = "";
	public int age;
	public bool isMale;
	public float weight;
	
	// Methods
	public void Eat()
	{
		Console.WriteLine("Nyam-nyam");
	}
	
	public void Sleep()
	{
		Console.WriteLine("purr...");
	}
	
	public void Meow()
	{
		Console.WriteLine("meow..");
	}
 }