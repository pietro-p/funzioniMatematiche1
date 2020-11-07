using System;
using System.ComponentModel;
using System.IO;

public class matematica
{
    public static int sommaInt(int a, int b)
    {

        return a + b;
    }
    public static double sommaDouble(double a, double b)
    {

        return a + b;
    }
    public static double differenza(double a, double b)
    {

        return a - b;

    }
    public static double moltipcicazione(double a, double b)
    {
        return a * b;

    }
    public static double divisione(double a, double b)
    {
        return a / b;

    }
    public static long potenza(int a, int b)
    {
        long p = 1;
        int cont = 0;
        for (; cont < b; cont++)
        {
            p = p * a;
        }
        return p;
    }
    public static long CalcoloFattoriale(int a)
    {
        long f = 1;
        int cont = 1;
        for (; cont <= a; cont++)
        {
            f = f * cont;
        }
        return f;
    }
    public static int MinoreTra(int a, int b, int c)
    {
        int min;
        if (a < b && a < c)
        {
            min = a;
        }
        else if (b < a && b < c)
        {
            min = b;
        }
        else
        {
            min = c;
        }
    }
    public static int MaggioreTra(int a, int b, int c)
    {
        int max;
        if (a > b && a > c)
        {
            max = a;
        }
        else if (b > a && b > c)
        {
            max = b;
        }
        else
        {
            max = c;
        }
    }
    public static double inverso(int a)
    {
        return a = a * -1;
    }
    public static bool IsPari(int a)
    {
        bool IsPari;
        if (a % 2 == 0)
        {
            IsPari = true;
        }
        else
        {
            IsPari = false;
        }
        return IsPari;
    }

    public static bool IsDispari(int a)
    {
        bool IsDispari;
        if (a % 2 == 0)
        {
            IsDispari = false;
        }
        else
        {
            IsDispari = true;
        }
        return IsDispari;
    }
    public static bool IsPositivo(int a)
    {
        bool IsPositivo;
        if (a > 0)
        {
            IsPositivo = true;
        }
        else
        {
            IsPositivo = false;
        }
        return IsPositivo;
    }
    public static bool IsNegativo(int a)
    {
        bool IsNegativo;
        if (a < 0)
        {
            IsNegativo = true;
        }
        else
        {
            IsNegativo = false;
        }
        return IsNegativo;
    }
    public static bool IsIntero(double a)
    {
        bool IsIntero;
        if (a =)
        {
            IsIntero = true;
        }
        else
        {
            IsIntero = false;
        }
        return IsIntero;
    }
}
