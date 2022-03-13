using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDatabaseProject
{
    interface CRUD
    {
        ICollection<MonsterCard> GetMonsterCards();
        ICollection<SpellCard> GetSpellCards();
        void AddCard(MonsterCard card);
        void RemoveCard(MonsterCard card);
        void AddSpell(SpellCard card);
        void RemoveCard(SpellCard card);
        void updateCard(string id_code, MonsterCard montochange);
        void updateCard(string id_code, SpellCard montochange);

        SpellCard FindSpell(string id_code);
        MonsterCard FindMonster(string id_code);

        bool ValidUser(string username, string password);
    }
    class CardRepository : CRUD
    {
        Card_DatabaeEntities1 entities;
        public CardRepository()  //call repository from database
        {
            entities = new Card_DatabaeEntities1();
        }


        public void AddCard(MonsterCard card) // Add new Monster cards to database
        {
            entities.MonsterCards.Add(card);
            entities.SaveChanges();
        }

        public void AddSpell(SpellCard card) //Add new spell cards to database
        {
            entities.SpellCards.Add(card);
            entities.SaveChanges();
        }

        public MonsterCard FindMonster(string id_code)
        {
            var card = entities.MonsterCards.First(c => c.Id_Code == id_code);
            if (card != null)
            {
                return card;
            }
            else
                return null;

        }

        public SpellCard FindSpell(string id_code)
        {
            var card=entities.SpellCards.First(s=>s.Id_Code == id_code);
            if (card != null)
            {
                return card;
            }
            else
                return null;
        }

        public ICollection<MonsterCard> GetMonsterCards() // get repository from monster database
        {
            return entities.MonsterCards.ToList();
        }

        public ICollection<SpellCard> GetSpellCards() // get repsository from spell database
        {
            return entities.SpellCards.ToList();
        }

        public void RemoveCard(MonsterCard card)// remove Monster cards from database
        {
            entities.MonsterCards.Remove(card);
            entities.SaveChanges();
        }

        public void RemoveCard(SpellCard card)// remove Spell cards from database
        {
            entities.SpellCards.Remove(card);
            entities.SaveChanges();
        }

        public void updateCard(string id_code, MonsterCard montochang)
        {
            var cardtochange = entities.MonsterCards.Find(id_code);
            cardtochange.Id_Code = montochang.Id_Code;
            cardtochange.Name = montochang.Name;
            cardtochange.Attack = montochang.Attack;
            cardtochange.Defences = montochang.Defences;
            cardtochange.Edition = montochang.Edition;
            cardtochange.Price= montochang.Price;
            entities.SaveChanges();
        }

        public void updateCard(string id_code, SpellCard montochange)
        {
            var cardtochange = entities.SpellCards.Find(id_code);
            cardtochange.Id_Code=montochange.Id_Code;
            cardtochange.Card_Name = montochange.Card_Name;
            cardtochange.Trap_bit = montochange.Trap_bit;
            cardtochange.Magic= montochange.Magic;
        }

        public bool ValidUser(string username, string password)
        {
            var user = (from u in entities.Logins
                        where u.username == username & u.password == password
                        select u).FirstOrDefault();
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}
