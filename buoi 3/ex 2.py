sizes=[5,7,300,90,24,50,75]
print("Hello I'm Nghia and these're my sheeps's sizes:", sizes)
for month_num in range (4):
    print("MONTH",month_num)
    print("No my biggest sheep has size",max(sizes),"let's shear it.")
    print("After shearing, here's my flock:")

    sizes[sizes.index(max(sizes))]=8

    print (sizes)

    print("One month has passed, now here's my flock")
    for i in range(len(sizes)):
        sizes[i]=int(sizes[i])+50
    print (sizes)
print("Now my flock has size in total:")
b= sum(sizes)
print (b)
print("I would get",b,"*2$=",b*2,"$")
