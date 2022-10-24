using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        function instance= new function();

       Write("Ödevi Belirtin");
       switch (ConvertReadLine())
       {
        case 1:
        instance.odev1();
        break;
        case 2:
        instance.odev2();
        break;
        case 3:
         instance.odev3();
        break;
        case 4:
         instance.odev4();
        break;
        default:
        Write("Lütfen Geçerli Bir Ödev Sayısı Giriniz");
        break;
       }

    }
    class function 
    {
       public void odev1()
       {
        Write("Lütfen Pozitif Bir Sayı Giriniz.");
        int inputvalue = ConvertReadLine();
        Write("Lütfen "+ inputvalue+" Tane Pozitif Sayı Giriniz.");
        List<int> arrayvalue = new List<int>();
        for (int i = 0; i < inputvalue; i++)
        {
            arrayvalue.Add (ConvertReadLine());
            
        }
       Write(arrayvalue.Count/2);

       }
       public void odev2()
       {
         List<int> arrayvalue = new List<int>();
         List<int> gelensayi = new List<int>();

        Write("Lütfen iki Pozitif Sayı Giriniz.");
       
        for (int i = 0; i < 2; i++)
        {
            arrayvalue.Add (ConvertReadLine());
            
        }
        Write("lütfen "+ arrayvalue[0]+ " Tane Sayı Giriniz");
        for (int i = 0; i < arrayvalue[0]; i++)
        {
            int sayi = ConvertReadLine();
            gelensayi.Add(sayi);
           
        }
        foreach (var item in gelensayi)
        {
            if(arrayvalue[1]%item ==0)
           {
            Write(item);
           }
       
        }
       }
       public void odev3()
       {
        List<string> arraystring = new List<string>();
        Write("Lütfen Bir Pozitif Sayı Giriniz.");
        int reply = ConvertReadLine();
        Write("Lütfen "+reply+" Tane Kelime Girin.");
        for (int i = 0; i < reply; i++)
        {
            arraystring.Add(ReadLine());
      
        }
        arraystring.Reverse();
        foreach (var item in arraystring)
        {
            Write(item);
            
        }

       }
       public void odev4()
       {
        int space = 0;
        int Notspace = 0;
        Write("Bir Cümle Yazınız.");
        char[] arrayChar = ReadLine().ToCharArray();
        
        for (int i = 0; i < arrayChar.Length; i++)
        {
            if(arrayChar[i].ToString() == " ")
            {
                space++;
                Notspace++;


            }
        }
        Write("Toplam Harf Sayısı : "+(arrayChar.Length-Notspace));
        Write("Toplam Boşluk sayısı : " + (space+1) );
      

       }

    }
 
    public static void Write(string x)
    {
        Console.WriteLine(x);

    }
    public static void Write(int x)
    {
        Console.WriteLine(x);

    }
    public static string ReadLine()
    {
      return Console.ReadLine();
    } 
    public static int ConvertReadLine()
    {
      return Convert.ToInt32(Console.ReadLine());
    }         
}
   
