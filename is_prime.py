def is_prime(num: int) -> bool:

    # 1 isn't a prime number.
    if num == 1:
        return False  

    # 2 and 5 are prime numbers but
    # they break the following
    # condition so return True now.
    if num in {2, 5}: 
        return True

    # Check if the number is even
    # (if it ends in 0, 2, 4, 6, or 8)
    # or if its is devisible by 5.
    last = str(num)[-1]
    if last in {"0", "2", "4", "6", "8", "5"}:
        return False

    # Check if any of the numbers up to the
    # given number is divisible into an
    # integer, if so the number is not prime.
    for i in range(2, num):
        if num % i == 0:
            return False

    # By now, the number should be
    # prime so we can return True
    return True

# Declare a list of numbers that will be prime.
primes = []

# Start a loop over the numbers, 1 - 100.
for i in range(100):
    # If the number is prime, add it
    # to the primes list.
    if is_prime(i):
        primes.append(i)

# Print a comma seperated list of the prime numbers.
print(", ".join(map(str, primes)))
