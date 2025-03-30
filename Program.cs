using System;

public abstract class Karyawan
{
    private string Nama;
    private string Id;
    private double GajiPokok;

    public Karyawan(string Nama, string Id, double GajiPokok)
    {
        this.Nama = Nama;
        this.Id = Id;
        this.GajiPokok = GajiPokok;
    }

    public string nama
    {
        get { return Nama; }
        set { Nama = value; }
    }

    public string id
    {
        get { return Id; }
        set { Id = value; }
    }

    public double gajiPokok
    {
        get { return GajiPokok; }
        set { GajiPokok = value; }
    }

    public abstract double HitungGaji();

    public void TampilkanInfo()
    {
        Console.WriteLine(".____________________.");
        Console.WriteLine("| INFORMASI KARYAWAN |");
        Console.WriteLine("|____________________|");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Gaji Akhir: {HitungGaji()}");
    }

}

public class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string nama, string id, double gajiPokok)
    : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return gajiPokok + 500000;
    }
}

public class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string nama, string id, double gajiPokok)
    : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return gajiPokok - 200000;
    }
}

public class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string nama, string id, double gajiPokok)
    : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return gajiPokok;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Sistem Manajemen Karyawan");
        Console.WriteLine();

        Console.WriteLine("- Pilih jenis karyawan -");
        Console.WriteLine("  1. Karyawan Tetap ");
        Console.WriteLine("  2. Karyawan Kontrak");
        Console.WriteLine("  3. Karyawan Magang");

        Console.WriteLine();

        Console.Write("Masukkan pilihan :  ");
        int pilihan = int.Parse(Console.ReadLine()); 

        if (pilihan < 1 || pilihan > 3)
        {
            Console.WriteLine("Pilihan tidak valid.");
            return;
        }

        Console.Write("Masukkan ID: ");
        string id = Console.ReadLine();

        Console.Write("Masukkan Nama: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan Gaji Pokok: ");
        double gajiPokok = double.Parse(Console.ReadLine());

        Karyawan karyawan = null;

        switch (pilihan)
        {
            case 1:
                karyawan = new KaryawanTetap(nama, id, gajiPokok);
                break;
            case 2:
                karyawan = new KaryawanKontrak(nama, id, gajiPokok);
                break;
            case 3:
                karyawan = new KaryawanMagang(nama, id, gajiPokok);
                break;

        }


        karyawan.TampilkanInfo();


    }
}
