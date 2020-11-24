package com.example.tdd;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.fail;

import org.junit.jupiter.api.Test;

public class RooterTest {

	@Test
	public void basicRooterTest() {
		Rooter rooter = new Rooter();
		
		double expectedResult = 2.0;
		double input = expectedResult * expectedResult;
		double actualResult = rooter.squareRoot(input);
		
		assertEquals(expectedResult, actualResult);
	}
	
	@Test
	public void testRooterValueRange() {
		Rooter rooter = new Rooter();
		
		for (float expected = 1e-8f; expected < 1e+8f; expected *= 3.2) {
			rooterOneValue(rooter, expected);
		}
		
	}
	
	private void rooterOneValue(Rooter rooter, double expected) {
		double input = expected * expected;
		double actual = rooter.squareRoot(input);
		
		assertEquals(expected, actual);
	}
	
	@Test
	public void testRooterNegativeInput() {
		Rooter rooter = new Rooter();
		
		try {
			rooter.squareRoot(-10);
		} catch (IllegalArgumentException e) {
			return;
		}
		
		fail();
	}
}
