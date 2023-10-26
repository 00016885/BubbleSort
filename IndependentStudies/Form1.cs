namespace IndependentStudies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //get inputs
            var input = tbxInput.Text.Split(",".ToCharArray());
            //array of doubles
            var numbers = new double[input.Length] ;
            for (int i = 0 ; i < input.Length ; i++)
            {
                var item = input[i] ;
                if(isNumeric(item))
                {
                    numbers[i]=Convert.ToDouble(item);
                }
                else
                {
                    showMessage("Invalid input");
                    return;
                }
            }
            bool haveChanges = true;
            while (haveChanges)
            {
                haveChanges = false;
                for (int i = 0 ;i < numbers.Length-1; i++)
                {
                    
                    if (numbers[i] > numbers[i + 1])
                    {
                        haveChanges = true;
                        swap(ref numbers[i], ref numbers[i + 1]);
                        //swap
                    }
                }
            }
            showMessage(string.Join(",", numbers));
        }
        //show messagebox with title
        private void showMessage(string message)
        {
            MessageBox.Show(message, "Bubble Sort");
        }
        //method check whether  array element is numeric
        private bool isNumeric(string text)
        {
            return double.TryParse(text, out _);
        }
        //method to swap a and b
        private void swap(ref double a, ref double b)
        {
            var temp = a;
            a=b; b=temp;
        }
    }
}