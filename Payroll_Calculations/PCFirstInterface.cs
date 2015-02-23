//Name= Erick Silva
//e-mail= ericksilva@csu.fullerton.edu
//Course = CPSC 223N
//Assignment #2
//Due date: February 26, 2015

using System;
using System.Windows.Forms;
using System.Drawing;

public class PCFirstInterface : Form
{
	private Label title;
	private Label firstname;
	private Label secondname;
	private Label hoursworked;
	private Label payrate;
	private Label dependents;
	private Label healthplan;
	private Button computebutton;
	private Button clearbutton;
	private Button exitbutton;
	private TextBox firstnameinput;
	private TextBox secondnameinput;
	private TextBox hoursWorkedInput;
	private TextBox payRateInput;
	private ComboBox dependentsComboBox;
	private RadioButton yesRadioButton;
	private RadioButton noRadioButton;
	private GroupBox groupBox1;
	private Label label1;
	private Label name;
	private Label regularPay;
	private Label overtimePay;
	private Label grossPay;
	private Label withholdTax;
	private Label health;
	private Label socialSecurity;
	private Label netPay;
	private Label netPayOutput;
	private Label socialSecutiryOutput;
	private Label healthOutput;
	private Label withholdTaxOutput;
	private Label grossPayOutput;
	private Label overtimePayOutput;
	private Label regularPayOutput;
	private Label nameOutput;

