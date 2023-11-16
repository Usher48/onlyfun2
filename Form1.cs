using System.Windows.Forms;

namespace onlyfun
{
    public partial class Onlyfun : Form
    {
        public Onlyfun()
        {
            InitializeComponent();
            InitializeRadioButtons(); // Call a method to set up radio buttons
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                UpdateDescription(radioButton.Tag.ToString()); // Assuming you set the tag property with the description
            }
        }

        private void UpdateDescription(string description)
        {
            LB2.Items.Clear();
            LB2.Items.Add(description);
        }


        private void InitializeRadioButtons()
        {
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;

            radioButton1.Tag = "Description for Game 1";
            radioButton2.Tag = "Description for Game 2";
            radioButton3.Tag = "Description for Game 3";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            InitializeRadioButtons();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            InitializeRadioButtons();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            InitializeRadioButtons();
        }
    }
}