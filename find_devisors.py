from typing import List


def find_devisors(num: int) -> List[int]:
    devisors = []
    for i in range(1, num):
        if num % i == 0:
            devisors.append(i)
    return devisors

num = int(input("Choose a number: "))
print(find_devisors(num))
