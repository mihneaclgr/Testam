using System.IO;

void AdaugareRuta()
{
    string plecare, destinatie;
    int nrKm;
    
    plecare = Console.ReadLine();
    destinatie = Console.ReadLine();
    nrKm = int.Parse(Console.ReadLine());
    
    File.AppendAllText("Rute.txt",plecare+"-"+destinatie+", "+nrKm+'\n');
}

AdaugareRuta();