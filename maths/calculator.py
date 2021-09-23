# Import the random module for generating random numbers.
import random

# Import Literal from the typing module which allows for typehinting the available operations.
from typing import Literal


# Define a function that takes 3 arguments, an operation and two float numbers.
def calculator(
    operation: Literal["+", "-", "*", "/"],
    a: float,
    b: float
) -> float:

    if operation == "+":
        return a + b
    elif operation == "-":
        return a - b
    elif operation == "*":
        return a * b
    elif operation == "/":
        return a / b

    # If the operation passed matched none of the above, raise an error.
    else:
        raise ValueError("'operation' must be one of '+', '-', '*', or '/'.")


# Choose some random numbers.
random_a = random.randint(1, 10)
random_b = random.randint(10, 20)

# Perform different calculation on the numbers.
add = calculator("+", random_a, random_b)
minus = calculator("-", random_a, random_b)
multiply = calculator("*", random_a, random_b)
divide = calculator("/", random_a, random_b)

# Print the results, with some formatting showing what operation happened.
print(f"{random_a} + {random_b} = {add}")
print(f"{random_a} - {random_b} = {minus}")
print(f"{random_a} * {random_b} = {multiply}")
print(f"{random_a} / {random_b} = {divide}")
