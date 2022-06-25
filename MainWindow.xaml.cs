using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _20104056Assignment2021Task3POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables to be used later for a calculation 
        
        public MainWindow()
        {
            InitializeComponent();
        }
//***TAB 1 - HOME*************************************************************************************************************************

        //Start Button That Takes The User To Fill In Their Expenses.     
        private void StartButton_Click(object sender, RoutedEventArgs e)
            {
                myTabControl.SelectedIndex = 1;
            }

 //***TAB 2 - INPUT EXPENSES*****************************************************************************************************************

        //Declaring the Array
        double[] myExpenses = new double[7];


        //Variables Declared

        double GrossMonthlyIncome;
        double MonthlyTaxDeductions;
        double Groceries;
        double Water_Lights;
        double TravelCost;
        double CellPhone_Telephone;
        double OtherExpenses;
        private void ExpensesBTN_Click(object sender, RoutedEventArgs e)
        {
            //Storing the variable from the text boxes into an Array.



            if (this.TB1.Text == null)
            {
                
                // Invalid. Set An Error.
                this.TB1.Text = "!!!!";

                if (this.TB2.Text == null)
                {
                    // Invalid. Set An Error.
                    this.TB2.Text = "!!!!";

                    if (this.TB3.Text == null)
                    {
                        // Invalid. Set An Error.
                        this.TB3.Text = "!!!!";

                        if (this.TB4.Text == null)
                        {
                            // Invalid. Set An Error.
                            this.TB4.Text = "!!!!";

                            if (this.TB5.Text == null)
                            {
                                // Invalid. Set An Error.
                                this.TB5.Text = "!!!!";

                                if (this.TB6.Text == null)
                                {
                                    // Invalid. Set An Error.
                                    this.TB6.Text = "!!!!";

                                    if (this.TB7.Text == null)
                                    {
                                        // Invalid. Set An Error.
                                        this.TB7.Text = "!!!!";
                                    }
                                }

                            }
                        }

                    }
                }
            }
            else
            {
                // Valid. Clear The Error.
                //Gross Monthly Income
                myExpenses[0] = double.Parse(this.TB1.Text);
                GrossMonthlyIncome = myExpenses[0];

                // Valid. Clear The Error.
                //MONTHLY TAX DEDUCTIONS
                myExpenses[1] = double.Parse(this.TB2.Text);
                MonthlyTaxDeductions = myExpenses[1];

                // Valid. Clear The Error.
                //GROCERIES
                myExpenses[2] = double.Parse(this.TB3.Text);
                Groceries = myExpenses[2];

                // Valid. Clear The Error.
                //WATER AND LIGHTS
                myExpenses[3] = double.Parse(this.TB4.Text);
                Water_Lights = myExpenses[3];

                // Valid. Clear The Error.
                //TRAVEL COST
                myExpenses[4] = double.Parse(this.TB5.Text);
                TravelCost = myExpenses[4];

                // Valid. Clear The Error.
                //CELL PHONE AND TELEPHONE
                myExpenses[5] = double.Parse(this.TB6.Text);
                CellPhone_Telephone = myExpenses[5];

                // Valid. Clear The Error.
                //OTHER EXPENSES
                myExpenses[6] = double.Parse(this.TB7.Text);
                OtherExpenses = myExpenses[6];

                myTabControl.SelectedIndex = 2;
            }
            

          
        }
//***TAB 3 - MENU*************************************************************************************************************************

            //Allows the user to choose which tab to foward to depending on the button the user clicks.
        public void RentPropertyBTN_Click(object sender, RoutedEventArgs e) => myTabControl.SelectedIndex = 3;

        private void BuyPropertyBTN_Click(object sender, RoutedEventArgs e) => myTabControl.SelectedIndex = 4;
      
        private void BuyVehicleBTN_Click(object sender, RoutedEventArgs e) => myTabControl.SelectedIndex = 5;
        

        private void AvailableMoneyBTN_Click(object sender, RoutedEventArgs e) => myTabControl.SelectedIndex = 6;
      

        private void SaveBTN_Click(object sender, RoutedEventArgs e) => myTabControl.SelectedIndex = 7;
       

        private void BTN7_Click(object sender, RoutedEventArgs e) => myTabControl.SelectedIndex = 8;
       


