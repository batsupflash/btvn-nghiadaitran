prices={
    "banana": 4,
    "apple": 2,
    "orange": 1.5,
    "pear": 3
    }
purchased_items=["banana",
"orange"
]
quantity={purchased_items[0]:5,purchased_items[1]:3}
          


for i in range(len(purchased_items)):
    print("{0}, quantity: {1}, unit price:{2}".format(purchased_items[i],quantity[purchased_items[i]],prices[purchased_items[i]]))
total = 0
for i in purchased_items:
    x=prices[i]*quantity[i]
    total +=x
print (total)
    
    
