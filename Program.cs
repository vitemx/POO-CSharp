﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Apuntador apuntadorPlatzi = new Apuntador();
Apuntador apuntadorPlatzi2 = new Apuntador();

apuntadorPlatzi.Color = "Verde";

apuntadorPlatzi2.Color = "Azul";
class Apuntador
{
    public string? Color;
    public double Largo;
    public short NumeroDeBotones;
    public bool TieneStickers;
}

class SuperHeroe
{
    public string? Nombre;
    public string? ColorTraje;
    public bool UsaCapa;
    public string? UsaMascara;
    public List<string>? SuperPoderes;
}