//***TAB 4 - RENT PROPERTY*********************************************************************************************************************
        private void RentBTN_Click(object sender, RoutedEventArgs e)
        {
            double rentProperty = double.Parse(this.Rent.Text);
            DisplayRent.Text = rentProperty.ToString();
        }
//***TAB 5 - BUY PROPERTY*********************************************************************************************************************
        //Generic Collection
        //Declaring the List
        //delegate must be inplemented in this. 
        List<Double> propertyData = new List<Double>();

        //Delaring variables:
        double purchasePrice;
        double TotalDeposit;
        double InterestRate;
        double Months;

        //Declaring The Monthly Repayments:
        double MonthlyRepayments = 0;

        private void BuyPropertyButton_Click(object sender, RoutedEventArgs e)
        {
            //Storing the variable from the text boxes into list.
            purchasePrice = double.Parse(this.PurchasePrice.Text);
            propertyData.Add(purchasePrice);

            TotalDeposit = double.Parse(this.Total_Deposit.Text);
            propertyData.Add(TotalDeposit);

            InterestRate = double.Parse(this.Interest_Rate.Text);
            InterestRate = InterestRate / 100;
            propertyData.Add(InterestRate);

            Months = double.Parse(this.MonthsBox.Text);
            propertyData.Add(Months);


            //A=P(1+in)

            propertyData[0] = propertyData[1] * (1 + (propertyData[2] * propertyData[3]));

            MonthlyRepayments = propertyData[1] / 12;

            if (MonthlyRepayments < (1 / 3) * (propertyData[0]))
            {
                DisplayMonthlyRepayments.Text = MonthlyRepayments.ToString();
                DisplayMonthlyRepayments.Text = "Approval for home loan is unlikely.";

            }
            else
            {
                DisplayMonthlyRepayments.Text = MonthlyRepayments.ToString();

            }
        }

