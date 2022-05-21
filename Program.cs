//# purpose : host the entry
//# contributor : ConfusedParrotfish

using System;

namespace absolutelynotaterrariaclone {
    class Program {
        static void Main(string[] args) {
            subwin win = new subwin();
            win.start(800, 600, "yay a window", "D:/Imggggggss/fixedlgo.jpg");
        }

        class subwin : window {
            public override void init(window win) {
                Console.WriteLine(new image("D:/imggggggss/vsfrd.png").tosprite());
                mousedown("");
            }

            public override void update(window win) {
                drawimage(new image("D:/imggggggss/vsfrd.png"), 0, 0);
            }
        }
    }
}