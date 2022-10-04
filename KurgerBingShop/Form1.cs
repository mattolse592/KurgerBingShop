using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace KurgerBingShop
{
    public partial class form : Form
    {
        //Creating sound player for errors
        SoundPlayer errorPlayer = new SoundPlayer(Properties.Resources.error);

        //Declaring variables
        double wherppoamount = 0;
        double bingamount = 0;
        double kriesamount = 0;
        double wherppoprice = 5;
        double bingprice = 1;
        double kriesprice = 2;
        double subtotal = 0;
        double tax = 0;
        double total = 0;
        double tendered = 0;
        double change = 0;
        double ordernum = 1;
        public form()
        {
            InitializeComponent();
        }
        private void totalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Get ordered amount
                wherppoamount = Convert.ToDouble(wherppoInput.Text);
                bingamount = Convert.ToDouble(bingInput.Text);
                kriesamount = Convert.ToDouble(kriesInput.Text);

                //If they order too many wherppos, tell then not enough inventory
                if (wherppoamount > 100){
                    errorPlayer.Play();

                    spacer.BackColor = Color.Red;
                    spacer.Text = "Insufficient inventory";
                    Refresh();
                    Thread.Sleep(1000);
                    spacer.BackColor = Color.SeaShell;
                    spacer.Text = "";
                    return;
                }
                //If they order too many kries, tell then not enough inventory
                if (kriesamount > 100)
                {
                    errorPlayer.Play();

                    spacer.BackColor = Color.Red;
                    spacer.Text = "Insufficient inventory";
                    Refresh();
                    Thread.Sleep(1000);
                    spacer.BackColor = Color.SeaShell;
                    spacer.Text = "";
                    return;
                }
                //If they order too many bing chillings, tell then not enough inventory and rick roll them
                if (bingamount > 100)
                {
                    //create soundplayer for rickroll
                    SoundPlayer rickPlayer = new SoundPlayer(Properties.Resources.rick);
                    rickPlayer.Play();
                    //play sound ^

                    spacer.BackColor = Color.Red;
                    spacer.Text = "Insufficient inventory";
                    Refresh();
                    Thread.Sleep(1000);
                    spacer.BackColor = Color.SeaShell;
                    spacer.Text = "";
                    
                    
                    return;
                }
                //If they don't order anything, tell them to select an item
                if (wherppoamount + bingamount + kriesamount < 1)
                {
                    errorPlayer.Play();
                    spacer.BackColor = Color.Red;
                    spacer.Text = "Please select an item";
                    Refresh();
                    Thread.Sleep(1000);
                    spacer.BackColor = Color.SeaShell;
                    spacer.Text = "";
                }
                else
                { 
                    //calculate subtotal, tax, and total
                    subtotal = wherppoamount * wherppoprice + bingamount * bingprice + kriesamount * kriesprice;
                    tax = subtotal * 0.13;
                    total = subtotal + tax;
                    //output subtotal, tax, and total
                    taxOutput.Text = $"{tax.ToString("C")}";
                    subTotalOutput.Text = $"{subtotal.ToString("C")}";
                    totalOutput.Text = $"{total.ToString("C")}";

                    //enable change button
                    changeButton.Enabled = true;
                }
            } catch
            {
                //error handling
                errorPlayer.Play();
                spacer.BackColor = Color.Red;
                spacer.Text = "User Input Error";
                Refresh();
                Thread.Sleep(1000);
                spacer.BackColor = Color.SeaShell;
                spacer.Text = "";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get tendered amount
                tendered = Convert.ToDouble(tenderedInput.Text);

                //if they input too much money, throw an error because it will mess the receipt
                if (tendered > 10000)
                {
                    errorPlayer.Play();

                    spacer.BackColor = Color.Red;
                    spacer.Text = "Possible counterfeit detected";
                    Refresh();
                    Thread.Sleep(1000);
                    spacer.BackColor = Color.SeaShell;
                    spacer.Text = "";
                    return;
                }
                if (tendered >= total)
                {
                    //if they have enough money, calculate change amount
                    change = tendered - total;

                    changeOutput.Text = $"{change.ToString("C")}";
                    //enable receipt button
                    receiptButton.Enabled = true;
                }
                else
                {
                    //if they don't have enough money, tell them
                    errorPlayer.Play();

                    spacer.BackColor = Color.Red;
                    spacer.Text = "Insufficient funds";
                    Refresh();
                    Thread.Sleep(1000);
                    spacer.BackColor = Color.SeaShell;
                    spacer.Text = "";
                }
            }
            catch
            {
                //error handling
                spacer.BackColor = Color.Red;
                spacer.Text = "User Input Error";
                Refresh();
                Thread.Sleep(1000);
                spacer.BackColor = Color.SeaShell;
                spacer.Text = "";
            }
        }
        private void receiptButton_Click(object sender, EventArgs e)
        {
            //clear receipt label
            receiptLabel.Text = "";
            SoundPlayer printerPlayer = new SoundPlayer(Properties.Resources.printer);
            //create and play printer sounds
            printerPlayer.Play();
            
            wherppoamount = Convert.ToDouble(wherppoInput.Text);
            bingamount = Convert.ToDouble(bingInput.Text);
            kriesamount = Convert.ToDouble(kriesInput.Text);

            //disable receipt button
            receiptButton.Enabled = false;

            //show receipt lables
            receiptTitleLabel.Visible = true;
            receiptLabel.Visible = true;
            //enable new order button
            newOrderButton.Enabled = true;
            DateTime now = DateTime.Now;
            // get the date and time^

            //print receipt
            Thread.Sleep(400);
            receiptTitleLabel.Text = "KURGER BING";
            Refresh();
            Thread.Sleep(400);
            receiptLabel.Text = $"Order Number {ordernum}";
            Refresh();
            Thread.Sleep(400);
            receiptLabel.Text += $"\n{now}\n";
            Refresh();
            Thread.Sleep(400);
            //if no wherppos ordered, do not show line.
            if (wherppoamount > 0)
            {
                receiptLabel.Text += $"\nWherppo  x{wherppoamount} @ $5";
                Refresh();
                Thread.Sleep(400);
            }
            if (bingamount > 0)
            {
                receiptLabel.Text += $"\nBing Chiling  x{bingamount} @ $1";
                Refresh();
                Thread.Sleep(400);
            }
            if (kriesamount > 0)
            {
                receiptLabel.Text += $"\nKries  x{kriesamount} @ $2";
                Refresh();
                Thread.Sleep(400);
            }
            receiptLabel.Text += $"\n\nSubtotal         {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(400);
            receiptLabel.Text += $"\nTax              {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(400);
            receiptLabel.Text += $"\nTotal            {total.ToString("C")}";
            Refresh();
            Thread.Sleep(400);
            receiptLabel.Text += $"\n\nTendered         {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(400);
            receiptLabel.Text += $"\nChange           {change.ToString("C")}";
            Refresh();
            Thread.Sleep(1500);
            receiptLabel.Text += $"\n\nThanks for shopping at Kurger Bing!";
            ordernum = ordernum + 1;
            printerPlayer.Stop();

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
           //disable buttons
            changeButton.Enabled = false;
            newOrderButton.Enabled = false;

            //clear labels
            wherppoInput.Text = "0";
            bingInput.Text = "0";
            kriesInput.Text = "0";
            subTotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Text = "0";
            changeOutput.Text = "";
            receiptLabel.Text = "";
            receiptTitleLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
           //start timer
            animationTimer.Enabled = true;

            //clear screen
            logopic.Visible = false;
            imageborder.Visible = false;
            wherppoLabel.Visible = false;
            bingLabel.Visible = false;
            kriesLabel.Visible = false;
            wherppoInput.Visible = false;
            bingInput.Visible = false;
            kriesInput.Visible = false;
            totalsButton.Visible = false;
            subTotalLabel.Visible = false;
            subTotalOutput.Visible = false;
            taxLabel.Visible = false;
            taxOutput.Visible = false;
            totalLabel.Visible = false;
            totalOutput.Visible = false;
            spacer.Visible = false;
            tenderedLabel.Visible = false;
            tenderedInput.Visible = false;
            changeButton.Visible = false;
            changeLabel.Visible = false;
            changeOutput.Visible = false;
            receiptButton.Visible = false;
            receiptLabel.Visible = false;
            receiptTitleLabel.Visible = false;
            newOrderButton.Visible = false;
            //show loading screen
            burgerBox1.Visible = true;
        }

        //when timer ends, close program
        private void animationTimer_Tick(object sender, EventArgs e)
        { 
            Application.Exit();
        }
    }
}
