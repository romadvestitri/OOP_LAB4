using System;
using System.Text.Json;
using System.Collections;
using System.Linq;
using lab4;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Reflection;

ArchiveAdapter archive = new ArchiveAdapter(@"C:\OOP\lab4\ClothesLibrary\ClothesLibrary\bin\Debug\net6.0");
archive.Compression("C:\\OOP\\lab3\\test.json", "C:\\OOP\\lab3\\test.gz");
archive.Decompression("C:\\OOP\\lab3\\test.gz", "C:\\OOP\\lab3\\test1.json");

