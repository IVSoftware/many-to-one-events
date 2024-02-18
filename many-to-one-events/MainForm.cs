
namespace many_to_one_events
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (var numericUpDown in Controls.OfType<NumericUpDown>())
            {
                // Multiple subscription to the `Enter` event
                numericUpDown.Enter += Any_NumericControlEnter;

                // Multiple inline subscription to the `MouseEnter` event using a lambda
                numericUpDown.MouseEnter += (sender, e) =>
                { 
                    if(sender is Control control)
                    {
                        switch(control.Name)
                        {
                            case nameof(numericUpDown1): richTextBox.SelectionColor = Color.Green; break;
                            case nameof(numericUpDown2): richTextBox.SelectionColor = Color.Blue; break;
                            case nameof(numericUpDown3): richTextBox.SelectionColor = Color.Maroon; break;
                        }
                        BeginInvoke(()=>richTextBox.AppendText($"MouseEnter {control.Name}{Environment.NewLine}"));
                    }
                };
            }
        }

        private void Any_NumericControlEnter(object? sender, EventArgs e)
        {
            if (sender is NumericUpDown thisNumericUpDown)
            {
                if (checkBoxUseBeginInvoke.Checked) BeginInvoke(() => localStyleNumericUpDownControl());
                else localStyleNumericUpDownControl();
            }
            void localStyleNumericUpDownControl() 
            {
                thisNumericUpDown.Select(0, $"{thisNumericUpDown.Value}".Length);
                foreach (var any in Controls.OfType<NumericUpDown>())
                {
                    any.BackColor = (any == thisNumericUpDown) ? Color.Wheat : this.BackColor;
                }
            }
        }
    }
}