//***TAB 6 - BUY VEHICLE*****************************************************************************************************
       

        //Declarations:
        string Make;
        string Model;
        double VehiclePurchasePrice;
        double VehicleTotalDeposit;
        double VehicleInterestRate;
        double InsurancePremium;

        double TotalMonthlyCost;


        double TotalInterest;
        double monthlyInterest;
        double monthlyInstalment;


        //Generic Collection:
        List<String> MAKEandMODEL = new List<String>();


        List<Double> vehicleExpenses = new List<Double>();

        List<Double> TotalMonthlyCostCalculation = new List<Double>();

        private void carCalculate_Click(object sender, RoutedEventArgs e)
        {
            
            //Storing the variable from the text boxes into list.
            Make = this.carMake.Text;
            MAKEandMODEL.Add(Make);

            Model = this.carModel.Text;
            MAKEandMODEL.Add(Model);

            VehiclePurchasePrice = double.Parse(this.carPurchasePrice.Text);
            vehicleExpenses.Add(VehiclePurchasePrice);

            VehicleTotalDeposit = double.Parse(this.carTotalDeposit.Text);
            vehicleExpenses.Add(VehicleTotalDeposit);

            VehicleInterestRate = double.Parse(this.carInterestRate.Text);
            VehicleInterestRate = VehicleInterestRate / 100;
            vehicleExpenses.Add(VehicleInterestRate);

            InsurancePremium = double.Parse(this.carInsurancePremium.Text);
            vehicleExpenses.Add(InsurancePremium);


           /*Your total interest = interest rate / 100 x loan amount x loan period
           Your monthly interest = total interest / (loan period x 12)
           Your monthly installment = (loan amount + total interest) / (loan period x 12)*/

            //Loan Period was given as 5. 
            TotalInterest = VehicleInterestRate / 100 * VehiclePurchasePrice * 5;
            TotalMonthlyCostCalculation.Add(TotalInterest);

            monthlyInterest = TotalInterest / (5 * 12);
            TotalMonthlyCostCalculation.Add(monthlyInterest);

            monthlyInstalment = (VehiclePurchasePrice + TotalInterest) / (5 * 12);
            TotalMonthlyCostCalculation.Add(monthlyInstalment);



            TotalMonthlyCost = InsurancePremium + monthlyInstalment;

            //Error HANDLING 

            double A = (75 / 100) * GrossMonthlyIncome;

            if ((TotalMonthlyCostCalculation[2]) > A)
            {
                //Summary With Error HANDLING
                carSummary.Text = "Make              :" + Make + "\n"
                                + "Model             :" + Model + "\n"
                                + "Purchase Price :" + VehiclePurchasePrice.ToString() + "\n"
                                + "Total Deposit  :" + VehicleTotalDeposit.ToString() + "\n"
                                + "Interest Rate  :" + VehicleInterestRate.ToString() + "\n"
                                + "Insurance Premium:" + InsurancePremium.ToString() + "\n"
                                + "_____________________________________" + "\n"
                                + "Total Monthly Cost:" + TotalMonthlyCostCalculation[2].ToString() + "\n"
                                + "The Total Monthly Cost exceeds 75% of your Gross Monthly Income.";
            }
            else
            {
                //Summary With Error HANDLING
                carSummary.Text = "Make              :" + Make + "\n"
                                + "Model             :" + Model + "\n"
                                + "Purchase Price :" + VehiclePurchasePrice.ToString() + "\n"
                                + "Total Deposit  :" + VehicleTotalDeposit.ToString() + "\n"
                                + "Interest Rate  :" + VehicleInterestRate.ToString() + "\n"
                                + "Insurance Premium:" + InsurancePremium.ToString() + "\n"
                                + "_____________________________________" + "\n"
                                + "Total Monthly Cost:" + TotalMonthlyCostCalculation[2].ToString();
            }

        }

//***TAB 7 - AVAILABLE MONEY*******************************************************************************************************

        //Declaring the variable to store the Input for available money
        double availableMoney;
        private void AvailableMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            //Calculate the avialble money
            double exp = MonthlyTaxDeductions + Groceries + Water_Lights + TravelCost + CellPhone_Telephone + OtherExpenses;

            availableMoney = GrossMonthlyIncome-exp;

            DisplayAvailableMoney.Text = availableMoney.ToString();
        }
//***TAB 8 - SAVE********************************************************************************************************************


        //Declaring Variables:

        double Savings_Amount;
        double Interest_Amount;
        double Savings_Time;
        double Total_Savings_Amount;
        double Monthly_Savings_Amount;

        //List to store values
        List<double> values = new List<double>();
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //Storing valiues in a List
            Savings_Amount = double.Parse(this.SaveAmount.Text);
            values.Add(Savings_Amount);
             
            Interest_Amount = double.Parse(this.SaveInterest.Text);
            Interest_Amount = Interest_Amount / 100;
            values.Add(Interest_Amount);

            Savings_Time = double.Parse(this.yearAmount.Text);
            values.Add(Savings_Time);

            //Simple Interest: Total Savings Amount = Initial Amount x Interest Rate x Time

            Total_Savings_Amount = (Savings_Amount * Interest_Amount * Savings_Time) + Savings_Amount;
            values.Add(Total_Savings_Amount);
            DisplayTotalSavingsAmount.Text = Total_Savings_Amount.ToString();

            //Simple Interest: Monthly Total Amount = Initial Amount x Interest Rate x Time/12

            Monthly_Savings_Amount = Savings_Amount * Interest_Amount * Savings_Time / 12;
            values.Add(Monthly_Savings_Amount);
            DisplayMonthlySavingsAmount.Text = Monthly_Savings_Amount.ToString();

        }

    }
}
