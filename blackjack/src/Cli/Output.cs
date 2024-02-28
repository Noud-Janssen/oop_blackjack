using Base;

namespace Cli {
    class Output {
        private Main_state_e m_state;
        private Screen m_screen = new Screen(100,20);
        public Output(Main_state_e state) {

        }
        public void print() {
            m_screen.clear();
            switch (m_state)
            {
                case Main_state_e.MAIN_MENU:
                    draw_main_menu();
                    break;
                case Main_state_e.MAIN_HELP:
                    draw_help();
                    draw_back();
                    break;
                default:
                    break;
            }
            m_screen.draw();
        }

        public void set_state(Main_state_e state) {
            m_state = state;
        }
        private void draw_main_menu() {
            m_screen.set_string("BlackJack!",45,5,Color_e.WHITE,Color_e.BLACK);
            m_screen.set_string("start",47,10,Color_e.WHITE,Color_e.BLACK);
            m_screen.set_string("help",47,11,Color_e.WHITE,Color_e.BLACK);
            m_screen.set_string("exit",47,12,Color_e.WHITE,Color_e.BLACK);
        }

        private void draw_help() {
            m_screen.set_string("help! helphelp help",45,9,Color_e.WHITE,Color_e.BLACK);
            m_screen.set_string("helphelphelp help",47,10,Color_e.WHITE,Color_e.BLACK);
            m_screen.set_string("help   help help",47,11,Color_e.WHITE,Color_e.BLACK);
            m_screen.set_string("help help help",47,12,Color_e.WHITE,Color_e.BLACK);
        }
        private void draw_back() {
            m_screen.set_string(" <- Back <- ",0,-1,Color_e.WHITE,Color_e.BLACK);
        }
    }
}