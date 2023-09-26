class TugasInheritance
{
    public static void Main(string[] args)
    {
        Vivobook laptop1 = new Vivobook();
        Console.WriteLine("\n");
        laptop1.ngoding();
        Console.WriteLine("\n");
        Console.WriteLine(laptop1.processor);
        Console.WriteLine(laptop1.vga);
        Console.WriteLine(laptop1.tipe);
        Console.WriteLine("\n");

        laptop laptop2 = new IdeaPad();
        laptop2 .LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        Console.WriteLine("\n");

        Predator predator = new Predator();
        predator.bermaingame();

        //Acer acer = new Predator();
        //acer.bermaingame();
        //error karena acer tidak memiliki kelas dan atribut
    }
}
class laptop
{
    public string merk;
    public string tipe;
    public string vga;
    public string processor;
    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop " + merk + tipe + " Menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop " + merk + tipe + " Mati");
    }
}

class Asus : laptop
{
    public Asus()
    {
        merk = "Asus";
    }
}

class ROG : Asus
{
    public ROG()
    {
        tipe = "ROG";
    }
}

class Vivobook : Asus
{
    public Vivobook()
    {
        tipe = "Vivobook";
        processor = "Core i5";
        merk = "Intel";
        vga = "Nvidia";
    }
    public void ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class Acer : laptop
{
    public Acer()
    {
        merk = "Acer";
    }
}

class Swift : Acer
{
    public Swift()
    {
        tipe = "Swift";
    }
}

class Predator : Acer
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void bermaingame()
    {
        Console.WriteLine("Laptop " + merk + tipe + " sedang memainkan game");
    }

}

class Lenovo : laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
    public void VtecKickedin()
    {
        Console.WriteLine("Ngeeeng Wooosh!!");
    }
}

class VGA
{
    public string merk;
}

class Nvidia : VGA
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

class AMD : VGA
{
    public AMD()
    {
        merk = "AMD";
    }
}
