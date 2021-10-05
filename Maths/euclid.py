
# Define a function that takes two number
# inputs and returns the highest common factor.
def highest_common_factor(number_1: int, number_2: int) -> None:

    # the divmod builtin returns the integer
    # result and the remainder of a devision.
    _, remainder = divmod(number_1, number_2)

    # If the remainder is 0, we have found the
    # highest common factor which is the number
    # we divided by to get 0.
    if remainder == 0:
        return number_2

    # The remainder wasn't 0, so we return the result
    # of calling the function on the number we were
    # dividing by, and the remainder.
    return highest_common_factor(number_2, remainder)

# Get input numbers from the user, convert them to integers.
number_1 = int(input("Number 1: "))
number_2 = int(input("Number 2: "))

# Print the result of the function.
print(highest_common_factor(number_1, number_2))
