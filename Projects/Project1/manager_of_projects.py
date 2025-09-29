def amount_strings(file):
    f = open("/content/notes.txt",'r', encoding = "utf-8").readlines()
    return len(f)+1

def create():
    file = open("/content/notes.txt",'a+', encoding = "utf-8")
    file.write(f"{amount_strings(file)}. {input("Write your note:\n")}\n")
def delete():
    num = input("What note do you want to delete? Write the number of it.")
    newfile = open("/content/notes.txt",'w', encoding = "utf-8")
    file = open("/content/notes.txt",'r', encoding = "utf-8")
    i=1
    for i in file.readlines():
      if a[0]!=num:
        newfile.write(f"{1}. ",i[2:])
    file = newfile
def search():
    pass
def close():
    file.close()
def show():
    file = open("notes.txt",'r', encoding = "utf-8")
    print(file.read())
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
          case _:
            print("You can choose only 1-5. Try again:")
            continue
        
interface()

