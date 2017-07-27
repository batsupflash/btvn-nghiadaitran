print ("helloo and this is the BMI calculator")
height=float(input("please enter your height(cm)"))/ 100
weight=float(input("please enter your weight(kg)"))
BMI=float(weight/height**2)
if BMI <16:
    print ("you're 'Severely underweight'")
elif 18.5 > BMI >= 16:
    print ("you're 'Underweight'")
elif 25 > BMI >= 18.5:
    print ("you're 'Normal'")
elif 30 > BMI >= 25:
    print ("you're 'Overweight'")
else:
    print ("you're 'Obese'")
    
