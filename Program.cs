//# purpose : to contain the main renderer and host the entry
//# contributor : ConfusedParrotfish

using System.Collections;
using System;
using SFML.Graphics;
using SFML.Window;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace absolutelynotaterrariaclone {
    class Program {
        static void Main(string[] args) {
            window win = new window();
            win.start(800, 600, "yay a window");
            // win.loadsprite("D:/Imggggggss/fixedlgo.jpg");
        }
    }

    class window {
        RenderWindow _window;

        ArrayList rndrordr;

        public void start(int width, int height, string title) {
            _window = new RenderWindow(new VideoMode((uint)width, (uint)height), "SFML window");
            _window.SetVisible(true);

            //. add event handlers
                //# add event of which activates when closed
            _window.Closed += new EventHandler(OnClosed); // this is very much cursed

            init();

            //.main update
            while (_window.IsOpen) {
                _window.DispatchEvents();
                update();
                _window.Display();
            }
        }
        void OnClosed(object sender, EventArgs e) {
            _window.Close();
        }

        public virtual void init() {
            //
        }

        public virtual void update() {
            //
        }

    }
}
