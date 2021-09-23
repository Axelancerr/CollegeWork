
# Define a function that will find a list of divisors for a given number.
def find_divisors(number: int) -> list[int]:

    # Define a list to store the divisors/factors in.
    divisors = []

    # Loop over all the numbers (potential devisors) leading up 
    # to the given number.
    # In Python, we explicitly tell the range to start at 1 and
    # end at the given number plus one, as normally it would
    # start at zero and end at the given number minus one.
    for potential_divisor in range(1, number + 1):

        # If the given number divided by the current potential_divisor
        # produces a remainder, continue to the next loop as it is not 
        # a factor.
        if number % potential_divisor != 0:
            continue

        # else, append the current loop number to the list of divisors.
        divisors.append(potential_divisor)

    # Return the list of divisors.
    return divisors


# Get the user to input a number.
num = input("Choose a number: ")
try:
    # Try to convert the user input to an integer (from string).
    num = int(num)
except ValueError:
    # If the user did not input a valid integer value, tell them.
    print("That was not a valid number.")
else:
    # Else, print the list of divisors for the given number.
    print(find_divisors(num))
