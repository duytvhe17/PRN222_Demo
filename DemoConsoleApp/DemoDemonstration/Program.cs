﻿using System;
using System.Net;

class Program
{
    //Using Event-Based Asynchronous Pattern (EAP)
    private static void DownloadAsynchronously()
    {
        WebClient client = new WebClient();
        client.DownloadStringCompleted +=
            new DownloadStringCompletedEventHandler(DownloadComplete);
        client.DownloadStringAsync(new Uri("http://www.aspnet.com"));
    }

    //--------------------------------------------------------
    private static void DownloadComplete(object sender, DownloadStringCompletedEventArgs e)
    {
        if (e.Error != null)
        {
            Console.WriteLine("Some error has occurred.");
            return;
        }

        //Print result
        Console.WriteLine(e.Result);
        Console.WriteLine(new string('*', 30));
        Console.WriteLine("Download completed.");
    }

    //--------------- Main Method ------------------------
    static void Main(string[] args)
    {
        DownloadAsynchronously();
        Console.WriteLine("Main thread : Done");
        Console.WriteLine(new string('*', 30));
        Console.ReadLine();
    } //end Main
} //end Program
