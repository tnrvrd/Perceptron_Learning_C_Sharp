using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Melez_Sistemler_Proje_2
{
    public partial class Form1 : Form
    {
        public List<DataPoint> listDataPoints;
        public double[] WEIGHT_ARRAY;
        public double TETA;
        public double ERROR;
        public double K_NUMBER;
        public double K_MAX;

        public Form1()
        {
            InitializeComponent();
        }

        string fileName;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                panel1.Visible = true;
                groupBox1.Visible = false;
                tbResultWeightVector.Text = "";
                try
                {
                    lbInput.Items.Clear();
                    using (TextReader reader = File.OpenText(fileName))
                    {
                        string line;
                        string[] words = null;
                        while ((line = reader.ReadLine()) != null)
                        {
                            lbInput.Items.Add(line);
                            words = line.Split('\t');
                        }

                        string initialWeigtVectorStr = "";
                        for (int i = 0; i < words.Length-1; i++)
                        {
                            if (i == words.Length - 2)
                            {
                                initialWeigtVectorStr += "1";
                            }
                            else
                            {
                                initialWeigtVectorStr += "1;";
                            }
                        }
                        tbInitialWeightVector.Text = initialWeigtVectorStr;

                        string newInputStr = "";
                        for (int i = 0; i < words.Length - 1; i++)
                        {
                            if (i == words.Length - 2)
                            {
                                newInputStr += "1";
                            }
                            else
                            {
                                newInputStr += "1;";
                            }
                        }
                        tbNewInput.Text = newInputStr;
                    }
                }
                catch (Exception)
                {
                    string msgString = "An error occured while reading file." + Environment.NewLine +
                                        "Please check your file format" + Environment.NewLine +
                                        "For more information about file formats, you can check 'User Manual' menu item";
                    MessageBox.Show(msgString);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCalculatePercepron_Click(object sender, EventArgs e)
        {
            #region Initialize Datas From Text file
            // Initialize datas from textfile
            using (TextReader reader = File.OpenText(fileName))
            {
                listDataPoints = new List<DataPoint>();

                string line;

                
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split('\t');
                    DataPoint dPointNew = new DataPoint();

                    // Initialize Inputs
                    for (int i = 0; i < words.Length - 1; i++)
                    {
                        try
                        {
                            dPointNew.ListInputs.Add(Convert.ToDouble(words[i]));
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Some inputs could not convert to double number");
                            return;
                        }
                    }

                    // Initialize Output
                    try
                    {
                        dPointNew.Output = Convert.ToDouble(words[words.Length-1]);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Some inputs could not convert to double number");
                        return;
                    }

                    // Add datapoint to the list
                    listDataPoints.Add(dPointNew);
                }

            }
            #endregion


            #region STEP 2
            // Initialize weight vector
            // All inputs number should be same, so get the first datapoint inputs number
            string[] STRWeighVector = tbInitialWeightVector.Text.Split(';');
            if (STRWeighVector.Length != listDataPoints[0].ListInputs.Count)
            {
                MessageBox.Show("Initial weight vector size is wrong");
                return;
            }
            WEIGHT_ARRAY = new double[STRWeighVector.Length];
            // Initialize weight vector
            for (int i = 0; i < STRWeighVector.Length ; i++)
            {
                try
                {
                    WEIGHT_ARRAY[i] = Convert.ToDouble(STRWeighVector[i]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Initial weight vector must be double numbers");
                }

            }

            // Teta
            try
            {
                TETA = Convert.ToDouble(tbTeta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Teta must be a double number");
            }


            // Set K and ERROR
            K_NUMBER = 1;
            ERROR = 0;
            K_MAX = listDataPoints.Count;

            #endregion

            #region STEP 3

            ERROR = 1;
            int MAXLOOP;
            try
            {
                MAXLOOP = Convert.ToInt32(tbMaxLoop.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Max Loop must be an integer number");
                return;
            }
            int loop = 0;
            while (ERROR > 0 && loop < MAXLOOP)
            {
                loop++;
                if (loop == MAXLOOP -1)
                {
                    MessageBox.Show("Loop number reached to maximum loop number");
                    return;
                }
                ERROR = 0;
                K_NUMBER = 1;
                for (int dataNumber = 0; dataNumber < listDataPoints.Count; dataNumber++)
                {
                    // w0 * x1
                    // Desire output should be datapoint.output
                    // 
                    DataPoint dPointProcessing = listDataPoints[dataNumber];
                    double sum = 0;
                    for (int i = 0; i < dPointProcessing.ListInputs.Count; i++)
                    {
                        sum += dPointProcessing.ListInputs[i] * WEIGHT_ARRAY[i];
                    }
                    if (Math.Sign(sum) == dPointProcessing.Output)
                    {
                        // OK
                    }
                    else
                    {
                        // Should change weigh vector with TETA
                        // Wi+1 = Wi + Teta(Yi - Sign(sum))*X

                        for (int i = 0; i < WEIGHT_ARRAY.Length; i++)
                        {
                            WEIGHT_ARRAY[i] = WEIGHT_ARRAY[i] + TETA * (dPointProcessing.Output - Math.Sign(sum)) * dPointProcessing.ListInputs[i];
                        }

                        // Calculate Error
                        ERROR = ERROR + (double)1 / 2 * (Math.Pow(dPointProcessing.Output - Math.Sign(sum), 2));
                    }

                    // SET K = K+1
                    K_NUMBER += 1;

                }
            }

            #endregion


            // Write result
            string resultWeightVectorStr = "";
            for (int i = 0; i < WEIGHT_ARRAY.Length; i++)
            {
                if (i == WEIGHT_ARRAY.Length - 1)
                {
                    resultWeightVectorStr += WEIGHT_ARRAY[i].ToString("N2");
                }
                else
                {
                    resultWeightVectorStr += WEIGHT_ARRAY[i].ToString("N2") + " ; ";
                }
            }

            tbResultWeightVector.Text = resultWeightVectorStr;

            groupBox1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] STRNewInput = tbNewInput.Text.Split(';');
            if (STRNewInput.Length != listDataPoints[0].ListInputs.Count)
            {
                MessageBox.Show("New input size is wrong");
                return;
            }

            double sum = 0;
            for (int i = 0; i < STRNewInput.Length; i++)
            {
                try
                {
                    double tempInput = Convert.ToDouble(STRNewInput[i]);
                    double productInputAndWeightVector = tempInput * WEIGHT_ARRAY[i];
                    sum += productInputAndWeightVector;
                }
                catch (Exception)
                {
                    MessageBox.Show("Inputs must be double numbers");
                }
            }

            if (sum >= 0)
            {
                lblResult.Text = "Result : " + Math.Sign(sum);
            }
            else
            {
                lblResult.Text = "Result : " + Math.Sign(sum);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("muhammedtanriverdi@gmail.com");
        }

        private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"user_manual.txt");
        }

        private void algorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"The perceptron learning rule.pdf");
        }
    }
}
