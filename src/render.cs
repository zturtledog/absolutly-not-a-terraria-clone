using SFML.Graphics;
using SFML.Window;
using System.Collections;
using System;

namespace absolutelynotaterrariaclone
{
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