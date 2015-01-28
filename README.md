VBEventingSample
----------------

This small code sample was originally written to aid another programmer who wanted a simple example of firing and consuming events in ASP.NET. 

I implemented a page which contains a UserControl and a Label. When the page loads, the label is initialised with some text indicating the time at which it was bound. There is a button on the page which will trigger a straightforward postback, causing the label to rebind.

Below this, there is our UserControl. It contains three buttons. The first one fires a standard event with no additional information, which is handled by the parent page. The handler updates the label with the time at which the event was handled and an indication that the event came from the UserControl.

The other two buttons fire a custom event, which uses an extended EventArgs class. The EventArgs instance includes a System.Drawing.Colour value as one of its' properties. This value is then used to customise the colour of the label.