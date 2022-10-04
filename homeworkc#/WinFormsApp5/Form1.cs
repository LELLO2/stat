namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "ok";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "1 the practice or science of collecting and analysing numerical data in large quantities, especially for the purpose of inferring proportions in a whole from those in a representative sample.\r\n2 dataset is a collection of data. In the case of tabular data, a data set corresponds to one or more database tables, where every column of a table represents a particular variable, and each row corresponds to a given record of the data set in question. The data set lists values for each of the variables, such as for example height and weight of an object, for each member of the data set. Data sets can also consist of a collection of documents or files.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "We have small differences between the two languages, for example in C # it is always necessary to use {} or to terminate a command at the end of the line it is necessary to use the; while in vb it is not necessary nor the use of the} and to go to the new line just go to the head moreover to finish the code in vb it is necessary to write END SUB END CLASS IN C # USE}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "Well done";
        }
    }
}