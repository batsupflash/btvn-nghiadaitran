user_str=("ThiS is String with Upper and lower case Letters")

    
    
def count_all(text):
    text = text.lower()
    counts = {}
    for char in text:
        if char == " ":
            continue
        if char not in counts:
            counts.setdefault(char,1)
        else:
            counts[char] = counts[char] + 1
    counts = sorted(counts.items())
    for i in counts:
        print(i[0],' ',i[1])

count_all(user_str)


    
    
    
    
    


