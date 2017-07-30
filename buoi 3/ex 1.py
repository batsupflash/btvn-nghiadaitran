defaut_item = ["T-shirt","Sweater","Jeans"]
user_input=input("Welcome to our shop, what do you want (C, R, U, D)?")
if user_input.lower() == 'c':
    new_item=input("Enter new item:")
    defaut_item.append (new_item)
    print ("Our items:",defaut_item)
elif user_input.lower() == 'r':
    print ("Our items:",defaut_item)
elif user_input.lower()== 'u':
    u=int(input("Update position?:"))-1
    updated_item=input("New items?:")
    defaut_item[u]=updated_item
    print ("Our items:",defaut_item)
elif user_input.lower()=='d':
    d=int(input("Delete position?:"))-1
    del defaut_item[d]
    print ("Our items:",defaut_item)

