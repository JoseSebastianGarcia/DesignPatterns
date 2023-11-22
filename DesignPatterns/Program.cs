using DesignPatterns.Views;

public class Program 
{
    public static void Main(params string[] args) 
    {
        IView view = new CategoriesView();
        view.Render();
    }
}