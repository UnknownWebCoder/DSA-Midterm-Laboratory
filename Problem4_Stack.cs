using System;

namespace LastNameFirstNameInitials{
    struct Operation{
        public string Action;
        public string StudentNumber;
        public string StudentName;
    }

    class Problem4_Stack{
        static void Main(string[] args){
            Operation[] stack = new Operation[10];
            int top = -1;

            top++; stack[top] = new Operation { Action = "Added", StudentName = "Christian", StudentNumber = "2025-8-0197" };
            top++; stack[top] = new Operation { Action = "Added", StudentName = "James", StudentNumber = "2025-8-0198" };
            top++; stack[top] = new Operation { Action = "Updated", StudentName = "Kristiyano", StudentNumber = "2025-8-0199" };
            top++; stack[top] = new Operation { Action = "Deleted", StudentName = "Santiago", StudentNumber = "2025-8-0200" };

            while (true){
                Console.WriteLine("\nOPERATION HISTORY");
                Console.WriteLine("1. View Operation History");
                Console.WriteLine("2. View Last Operation");
                Console.WriteLine("3. Remove Last Operation");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                
                if (!int.TryParse(Console.ReadLine(), out int choice)){
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1){
                    if (top == -1){
                        Console.WriteLine("No recorded operations.");
                    } else{
                        Console.WriteLine("\nOPERATION HISTORY");
                        for (int i = 0; i <= top; i++){
                            Console.WriteLine((i + 1) + ". " + stack[i].Action + " " + stack[i].StudentName);
                        }
                    }
                }


                else if (choice == 2){
                    if (top == -1){
                        Console.WriteLine("No recorded operations.");
                    } else{
                        Console.WriteLine("Last Operation: " + stack[top].Action + " " + stack[top].StudentName);
                    }
                }


                else if (choice == 3){
                    if (top == -1){
                        Console.WriteLine("No recorded operations to remove.");
                    } else{
                        top--;
                        Console.WriteLine("Last operation removed successfully!");
                    }
                }


                else if (choice == 4){
                    Console.WriteLine("Program exited.");
                    break;
                }
            }
        }
    }
}