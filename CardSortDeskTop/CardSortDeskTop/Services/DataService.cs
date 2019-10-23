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
    }
}
