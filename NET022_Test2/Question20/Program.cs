
namespace NET022_Test2.Question20
{
    // 5.   Associate the event with the event handler
    public class Program
    {
        static void Main(string[] args)
        {
            
            Button button = new Button();
            ButtonHandler handler = new ButtonHandler();

            // Subscribe to the event
            button.ButtonClicked += handler.OnButtonClicked;

            // Simulate clicking the button
            button.Click();
        }

    }
}
