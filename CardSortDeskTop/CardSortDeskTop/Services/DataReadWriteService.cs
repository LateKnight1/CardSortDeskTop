using CardSortDataTypes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace CardSortDeskTop.Services
{
    class DataReadWriteService
    {
        private static HttpClient httpClient = new HttpClient();

        public static async Task<bool> WriteDeckToDataBase(Deck deck)
        {
            var requestUri = new Uri($"http://cardsortapi.net/api/decks");
            var username = new StringContent("swordmasterd");
            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(username, "username");
            content.Add(new StringContent(deck.Name), "name");
            content.Add(new StringContent(deck.Type), "type");

            try
            {
                var message = await httpClient.PostAsync(requestUri, content);
                message.EnsureSuccessStatusCode();
            }
            catch(Exception e)
            {
                // implement error handling
                Console.WriteLine(e.Message);
            }
            return true;
        }

        public static async Task<bool> GetDecks()
        {
            List<Deck> decks = new List<Deck>();

            Uri requestUri = new Uri($"http://cardsortapi.net/api/Decks?username={"swordmasterd"}");

            HttpResponseMessage responseMessage;

            try
            {
                responseMessage = await httpClient.GetAsync(requestUri);
                responseMessage.EnsureSuccessStatusCode();
                string response = await responseMessage.Content.ReadAsStringAsync();
                response = response.Replace("\"", "");
                response = response.Replace("\\", "");
                response = response.Replace("{", "");
                response = response.Replace("}", "");
                response = response.Replace("[", "");
                response = response.Replace("]", "");
                var valuesArray = response.Split(',');
                for (int i = 0; i < valuesArray.Length; i++)
                {
                    string name = GetValueFromResult(valuesArray[i]);
                    i++;
                    string type = GetValueFromResult(valuesArray[i]);

                    var deck = DataService.CreateDeck(name, type);
                    decks.Add(deck);
                }
            }
            catch (Exception e)
            {
                //TODO: implement error handling here
            }
            DataService.decks = decks;
            return true;
        }

        public static async Task<bool> GetCardsForDeck(string deckName)
        {
            var deck = DataService.decks.Find(d => d.Name == deckName);
            Uri requestUri = new Uri($"http://cardsortapi.net/api/Cards?username={"swordmasterd"}&deckName={deckName}");

            HttpResponseMessage responseMessage;

            try
            {
                responseMessage = await httpClient.GetAsync(requestUri);
                responseMessage.EnsureSuccessStatusCode();
                string response = await responseMessage.Content.ReadAsStringAsync();
                response = response.Replace("\"", "");
                response = response.Replace("\\", "");
                response = response.Replace("{", "");
                response = response.Replace("}", "");
                response = response.Replace("[", "");
                response = response.Replace("]", "");
                var valuesArray = response.Split(',');
                for (int i = 0; i < valuesArray.Length; i++)
                {
                    string id, name, type, d, colors, rarity, cost;
                    id = GetValueFromResult(valuesArray[i]);
                    i++;
                    name = GetValueFromResult(valuesArray[i]);
                    i++;
                    type = GetValueFromResult(valuesArray[i]);
                    i++;
                    d = GetValueFromResult(valuesArray[i]);
                    i++;
                    colors = GetValueFromResult(valuesArray[i]);
                    i++;
                    rarity = GetValueFromResult(valuesArray[i]);
                    i++;
                    cost = GetValueFromResult(valuesArray[i]);
                    int.TryParse(id, out int iid);
                    Card card = new Card(iid, name, type, d, colors, rarity, cost);
                    DataService.AddCardToDeck(deck, card);
                }
            }
            catch(Exception e)
            {
                //Handle Error
            }
            return true;
        }

        private static string GetValueFromResult(string result)
        {
            return result.Split(':')[1];
        }

    }
}
