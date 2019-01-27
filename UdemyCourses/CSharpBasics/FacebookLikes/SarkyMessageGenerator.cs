using System;
using System.Collections.Generic;

namespace FacebookLikes
{
    public static class SarkyMessageGenerator
    {

        public static string GenerateSavageAdjective()
        {
            var adjectives = new List<string>()
            {
                "pathetic",
                "sycophantic",
                "vomit-inducing",
                "moribund",
                "tepid",
                "lukewarm",
                "cretinous",
                "miserable",
                "turd-polishing",
                "self-aggrandising",
                "ghastly",
                "arse-licking"
            };

            var random = new Random().Next(adjectives.Count);
            var savageAdjective = adjectives[random];
            return savageAdjective;
        }

        public static string GenerateSadFacebookPostTopic()
        {
            var topics = new List<string>()
            {
                "your wedding",
                "the newest addition to your family of vegetables",
                "veganism",
                "train delays",
                "the weather",
                "an absolutely AMAZING latte leaf",
                "your friend's band",
                "#100DaysOf[insert new fad here]",
                "your new trainers that look soOoo Y2k."
            };
            var random = new Random().Next(topics.Count);
            var randomTopic = topics[random];
            return randomTopic;
        }
      



    }
}
