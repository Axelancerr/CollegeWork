
def maths(a: float, b: float, *, operation: str) -> float:
    if operation == "*":
        return a * b
    elif operation == "/":
        return a / b
    elif operation == "-":
        return a - b
    elif operation == "+":
        return a + b
    raise ValueError("Invalid operation")

print(maths(10, 5, operation="*"))
print(maths(20, 5, operation="/"))
print(maths(1, 5, operation="-"))
print(maths(20, 7, operation="-"))
