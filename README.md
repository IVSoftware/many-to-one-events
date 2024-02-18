# Many Controls One Handler

In general, there's nothing wrong with subscribing many controls to a common event handler.

I believe you may be running into a subtlety where the mouse events need to be allowed to continue, and in particular for the mouse button to "come back up" before this is actually going to work the way you expect. The intent of your code seems to be to style the background color and select the value text when the control is clicked into. So what you can experiment with is posting the selection action at the end of the message queue using `BeginInvoke`.

[![with and without begin invoke][1]][1]

```csharp
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        foreach (var numericUpDown in Controls.OfType<NumericUpDown>())
        {
            // Multiple subscription to the `Enter` event
            numericUpDown.Enter += Any_NumericControlEnter;
        }
    }

    private void Any_NumericControlEnter(object? sender, EventArgs e)
    {
        if (sender is NumericUpDown numericUpDown)
        {
            if (checkBoxUseBeginInvoke.Checked)
            {
                BeginInvoke(() => localStyleNumericUpDownControl());
            }
            else localStyleNumericUpDownControl();
        }
        void localStyleNumericUpDownControl() 
        {
            numericUpDown.Select(0, numericUpDown.Text.Length);
            foreach (var any in Controls.OfType<NumericUpDown>())
            {
                any.BackColor = (any == numericUpDown) ? 
                    Color.Wheat : this.BackColor;
            }
        }
    }
}
```


  [1]: https://i.stack.imgur.com/2iOUC.png