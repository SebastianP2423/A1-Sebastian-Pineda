// The Robco terminal denies the entry
// Telling the player the security screening that is needed
// Asks for the input


Console.WriteLine("[RobCo Industries Access Terminal]");
Console.WriteLine("[Access Denied]");
Console.WriteLine("[CREDENTIALS NOT PRESENT TO ACCESS ROBCO HEAVY INDUSTRIES MANUFACTURING PLANT]");
Console.WriteLine("*SENTRY BOTS HOLD AT GUNPOINT*");
Console.WriteLine("TERMINAL SECURITY SCREENING AND QUESTIONING PROTOCOLS ENGAGED");
Console.WriteLine("ANSWER IN ACCORDACE OF ROBCO COMPANY STANDARD, UNSATISFYING PERFORMANCE YIELDS CAPITAL PUNISHMENT");
Console.WriteLine("Do you understand these terms? YES/NO");

// The player needs to answer the terminal with its descision
// But also if it refuses the screening

string response = Console.ReadLine().Trim().ToUpper(); // Trim helps remove trailing and leading spaces, and Toupper allows inputs like "yes" 

if (response == "YES")
{
    Console.WriteLine("COMMENCING SECURITY QUESTIONING...");
    // Now we ca proceed with the questioning sequence
}
else if (response == "NO")
{
    Console.WriteLine("*SENTRY BOTS CHARGING WEAPONS*");
    Console.WriteLine("NON-COMPLIANCE REGISTERED. YOU WILL BE TERMINATED.");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("UNRECOGNIZED INPUT. COMPLIANCE FAILURE DETECTED.");
    Console.WriteLine("*TERMINATION IN PROGRESS*");
    Environment.Exit(0);// Exit command is for ending the program simulating the death of the player
}
// I made all the questions Fallout themed so it would better comply with the roleplaying scenario
// The code is structured in a way to allow only YES/NO input

Console.WriteLine("ARE YOU AFFILIATED OR HAD ANY RECENT CONTACT WITH MEMBERS OF THE COMMUNIST PARTY OF CHINA AS OF 2076?");

string answer = Console.ReadLine().Trim().ToUpper();

if (answer =="NO")
{
    Console.WriteLine("ANY AND ALL COLLABORATORS TO THE ENEMY WILL BE DISPATCHED");
    Console.WriteLine("*TERMINATION IN PROGRESS*");
    Environment.Exit(0);
}
else if (answer =="YES") ;
{
    Console.WriteLine("SUFFICIENT ANSWER PREPARE FOR THE FOLOWING QUESTIONS");
}
// Second Question
Console.WriteLine("DO YOU THINK T-60 POWER ARMOR HAS ANY FLAWS?");

string reply = Console.ReadLine().Trim().ToUpper();

if (reply =="YES")
{
    Console.WriteLine("WEST-TEK HAS DISREGARDED ANY FLAWS WITH LATEST MODELS.... ANY OBJECTION IS CONSIDERED TREASON");
    Console.WriteLine("*TERMINATION IN PROGRESS*");
    Environment.Exit(0);
}
else if (reply =="NO") ;
{
    Console.WriteLine("ANSWER RECORDED TO BE USED AS PART OF NATIONAL SURVEY :)");
}
// Question 3
Console.WriteLine("ARE ROBCO'S MR HANDY UTILITY ROBOTS SAFE FOR FAMILY STANDARDS?");
string answer1 = Console.ReadLine().Trim().ToUpper();

if (answer1 == "YES")
{
    Console.WriteLine("FEEDBACK NOTED..... WE AT ROBCO ARE CONTENT WITH CUSTOMER CONCERNS.");
}
else if (answer1 == "NO")
{
    Console.WriteLine("MR HANDY'S HAVE HAD NO PRIOR NEGATIVE FEEDBACK.");
    Console.WriteLine("*OUTLIER FEEDBACK WILL BE TERMINATED*");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("UNRECOGNIZED INPUT. COMPLIANCE FAILURE DETECTED.");
    Environment.Exit(0);
}

// I ran out of questions i could make up without it being too edgy, Fallout mocks a lot of things
Console.WriteLine("[SCREENING COMPLETE. YOU MAY PROCEED.]");

