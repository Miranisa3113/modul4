using System;
using System.Collections.Generic;

class KodeBuah
{
    private Dictionary<string, string> kodeBuah = new Dictionary<string, string>()
    {
        {"Apel","A00"},
        {"Aprikot","B00"},
        {"Alpukat","C00"},
        {"Pisang","D00"},
        {"Paprika","E00"},
        {"Blackberry","F00"},
        {"Ceri","H00"},
        {"Kelapa","I00"},
        {"Jagung","J00"},
        {"Kurma","K00"},
        {"Durian","L00"},
        {"Anggur","M00"},
        {"Melon","N00"},
        {"Semangka","O00"}
    };

    public string getKodeBuah(string namaBuah)
    {
        return kodeBuah[namaBuah];
    }

    public Dictionary<string, string> getAllKodeBuah()
    {
        return kodeBuah;
    }
}


class PosisiKarakterGame
{
    enum State
    {
        Berdiri,
        Tengkurap
    }

    private State currentState;

    public PosisiKarakterGame()
    {
        currentState = State.Berdiri;
        Console.WriteLine("posisi standby");
    }

    public void TombolS()
    {
        if (currentState == State.Berdiri)
        {
            currentState = State.Tengkurap;
            Console.WriteLine("posisi istirahat");
        }
    }

    public void TombolW()
    {
        if (currentState == State.Tengkurap)
        {
            currentState = State.Berdiri;
            Console.WriteLine("posisi standby");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodeBuah buah = new KodeBuah();

        foreach (var item in buah.getAllKodeBuah())
        {
            Console.WriteLine("Kode Buah " + item.Key + " : " + item.Value);
        }

        PosisiKarakterGame karakter = new PosisiKarakterGame();

        karakter.TombolS();
        karakter.TombolW();

        Console.ReadLine();
    }
}
