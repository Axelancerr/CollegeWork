def is_prime(num: int) -> bool:

    if num == 5:
        return True
    
    last = str(num)[-1]
    if last in {"0", "2", "4", "6", "8", "5"}:
        return False

    for i in range(2, num):
        if (num / (num + i)) % 1 == 0:
            break

    return True

primes = []
for i in range(35):
    if is_prime(i):
        primes.append(i)

print(", ".join(map(str, primes)))
