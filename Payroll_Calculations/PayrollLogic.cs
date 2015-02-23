//Name= Erick Silva
//e-mail= ericksilva@csu.fullerton.edu
//Course = CPSC 223N
//Assignment #2
//Due date: February 26, 2015
using System;

public class PayrollLogic
{
	public PayrollLogic ()
	{

	}
	public static String concatName(String firstName, String secondName){
		return firstName + " " + secondName;
	}
	public static double computeRegularPay(double hours, double rate){
		double result = 0;
		if (hours >= 40) {
			result = 40 * rate;
		} else
			result = hours * rate;
		return result;
	}

	public static double computeOvertimePay(double hours, double rate){
		double result = 0;
		if (hours >= 40) {
			result = (1.5 * (hours - 40)) * rate;
		}
		return result;
	}

	public static double computeGrossPay(double regular, double overtime){
		return regular + overtime;
	}

	public static double computeWithholdTax(int dependents, double grossPay){
		System.Console.WriteLine (dependents);
		double result = 20 - (2 * (dependents + 1));
		System.Console.WriteLine (result);
		return ((double) result /100.00) * grossPay ;
	}
	public static double computeHealth(int dependents,bool healthplan){
		if (healthplan) {
			return 85 + (54 * dependents);
		}
		return 0;
	}

	public static double computeSocialSecurity(double gross){
		double result = gross * 0.04;
		if (result > 30)
			return 30;
		return result;
	}

	public static double computeNetPay(double gross, double withhold, double health, double socialSecurity){
		return gross -withhold - health - socialSecurity;
	}
}
