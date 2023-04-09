from tkinter import *

ws = Tk()
ws.title('PythonGuides')
ws.geometry('300x300')
ws.config(bg='#345')

canvas = Canvas(
    ws,
    height=500,
    width=500,
    bg="#fff"
)

canvas.pack()

canvas.create_rectangle(30, 150, 300, 300,outline="black",fill="#fb0")

points = [30,150,165,30,300,150]
canvas.create_polygon(points, outline='black',fill='grey', width=5)

canvas.create_rectangle(50,170,150,270,outline="black",fill='#01ffe6')
canvas.create_line(100,170,100,270,fill="black")

canvas.create_rectangle(200,200,250,300,fill="#363202")

ws.mainloop()