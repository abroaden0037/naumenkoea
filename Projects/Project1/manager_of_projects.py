import os
def amount_strings(file):
    f = open("/content/notes.txt",'r', encoding = "utf-8").readlines()
    return len(f)+1

def create():
    file = open("/content/notes.txt",'a+', encoding = "utf-8")
    file.write(f"{amount_strings(file)}. {input("Write your note:\n")}\n")
def delete():
    deleted = input("What note do you want to delete? Write the number of it.\n")
    newfile = open("/content/notes1.txt",'w', encoding = "utf-8")
    file = open("/content/notes.txt",'r', encoding = "utf-8")
    num=1
    for i in file.readlines():
        if i[0]!=deleted:
          newfile.write(f"{num}. {i[3:]}")
          num+=1
    os.remove("/content/notes.txt")
    os.rename("/content/notes1.txt","/content/notes.txt")
def search():
    num = input("Which note do you want to search? Write the number of it.\n")
    file = open("/content/notes.txt",'r', encoding = "utf-8").readlines()
    for i in file:
      if i[0] == num:
        print(i)
        break
def close():
    pass
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
            4. close the programm
            5. view all notes
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

