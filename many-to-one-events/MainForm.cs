
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
}
