# Install pyperclip first!!!!!!!!!!
# for C#
import pyperclip

# WARNING
# SHIT CODE UP AHEAD

text = pyperclip.paste()
temp = text.split("\r\n")
rows = [item for item in temp if item]

to_be_copied = ["\n{"]
method_name = input("Enter method name (with no paranthesis): ")
to_be_copied.insert(0, f"static string {method_name}()")

fuck_you_python = len(rows)
for i in range(fuck_you_python):
    if (i != fuck_you_python - 1):
        to_be_copied.append(f"\n\tConsole.WriteLine(\"{rows[i]}\");")
    else:
        to_be_copied.append(f"\n\tConsole.Write(\"{rows[i]}\");")

to_be_copied.append("\n\tstring userOption = Console.ReadLine();")
to_be_copied.append("\n\n\treturn userOption;")
to_be_copied.append("\n}")

for i in range(len(to_be_copied)):
    print(to_be_copied[i])


new_text = "".join(to_be_copied)
print(new_text)
pyperclip.copy(new_text)