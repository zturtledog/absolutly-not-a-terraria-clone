//# purpose : to contain the main renderer and host the entry
//# contributor : ConfusedParrotfish

using System.Text.Json;
using System.Text.Json.Serialization;

namespace absolutelynotaterrariaclone {
    class Program {
        static void Main(string[] args) {
            subwin win = new subwin();
            win.start(800, 600, "yay a window");
            // win.loadsprite("D:/Imggggggss/fixedlgo.jpg");
        }

        class subwin : window {
            public override void init() {
                //
            }

            public override void update() {
                //
            }
        }
    }
}