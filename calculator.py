
def calculator(a: float, b: float, *, operation: str) -> float:
    if operation == "*":
        return a * b
    elif operation == "/":
        return a / b
    elif operation == "-":
        return a - b
    elif operation == "+":
        return a + b
    raise ValueError("Invalid operation")

a = float(input("Number 1: "))
b = float(input("Number 2: "))
operation = input("Operation: ")
print(calculator(a, b, operation=operation))

