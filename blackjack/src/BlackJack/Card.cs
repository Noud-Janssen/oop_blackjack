namespace Blackjack {

    enum Card_types_e {
        CARD_HEART,
        CARD_CLUBS,
        CARD_DIAMONDS,
        CARD_SPADES
    }
    class Card {
        private Card_types_e m_type;
        private int m_value;
        public Card(int value, Card_types_e type) {
            m_value = value;
            m_type = type;
        }
        public int get_value() {

            return m_value;
        }

        public Card_types_e get_type() {
            return m_type;
        }
    }
}