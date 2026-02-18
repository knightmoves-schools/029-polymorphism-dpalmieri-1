namespace knightmoves;

public class Trainer{
    public string Listen(Animal[] animals) {
        string sounds = ", ";
        foreach(Animal animal in animals){
            sounds += animal.Say();
        }
        
        return sounds;
    }
}

public abstract class Animal {
    public abstract string Say();
}

public class Cat : Animal{
    public override string Say(){
        return "meow";
    }
}

public class Dog : Animal{
    public override string Say(){
        return "woof";
    }
}

public class Bird  : Animal{
    public override string Say(){
        return "chirp";
    }
}









