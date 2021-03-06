﻿/* Student Name: Varun Dua
 * Student ID: 19230587
 * Date: 25/10/2019
 * Assignment: 3
 * Assignment: Create a well-designed application for TeamBuilder Ltd, a company that provides team building
 * events in locations across Ireland. The purpose of your application is to enable the companies front of
 * house sales team to generate quotations and process bookings for these events.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*For Clear Event*/
        int Page;

        /*Event details, used in Display and Booking Events*/
        String[] Event = {"The Chase","The Great Outdoors","CSI Weekend","Murder Mystery Weekend","Digital Refresh"};
        String[] location = {"Belmullet","Cork","Galway","Dublin","Belfast"};
        String[] Options = { "Full Board", "Half Board", "Breakfast", "No Meal" };
        decimal[] EventCost = {1800,1500,1000,600,599};
        decimal[] LocationCost = { 305, 250, 225, 165, 95 };
        decimal[] OptionalCost = { 49.50m, 37.50m, 12, 0 };
        decimal CertificateCost = 9.95m;
        int Certificate = 0;                       //Flag to track Certificate option
        int[] EventDays = { 6, 4, 3, 2, 2 };       //Number of Days of Event
        int[] OptionCount = { 0, 0, 0, 0 };        //Option Value Count

        int OptionIndex;
        int EventIndex;
        int LocationIndex;
        decimal TotalCost = 0;


        /*For Summary Event*/
        int NumberOfEvents = 0;
        decimal TotalRegistrationCost = 0;
        decimal TotalLodgingCost = 0;
        decimal TotalOptionalCost = 0;
        decimal SummaryCosts = 0;
        decimal AverageRevenue = 0;

        /*For Login Event*/
        const String Password = "iLuvVisualC#";    
        int LoginCount = 0;

        /*Handler for Form Load*/
        private void Form1_Load(object sender, EventArgs e)
        {
            EventBox.Visible = false;
            LocationBox.Visible = false;
            MealBox.Visible = false;
            CertificateButton.Visible = false;
            DisplayButton.Visible = false;
            EventSelectionLabel.Visible = false;
            LocationSelectionLabel.Visible = false;
            BookingButton.Visible = false;
            EventBookingLabel.Visible = false;
            EventDetailLabel.Visible = false;
            LocationBookingLabel.Visible = false;
            LocationDetailLabel.Visible = false;
            OptionalBookingLabel.Visible = false;
            OptionalDetailLabel.Visible = false;
            TotalCostLabel.Visible = false;
            CostDetailLabel.Visible = false;
            DetailPanel.Visible = false;
            SummaryButton.Visible = false;
            NumberOfBookingLabel.Visible = false;
            PageLabel.ForeColor = Color.Green;
            Page = 1;
        }

        /*Login Button Event handler*/
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(PasswordBox.Text == Password && LoginCount<3)   //Password is correct and Number of attempts < 4
            {
                BackgroundImage = null; 
                LoginMessageLabel.Visible = false;
                PasswordLabel.Visible = false;
                PasswordBox.Visible = false;
                LoginPageLabel.Visible = false;
                LoginButton.Visible = false;
                EventBox.Visible = true;
                LocationBox.Visible = true;
                MealBox.Visible = true;
                CertificateButton.Visible = true;
                DisplayButton.Visible = true;
                EventSelectionLabel.Visible = true;
                LocationSelectionLabel.Visible = true;
                DetailPanel.Visible = true;
                BookingButton.Visible = true;
                BookingButton.Enabled = false;
                EventBookingLabel.Visible = true;
                EventDetailLabel.Visible = true;
                LocationBookingLabel.Visible = true;
                LocationDetailLabel.Visible = true;
                OptionalBookingLabel.Visible = true;
                OptionalDetailLabel.Visible = true;
                TotalCostLabel.Visible = true;
                CostDetailLabel.Visible = true;
                CertificateButton.Checked = false;
                SummaryButton.Visible = true;
                PageLabel.Text = "Event Booking";
                if(NumberOfEvents == 0)
                {
                    SummaryButton.Enabled = false;
                }
                else
                {
                    SummaryButton.Enabled = true;
                }
                EventBox.Select();
                Page = 2;
            }
            else if(LoginCount<3)               //Password is wrong, but the number of attampts < 4
            {
                String Message = "Incorrect Password.\n" + (4 - ++LoginCount) + " Chance/s left";
                MessageBox.Show(Message);
                LoginMessageLabel.Text = Message;
                LoginMessageLabel.ForeColor = Color.Red;
                PasswordBox.Select();
                PasswordBox.SelectAll();
            }
            else
            {
                MessageBox.Show(" Wrong Password entered 4 times. Quiting application.", "Incorrect Attempts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {

            decimal SumOptionCost = 0;                       //To calculate sum of Optional and Certificate Costs
                      
            if(EventBox.SelectedIndex != -1)                 //Handling No selections in Event Box
            {
                
                if (LocationBox.SelectedIndex != -1)        //Handling No selections in Location Box
                {
                    
                    BookingButton.Enabled = true;
                    if (NumberOfEvents == 0)
                    {
                        SummaryButton.Enabled = false;
                    }
                    else
                    {
                        SummaryButton.Enabled = true;
                    }

                    if (FullBoardButton.Checked == true)
                    {
                        OptionIndex = 0;                        
                    }
                    else if (HalfBoardButton.Checked == true)
                    {
                        OptionIndex = 1;                        
                    }
                    else if (BreakfastButton.Checked == true)
                    {
                        OptionIndex = 2;                        
                    }
                    else
                    {
                        OptionIndex = 3;
                    }

                    EventIndex = EventBox.SelectedIndex;
                    EventDetailLabel.Text = Event[EventIndex];
                                                         
                    LocationIndex = LocationBox.SelectedIndex;
                    LocationDetailLabel.Text = location[LocationIndex] + ", Total Lodging Cost:" + LocationCost[LocationIndex] * EventDays[EventIndex];
                            
                    if (CertificateButton.Checked == true)
                    {
                        SumOptionCost = (OptionalCost[OptionIndex] * EventDays[EventIndex]) + CertificateCost;
                        Certificate = 1;
                    }
                    else
                    {
                        SumOptionCost = (OptionalCost[OptionIndex] * EventDays[EventIndex]);
                        Certificate = 0;
                    }

                    TotalCost = EventCost[EventIndex] + (LocationCost[LocationIndex] * EventDays[EventIndex]) + SumOptionCost;
                    

                    if (Certificate == 1)
                    {

                        OptionalDetailLabel.Text = Options[OptionIndex] + ", " + "Printed Certificate, Costs: " + SumOptionCost.ToString("C");
                        
                    }
                    else
                    {
                        OptionalDetailLabel.Text = Options[OptionIndex] + ", " + " Costs: " + SumOptionCost.ToString("C");
                    }
                    CostsLabel.Text = "Event Cost: " + EventCost[EventIndex] + ", Lodging Costs: " + (LocationCost[LocationIndex] * EventDays[EventIndex]) + ", Optional Costs: " + SumOptionCost;
                    CostDetailLabel.Text = TotalCost.ToString("C");
                }
                else
                {
                    MessageBox.Show("Please select a Location", "Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an Event", "Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        /*Booking button handler*/
        private void BookingButton_Click(object sender, EventArgs e)
        {

            String Confirm = String.Format("Confirm Booking? \nDetails:\nEvent: {0} \nLocation: {1} \nTotal costs: {2:C}", Event[EventIndex], location[LocationIndex], TotalCost);

            /*Option to confirm booking through OK button, or cancel and go back to Display*/

            DialogResult result = MessageBox.Show(Confirm, "Confirm Booking?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                NumberOfEvents++;
                TotalRegistrationCost += EventCost[EventIndex];
                TotalLodgingCost += (LocationCost[LocationIndex] * EventDays[EventIndex]);
                if(Certificate == 1)
                {
                    TotalOptionalCost += (OptionalCost[OptionIndex] * EventDays[EventIndex]) + CertificateCost;
                }
                else
                {
                    TotalOptionalCost += OptionalCost[OptionIndex] * EventDays[EventIndex];
                }
                
                SummaryCosts += TotalCost;
                AverageRevenue = SummaryCosts / NumberOfEvents;
                SummaryButton.Enabled = true;
                OptionCount[OptionIndex]++;

                BookingButton.Enabled = false;

                EventBox.ClearSelected();
                LocationBox.ClearSelected();
                FullBoardButton.Checked = false;
                HalfBoardButton.Checked = false;
                BreakfastButton.Checked = false;
                CertificateButton.Checked = false;
                EventDetailLabel.Text = "";
                LocationDetailLabel.Text = "";
                OptionalDetailLabel.Text = "";
                CostDetailLabel.Text = "";
                CostsLabel.Text = "";
            }
            else
            {
                BookingButton.Enabled = false;
                EventBox.Select();
            }
            
        }

        /*Summary Button Event Handler*/
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            PageLabel.Text = "Company Summary";
            NumberOfBookingLabel.Visible = true;
            BookingButton.Enabled = false;
            DisplayButton.Enabled = false;
            EventSelectionLabel.Visible = false;
            LocationSelectionLabel.Visible = false;
            EventBox.Visible = false;
            LocationBox.Visible = false;
            MealBox.Visible = false;
            CertificateButton.Visible = false;
            EventBookingLabel.Text = "Total Registration Costs";
            LocationBookingLabel.Text = "Total Lodging Costs";
            OptionalBookingLabel.Text = "Total Optional Costs";
            TotalCostLabel.Text = "Average Revenue/booking";
            NumberOfBookingLabel.Text = "Number of Bookings:\n"+ NumberOfEvents.ToString();
            EventDetailLabel.Text = TotalRegistrationCost.ToString("C");
            LocationDetailLabel.Text = TotalLodgingCost.ToString("C");
            OptionalDetailLabel.Text = TotalOptionalCost.ToString("C");
            CostDetailLabel.Text = AverageRevenue.ToString("C");
            CostsLabel.Text = "Breakfast: " + OptionCount[2] + ", Half Board: " + OptionCount[1] + ", Full Board: " + OptionCount[0];
            Page = 3;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            /*Page 1 is Login Page, before Login button is clicked. Clear button clears the Password Text Box on this page.*/

            if(Page == 1)          
            {
                PasswordBox.Text = "";
            }
            
            /*Page 2 is the Event Display Page. Clear button clears the selections and Displayed items on this page.*/
            else if(Page == 2)
            {
                EventBox.ClearSelected();
                LocationBox.ClearSelected();
                FullBoardButton.Checked = false;
                HalfBoardButton.Checked = false;
                BreakfastButton.Checked = false;
                CertificateButton.Checked = false;
                EventDetailLabel.Text = "";
                LocationDetailLabel.Text = "";
                OptionalDetailLabel.Text = "";
                CostDetailLabel.Text = "";
                CostsLabel.Text = "";
                BookingButton.Enabled = false;
            }

            /*Page 3 is Summary Page. Clear button clears the Summary, and Displays Event Booking page again.*/
            else if(Page == 3)
            {
                EventBox.ClearSelected();
                LocationBox.ClearSelected();
                FullBoardButton.Checked = false;
                HalfBoardButton.Checked = false;
                BreakfastButton.Checked = false;
                CertificateButton.Checked = false;
                EventDetailLabel.Text = "";
                LocationDetailLabel.Text = "";
                OptionalDetailLabel.Text = "";
                CostDetailLabel.Text = "";
                CostsLabel.Text = "";
                EventBox.Visible = true;
                LocationBox.Visible = true;
                MealBox.Visible = true;
                CertificateButton.Visible = true;
                DisplayButton.Visible = true;
                EventSelectionLabel.Visible = true;
                LocationSelectionLabel.Visible = true;
                DetailPanel.Visible = true;
                BookingButton.Visible = true;
                BookingButton.Enabled = false;
                EventBookingLabel.Visible = true;
                EventDetailLabel.Visible = true;
                LocationBookingLabel.Visible = true;
                LocationDetailLabel.Visible = true;
                OptionalBookingLabel.Visible = true;
                OptionalDetailLabel.Visible = true;
                TotalCostLabel.Visible = true;
                CostDetailLabel.Visible = true;
                CertificateButton.Checked = false;
                NumberOfBookingLabel.Visible = false;
                DisplayButton.Enabled = true;
                SummaryButton.Visible = true;
                PageLabel.Text = "Event Booking";
                EventBookingLabel.Text = "Event :";
                LocationBookingLabel.Text = "Location :";
                OptionalBookingLabel.Text = "Add on Selections :";
                TotalCostLabel.Text = "Total Costs :";
                if (NumberOfEvents == 0)
                {
                    SummaryButton.Enabled = false;
                }
                else
                {
                    SummaryButton.Enabled = true;
                }
                EventBox.Select();
                Page = 2;
            }
        }

        /*Exit button Event Handler*/
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

