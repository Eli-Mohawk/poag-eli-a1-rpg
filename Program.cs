// Displays the title at the top of the console
Console.WriteLine("Welcome to Realmwalker.");
Console.WriteLine("");
Console.WriteLine("----------------------------------");

// Displays the current story information and the options to move on
Console.WriteLine("You wake up to find yourself in a massive empty field.");
Console.WriteLine("Far into the distance you can just barely see what looks to be a town.");
Console.WriteLine("Do you walk towards the distant town?");
Console.WriteLine("Type [yes] or [no]:");

// If statements that control how the story progresses based on the choices made by the player
// Variable that takes what the user inputs and progresses the story accordingly
String jpq1 = Console.ReadLine();
// If statement directs the story in a set direction based on the answer the user inputed (similar for all instances in this program)
if (jpq1 == "no")
{
    Console.WriteLine("");
    Console.WriteLine("You decide not to travel to the town because it's to far away.");
    Console.WriteLine("After sitting in the same spot that you woke at for several days, you die.");
    Console.WriteLine("THE END [1/11]");
    Console.WriteLine("Congrats! You got the worst one! (for the story)");
}
// The alternative story directions for if the user doesn't do the one listed in the if statement (similar for all instances in this program)
else if (jpq1 == "yes")
{
    
    Console.WriteLine("");
    Console.WriteLine("You decide to travel to the distant town. After several hours, you finally reach it.");
    Console.WriteLine("When you arive, you notice that there are no people to be found. After checking multiple homes, you realise that ");
    Console.WriteLine("the entire town has been abandoned.");
    Console.WriteLine("You begin wondering if you should continue to travel in hopes of finding somewhere else with people, ");
    Console.WriteLine("or stay in the town for a while to rest.");
    Console.WriteLine("Will you stay in the town or will you continue your journey?");
    Console.WriteLine("Type [stay] or [continue]:");

    String jpq2 = Console.ReadLine();
    if (jpq2 == "stay")
    {
        Console.WriteLine("");
        Console.WriteLine("You decide to stay in the town for a while.");
        Console.WriteLine("After a short rest and taking some food, you question if you should stay incase someone returns, ");
        Console.WriteLine("or if you should continue travelling.");
        Console.WriteLine("Type [stay] or [continue]:");

        String hpq1 = Console.ReadLine();
        if (hpq1 == "stay")
        {
            Console.WriteLine("");
            Console.WriteLine("You decide to wait a while longer. The town is running low on supplies, and still, no one has come.");
            Console.WriteLine("You are once again wondering if you should stay or continue on your original journey.");
            Console.WriteLine("Type [stay] or [continue]:");

            String hpq2 = Console.ReadLine();
            if (hpq2 == "stay")
            {
                Console.WriteLine("");
                Console.WriteLine("You decide that you will stay in the abandoned town for as long as you are able.");
                Console.WriteLine("After a few days, the towns supplies have run out. Will you Leave or Stay?");
                Console.WriteLine("Type [stay] or [continue]:");

                String hpq3 = Console.ReadLine();
                if (hpq3 == "stay")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You made your choice...");
                    Console.WriteLine("THE END [2/11]");
                    Console.WriteLine("Was this ending good, or bad?");
                }
                else if (hpq3 == "continue")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You finally decide to continue your journey, but it's to late.");
                    Console.WriteLine("You died...");
                    Console.WriteLine("THE END [3/11]");
                    Console.WriteLine("You shouldn't have stayed so long.");
                }
                // Incase the user incorrectly responds, this will prevent the program from glitching (same for all else statements in this program)
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Learn how to type and try again");
                }
            }
            else if (hpq2 == "continue")
            {
                Console.WriteLine("");
                Console.WriteLine("You finally decide to leave the town.");
                Console.WriteLine("You continue travelling for a long time, but never find another town.");
                Console.WriteLine("Eventually, you starve.");
                Console.WriteLine("THE END [4/11]");
                Console.WriteLine("Alone when you woke, and alone when you return to sleep.");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Learn how to type and try again");
            }
        }
        else if (hpq1 == "continue")
        {
            Console.WriteLine("");
            Console.WriteLine("You feel that moving on is the best choice. Don't want to get to comfortable.");
            Console.WriteLine("Hours pass, but you still haven't seen anything other than grass. You are beginning to wonder if you should continue.");
            Console.WriteLine("Type [continue] or [return]:");
            
            String hpq2b = Console.ReadLine();
            if (hpq2b == "continue")
            {
                Console.WriteLine("You travel for a long time, but it seems like you arent making any progress.");
                Console.WriteLine("Type [walk] or [look]");

                String hpq3b = Console.ReadLine();
                if (hpq3b == "walk")
                {
                    Console.WriteLine("You continue walking, hoping that you aren't going in circles.");
                    Console.WriteLine("THE END [5/11]");
                    Console.WriteLine("Will you ever look behind you? Or can you not handle the truth.");
                }
                else if (hpq3b == "look")
                {
                    Console.WriteLine("You look behind you. The town is only a few minutes of walking away.");
                    Console.WriteLine("You're in a loop.");
                    Console.WriteLine("THE END [6/11]");
                    Console.WriteLine("Did you escape, or are you trapped forever?");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Learn how to type and try again");
                }
            }
            else if (hpq2b == "return")
            {
                Console.WriteLine("You decide to make your way back to the town. Maybe you can get more food.");
                Console.WriteLine("THE END [7/11]");
                Console.WriteLine("I wonder if you ever got that food.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Learn how to type and try again");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Learn how to type and try again");
        }
    }
    else if (jpq2 == "continue")
    {
        Console.WriteLine("");
        Console.WriteLine("You decide that you should take the chance and continue travelling.");
        Console.WriteLine("Your gamble paid off! You can see a hill slowly come into your field of view. ");
        Console.WriteLine("There seems to be a small hut sitting on the hill.");
        Console.WriteLine("After arriving at the hut, you find a map. The map has three X's on it.");
        Console.WriteLine("Type [left], [right], [bottom], or [stay]:");

        String jpq3 = Console.ReadLine();
        if (jpq3 == "left")
        {
            Console.WriteLine("");
            Console.WriteLine("After Choosing the left path you start becoming very tired.");
            Console.WriteLine("Unable to hold back, you fall asleep.");
            Console.WriteLine("When you wake up, you realise that all of this was no more than a strange dream.");
            Console.WriteLine("THE END [8/11]");
            Console.WriteLine("Congrats! You got the worst one! (for the player)");
        }
        else if (jpq3 == "right")
        {
            Console.WriteLine("");
            Console.WriteLine("You go towards the X on the right of the map.");
            Console.WriteLine("After walking for a long time, you look back to realise that you are still at the hut.");
            Console.WriteLine("You got stuck in a loop.");
            Console.WriteLine("THE END [9/11]");
            Console.WriteLine("There doesn't always have to be a good ending.");
        }
        else if (jpq3 == "bottom")
        {
            Console.WriteLine("");
            Console.WriteLine("You follow the map towards the bottom X. When you reach the spot, you find a hatch in the ground.");
            Console.WriteLine("After opening the hatch, you discover a large library with many books.");
            Console.WriteLine("You look through several books, but are confused as to why they are all about seemingly random people.");
            Console.WriteLine("When you finally realise that each person is said to be missing, you connect the dots.");
            Console.WriteLine("These people are the residents of the abandoned town.");
            Console.WriteLine("THE END [10/11}");
            Console.WriteLine("Wow, that's creepy.");
        }
        else if (jpq3 == "stay")
        {
            Console.WriteLine("");
            Console.WriteLine("You stay in the hut.");
            Console.WriteLine("I disapprove of this choice.");
            Console.WriteLine("THE END [11/11]");
            Console.WriteLine("Congrats! you got the worst one! (for the character)");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Learn how to type and try again");
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Learn how to type and try again");
    }
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Learn how to type and try again");
}