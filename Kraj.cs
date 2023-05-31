using System;
using System.Threading;

public class Kraj
{
    public string nazwa;
    public int ekonomia;
    public int wojsko;
    public int ludnosc;
    public int ekologia;
    public int satysfakcja;

    public Kraj(string nazwa, int ekonomia = 50, int wojsko = 50, int ludnosc = 50, int ekologia = 50, int satysfakcja = 50)
    {
        this.nazwa = nazwa;
        this.ekonomia = ekonomia;
        this.wojsko = wojsko;
        this.ludnosc = ludnosc;
        this.ekologia = ekologia;
        this.satysfakcja = satysfakcja;
    }

    public void Checker()
    {


    }



    public override string ToString()
    {
        return $"Ekonomia: {ekonomia}\nWojsko: {wojsko}\nLudnosc: {ludnosc}\nEkologia: {ekologia}\nSatysfakcja: {satysfakcja}";
    }
}
