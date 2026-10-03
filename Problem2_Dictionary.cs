using System;

namespace LastNameFirstNameInitials{
    struct Student{
        public string StudentNumber;
        public string Name;
        public string Program;
        public int YearLevel;
    }

    class Problem2_Dictionary{
        static void Main(string[] args){
            string[] keys = new string[10];
            Student[] values = new Student[10];
            int count = 0;

            while (true){
                Console.WriteLine("\nPalSU STUDENT DICTIONARY");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Display All Students");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                
                if (!int.TryParse(Console.ReadLine(), out int choice)){
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1){
                    if (count >= 10){
                        Console.WriteLine("Limit reached.");
                        continue;
                    }
                    Console.Write("Enter Student's ID Number: ");
                    string num = Console.ReadLine();

                    bool duplicate = false;
                    for (int i = 0; i < count; i++){
                        if (keys[i] == num){
                            duplicate = true;
                            break;
                        }
                    }

                    if (duplicate){
                        Console.WriteLine("Error: Student Number already exists!");
                    } else{
                        Student s;
                        s.StudentNumber = num;
                        Console.Write("Enter Name: ");
                        s.Name = Console.ReadLine();
                        Console.Write("Enter Program: ");
                        s.Program = Console.ReadLine();
                        Console.Write("Enter Year Level: ");
                        s.YearLevel = int.Parse(Console.ReadLine());

                        keys[count] = num;
                        values[count] = s;
                        count++;
                        Console.WriteLine("Student added successfully!");
                    }
                } 
                

                else if (choice == 2){
                    Console.Write("Enter Student's ID Number to search: ");
                    string searchNum = Console.ReadLine();
                    bool found = false;

                    for (int i = 0; i < count; i++){
                        if (keys[i] == searchNum){
                            Console.WriteLine("\nStudent Found!");
                            Console.WriteLine("Student's ID Number: " + values[i].StudentNumber);
                            Console.WriteLine("Name: " + values[i].Name);
                            Console.WriteLine("Program: " + values[i].Program);
                            Console.WriteLine("Year Level: " + values[i].YearLevel);
                            found = true;
                            break;
                        }
                    }

                    if (!found){
                        Console.WriteLine("Student's ID Number does not exist.");
                    }
                }
                
                
                else if (choice == 3){
                    if (count == 0){
                        Console.WriteLine("No records found.");
                    } else{
                        Console.WriteLine("\nSTUDENT RECORDS");
                        for (int i = 0; i < count; i++){
                            Console.WriteLine("Student's ID Number: " + values[i].StudentNumber);
                            Console.WriteLine("Name: " + values[i].Name);
                            Console.WriteLine("Program: " + values[i].Program);
                            Console.WriteLine("Year Level: " + values[i].YearLevel);
                            Console.WriteLine("------------------------------");
                        }
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