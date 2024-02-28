
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Blackjack {
    class Card_container {

        private List<Card> m_cards;

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
            return true;
        }
    }
}