using System;

namespace LastNameFirstNameInitials{
    struct Student{
        public string StudentNumber;
        public string Name;
        public string Program;
        public int YearLevel;
    }

    class Problem1_Array{
        static void Main(string[] args){
            Student[] students = new Student[10];
            int count = 0;

            while (true){
                Console.WriteLine("\nPalSU STUDENT RECORD MANAGEMENT");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                
                if (!int.TryParse(Console.ReadLine(), out int choice)){
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1){
                    if (count >= 10){
                        Console.WriteLine("Cannot add more students. Limit reached.");
                    } else{
                        Student s;
                        Console.Write("Enter Student's ID Number: ");
                        s.StudentNumber = Console.ReadLine();
                        Console.Write("Enter Student's Name: ");
                        s.Name = Console.ReadLine();
                        Console.Write("Enter Student's Program: ");
                        s.Program = Console.ReadLine();
                        Console.Write("Enter Student's Year Level: ");
                        s.YearLevel = int.Parse(Console.ReadLine());

                        students[count] = s;
                        count++;
                        Console.WriteLine("Student added successfully!");
                    }
                }


                else if (choice == 2){
                    if (count == 0){
                        Console.WriteLine("No student records found.");
                    } else{
                        Console.WriteLine("\nSTUDENT RECORDS");
                        for (int i = 0; i < count; i++){
                            Console.WriteLine("Student's ID Number: " + students[i].StudentNumber);
                            Console.WriteLine("Name: " + students[i].Name);
                            Console.WriteLine("Program: " + students[i].Program);
                            Console.WriteLine("Year Level: " + students[i].YearLevel);
                            Console.WriteLine("------------------------------");
                        }
                    }
                }


                else if (choice == 3){
                    Console.Write("Enter Student's ID Number to search: ");
                    string searchNum = Console.ReadLine();
                    bool found = false;

                    for (int i = 0; i < count; i++){
                        if (students[i].StudentNumber == searchNum){
                            Console.WriteLine("\nStudent Found!");
                            Console.WriteLine("Student's ID Number: " + students[i].StudentNumber);
                            Console.WriteLine("Name: " + students[i].Name);
                            Console.WriteLine("Program: " + students[i].Program);
                            Console.WriteLine("Year Level: " + students[i].YearLevel);
                            found = true;
                            break;
                        }
                    }

                    if (!found){
                        Console.WriteLine("Student not found.");
                    }


                } else if (choice == 4){
                    Console.Write("Enter Student Number to update: ");
                    string updateNum = Console.ReadLine();
                    bool found = false;

                    for (int i = 0; i < count; i++){
                        if (students[i].StudentNumber == updateNum){
                            Console.Write("Enter New Name: ");
                            students[i].Name = Console.ReadLine();
                            Console.Write("Enter New Program: ");
                            students[i].Program = Console.ReadLine();
                            Console.Write("Enter New Year Level: ");
                            students[i].YearLevel = int.Parse(Console.ReadLine());
                            Console.WriteLine("Student updated successfully!");
                            found = true;
                            break;
                        }
                    }

                    if (!found){
                        Console.WriteLine("Student not found.");
                    }
                }
                

                else if (choice == 5){
                    Console.Write("Enter Student Number to delete: ");
                    string deleteNum = Console.ReadLine();
                    int foundIndex = -1;

                    for (int i = 0; i < count; i++){
                        if (students[i].StudentNumber == deleteNum){
                            foundIndex = i;
                            break;
                        }
                    }

                    if (foundIndex != -1){
                        for (int i = foundIndex; i < count - 1; i++){
                            students[i] = students[i + 1];
                        }
                        count--;
                        Console.WriteLine("Student deleted successfully!");
                    } else{
                        Console.WriteLine("Student not found.");
                    }
                } 
                
                
                else if (choice == 6){
                    Console.WriteLine("Program exited.");
                    break;
                }
            }
        }
    }
}