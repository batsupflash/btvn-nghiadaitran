##
##px = [0,1,2,3]
##py = [0,1,2,3]
##Gx = [0,1,2,3]
##Gy = [0,1,2,3]
##Bx = [0,1,2,3]
##By = [0,1,2,3]
##l=[px,py,Gx,Gy,Bx,By]
##import random
##for i in l:
##    i = random.choice(i)
px=2
py=1
Gx=1
Gy=3
Bx=1
By=2



while True:
    for y in range (4):
        for x in range (4):
            if y == By and x == Bx:
                print ("B",end=" ")
                continue

            if y == Gy and x == Gx:
                print ("G",end=" ")
                continue
            
            if y == py and x == px:
                print ("p",end=" ")
                continue
            else:
                print("-", end=" ")

        print() #new line
    if Bx==Gx and By==Gy:
        print ("You won!")
        break
    command = input("Your move?:")
    if command.upper() == "W":
        py -=1
        if py==By and px == Bx and By==0:
            print("Can't move")
            py = 1
        if py <0:
            py=0
            print ("Can't move")
        
    if command.upper() == "D":
        px +=1
        if py==By and px == Bx and Bx==3:
            print("Can't move")
            px = 2
        if px >3:
            print ("Can't move")
            px=3
    if command.upper() =="A":
        px -=1
        if py==By and px == Bx and Bx==0:
            print("Can't move")
            px = 1
        if px <0:
            print ("Can't move")
            px=0
    if command.upper() =="S":
        py +=1
        if py==By and px == Bx and By==3:
            print("Can't move")
            py = 2
        if py >3:
            print("Can't move")
            py=3
    if px==Bx and py == By and command.upper()=="S":
        By+= 1
        if By>3:
            print("Can't move")
            By=3
    if px==Bx and py == By and command.upper()=="A":
        Bx-= 1
        if By<0:
            print("Can't move")
            By=0
    if px==Bx and py == By and command.upper()=="W":
        By-= 1
        if By<0:
            print("Can't move")
            By=0
    if px==Bx and py == By and command.upper()=="D":
        Bx+= 1
        if Bx>3:
            print("Can't move")
            Bx=3

    
            
