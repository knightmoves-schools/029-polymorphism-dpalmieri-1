namespace Tests;

using System.Reflection;
using System.Text.RegularExpressions;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    /*
- should rename the `Talk` method on the `Dog` class to `Say`
- should rename the `Sing` method on the `Bird` class to `Say`
- should replace the `if` statements with a single call to the `Say` method
    */

    [Fact]
    public void Should_Rename_The_Talk_Method_On_The_Dog_Class_To_Say(){
       var dog = new Dog();
       Assert.Equal("woof", dog.Say());
    }

    [Fact]
    public void Should_Rename_The_Sing_Method_On_The_Bird_Class_To_Say(){
       var bird = new Bird();
       Assert.Equal("chirp", bird.Say());
    }

    [Fact]
    public void Should_Replace_The_If_Statements_With_A_Single_Call_To_The_Say_Method_On_Each_Of_The_Animals(){
      string filePath = Path.GetDirectoryName(typeof(Animal).Assembly.Location) + "/../../../Animals.cs";

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);
        Regex rx = new Regex(@"if");

        bool hasIf = rx.IsMatch(content);

        Assert.True(!hasIf, "should replace the `if` statements with a single call to the `Say` method on each of the animals");

       Animal[] animals = {new Cat(), new Dog(), new Bird()};
       var trainer = new Trainer();
       Assert.Equal("meow, woof, chirp, ", trainer.Listen(animals));
    }
}