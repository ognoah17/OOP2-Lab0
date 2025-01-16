# Lab 0: Numeric Range and File Operations Program

## Description
This C# console application allows users to work with numeric ranges, validate inputs, identify prime numbers, and perform file operations. It ensures robust user input validation and provides functionality to save and read data from a file.

---

## Features
1. **Input Validation**:
   - Prompts the user for a positive number and validates the input.
   - Ensures the second number entered is greater than the first.

2. **Range Calculation**:
   - Calculates the difference between two numbers and generates a range of numbers between them.

3. **Prime Number Detection**:
   - Identifies and displays all prime numbers in the specified range.

4. **File Writing**:
   - Writes the range of numbers to a file (`numbers.txt`) in reverse order.

5. **File Reading and Summation**:
   - Reads numbers from the file, calculates their sum, and gracefully handles invalid entries.

---

## How to Use

### 1. **Run the Program**:
   - Open the console and execute the application.

### 2. **Enter Inputs**:
   - Provide a positive number when prompted.
   - Provide a second number greater than the first.

### 3. **View Results**:
   - The program will:
     - Display the difference between the numbers.
     - List all prime numbers in the range.
     - Save the range to a file (`numbers.txt`) in reverse order.

### 4. **Sum Numbers from the File**:
   - The program reads the saved file and calculates the sum of the numbers, displaying it in the console.

---

## File Details

### Input File:
- File Name: `numbers.txt`
- Content: Contains numbers written in reverse order from the generated range.

### Example File Content:
```plaintext
20
19
18
17
16
15
14
13
12
11
10
```

---

## Error Handling
- **Invalid Input**: Prompts the user until a valid number is provided.
- **File Handling**: Gracefully handles file errors (e.g., missing file, invalid content).
- **Prime Detection**: Skips non-numeric content in the file during summation.

---

## Requirements
- **Platform**: .NET 5.0 or later.
- **Environment**: Windows, macOS, or Linux.
- **Tools**: Any IDE or text editor to run the program.

---

## Example Run

### Input:
```plaintext
Please enter a number (positive): 10
Please enter a number greater than the low number: 20
```

### Output:
```plaintext
The difference between 20 and 10 is 10.
The prime numbers are:
11
13
17
19
The sum of the numbers in the file is 165.
```

---
