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
            public override void init() {
                (new image("D:/Imggggggss/fixedlgo.jpg")).tosprite();
            }

            public override void update() {
                //
            }
        }
    }
}