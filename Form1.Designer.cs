namespace Assignment_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginPageLabel = new System.Windows.Forms.Label();
            this.LoginMessageLabel = new System.Windows.Forms.Label();
            this.EventBox = new System.Windows.Forms.ListBox();
            this.LocationBox = new System.Windows.Forms.ListBox();
            this.MealBox = new System.Windows.Forms.GroupBox();
            this.BreakfastButton = new System.Windows.Forms.RadioButton();
            this.HalfBoardButton = new System.Windows.Forms.RadioButton();
            this.FullBoardButton = new System.Windows.Forms.RadioButton();
            this.CertificateButton = new System.Windows.Forms.CheckBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.EventSelectionLabel = new System.Windows.Forms.Label();
            this.LocationSelectionLabel = new System.Windows.Forms.Label();
            this.BookingButton = new System.Windows.Forms.Button();
            this.EventBookingLabel = new System.Windows.Forms.Label();
            this.LocationBookingLabel = new System.Windows.Forms.Label();
            this.OptionalBookingLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.EventDetailLabel = new System.Windows.Forms.Label();
            this.LocationDetailLabel = new System.Windows.Forms.Label();
            this.OptionalDetailLabel = new System.Windows.Forms.Label();
            this.CostDetailLabel = new System.Windows.Forms.Label();
            this.DetailPanel = new System.Windows.Forms.Panel();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.NumberOfBookingLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CostsLabel = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.MealBox.SuspendLayout();
            this.DetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(849, 249);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(115, 35);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "&Login";
            this.toolTip1.SetToolTip(this.LoginButton, "Click to Login");
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(879, 425);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(115, 35);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.ClearButton, "Click to Clear");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(879, 483);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(115, 35);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Exit");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(788, 145);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(176, 22);
            this.PasswordBox.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(873, 99);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginPageLabel
            // 
            this.LoginPageLabel.AutoSize = true;
            this.LoginPageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.LoginPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPageLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoginPageLabel.Location = new System.Drawing.Point(738, 62);
            this.LoginPageLabel.Name = "LoginPageLabel";
            this.LoginPageLabel.Size = new System.Drawing.Size(205, 20);
            this.LoginPageLabel.TabIndex = 1;
            this.LoginPageLabel.Text = "Please Enter Password";
            // 
            // LoginMessageLabel
            // 
            this.LoginMessageLabel.AutoSize = true;
            this.LoginMessageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.LoginMessageLabel.Location = new System.Drawing.Point(785, 195);
            this.LoginMessageLabel.Name = "LoginMessageLabel";
            this.LoginMessageLabel.Size = new System.Drawing.Size(0, 17);
            this.LoginMessageLabel.TabIndex = 1;
            // 
            // EventBox
            // 
            this.EventBox.BackColor = System.Drawing.SystemColors.Menu;
            this.EventBox.FormattingEnabled = true;
            this.EventBox.ItemHeight = 16;
            this.EventBox.Items.AddRange(new object[] {
            "  6 Days             €1800               The Chase                ",
            "  4 Days             €1500               The Great Outdoors",
            "  3 Days             €1000               CSI Weekend",
            "  2 Days             €  600               Murder Mystery Weekend",
            "  2 Days             €  599               Digital Refresh"});
            this.EventBox.Location = new System.Drawing.Point(40, 52);
            this.EventBox.Name = "EventBox";
            this.EventBox.Size = new System.Drawing.Size(349, 84);
            this.EventBox.TabIndex = 5;
            // 
            // LocationBox
            // 
            this.LocationBox.BackColor = System.Drawing.SystemColors.Menu;
            this.LocationBox.FormattingEnabled = true;
            this.LocationBox.ItemHeight = 16;
            this.LocationBox.Items.AddRange(new object[] {
            "      €305                                        Belmullet",
            "      €250                                        Cork",
            "      €225                                        Galway ",
            "      €165                                        Dublin",
            "      €95                                          Belfast"});
            this.LocationBox.Location = new System.Drawing.Point(40, 170);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(349, 84);
            this.LocationBox.TabIndex = 6;
            // 
            // MealBox
            // 
            this.MealBox.Controls.Add(this.BreakfastButton);
            this.MealBox.Controls.Add(this.HalfBoardButton);
            this.MealBox.Controls.Add(this.FullBoardButton);
            this.MealBox.Location = new System.Drawing.Point(40, 276);
            this.MealBox.Name = "MealBox";
            this.MealBox.Size = new System.Drawing.Size(244, 110);
            this.MealBox.TabIndex = 7;
            this.MealBox.TabStop = false;
            this.MealBox.Text = "Meal Options";
            // 
            // BreakfastButton
            // 
            this.BreakfastButton.AutoSize = true;
            this.BreakfastButton.Location = new System.Drawing.Point(7, 78);
            this.BreakfastButton.Name = "BreakfastButton";
            this.BreakfastButton.Size = new System.Drawing.Size(127, 21);
            this.BreakfastButton.TabIndex = 2;
            this.BreakfastButton.TabStop = true;
            this.BreakfastButton.Text = "Breakfast (€12)";
            this.BreakfastButton.UseVisualStyleBackColor = true;
            // 
            // HalfBoardButton
            // 
            this.HalfBoardButton.AutoSize = true;
            this.HalfBoardButton.Location = new System.Drawing.Point(7, 50);
            this.HalfBoardButton.Name = "HalfBoardButton";
            this.HalfBoardButton.Size = new System.Drawing.Size(154, 21);
            this.HalfBoardButton.TabIndex = 1;
            this.HalfBoardButton.TabStop = true;
            this.HalfBoardButton.Text = "Half Board (€37.50)";
            this.HalfBoardButton.UseVisualStyleBackColor = true;
            // 
            // FullBoardButton
            // 
            this.FullBoardButton.AutoSize = true;
            this.FullBoardButton.Location = new System.Drawing.Point(7, 22);
            this.FullBoardButton.Name = "FullBoardButton";
            this.FullBoardButton.Size = new System.Drawing.Size(151, 21);
            this.FullBoardButton.TabIndex = 0;
            this.FullBoardButton.TabStop = true;
            this.FullBoardButton.Text = "Full Board (€49.50)";
            this.FullBoardButton.UseVisualStyleBackColor = true;
            // 
            // CertificateButton
            // 
            this.CertificateButton.AutoSize = true;
            this.CertificateButton.Location = new System.Drawing.Point(40, 433);
            this.CertificateButton.Name = "CertificateButton";
            this.CertificateButton.Size = new System.Drawing.Size(244, 21);
            this.CertificateButton.TabIndex = 8;
            this.CertificateButton.Text = "I want a Printed Certificate (€9.95)";
            this.CertificateButton.UseVisualStyleBackColor = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(40, 483);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(106, 35);
            this.DisplayButton.TabIndex = 9;
            this.DisplayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.DisplayButton, "Display Event Details");
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // EventSelectionLabel
            // 
            this.EventSelectionLabel.AutoSize = true;
            this.EventSelectionLabel.Location = new System.Drawing.Point(37, 29);
            this.EventSelectionLabel.Name = "EventSelectionLabel";
            this.EventSelectionLabel.Size = new System.Drawing.Size(51, 17);
            this.EventSelectionLabel.TabIndex = 12;
            this.EventSelectionLabel.Text = "Events";
            // 
            // LocationSelectionLabel
            // 
            this.LocationSelectionLabel.AutoSize = true;
            this.LocationSelectionLabel.Location = new System.Drawing.Point(37, 148);
            this.LocationSelectionLabel.Name = "LocationSelectionLabel";
            this.LocationSelectionLabel.Size = new System.Drawing.Size(69, 17);
            this.LocationSelectionLabel.TabIndex = 13;
            this.LocationSelectionLabel.Text = "Locations";
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(879, 367);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(115, 35);
            this.BookingButton.TabIndex = 14;
            this.BookingButton.Text = "&Book";
            this.toolTip1.SetToolTip(this.BookingButton, "Click to Book Event");
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // EventBookingLabel
            // 
            this.EventBookingLabel.AutoSize = true;
            this.EventBookingLabel.Location = new System.Drawing.Point(6, 25);
            this.EventBookingLabel.Name = "EventBookingLabel";
            this.EventBookingLabel.Size = new System.Drawing.Size(56, 17);
            this.EventBookingLabel.TabIndex = 15;
            this.EventBookingLabel.Text = "Event : ";
            this.EventBookingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationBookingLabel
            // 
            this.LocationBookingLabel.AutoSize = true;
            this.LocationBookingLabel.Location = new System.Drawing.Point(6, 88);
            this.LocationBookingLabel.Name = "LocationBookingLabel";
            this.LocationBookingLabel.Size = new System.Drawing.Size(74, 17);
            this.LocationBookingLabel.TabIndex = 16;
            this.LocationBookingLabel.Text = "Location : ";
            this.LocationBookingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionalBookingLabel
            // 
            this.OptionalBookingLabel.AutoSize = true;
            this.OptionalBookingLabel.Location = new System.Drawing.Point(6, 149);
            this.OptionalBookingLabel.Name = "OptionalBookingLabel";
            this.OptionalBookingLabel.Size = new System.Drawing.Size(134, 17);
            this.OptionalBookingLabel.TabIndex = 17;
            this.OptionalBookingLabel.Text = "Add on Selections : ";
            this.OptionalBookingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(6, 240);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(91, 17);
            this.TotalCostLabel.TabIndex = 18;
            this.TotalCostLabel.Text = "Total Costs : ";
            this.TotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventDetailLabel
            // 
            this.EventDetailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventDetailLabel.Location = new System.Drawing.Point(226, 24);
            this.EventDetailLabel.Name = "EventDetailLabel";
            this.EventDetailLabel.Size = new System.Drawing.Size(322, 23);
            this.EventDetailLabel.TabIndex = 19;
            this.EventDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocationDetailLabel
            // 
            this.LocationDetailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationDetailLabel.Location = new System.Drawing.Point(226, 87);
            this.LocationDetailLabel.Name = "LocationDetailLabel";
            this.LocationDetailLabel.Size = new System.Drawing.Size(322, 23);
            this.LocationDetailLabel.TabIndex = 20;
            this.LocationDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionalDetailLabel
            // 
            this.OptionalDetailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionalDetailLabel.Location = new System.Drawing.Point(226, 148);
            this.OptionalDetailLabel.Name = "OptionalDetailLabel";
            this.OptionalDetailLabel.Size = new System.Drawing.Size(322, 23);
            this.OptionalDetailLabel.TabIndex = 21;
            this.OptionalDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostDetailLabel
            // 
            this.CostDetailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostDetailLabel.Location = new System.Drawing.Point(226, 239);
            this.CostDetailLabel.Name = "CostDetailLabel";
            this.CostDetailLabel.Size = new System.Drawing.Size(322, 23);
            this.CostDetailLabel.TabIndex = 22;
            this.CostDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailPanel
            // 
            this.DetailPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DetailPanel.Controls.Add(this.CostsLabel);
            this.DetailPanel.Controls.Add(this.EventBookingLabel);
            this.DetailPanel.Controls.Add(this.CostDetailLabel);
            this.DetailPanel.Controls.Add(this.EventDetailLabel);
            this.DetailPanel.Controls.Add(this.TotalCostLabel);
            this.DetailPanel.Controls.Add(this.OptionalDetailLabel);
            this.DetailPanel.Controls.Add(this.OptionalBookingLabel);
            this.DetailPanel.Controls.Add(this.LocationDetailLabel);
            this.DetailPanel.Controls.Add(this.LocationBookingLabel);
            this.DetailPanel.Location = new System.Drawing.Point(416, 29);
            this.DetailPanel.Name = "DetailPanel";
            this.DetailPanel.Size = new System.Drawing.Size(564, 285);
            this.DetailPanel.TabIndex = 23;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(416, 483);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(167, 35);
            this.SummaryButton.TabIndex = 24;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Click to get Summary of Bookings");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // NumberOfBookingLabel
            // 
            this.NumberOfBookingLabel.AutoSize = true;
            this.NumberOfBookingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfBookingLabel.Location = new System.Drawing.Point(106, 168);
            this.NumberOfBookingLabel.Name = "NumberOfBookingLabel";
            this.NumberOfBookingLabel.Size = new System.Drawing.Size(0, 29);
            this.NumberOfBookingLabel.TabIndex = 25;
            this.NumberOfBookingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // CostsLabel
            // 
            this.CostsLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CostsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostsLabel.Location = new System.Drawing.Point(37, 200);
            this.CostsLabel.Name = "CostsLabel";
            this.CostsLabel.Size = new System.Drawing.Size(500, 17);
            this.CostsLabel.TabIndex = 23;
            this.CostsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.Location = new System.Drawing.Point(411, 346);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(122, 29);
            this.PageLabel.TabIndex = 26;
            this.PageLabel.Text = "Welcome";
            this.PageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_3.Properties.Resources.TeamBuilderLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 555);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.NumberOfBookingLabel);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.DetailPanel);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.LocationSelectionLabel);
            this.Controls.Add(this.EventSelectionLabel);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.CertificateButton);
            this.Controls.Add(this.MealBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.EventBox);
            this.Controls.Add(this.LoginMessageLabel);
            this.Controls.Add(this.LoginPageLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoginButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MealBox.ResumeLayout(false);
            this.MealBox.PerformLayout();
            this.DetailPanel.ResumeLayout(false);
            this.DetailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginPageLabel;
        private System.Windows.Forms.Label LoginMessageLabel;
        private System.Windows.Forms.ListBox EventBox;
        private System.Windows.Forms.ListBox LocationBox;
        private System.Windows.Forms.GroupBox MealBox;
        private System.Windows.Forms.RadioButton BreakfastButton;
        private System.Windows.Forms.RadioButton HalfBoardButton;
        private System.Windows.Forms.RadioButton FullBoardButton;
        private System.Windows.Forms.CheckBox CertificateButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label EventSelectionLabel;
        private System.Windows.Forms.Label LocationSelectionLabel;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Label EventBookingLabel;
        private System.Windows.Forms.Label LocationBookingLabel;
        private System.Windows.Forms.Label OptionalBookingLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label EventDetailLabel;
        private System.Windows.Forms.Label LocationDetailLabel;
        private System.Windows.Forms.Label OptionalDetailLabel;
        private System.Windows.Forms.Label CostDetailLabel;
        private System.Windows.Forms.Panel DetailPanel;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Label NumberOfBookingLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label CostsLabel;
        private System.Windows.Forms.Label PageLabel;
    }
}

