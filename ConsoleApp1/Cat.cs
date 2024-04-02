namespace ConsoleApp1;

public class Cat : Pet, Talkable {
    private int mousesKilled;

    public Cat(int mousesKilled, String name) : base(name) {
        this.mousesKilled = mousesKilled;
    }

    public int getMousesKilled() {
        return mousesKilled;
    }

    public void addMouse() {
        mousesKilled++;
    }
    
    public String talk() {
        return "Meow";
    }
    
    public String toString() {
        return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
    }
}