namespace Par_prog3;

class Program
{
     static List<ChatBot> chatBots = new List<ChatBot>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Chættbått Meny ---");
                Console.WriteLine("1. Mekke en chættbått");
                Console.WriteLine("2. Preke med en chættbått");
                Console.WriteLine("3. Avslutt");
                Console.Write("Velg et alternativ: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateChatBot();
                        break;
                    case "2":
                        TalkToChatBot();
                        break;
                    case "3":
                        Console.WriteLine("Ha det bra!");
                        return;
                    default:
                        Console.WriteLine("Ugyldig valg, prøv igjen.");
                        break;
                }
            }
        }

        static void CreateChatBot()
        {
            Console.Write("Hva skal chættbått'n hete? ");
            string name = Console.ReadLine();
            ChatBot newBot = new ChatBot(name);

            Console.WriteLine($"Chættbått’n {name} er opprettet!");
            while (true)
            {
                Console.Write("Legg til en mulig respons (eller skriv 'ferdig' for å avslutte): ");
                string response = Console.ReadLine();
                if (response.ToLower() == "ferdig")
                    break;
                
                newBot.AddResponse(response);
                Console.WriteLine($"Respons lagt til: {response}");
            }

            chatBots.Add(newBot);
            Console.WriteLine($"{name} er klar til bruk!");
        }

        static void TalkToChatBot()
        {
            if (chatBots.Count == 0)
            {
                Console.WriteLine("Det finnes ingen chættbåtts ennå! Lag en først.");
                return;
            }

            Console.WriteLine("Tilgjengelige chættbåtts:");
            for (int i = 0; i < chatBots.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {chatBots[i].Name}");
            }

            Console.Write("Velg hvilken chættbått du vil snakke med (tall): ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= chatBots.Count)
            {
                ChatBot selectedBot = chatBots[choice - 1];
                Console.WriteLine($"Du snakker nå med {selectedBot.Name}.");
                while (true)
                {
                    Console.Write("Du: ");
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower() == "exit")
                    {
                        Console.WriteLine("Avslutter samtalen...");
                        break;
                    }

                    Console.WriteLine($"{selectedBot.Name}: {selectedBot.GetRandomResponse()}");
                }
            }
            else
            {
                Console.WriteLine("Ugyldig valg, prøv igjen.");
            }
        }
    }

