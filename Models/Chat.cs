using System.Collections.Generic;

namespace Module5_TP1.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Couleur { get; set; }

        private static List<Chat> meuteChats;

        private static void InitMeuteDeChats()
        {
            var i = 1;
            meuteChats = new List<Chat>
            {
                new Chat{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new Chat{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new Chat{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new Chat{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new Chat{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new Chat{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new Chat{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }

        public static List<Chat> GetMeuteDeChats()
        {
           if (meuteChats is null)
            {
                InitMeuteDeChats();
            }
            return meuteChats;
        }
    }
}