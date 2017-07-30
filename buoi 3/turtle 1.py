from turtle import *
speed (-1)
a=["red","blue","brown","yellow","gray"]
x=0
for i in range (3,8):
    color(a[x])
    x=x+1
    for n in range(i):
        forward(100)
        left(360/i)
       
   
        
