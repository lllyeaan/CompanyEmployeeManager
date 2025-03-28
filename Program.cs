using System;

public abstract class Karyawan
{
    private string Nama;
    private string Id;
    private double Gajipokok;

    public Karyawan(string Nama, string Id, double GajiPokok)
    {
        this.Nama = Nama;
        this.Id = Id;
        this.Gajipokok = GajiPokok;
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

    public double gajipokok
    {
        get { return Gajipokok; }
        set { Gajipokok = value; }
    }

    public abstract double HitungGaji();
}

public class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string nama, string id, double gajiPokok)
    : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return gajipokok + 500000;
    }
}

public class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string nama, string id, double gajiPokok)
    : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return gajipokok - 200000;
    }
}

public class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string nama, string id, double gajiPokok)
    : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return gajipokok;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Pilih jenis karyawan: \n(1) Tetap \n(2) Kontrak \n(3) Magang");
        int pilihan = int.Parse(Console.ReadLine());

        Console.Write("Masukkan Nama: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan ID: ");
        string id = Console.ReadLine();

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
            default:
                Console.WriteLine("Pilihan tidak valid.");
                return;
        }

        if (karyawan != null)
        {
            Console.WriteLine($"Total Gaji {karyawan.nama} ({karyawan.id}): {karyawan.HitungGaji()}");
        }
    }
}
