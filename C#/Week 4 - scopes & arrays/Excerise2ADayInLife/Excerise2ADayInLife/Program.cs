namespace Excerise2ADayInLife
{
    internal class Program
    {
        /*En dag I livet
◦ Du ska simulera de olika sakerna du brukar göra en vanlig skoldag, och hålla reda på din energinivå.
◦ Aktivitet Din energinivå
◦ Vakna på morgonen 70
◦ Äta frukost +30
◦ Lyssna på föreläsning -35
◦ Lunch +30
◦ Jobba med övningar -50
◦ Middag +20
◦ Se TV/Träna/Plugga -65
◦ Skapa en metod som tar in två värden, aktivitet, och nuvarande energinivå.
◦ Metoden returnerar din energinivå efter aktiviteten, som uppdaterar energinivå-variabeln I huvudprogrammet.
◦ Anropa metoden flera gånger, med vilken aktivitet du utför.
◦ Efter varje aktivitet så skriver du ut nuvarande energinivå:
◦ Vaknat: 70%
◦ Ätit frukost: 100%
◦ Lyssnat på föreläsning 65%
◦ …osv
◦ Det går bra att hitta på egna aktiviteter, och “energi-poäng”*/

        //method to update energy based on activity
        static int UpdateEnergy(string activity,int currentEnergy)
        {
          //energy based on activity
          switch(activity)
            {
                case "Vakna":
                    return currentEnergy; // starts at 70%
                case "Äta Frukost":
                    return currentEnergy + 80;
                case "Promenand till skolan":
                    return currentEnergy - 50;
                case "Lyssna på föreläsning":
                    return currentEnergy - 20;
                case "Äta Lunch":
                    return currentEnergy + 30;
                case "Jobba med övningar":
                    return currentEnergy - 40;
                case "Middag":
                    return currentEnergy + 20;
                case "Se TV":
                    return currentEnergy - 30;
                default:
                    return currentEnergy; //no change for unknown activity

            }
        }
        static void Main(string[] args)
        {
            //Starting engery level 
            int currentEnergy = 70;

            //list of activities during the day
            List<string> activities = new List<string>()
            {
                "Vakna",
                "Äta Frukost",
                "Promenand till skolan",
                "Lyssna på föreläsning",
                "Äta Lunch",
                "Jobba med övningar",
                "Middag",
                "Se TV"
            };
            //loop through each activity and update energy level
            foreach(string activity in activities)
            {
                //method calling
                currentEnergy = UpdateEnergy(activity, currentEnergy);
                //Print the current energy level after each activity
                Console.WriteLine($"Efter {activity} :{currentEnergy}% energi");

                Console.ReadLine();
            }
        }
    }
}
