public class Animal
{
    private string name;
    private string favouriteFood;

    public Animal(string name, string favoriteFood)
    {
        this.name = name;
        this.favouriteFood = favoriteFood;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string FavoriteFood
    {
        get { return this.favouriteFood; }
        set { this.favouriteFood = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
    }
}