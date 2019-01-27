using System;
using System.Collections.Generic;

namespace FacebookLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello slave of Facey B. I am your friend. Let's see how many friends are pretending " +
                                    "to like your pathetic posts.");
            Console.WriteLine("Type something inane to continue our journey, or press the enter key " +
                              "at any time to leave...");

            var userInput = Console.ReadLine().ToLower();
            var friendsWhoLike = new List<string>();

            if (!String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Type in a name of a friend ooh friend! Keep typing in names and then press Enter" +
                                  "to see how many of them are feigning interest in your life.");
                var friend = Console.ReadLine();
                while (!String.IsNullOrWhiteSpace(friend))
                {
                    friendsWhoLike.Add(friend);

                    Console.WriteLine("Type in another name of a friend ooh friend!");
                    friend = Console.ReadLine();
                }
            }

            var restOfFriends = friendsWhoLike.Count - 2;
            var sarkyMessage = friendsWhoLike.Count > 2 ?
                                             $"{friendsWhoLike[0]}, {friendsWhoLike[1]} and {restOfFriends} others" +
                                             $" like your {SarkyMessageGenerator.GenerateSavageAdjective()} post" +
                                             $" about {SarkyMessageGenerator.GenerateSadFacebookPostTopic()}."
                                             :
                                             $"{friendsWhoLike[0]} and {friendsWhoLike[1]} like your " +
                                             $"{SarkyMessageGenerator.GenerateSavageAdjective()} post" +
                                             $" about {SarkyMessageGenerator.GenerateSadFacebookPostTopic()}.";

            Console.WriteLine(sarkyMessage);
            Console.WriteLine("Now I've got all your data HA HA! Bye dickhead!");
        }

    }
}