	public PCFirstInterface ()
	{
		title = new Label();
		firstname = new Label();
		secondname = new Label();
		hoursworked = new Label();
		payrate = new Label();
		dependents = new Label();
		healthplan = new Label();
		computebutton = new Button();
		clearbutton = new Button();
		exitbutton = new Button();
		firstnameinput = new TextBox();
		secondnameinput = new TextBox();
		hoursWorkedInput = new TextBox();
		payRateInput = new TextBox();
		dependentsComboBox = new ComboBox();
		yesRadioButton = new RadioButton();
		noRadioButton = new RadioButton();
		groupBox1 = new GroupBox();
		label1 = new Label();
		name = new Label();
		regularPay = new Label();
		overtimePay = new Label();
		grossPay = new Label();
		withholdTax = new Label();
		health = new Label();
		socialSecurity = new Label();
		netPay = new Label();
		netPayOutput = new Label();
		socialSecutiryOutput = new Label();
		healthOutput = new Label();
		withholdTaxOutput = new Label();
		grossPayOutput = new Label();
		overtimePayOutput = new Label();
		regularPayOutput = new Label();
		nameOutput = new Label();

		Size = new Size (580, 700);
		// 
		// title
		// 
		title.Anchor = AnchorStyles.Top;
		title.AutoSize = true;
		title.Location = new System.Drawing.Point(201, 23);
		title.Name = "title";
		title.Size = new System.Drawing.Size(146, 13);
		title.TabIndex = 0;
		title.Text = "Erick Silva Enterprises Payroll";
		// 
		// firstname
		// 
		firstname.AutoSize = true;
		firstname.Location = new System.Drawing.Point(36, 70);
		firstname.Name = "firstname";
		firstname.Size = new System.Drawing.Size(60, 13);
		firstname.TabIndex = 1;
		firstname.Text = "First Name:";
		// 
		// secondname
		// 
		secondname.AutoSize = true;
		secondname.Location = new System.Drawing.Point(253, 70);
		secondname.Name = "secondname";
		secondname.Size = new System.Drawing.Size(78, 13);
		secondname.TabIndex = 2;
		secondname.Text = "Second Name:";
		// 
		// hoursworked
		// 
		hoursworked.AutoSize = true;
		hoursworked.Location = new System.Drawing.Point(36, 114);
		hoursworked.Name = "hoursworked";
		hoursworked.Size = new System.Drawing.Size(76, 13);
		hoursworked.TabIndex = 3;
		hoursworked.Text = "Hours Worked";
		// 
		// payrate
		// 
		payrate.AutoSize = true;
		payrate.Location = new System.Drawing.Point(36, 149);
		payrate.Name = "payrate";
		payrate.Size = new System.Drawing.Size(51, 13);
		payrate.TabIndex = 4;
		payrate.Text = "Pay Rate";
		// 
		// dependents
		// 
		dependents.AutoSize = true;
		dependents.Location = new System.Drawing.Point(36, 179);
		dependents.Name = "dependents";
		dependents.Size = new System.Drawing.Size(65, 13);
		dependents.TabIndex = 5;
		dependents.Text = "Dependents";
		// 
		// healthplan
		// 
		healthplan.AutoSize = true;
		healthplan.Location = new System.Drawing.Point(36, 225);
		healthplan.Name = "healthplan";
		healthplan.Size = new System.Drawing.Size(62, 13);
		healthplan.TabIndex = 6;
		healthplan.Text = "Health Plan";
		// 
		// computebutton
		// 
		computebutton.Cursor = System.Windows.Forms.Cursors.Hand;
		computebutton.Location = new System.Drawing.Point(92, 591);
		computebutton.Name = "computebutton";
		computebutton.Size = new System.Drawing.Size(90, 23);
		computebutton.TabIndex = 7;
		computebutton.Text = "Compute Pay";
		// 
		// clearbutton
		// 
		clearbutton.Cursor = System.Windows.Forms.Cursors.Hand;
		clearbutton.Location = new System.Drawing.Point(228, 591);
		clearbutton.Name = "clearbutton";
		clearbutton.Size = new System.Drawing.Size(90, 23);
		clearbutton.TabIndex = 8;
		clearbutton.Text = "Clear";

		// 
		// exitbutton
		//
		exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
		exitbutton.Location = new System.Drawing.Point(372, 591);
		exitbutton.Name = "exitbutton";
		exitbutton.Size = new System.Drawing.Size(90, 23);
		exitbutton.TabIndex = 9;
		exitbutton.Text = "Exit";
		// 
		// firstnameinput
		// 
		firstnameinput.Location = new System.Drawing.Point(100, 67);
		firstnameinput.Name = "firstnameinput";
		firstnameinput.Size = new System.Drawing.Size(140, 20);
		firstnameinput.TabIndex = 10;
		// 
		// secondnameinput
		// 
		secondnameinput.Location = new System.Drawing.Point(337, 67);
		secondnameinput.Name = "secondnameinput";
		secondnameinput.Size = new System.Drawing.Size(166, 20);
		secondnameinput.TabIndex = 11;
		// 
		// hoursWorkedInput
		// 
		hoursWorkedInput.Location = new System.Drawing.Point(138, 111);
		hoursWorkedInput.Name = "hoursWorkedInput";
		hoursWorkedInput.Size = new System.Drawing.Size(365, 20);
		hoursWorkedInput.TabIndex = 12;
		// 
		// payRateInput
		// 
		payRateInput.Location = new System.Drawing.Point(138, 146);
		payRateInput.Name = "payRateInput";
		payRateInput.Size = new System.Drawing.Size(365, 20);
		payRateInput.TabIndex = 13;
		// 
		// dependentsComboBox
		// 
		dependentsComboBox.FormattingEnabled = true;
		dependentsComboBox.Items.AddRange(new object[] {
			"0","1","2","3","4","5","6","7","8","9"});
		dependentsComboBox.Location = new System.Drawing.Point(138, 179);
		dependentsComboBox.Name = "dependentsComboBox";
		dependentsComboBox.Size = new System.Drawing.Size(365, 21);
		dependentsComboBox.TabIndex = 14;
		// 
		// yesRadioButton
		// 
		yesRadioButton.AutoSize = true;
		yesRadioButton.Location = new System.Drawing.Point(6, 19);
		yesRadioButton.Name = "yesRadioButton";
		yesRadioButton.RightToLeft = RightToLeft.Yes;
		yesRadioButton.Size = new System.Drawing.Size(43, 17);
		yesRadioButton.TabIndex = 15;
		yesRadioButton.TabStop = true;
		yesRadioButton.Text = "Yes";
		yesRadioButton.UseVisualStyleBackColor = true;
		yesRadioButton.Checked = false;
		// 
		// noRadioButton
		// 
		noRadioButton.AutoSize = true;
		noRadioButton.Location = new System.Drawing.Point(109, 19);
		noRadioButton.Name = "noRadioButton";
		noRadioButton.RightToLeft = RightToLeft.Yes;
		noRadioButton.Size = new System.Drawing.Size(39, 17);
		noRadioButton.TabIndex = 16;
		noRadioButton.TabStop = true;
		noRadioButton.Text = "No";
		noRadioButton.UseVisualStyleBackColor = true;
		noRadioButton.Checked = true;
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(noRadioButton);
		groupBox1.Controls.Add(yesRadioButton);
		groupBox1.Location = new System.Drawing.Point(138, 206);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(165, 42);
		groupBox1.TabIndex = 17;
		groupBox1.TabStop = false;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(36, 272);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(475, 13);
		label1.TabIndex = 18;
		label1.Text = "*********************************************************************************" +
			"************************************";
		// 
		// name
		// 
		name.AutoSize = true;
		name.Location = new System.Drawing.Point(36, 312);
		name.Name = "name";
		name.Size = new System.Drawing.Size(38, 13);
		name.TabIndex = 19;
		name.Text = "Name:";
		// 
		// regularPay
		// 
		regularPay.AutoSize = true;
		regularPay.Location = new System.Drawing.Point(36, 349);
		regularPay.Name = "regularPay";
		regularPay.Size = new System.Drawing.Size(68, 13);
		regularPay.TabIndex = 20;
		regularPay.Text = "Regular Pay:";
		// 
		// overtimePay
		// 
		overtimePay.AutoSize = true;
		overtimePay.Location = new System.Drawing.Point(36, 386);
		overtimePay.Name = "overtimePay";
		overtimePay.Size = new System.Drawing.Size(73, 13);
		overtimePay.TabIndex = 21;
		overtimePay.Text = "Overtime Pay:";
		// 
		// grossPay
		// 
		grossPay.AutoSize = true;
		grossPay.Location = new System.Drawing.Point(36, 421);
		grossPay.Name = "grossPay";
		grossPay.Size = new System.Drawing.Size(58, 13);
		grossPay.TabIndex = 22;
		grossPay.Text = "Gross Pay:";
		// 
		// withholdTax
		// 
		withholdTax.AutoSize = true;
		withholdTax.Location = new System.Drawing.Point(36, 454);
		withholdTax.Name = "withholdTax";
		withholdTax.Size = new System.Drawing.Size(69, 13);
		withholdTax.TabIndex = 23;
		withholdTax.Text = "Withhold tax:";
		// 
		// health
		// 
		health.AutoSize = true;
		health.Location = new System.Drawing.Point(36, 482);
		health.Name = "health";
		health.Size = new System.Drawing.Size(41, 13);
		health.TabIndex = 24;
		health.Text = "Health:";
		// 
		// socialSecurity
		// 
		socialSecurity.AutoSize = true;
		socialSecurity.Location = new System.Drawing.Point(36, 511);
		socialSecurity.Name = "socialSecurity";
		socialSecurity.Size = new System.Drawing.Size(80, 13);
		socialSecurity.TabIndex = 25;
		socialSecurity.Text = "Social Security:";
		// 
		// netPay
		// 
		netPay.AutoSize = true;
		netPay.Location = new System.Drawing.Point(36, 543);
		netPay.Name = "netPay";
		netPay.Size = new System.Drawing.Size(47, 13);
		netPay.TabIndex = 26;
		netPay.Text = "Net pay:";
		// 
		// netPayOutput
		// 
		netPayOutput.AutoSize = true;
		netPayOutput.Location = new System.Drawing.Point(126, 543);
		netPayOutput.Name = "netPayOutput";
		netPayOutput.Size = new System.Drawing.Size(10, 13);
		netPayOutput.TabIndex = 34;
		netPayOutput.Text = ".";
		// 
		// socialSecutiryOutput
		// 
		socialSecutiryOutput.AutoSize = true;
		socialSecutiryOutput.Location = new System.Drawing.Point(126, 511);
		socialSecutiryOutput.Name = "socialSecutiryOutput";
		socialSecutiryOutput.Size = new System.Drawing.Size(10, 13);
		socialSecutiryOutput.TabIndex = 33;
		socialSecutiryOutput.Text = ".";
		// 
		// healthOutput
		// 
		healthOutput.AutoSize = true;
		healthOutput.Location = new System.Drawing.Point(126, 482);
		healthOutput.Name = "healthOutput";
		healthOutput.Size = new System.Drawing.Size(10, 13);
		healthOutput.TabIndex = 32;
		healthOutput.Text = ".";
		// 
		// withholdTaxOutput
		// 
		withholdTaxOutput.AutoSize = true;
		withholdTaxOutput.Location = new System.Drawing.Point(126, 454);
		withholdTaxOutput.Name = "withholdTaxOutput";
		withholdTaxOutput.Size = new System.Drawing.Size(10, 13);
		withholdTaxOutput.TabIndex = 31;
		withholdTaxOutput.Text = ".";
		withholdTaxOutput.UseMnemonic = false;
		// 
		// grossPayOutput
		// 
		grossPayOutput.AutoSize = true;
		grossPayOutput.Location = new System.Drawing.Point(126, 421);
		grossPayOutput.Name = "grossPayOutput";
		grossPayOutput.Size = new System.Drawing.Size(10, 13);
		grossPayOutput.TabIndex = 30;
		grossPayOutput.Text = ".";
		// 
		// overtimePayOutput
		// 
		overtimePayOutput.AutoSize = true;
		overtimePayOutput.Location = new System.Drawing.Point(126, 386);
		overtimePayOutput.Name = "overtimePayOutput";
		overtimePayOutput.Size = new System.Drawing.Size(10, 13);
		overtimePayOutput.TabIndex = 29;
		overtimePayOutput.Text = ".";
		// 
		// regularPayOutput
		// 
		regularPayOutput.AutoSize = true;
		regularPayOutput.Location = new System.Drawing.Point(126, 349);
		regularPayOutput.Name = "regularPayOutput";
		regularPayOutput.Size = new System.Drawing.Size(10, 13);
		regularPayOutput.TabIndex = 28;
		regularPayOutput.Text = ".";
		// 
		// nameOutput
		// 
		nameOutput.AutoSize = true;
		nameOutput.Location = new System.Drawing.Point(126, 312);
		nameOutput.Name = "nameOutput";
		nameOutput.Size = new System.Drawing.Size(10, 13);
		nameOutput.TabIndex = 27;
		nameOutput.Text = ".";
		// 
		// Form1
		// 

		//Associate the Compute button with the Enter key of the keyboard
		AcceptButton = computebutton;
		//Assciate the Exit Button with the ESC key
		CancelButton = exitbutton;

		Controls.Add(netPayOutput);
		Controls.Add(socialSecutiryOutput);
		Controls.Add(healthOutput);
		Controls.Add(withholdTaxOutput);
		Controls.Add(grossPayOutput);
		Controls.Add(overtimePayOutput);
		Controls.Add(regularPayOutput);
		Controls.Add(nameOutput);
		Controls.Add(netPay);
		Controls.Add(socialSecurity);
		Controls.Add(health);
		Controls.Add(withholdTax);
		Controls.Add(grossPay);
		Controls.Add(overtimePay);
		Controls.Add(regularPay);
		Controls.Add(name);
		Controls.Add(label1);
		Controls.Add(groupBox1);
		Controls.Add(dependentsComboBox);
		Controls.Add(payRateInput);
		Controls.Add(hoursWorkedInput);
		Controls.Add(secondnameinput);
		Controls.Add(firstnameinput);
		Controls.Add(exitbutton);
		Controls.Add(clearbutton);
		Controls.Add(computebutton);
		Controls.Add(healthplan);
		Controls.Add(dependents);
		Controls.Add(payrate);
		Controls.Add(hoursworked);
		Controls.Add(secondname);
		Controls.Add(firstname);
		Controls.Add(title);

		computebutton.Click += new EventHandler(computePayroll);
		clearbutton.Click += new EventHandler(clearForm);
		exitbutton.Click += new EventHandler(stopRun);
	}

