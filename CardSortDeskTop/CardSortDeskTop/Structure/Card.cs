namespace CardSortDeskTop.Structure
{
    internal class Card
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Deck { get; private set; }
        public string Colors { get; private set; }
        public string Rarity { get; private set; }
        public string Costs { get; private set; }

        public Card(int id, string name, string type, string deck, string colors, string rarity, string costs)
        {
            Id = id;
            Name = name;
            Type = type;
            Deck = deck;
            Colors = colors;
            Rarity = rarity;
            Costs = costs;
        }

        public override string ToString()
        {
            return
                $"Name: {Name}\r\nType: {Type}\r\nDeck: {Deck}\r\nColors: {Colors}\r\nRarity: {Rarity}\r\nCosts: {Costs}";
        }

        internal void UpdateCard(int id, string name, string type, string colors, string rarity, string costs)
        {
            Id = id;
            Name = name;
            Type = type;
            Colors = colors;
            Rarity = rarity;
            Costs = costs;
        }

        internal void TransferCard(string deck)
        {
            Deck = deck;
        }
    }
}
