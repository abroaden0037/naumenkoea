def create():
    pass
def delete():
    pass
def search():
    pass
def close():
    pass
def show()
    pass
def interface():
    print("Welcome to Mahager of Projects! Darling, let's start!")
    while True:
        print('''What do you want to do?
            1. create a new note
            2. delete a note
            3. search a note
            4. close a note
            5. show all notes
        To select an action write the number of it.''')
    answer=input()
    match answer:
        case "1":
            create()
        case "2":
            delete()
        case "3":
            search()
        case "4":
            close()
        case "5":
            show()
        case _: print("You can choose only 1-5. Try again:")
            continue

