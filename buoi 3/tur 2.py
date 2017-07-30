from turtle import *
speed(-1)

colors=["red","blue","brown","yellow","gray"]
a=0
for i in range (5):

    begin_fill()
    color(colors[a])
    
    a=a+1
    for sides in range (2):
        forward(50)
        left(90)
        forward(100)
        left(90)
    forward (50)
    end_fill()

    
