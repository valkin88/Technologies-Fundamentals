using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> listOfUserAndComments = new Dictionary<string, List<string>>();
            Dictionary<string, List<DateTime>> listOfUserAndDate = new Dictionary<string, List<DateTime>>();
            List<string> users = new List<string>();

            string startinput = Console.ReadLine();
            string userName = String.Empty;
            
            while (true)
            {
                if (startinput == "end of dates")
                {
                    break;
                }

                string[] userInput = startinput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                userName = userInput[0];
                users.Add(userInput[0]);

                if (userInput.Length == 1)
                {
                    listOfUserAndDate.Add(userName, new List<DateTime>());
                }
                else
                {
                    for (int i = 1; i < userInput.Length; i++)
                    {
                        DateTime dateOfLog = DateTime.ParseExact(userInput[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        if (!listOfUserAndDate.ContainsKey(userName))
                        {
                            listOfUserAndDate.Add(userName, new List<DateTime>());
                            listOfUserAndDate[userName].Add(dateOfLog);
                        }
                        else if (listOfUserAndDate.ContainsKey(userName))
                        {
                            listOfUserAndDate[userName].Add(dateOfLog);
                        }
                    }
                }
                startinput = Console.ReadLine();
            }

            string endInput = Console.ReadLine();
            string user = String.Empty;
            string comment = String.Empty;

            while (true)
            {
                if (endInput == "end of comments")
                {
                    break;
                }

                string[] userInput = endInput.Split('-').ToArray();
                user = userInput[0];
                comment = userInput[1];

                if (!listOfUserAndComments.ContainsKey(user))
                {
                    if (users.Contains(user))
                    {
                        listOfUserAndComments.Add(user, new List<string>());
                        listOfUserAndComments[user].Add(comment);
                    }

                }
                else if (listOfUserAndComments.ContainsKey(user))
                {
                    if (users.Contains(user))
                    {
                        listOfUserAndComments[user].Add(comment);
                    }
                }

                endInput = Console.ReadLine();
            }

            foreach (var person in listOfUserAndDate.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{person.Key}" + Environment.NewLine + "Comments:");

                foreach (var name in listOfUserAndComments)
                {

                    foreach (var commentsOfPeople in name.Value)
                    {
                        if (person.Key == name.Key)
                        {
                            Console.WriteLine($"- {commentsOfPeople}");
                        }
                    }
                }
                Console.WriteLine("Dates attended:");

                foreach (var date in person.Value.OrderBy(x => x))
                {
                        Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}
