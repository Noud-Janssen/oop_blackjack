
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Blackjack {
    class Card_container {

        private List<Card> m_cards = new List<Card>();

        public void add(Card card) {
            m_cards.Add(card);
        }

        public Card get(int i) {
            return m_cards[i];
        }

        public int get_size() {
            return m_cards.Count();
        }

        public int get_total() {
            int total = 0;
            foreach (Card card in m_cards) {
                total += card.get_value();
            }
            return total;
        }

        public bool discard(Card_container container) {
            for (int i = 0; i < get_total() ; i++) {
                container.add(m_cards[i]);
                m_cards.RemoveAt(i);
            }
            return true;
        }

        public bool draw(Card_container container) {
            Random rnd = new Random();
            int i = rnd.Next(container.get_size());
            m_cards.Add(container.get(i));
            container.remove(i);
            return true;
        }

        public void remove(int i) {
            m_cards.RemoveAt(i);
        }

        public void fill() {
            clear();
            for (int i = 0; i < 13; i++) {
                Card card_h = new Card(i + 1, Card_types_e.CARD_HEART);
                Card card_c = new Card(i + 1, Card_types_e.CARD_CLUBS);
                Card card_s = new Card(i + 1, Card_types_e.CARD_SPADES);
                Card card_d = new Card(i + 1, Card_types_e.CARD_DIAMONDS);
                add(card_h);
                add(card_c);
                add(card_s);
                add(card_d);
            }
        }

        public void clear() {
            m_cards.Clear();
        }

        public void debug() {
            foreach (Card card in m_cards) {
                Console.WriteLine(card.get_type().ToString() + " - " + card.get_value().ToString());
            }
        }
    }
}