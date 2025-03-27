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
