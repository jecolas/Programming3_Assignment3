using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moemi_Hagiyama_Lab03_Ex1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region CalculateFactorial

        private async void btn_calculate_Click(object sender, EventArgs e)
        {
            long num = 0;
            lbl_relDisp.Text = "";

            // check if the text box is empty or not
            if (txt_factorial.Text == "")
            {
                lbl_rel.ForeColor = Color.Red;
                lbl_rel.Text = emptyError;
            }
            else
            {
                // check if the input is number and can combertable to double
                if (long.TryParse(txt_factorial.Text, out num))
                {
                    Task<long> task = Task.Run(() => Factorial(num));
                    long rel = await task;


                    lbl_rel.ForeColor = Color.Black;
                    lbl_rel.Text = "Result:";
                    lbl_relDisp.Text = rel.ToString();
                }
                else
                {
                    lbl_rel.ForeColor = Color.Red;
                    lbl_rel.Text = formatError;
                }
            }
        }

        /*
         * Calculate factorial
         */
        long Factorial(long num)
        {
            return num * num;
        }
        #endregion

        #region CheckEvenOdd

        private void btn_checkEvenOdd_Click(object sender, EventArgs e)
        {
            int num = 0;
            lbl_errEvenOdd.Text = "";
            lbl_relEven.Text = "";
            lbl_relOdd.Text = "";
            lbl_even.Visible = false;
            lbl_odd.Visible = false;

            // check if the text box is empty or not
            if (txt_EvenOdd.Text == "")
            {
                lbl_errEvenOdd.Text = emptyError;
            }
            else
            {
                // check if the input is number and can combertable to int
                if (int.TryParse(txt_EvenOdd.Text, out num))
                {
                    // multi cast delegate with invocation list
                    Func<int, bool> checkEvenOdd = IsEven;
                    checkEvenOdd += IsOdd;

                    List<bool> rel = new List<bool>();
                    Delegate[] delegates = checkEvenOdd.GetInvocationList();

                    foreach (Func<int, bool> evenOdd in delegates)
                    {
                        rel.Add(evenOdd(num));
                    }

                    // display results
                    lbl_even.Visible = true;
                    lbl_relEven.Text = rel[0].ToString();
                    lbl_odd.Visible = true;
                    lbl_relOdd.Text = rel[1].ToString();
                }
                else
                {
                    lbl_errEvenOdd.Text = formatError;
                }
            }
        }

        bool IsEven(int num) => num % 2 == 0;

        bool IsOdd(int num) => num % 2 == 1;
        #endregion

        #region Display List Value and Search
        private List<int> intList = new List<int>();
        private List<double> doubleList = new List<double>();
        private List<char> charList = new List<char>();

        #region generate values
        private async void btn_generate_Click(object sender, EventArgs e)
        {
            // clear all values before generate values
            lbl_errGenerate.Text = "";
            list_genValues.Items.Clear();

            /*
             * using random, generate 10 values
             * and add the value to the item list
             */
            if (rbtn_integer.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    int num = rnd.Next(1, 100); // creates a number between 1 and 99
                    list_genValues.Items.Add(num);
                    intList.Add(num);
                    await Task.Delay(1);
                }
            }
            else if (rbtn_double.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    double num = rnd.NextDouble() * (1000 - 1) + 1; // creates a number between 1 and 99
                    list_genValues.Items.Add(Math.Round(num, 2));
                    doubleList.Add(Math.Round(num, 2));
                    await Task.Delay(1);
                }
            }
            else if (rbtn_char.Checked)
            {
                var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    char ch = chars[rnd.Next(chars.Length)];
                    list_genValues.Items.Add(ch);
                    charList.Add(ch);
                    await Task.Delay(1);
                }
            }
            else
            {
                lbl_errGenerate.Text = "Please select radio button";
            }

        }
        #endregion

        #region Search values
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show(emptyError, "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtn_integer.Checked)
                {
                    int num = 0;                   
                    if (int.TryParse(txt_search.Text, out num))
                    {
                        Search<int>(num, intList);
                    }
                    else
                    {
                        FormatError("integer");
                    }
                }
                else if (rbtn_double.Checked)
                {
                    double num = 0;
                    if (double.TryParse(txt_search.Text, out num))
                    {
                        Search<double>(num, doubleList);
                    }
                    else
                    {
                        FormatError("double");
                    }
                }
                else if (rbtn_char.Checked)
                {
                    char val;
                    if (char.TryParse(txt_search.Text, out val))
                    {
                        Search<char>(val, charList);
                    }
                    else
                    {
                        FormatError("char");
                    }
                }
                else
                {
                    MessageBox.Show(notGeneratedError, "error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        /*
         * -----------------------------------
         * Search<T>(T x, List<T> inputValues)
         * -----------------------------------
         * search the value from the generated list.
         * display the result by message box.
         * 
         */
        private void Search<T>(T x, List<T> inputValues) where T : IComparable<T>
        {
            for (var i = 0; i < inputValues.Count; i++)
            {
                if (x.CompareTo(inputValues[i]) == 0)
                {
                    MessageBox.Show($"Searched number found. \nsearched number: {x}", "result",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
            MessageBox.Show($"Searched number not found. \nsearched number: {x}", "result",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region Low Index and High Index
        private void btn_display_Click(object sender, EventArgs e)
        {
            //clear the list of data
            list_valLowHigh.Items.Clear();
            lbl_err_Index.Text = "";

            //check if both index fields are filled up
            if (txt_low.Text == "" || txt_high.Text == "")
            {
                lbl_err_Index.Text = emptyError;
            }
            else
            {
                /* 
                 * 1. check button type
                 * 2. check if the index low & high text can be convert to the type which is choose by radio button 
                 * 3. Call PrintData<t>(List<T> list, t low, t high) and create the list between low and high index
                 * 4. Call DisplayList<t>(List<T> list) which is display the list to the result list box.
                 * 
                 *  ** 2~3 could be occured error.
                */
                if (rbtn_integer.Checked)
                {
                    int low = 0, high = 0;

                    if (int.TryParse(txt_low.Text, out low) && int.TryParse(txt_high.Text, out high))
                    {
                        List<int> relList = new List<int>();
                        try
                        {
                            relList = PrintData(intList, low, high);
                        }
                        catch (Exception ex)
                        {
                            lbl_err_Index.Text = ex.Message.ToString();
                        }
                        DisplayList(relList);
                    }
                    else
                    {
                        lbl_err_Index.Text = matchError;
                    }
                }
                else if (rbtn_double.Checked)
                {
                    double low = 0, high = 0;
                    if (double.TryParse(txt_low.Text, out low) && double.TryParse(txt_high.Text, out high))
                    {
                        List<double> relList = new List<double>();
                        try
                        {
                            relList = PrintData(doubleList, low, high);
                        }
                        catch (Exception ex)
                        {
                            lbl_err_Index.Text = ex.Message.ToString();
                        }

                        DisplayList(relList);
                    }
                    else
                    {
                        lbl_err_Index.Text = matchError;
                    }
                }
                else if (rbtn_char.Checked)
                {
                    char low, high;
                    if (char.TryParse(txt_low.Text, out low) && char.TryParse(txt_high.Text, out high))
                    {
                        List<char> relList = new List<char>();
                        try
                        {
                            relList = PrintData(charList, low, high);
                        }
                        catch (Exception ex)
                        {
                            lbl_err_Index.Text = ex.Message.ToString();
                        }

                        DisplayList(relList);
                    }
                    else
                    {
                        lbl_err_Index.Text = matchError;
                    }
                }
                else
                {
                    lbl_err_Index.Text = "please generate values first.";
                }
            }
        }

        private List<T> PrintData<T>(List<T> list, T low, T high)
        {
            List<T> relList = new List<T>();
            list.Sort();

            int lowValue = list.IndexOf(low);
            int highValue = list.IndexOf(high);

            if(lowValue < 0 || highValue < 0)
            {
                throw new Exception("Please enter valid values");
            }
            else if(lowValue >= highValue)
            {
                throw new Exception("high index should be higher than low index");
            }
            else
            {
                // create list between low index and high index
                for (int i = lowValue+1; i < highValue; i++)
                {
                    relList.Add(list[i]);
                }

            }

            return relList;
        }

        //
        // display values to the list box.
        //
        private void DisplayList<T>(List<T> list)
        {
            foreach (var value in list)
            {
                list_valLowHigh.Items.Add(value);
            }
        }
        #endregion
        #endregion

        #region errors
        //
        // common errors
        //
        private void FormatError(string value) =>
              MessageBox.Show($"Format Error. Please enter {value}", "error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        string matchError = "the selected value type and type of \ninput value is not match";
        string notGeneratedError = "Please generate values first";
        string emptyError = "Please input a value to the textbox";
        string formatError = "Format error";
        #endregion
    }
}
