from turtle import *
speed (-1)

for n in range (3,7):
    if n in range (3,7,2):
        color ("blue")
    else:
        color ("red")
    for i in range(n):
        forward(100)
        left(360/n)
        
