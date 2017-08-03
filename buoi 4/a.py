def add_fruit(inventory, fruit, quantity):
     inventory={}
     inventory[fruit]+= quantity
     
new_inventory = {}
add_fruit(new_inventory, "strawberries", 10)
"strawberries" in new_inventory

new_inventory["strawberries"] == 10
add_fruit(new_inventory, "strawberries", 25)
new_inventory["strawberries"] == 35
    
  
