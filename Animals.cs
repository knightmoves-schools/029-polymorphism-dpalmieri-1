namespace knightmoves;

public abstract class Trainer{
    public string Listen(Animal[] animals) {
        string sounds = "";

        foreach(Animal animal in animals){
            public abstract string Say() += sounds;
        }

        return sounds;
    }
}

public abstract class Animal {
    
}

public class Cat : Animal{
    public override string Say() {
        return "meow";
    }
}

public class Dog : Animal{
    public override string Say() {
        return "woof";
    }
}

public class Bird  : Animal{
    public override string Say() {
        return "chirp";
    }
}


