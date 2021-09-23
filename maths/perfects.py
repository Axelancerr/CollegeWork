# Define a function that will check if the given
# number is perfect and return a boolean value.
def is_perfect(number: int) -> bool:

    # Define a list to store the divisors of the given number in.
    divisors = []

    # Loop over all the numbers (potential divisors) leading up
    # to the given number.
    for potential_divisor in range(1, number - 1):

        # If the given number divided by the current potential_divisor
        # does not produce a remainder, it is a divisor and can be added
        # to the list of divisors.
        if number % potential_divisor == 0:
            divisors.append(potential_divisor)

    # By now, we should have all the divisors/factors of the given number, so
    # we can check if the sum of all of them equals the given number. If so the
    # number is considered perfect and we can return True, else return False as
    # it is not perfect.
    if sum(divisors) == number:
        return True

    return False


# Ask they user how many perfect numbers they want.
count = input("How many perfect numbers do you want? (Recommend less than 4, as any higher can take a loooong time):  ")
try:
    # Try to convert the user input to an integer (from string).
    count = int(count)
except ValueError:
    # If the user did not input a valid integer value, tell them.
    print("That was not a valid number.")
else:

    # Declare a list to store the perfect numbers in.
    perfects = []

    # Define a stating number.
    current_number = 1

    # Start a loop that will run as long as the number of found
    # perfect numbers is less than the amount the user asked for.
    while len(perfects) < count:

        # If the current number is perfect, append it
        # to the list of perfect numbers.
        if is_perfect(current_number):
            perfects.append(current_number)

        # Increment the current number by one.
        current_number += 1

    # Print the final list of perfect numbers.
    print(perfects)
