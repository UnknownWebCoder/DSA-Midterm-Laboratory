using System;

namespace LastNameFirstNameInitials{
    struct StudentRequest{
        public string StudentNumber;
        public string StudentName;
        public string RequestType;
    }

    class Problem3_Queue{
        static void Main(string[] args){
            StudentRequest[] queue = new StudentRequest[10];
            int count = 0;

            while (true){
                Console.WriteLine("\nPalSU STUDENT REQUEST QUEUE");
                Console.WriteLine("1. Add Request");
                Console.WriteLine("2. View Pending Requests");
                Console.WriteLine("3. Process Request");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                
                if (!int.TryParse(Console.ReadLine(), out int choice)){
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1){
                    if (count >= 10){
                        Console.WriteLine("Queue is full.");
                        continue;
                    }

                    StudentRequest req;
                    Console.Write("Enter Student's ID Number: ");
                    req.StudentNumber = Console.ReadLine();
                    Console.Write("Enter Student Name: ");
                    req.StudentName = Console.ReadLine();
                    Console.Write("Enter Request Type: ");
                    req.RequestType = Console.ReadLine();

                    queue[count] = req;
                    count++;
                    Console.WriteLine("Request added successfully!");
                }


                else if (choice == 2){
                    if (count == 0){
                        Console.WriteLine("No pending requests.");
                    } else{
                        Console.WriteLine("\nREQUEST QUEUE");
                        
                        for (int i = 0; i < count; i++){
                            Console.WriteLine((i + 1) + ". " + queue[i].StudentName + " - " + queue[i].RequestType);
                        }
                    }
                }


                else if (choice == 3){
                    if (count == 0){
                        Console.WriteLine("No pending requests to process.");
                    } else{
                        StudentRequest current = queue[0];
                        Console.WriteLine("Processing Request: " + current.StudentName);
                        Console.WriteLine(current.RequestType);

                        for (int i = 0; i < count - 1; i++){
                            queue[i] = queue[i + 1];
                        }
                        count--;
                        Console.WriteLine("Request processed successfully!");
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