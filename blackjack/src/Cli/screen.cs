using System.Drawing;

namespace Cli {
    enum Color_e {
        GREEN=0,
        RED=1,
        BLACK=2,
        WHITE=3,
        YELLOW=4,
    }

    class Screen {
        private int m_x;
        private int m_y;
        private string[,] m_string = new string[255,255];
        public Screen(int x, int y) {

            m_x = x;
            m_y = y;
        }
        public void clear() {
            for (int x = 0; x < m_x; x++) {
                for (int y = 0; y < m_y; y++) {
                    m_string[y,x] = " ";
                }
            }
        }

        public void set_string(string s, int x, int y, Color_e fg, Color_e bg) {
            for (int i = 0; i < s.Count(); i++) {
                set_pixel(s[i],x+i,y,fg,bg);
            }
        }

        public void set_pixel(char c, int x, int y, Color_e fg, Color_e bg) {
            if (x < 0) {
                x = m_x + x;
            }
            if (y < 0) {
                y = m_y + y;
            }
            m_string[y,x] = c.ToString();
        }

        public void fill(char c, int x1, int y1, int x2, int y2, Color fg, Color bg) {
            Console.WriteLine("Screen.fill() not yet implemented");
        }

        public void draw() {
            Console.Clear();
            for (int i = 0; i < m_x + 2; i++) {
                Console.Write("=");
            }
            Console.WriteLine();
            for (int y = 0; y < m_y; y++) {
                Console.Write("|");
                for (int x = 0; x < m_x; x++) {
                    Console.Write(m_string[y,x]);
                }
                Console.Write("|");
                Console.Write("\n");
            }
            for (int i = 0; i < m_x + 2; i++) {
                Console.Write("=");
            }
            Console.Write("\n");
        }
    }
}