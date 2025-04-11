using System;

public abstract class Karyawan
{

    private string Id;
    private string Nama;
    private double GajiPokok;

    public Karyawan(string id, string nama, double gajiPokok)
    {
        SetId(id);
        SetNama(nama);
        SetGajiPokok(gajiPokok);
    }

    public string GetId() { return Id; }
    public void SetId(string value) { Id = value; }

    public string GetNama() { return Nama; }
    public void SetNama(string value) { Nama = value; }

    public double GetGajiPokok() { return GajiPokok; }
    public void SetGajiPokok(double value) { GajiPokok = value; }

    public abstract double HitungGaji();

    public void TampilkanInfo()
    {
        Console.WriteLine();
        Console.WriteLine("- INFORMASI KARYAWAN -");
        Console.WriteLine();
        Console.WriteLine($"ID: {GetId()}");
        Console.WriteLine($"Nama: {GetNama()}");
        Console.WriteLine($"Gaji Pokok: {GetGajiPokok()}");
        Console.WriteLine($"Gaji Akhir: {HitungGaji()}");
    }

}

public class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string id, string nama, double gajiPokok)
    : base(id, nama, gajiPokok) { }

    public override double HitungGaji()
    {
        return GetGajiPokok() + 500000;
    }
}

public class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string id, string nama, double gajiPokok)
    : base(id, nama, gajiPokok) { }

    public override double HitungGaji()
    {
        return GetGajiPokok() - 200000;
    }
}

public class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string id, string nama, double gajiPokok)
    : base(id, nama, gajiPokok) { }

    public override double HitungGaji()
    {
        return GetGajiPokok();
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
                karyawan = new KaryawanTetap(id, nama, gajiPokok);
                break;
            case 2:
                karyawan = new KaryawanKontrak(id, nama, gajiPokok);
                break;
            case 3:
                karyawan = new KaryawanMagang(id, nama, gajiPokok);
                break;

        }

        karyawan.TampilkanInfo();
    }
}
