// See https://aka.ms/new-console-template for more information
using ExercicesAvancedProgramming.SolidPrincipes.DependencyInjectionPrinciple;
using ExercicesAvancedProgramming.SolidPrincipes.LiskovSubstitutionPrinciple;

Console.WriteLine("Hello, World!");

IAutomobile automobile = new Jeep();

AutomobileController _ = new(automobile);

automobile.Ignition();
automobile.Stop();

Console.ReadKey();
