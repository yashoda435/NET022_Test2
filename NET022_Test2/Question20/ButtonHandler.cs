
namespace NET022_Test2.Question20
{
    // 4.   Create code the will be run when the event occurs (Event Handler)
    public class ButtonHandler
    {
        // Event handler method that gets triggered when the button is clicked
        public void OnButtonClicked(object sender, ButtonClickEventArgs e)
        {
            Console.WriteLine("Button click event handled.");
        }
    }
}
