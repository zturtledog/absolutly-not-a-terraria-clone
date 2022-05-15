//# purpose : render the window
//# contributor : ConfusedParrotfish

using SFML.Graphics;
using SFML.Window;
using System.Collections;
using System.Threading;
using System; 

namespace absolutelynotaterrariaclone
{
    class window {
        RenderWindow _window;

        public void start(int width, int height, string title, string icon) {
            Image image = new Image(icon);

            _window = new RenderWindow(new VideoMode((uint)width, (uint)height), "SFML window");
            _window.SetVisible(true);
            _window.SetIcon(image.Size.X, image.Size.Y,image.Pixels);

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

        public class image {
            public Image actial;
            
            public image(string path) {
                actial = new Image(path);
            }

            public int width() {
                return (int)actial.Size.X;
            }

            public int height() {
                return (int)actial.Size.Y;
            }

            public Object pixels() {
                return actial.Pixels;
            }

            public Sprite tosprite() {
                Sprite sprite = new Sprite();
                sprite.Texture = new Texture(actial);

                Console.WriteLine(sprite);

                return sprite;
            }
        }
    }
}