package com.example.tdd;

public class Rooter {

	public double squareRoot(double input) {
		if (input <= 0.0) throw new IllegalArgumentException();

		double previousResult;  
		
		double result = input / 2;  
		do {
			previousResult = result;  
			result = (previousResult + (input/previousResult)) / 2;  
		} while((previousResult - result) != 0);  
		
		return result;  
	}
}
