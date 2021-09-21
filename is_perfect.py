
def is_perfect(num: int) -> bool:

    devisors = []
    for i in range(1, num - 1):
        if num % i == 0:
            devisors.append(i)

    if sum(devisors) == num:
        return True

    return False

num = int(input("Choose a number: "))
print(is_perfect(num))
