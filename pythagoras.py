import math

def pythagoras(x1: float, y1: float, x2: float, y2: float) -> float:
    x_diff = x1 - x2
    y_diff = y1 - y2
    return math.sqrt(x_diff**2 + y_diff**2)

x1 = float(input("Point x1: "))
y1 = float(input("Point y1: "))
x2 = float(input("Point x2: "))
y2 = float(input("Point y2: "))

print(pythagoras(x1, y1, x2, y2))
