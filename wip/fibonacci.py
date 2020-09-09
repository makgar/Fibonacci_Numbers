#!/usr/bin/python3.6

fibonacci_numbers = [0, 1]
#print(fibonacci_numbers)
#print(fibonacci_numbers[0])

def user_input():
    check = False
    print("Please input an integer value:")
    while not check:
        try:
            value = int(input())
            check = True
            if value < 0:
                print("\nYou have provided a negative value. Ommiting sign.", end="")
                value = value * -1
        except:
            print("\nThe value you have provided can not be converted to integer.\nPlease try again:")
    print()
    return value

a = user_input()
print("Your first number is:", a, "\n")

#print("\nGreatest common divisor of ", a, " and ", b, " is:\n", gcd(a, b), sep="")