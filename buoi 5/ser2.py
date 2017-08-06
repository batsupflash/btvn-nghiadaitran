def extract_even(l):
    l=[x for x in l if x%2 == 0]
    print(l)
    return l
extract_even([1,2,3,4,5,6,7,9,-10])
even_list = extract_even([1, 2, 5, -10, 9, 6])

if set(even_list) == set([2, -10, 6]):
    print("Your function is correct")
else:
    print("Ooops, bugs detected")

