using System;
using System.Text.Json;

var names = new[] {"Ole", "Knut", "Kari"};
var serialized = JsonSerializer.Serialize(names);

Console.WriteLine(serialized);
