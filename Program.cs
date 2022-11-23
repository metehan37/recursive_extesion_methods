namespace recursive_extesion_methods;
class Program
{
    static void Main(string[] args)
    {
        //rekursif - Öz yinelemeli
        int result =1;
        for (int i=1;i<5;i++){
            result =result *3;
        }
        Console.WriteLine(result);

        Islemler instance=new Islemler();
        Console.WriteLine(instance.Expo(3,4));

        //Extension Metotlar
        string ifade ="Metehan Metinoğlu";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if(sonuc)
        Console.WriteLine(ifade.RemoveWhiteSpaces());
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi ={2,3,6,1,8,5,3};
        dizi.SortArray();
        dizi.Yazdir();
        int sayi=5;
        Console.WriteLine(sayi.IsEvenNumber());
        Console.WriteLine(ifade.GetFirtCharacter());
    }

  
}
public class Islemler
{
    public int Expo(int sayi,int üs)
    {
        if(üs<2)return sayi;
        return Expo(sayi, üs-1)* sayi;
    }
}
public static class Extension
{
    public static bool CheckSpaces(this string value)
    {
        return value.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string value)
    {
        string[] dizi= value.Split(" ");
        return string.Join("*",dizi);
    }
    public static string MakeUpperCase(this string value)
    {
        return value.ToUpper();
    }
       public static string MakeLowerCase(this string value)
    {
        return value.ToLower();
    }
    public static int[] SortArray(this int[] values)
    {
        Array.Sort(values);
        return values;
    }
    public static void Yazdir(this int[] values)
    {
        foreach (var item in values)
        Console.WriteLine(item);
    }
    public static bool IsEvenNumber(this int number)
    {
        return number%2==0;
    }
    public static string GetFirtCharacter(this string value)
    {
        return value.Substring(0,1);
    }
}