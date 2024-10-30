from tkinter import *
from tkinter import ttk
import keyboard
import time

def type_text(*args):
    try:
        t_input = feet.get()
        if t_input:  # Only proceed if there's text to type
            meters.set("Typing in 3 seconds...")
            root.update()
            time.sleep(3)
            keyboard.write(t_input)
            meters.set("Typed successfully!")
        else:
            meters.set("Please enter text to type.")
    except ValueError:
        meters.set("Error: Invalid input.")
    except Exception as e:
        meters.set(f"Error: {e}")

root = Tk()
root.title("Auto Typer")

mainframe = ttk.Frame(root, padding="10 10 20 20")
mainframe.grid(column=0, row=0, sticky=(N, W, E, S))
root.columnconfigure(0, weight=1)
root.rowconfigure(0, weight=1)

# Input text variable and entry
feet = StringVar()
feet_entry = ttk.Entry(mainframe, width=20, textvariable=feet)
feet_entry.grid(column=2, row=1, sticky=(W, E))

# Status message label
meters = StringVar()
ttk.Label(mainframe, textvariable=meters).grid(column=2, row=2, sticky=(W, E))

# Start button
ttk.Button(mainframe, text="Start Typing", command=type_text).grid(column=3, row=3, sticky=W)

# Padding for each widget
for child in mainframe.winfo_children(): 
    child.grid_configure(padx=5, pady=5)

feet_entry.focus()
root.bind("<Return>", type_text)

root.mainloop()