	protected void computePayroll(Object sender, EventArgs events){
		try{
		double hours = double.Parse (hoursWorkedInput.Text);
		double rate = double.Parse (payRateInput.Text);
		int dependents = int.Parse(dependentsComboBox.Text);
		bool health = false;
		if (yesRadioButton.Checked == true)
			health = true;
		string name = string.Concat (firstnameinput.Text.ToString ().ToUpper(), " ", secondnameinput.Text.ToString ().ToUpper ());
		double regular = PayrollLogic.computeRegularPay (hours, rate);
		double overtime = PayrollLogic.computeOvertimePay (hours, rate);
		double gross = PayrollLogic.computeGrossPay (regular, overtime);
		double withhold = PayrollLogic.computeWithholdTax (dependents, gross);
		double healthFee = PayrollLogic.computeHealth (dependents, health);
		double ssFee = PayrollLogic.computeSocialSecurity (gross);
		double netPay = PayrollLogic.computeNetPay (gross, withhold, healthFee, ssFee);
		nameOutput.Text = name;
		regularPayOutput.Text = string.Format("{0:F2}",regular);
		overtimePayOutput.Text = string.Format("{0:F2}",overtime);
		grossPayOutput.Text = string.Format("{0:F2}",gross);
		withholdTaxOutput.Text = string.Format("{0:F2}",withhold);
		healthOutput.Text = string.Format("{0:F2}",healthFee);
		socialSecutiryOutput.Text = string.Format("{0:F2}",ssFee);
		netPayOutput.Text = string.Format("{0:F2}",netPay);
		}catch(Exception e){
			MessageBox.Show ("Error in input: Try Again!");
		}

	}
	protected void clearForm(Object sender, EventArgs events){
		firstnameinput.Text = "";
		secondnameinput.Text = "";
		hoursWorkedInput.Text = "";
		payRateInput.Text = "";
		nameOutput.Text = "";
		regularPayOutput.Text = "";
		overtimePayOutput.Text = "";
		grossPayOutput.Text = "";
		withholdTaxOutput.Text = "";
		healthOutput.Text = "";
		socialSecutiryOutput.Text = "";
		netPayOutput.Text = "";
		noRadioButton.Checked = true;
		yesRadioButton.Checked = false;
		dependentsComboBox.Text = "";

	}

	protected void stopRun(Object sender, EventArgs events){
		Close ();
	}
}

