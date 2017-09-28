from flask import Flask, render_template, redirect
app = Flask(__name__)


@app.route('/')
def index():
    return render_template('index.html', type="Hư")


@app.route("/school")
def to_school_site():
    return redirect("https://www.techkids.vn", code=302)


if __name__ == '__main__':
    app.run(debug=True)
