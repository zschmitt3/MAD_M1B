namespace ConsoleApp1;


public class Dog : Pet, Talkable {
    private bool friendly;


    public Dog(bool friendly, String name) : base(name) {
        this.friendly = friendly;
    }

    public bool isFriendly() {
        return friendly;
    }

    
    public String talk() {
        return "Bark";
    }

    
    public String toString() {
        return "Dog: " + "name=" + name + " friendly=" + friendly;
    }


}