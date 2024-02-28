using System.Drawing;
using Cli;

namespace Base {
    enum Main_state_e {
        MAIN_MENU,
        MAIN_HELP,
        GAME_INLAY,
        GAME_TURN,


    }
    class Main_app {
        static Main_state_e m_state = Main_state_e.MAIN_MENU;
        static Input m_input = new Input();
        static Output m_output = new Output(Main_state_e.MAIN_MENU);


        public static void Main() {
            m_output.print();
            while (true) {
                switch (m_input.read())
                {
                    case "exit":
                        return;
                    case "help":
                        m_output.set_state(Main_state_e.MAIN_HELP);
                        break;
                    default:
                        break;
                }
                m_output.print();
            }
        }
    }
}

