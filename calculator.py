
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

print(calculator(10, 5, operation="*"))
print(calculator(20, 5, operation="/"))
print(calculator(1, 5, operation="-"))
print(calculator(20, 7, operation="+"))
