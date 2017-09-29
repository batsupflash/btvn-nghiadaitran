from flask import Flask
from flask import request
from flask import render_template

app = Flask(__name__)


@app.route('/')
def my_form():
    return render_template("BMIcal.html")


@app.route('/', methods=['POST'])
def my_form_post():

    height = request.form['height']
    height_in_m = float(height)/100
    weight = request.form['weight']
    BMI = float(weight) / (float(height_in_m)**2)
    if BMI < 16:
        text = "you're 'Severely underweight'"
    elif 18.5 > BMI >= 16:
            text = "you're 'Underweight'"
    elif 25 > BMI >= 18.5:
            text = "you're 'Normal'"
    elif 30 > BMI >= 25:
            text = "you're 'Overweight'"
    else:
            text = "you're 'Obese'"
    return "BMI = " + str(BMI) + " " + text


if __name__ == '__main__':
    app.run(debug=True)
