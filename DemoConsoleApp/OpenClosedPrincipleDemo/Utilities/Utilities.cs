﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

internal class Utilities
{
    static string ReadFile(string filename)
    {
        return File.ReadAllText(filename);
    }

    // -------------------------------------------------------------
    internal static List<Book> ReadData()
    {
        var cadJSON = ReadFile("\"E:\\FPT\\Semester8\\PRN222\\DemoPrn222\\PRN222_Demo\\DemoConsoleApp\\OpenClosedPrincipleDemo\\Data\\BookStore_01.json\"");
        return JsonConvert.DeserializeObject<List<Book>>(cadJSON);
    }

    // -------------------------------------------------------------
    internal static List<Book> ReadDataExtra()
    {
        List<Book> books = ReadData();
        var cadJSON = ReadFile("\"E:\\FPT\\Semester8\\PRN222\\DemoPrn222\\PRN222_Demo\\DemoConsoleApp\\OpenClosedPrincipleDemo\\Data\\BookStore_02.json\"");
        books.AddRange(JsonConvert.DeserializeObject<List<Book>>(cadJSON));
        return books;
    }
}
