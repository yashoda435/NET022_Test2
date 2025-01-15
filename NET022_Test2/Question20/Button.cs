
namespace NET022_Test2.Question20
{
    // 2. Set up the delegate for the event
    public delegate void ButtonClickEventHandler(object sender, ButtonClickEventArgs e);

    // 3. Declare the code for the event
    public class Button
    {
        // Declare the event using the delegate 
        public event ButtonClickEventHandler ButtonClicked;

        
        public void Click()
        {
            Console.WriteLine("Button was clicked!");

            // Raise the event 
            OnButtonClicked(new ButtonClickEventArgs());
        }

        // trigger the event
        protected virtual void OnButtonClicked(ButtonClickEventArgs e)
        {
            // Check if any subscribers to the event before invoking it
            ButtonClicked?.Invoke(this, e);
        }
    }
}
