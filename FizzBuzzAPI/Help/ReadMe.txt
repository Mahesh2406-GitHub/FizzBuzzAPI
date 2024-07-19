FizzBuzz Web Application

Overview

This web application accepts an array of values and performs the following operations for each value:

- If the value is a multiple of 3, output "Fizz"
- If the value is a multiple of 5, output "Buzz"
- If the value is divisible by both 3 and 5, output "FizzBuzz"
- If the value is not divisible by 3 or 5 , output "value Divided by 3" "value Divided by 5"


Technical Requirements

- Built using C# programming language
- Web application framework: 7.0 (Core)
- Repository Added in the application services
- Dependancy inversion principle implemented by injecting interface to the constructor of fizzbuzzController.
- FizzBuzz controller is higher level module, whereas fizzbuzz is a lower level module and both dependent on abbsraction.
- To implement loose coupled code,dependancy injection used.
- Single respnsibility principle is used.
- Input: integers
- Output: String output for each value in the array, followed by a list of divisions performed

Functionality

1. User inputs an integers value
2. Application iterates through each value in the array
3. For each value:
    - Checks if value is multiple of 3, outputs "Fizz"
    - Checks if value is multiple of 5, outputs "Buzz"
    - Checks if value is divisible by both 3 and 5, outputs "FizzBuzz"
    - Checks if value is string, outputs "Invalid Item"
    - Checks if value is null, outputs "Invalid Item"


Usage

1. Build and run the application
2. Input an integer values (e.g. 1, 2, 3, 4, 5, 15,null)
3. View the output for each value.
4. Check the list of divisions performed.

Steps to follow for testing the FizzBuzz web application:

Test Case 1: Multiple of 3

1. Input: [3]
2. Expected Output: "Fizz"
3. Verify that the output is "Fizz"

Test Case 2: Multiple of 5

1. Input: [5]
2. Expected Output: "Buzz"
3. Verify that the output is "Buzz"

Test Case 3: Multiple of both 3 and 5

1. Input: [15]
2. Expected Output: "FizzBuzz"
3. Verify that the output is "FizzBuzz"

Test Case 4: Not a multiple of 3 or 5

1. Input: [1]
2. Expected Output: 1 Divided by 3 1 Divided by 5
3. Verify that output is "1 Divided by 3 1 Divided by 5"

Test Case 5: Invalid input

1. Input: 
2. Expected Output: "Invalid Item"
3. Verify that the output is "Invalid Item"

Test Case 6: Invalid input

1. Input: A
2. Expected Output: "Invalid Item"
3. Verify that the output is "Invalid Item"

Test Case 7: Invalid input

1. Input: ["abc"]
2. Expected Output: Error message or default value
3. Verify that an error message or default value is displayed

Test Case 8: Large input array

1. Input: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 30]
2. Expected Output:
    - Correct output for each value in the array
    - Division display for each value
3. Verify that the output is correct and the division display is correct



Author
Mahesh Patil

Date
18-07-2024
