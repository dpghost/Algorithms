using System;
using System.Threading;
public  class App {
    private static string MakePassword(int pl)
    {
        string possibles = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
        char[] passwords = new char[pl];
        Random rd = new Random();

        for (int i = 0; i < pl; i++)
        {
            passwords[i] = possibles[rd.Next(0, possibles.Length)];
        }
        return new string(passwords);
    }

    public static void Main()
    {
        Console.WriteLine("Slow Test for Random Password Generation");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Password {0}={1}",i, MakePassword(10));
            Thread.Sleep(2000);
        }
        Console.WriteLine("Press the Enter Key to finish...");
        Console.ReadLine();
    }
}
