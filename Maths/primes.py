# Define a list of know and small primes that break
# the prime number pattern. (2, 3, 5)
PRIMES = {2, 3, 5}

# Define a list of digits that, if a number ends in
# them, will never be prime. (0, 2, 4, 6, 8, 5)
BAD_ENDINGS = {"0", "2", "4", "6", "8", "5"}


def is_prime(number: int) -> bool:

    # 1 isn't a prime number.
    if number == 1:
        return False

    # Check if the number is in the list of small
    # and known primes that break the pattern of
    # prime numbers.
    if number in PRIMES:
        return True

    # If the last digit of the number is even or a
    # five, the number is either divisible by two
    # or five, which means it is not prime.
    last = str(number)[-1]
    if last in BAD_ENDINGS:
        return False

    # Loop over all the numbers (potential factors) leading up
    # to the given number.
    # We explicitly tell the loop to start at two, as every number
    # is divisible by one which would make this check immediately
    # return False, even if the number is actually prime.
    for possible_factor in range(2, number):

        # If the given number divided by the current possible_factor
        # does not produce a remainder, possible_factor is an actual
        # factor and therefore the number is not prime.
        if number % possible_factor == 0:
            return False

    # The number should now be confirmed to be prime, so return True.
    return True


# Ask they user how many prime numbers they want.
count = input("How many prime numbers do you want? ")
try:
    # Try to convert the user input to an integer (from string).
    count = int(count)
except ValueError:
    # If the user did not input a valid integer value, tell them.
    print("That was not a valid number.")
else:

    # Declare a list to store the prime numbers in.
    primes = []

    # Define a stating number.
    current_number = 1

    # Start a loop that will run as long as the number of found
    # prime numbers is less than the amount the user asked for.
    while len(primes) < count:

        # If the current number is prime, append it
        # to the list of prime numbers.
        if is_prime(current_number):
            primes.append(current_number)

        # Increment the current number by one.
        current_number += 1

    # Print the final list of prime numbers.
    print(primes)
