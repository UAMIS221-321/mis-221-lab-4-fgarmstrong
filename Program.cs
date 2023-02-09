// start main
int userChoice = GetUserChoice(); // priming read
// pre-test loop
// while(userChoice!=3){ // condition check
//     RouteEm(userChoice)
//     userChoice - GetUserChoice(); // update read
// }
// Post test loop
do {
    RouteEm(userChoice);
    userChoice = GetUserChoice(); // update read
} while (userChoice!=3);
// end main

static int GetUserChoice() {
    DisplayMenu(); 
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
        }
    return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to dispaly full triangle\nEnter 2 to dispaly partial triangle\n Enter 3 to exit");
}

static bool IsValidChoice(string userChoice) {
    if(userChoice== "1" || userChoice== "2" || userChoice=="3") {
        return true;
    }
    else return false;
}

static void DispalyFullTriangle() {
    Random rnd = new Random();
     int number = rnd.Next(3,10);
    for(int i=0; i < number; i++) {
         for(int j=0; j < i+1; j++) {
            Console.Write("o");
        }
        Console.WriteLine();
    }
    PauseAction();
}

static void DispalyPartialTriangle() {
     Random rnd = new Random();
     int number = rnd.Next(3,10);
    for(int i=0; i < number; i++) {
         for(int j=0; j < i+1; j++) {
 //           Console.Write("o");
            if(number == rnd.Next(3,10)) {
                Console.Write(" ");
                 }
            else{Console.Write("o");}
        }
        Console.WriteLine();
    }
    PauseAction();
}

static void SayInvalid() {
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        DispalyFullTriangle();
    }
    else if(menuChoice==2) {
        DispalyPartialTriangle();
    }
    else if(menuChoice!=3) {
        SayInvalid();
    }
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
