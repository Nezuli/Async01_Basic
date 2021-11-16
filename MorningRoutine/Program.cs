using System.Diagnostics;
using Async01_Basic.Util;
using Async01_Basic.MorningRoutine;

// How to program async using a programmers daily task as an example

var outputProvider = new ConsoleOutputProvider(); // Abstraction of ConsoleWriter-class
var morningRoutine = new MorningRoutine(outputProvider);

var stopwatch = new Stopwatch();
stopwatch.Start();
morningRoutine.DoMorningRoutine();
stopwatch.Stop();
outputProvider.WriteSummary($"Elapsed time: {stopwatch.Elapsed}");