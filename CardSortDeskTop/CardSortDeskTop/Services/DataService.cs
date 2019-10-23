//using CardSortDeskTop.Structure;
using CardSortDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSortDeskTop.Services
{
    class DataService
    {
        public static List<Deck> decks = new List<Deck>();
        public static List<Card> GetCardsFromDeck(string deckName)
        {
            Deck deck = decks.Find(x => x.Name == deckName);
            try
            {
                switch (deck.Type)
                {
                    case "Commander":
                        CommanderDeck commanderDeck = deck as CommanderDeck;
                        return commanderDeck.Cards;
                    case "Standard":
                        StandardDeck standardDeck = deck as StandardDeck;
                        return standardDeck.Cards;
                    case "Extras":
                        ExtraCards extraCards = deck as ExtraCards;
                        return extraCards.Cards;
                }
            }
            catch (Exception e)
            {
                //implement error handling
                Console.WriteLine("something went wrong and the deck could not be opened." + e.Message);
            }

            return null;
        }

        public static string[] GetDeckNames()
        {
            string[] names = new string[decks.Count];
            int i = 0;

            foreach(Deck deck in decks)
            {
                names[i] = deck.Name;
            }

            return names;
        }

        public static void AddCardToDeck(Deck deck, Card card)
        {
            switch (deck.Type)
            {
                case "Commander":
                    CommanderDeck commanderDeck = deck as CommanderDeck;
                    commanderDeck.AddCard(card);
                    return;
                case "Standard":
                    StandardDeck standardDeck = deck as StandardDeck;
                    standardDeck.AddCard(card);
                    return;
                case "Extras":
                    ExtraCards extraCards = deck as ExtraCards;
                    extraCards.AddCard(card);
                    return;
                default:
                    //Handle Error
                    return;
            }
        }

        private static Deck CreateDeck(string name, string type)
        {
            switch (type)
            {
                case "Commander":
                    CommanderDeck commander = new CommanderDeck(name, type);
                    return commander;
                case "Standard":
                    StandardDeck standard = new StandardDeck(name, type);
                    return standard;
                case "Extras":
                    ExtraCards extras = new ExtraCards(name, type);
                    return extras;
                default:
                    //Implement error handling
                    return null;
            }
        }

    }
}
