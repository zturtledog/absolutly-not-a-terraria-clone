//# purpose : window handling
//# contributor : ConfusedParrotfish

using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Collections;
using System.Threading;
using System;

namespace absolutelynotaterrariaclone
{
    class window {
        RenderWindow _window;

        Vector2u winsize;

        public void start(int width, int height, string title, string icon) {
            Image image = new Image(icon);

            _window = new RenderWindow(new VideoMode((uint)width, (uint)height), "SFML window");
            _window.SetVisible(true);
            _window.SetIcon(image.Size.X, image.Size.Y, image.Pixels);

            winsize = _window.Size;

            //. add event handlers
            //# add event of which activates when closed
            _window.Closed += new EventHandler(OnClosed); // this is very much cursed
            _window.Resized += new EventHandler<SFML.Window.SizeEventArgs>(bores); // this is very much cursed

            //. main update  
            while (_window.IsOpen) {
                _window.DispatchEvents();



                update(this);
                _window.Display();
            }
        }

        //. inputs

        public bool mousedown(string side) {
            if (side == "left") {
                return Mouse.isButtonPressed(Mouse.Left);
            } else if (side == "right") {
                return Mouse.isButtonPressed(Mouse.Right);
            } else if (side == "middle") {
                return Mouse.isButtonPressed(Mouse.Middle);
            }
            return false;
        }

        //. events

        void OnClosed(object sender, EventArgs e) {
            // thread.Abort();
            _window.Close();
        }

        void bores(object sender, SizeEventArgs e) {
            // Console.WriteLine();
            _window.SetView(new View((new FloatRect(0, 0, e.Width, e.Height))));
            onresize(this);
            // _window.Viewport = 
        }

        //. overides

        public virtual void init(window win) {
            //
        }

        public virtual void update(window win) {
            //
        }

        public virtual void onresize(window win) {
            //
        }

        //. getters

        public vec2d size() {
            return new vec2d((int)_window.Size.X, (int)_window.Size.Y);
        }

        public vec2d mapliplier(float w, float h) {
            return new vec2d(
                (double)((w) * (winsize.X) / (_window.Size.X)),
                (double)((h) * (winsize.Y) / (_window.Size.Y))
            );
        }

        //. component renderers

        public void drawimage(image _image, int x, int y) {
            // vec2d nwidth = mapliplier(_image.width(), _image.height());
            // _image.resizeImage((float)nwidth.x(),(float)nwidth.y());
            Sprite spr = _image.tosprite();
            spr.Position = new Vector2f((float)x, (float)y);
            // Console.WriteLine(spr);            
            _window.Draw(spr);
        }
        public void ellipse(int x, int y, int w, int h) {
            // ConvexShape ellipse;
            // ellipse.setPointCount(70);

            // for(int i = 0; i<70; i++){
            //     float rad=(360/70*i)/(360/MathF.PI/2);
            //     float ix=MathF.Acos(rad)*w;
            //     float iy=MathF.Asin(rad)*h;

            //     ellipse.setPoint(i,new Vector2(ix+x,iy+y));
            // };

            // ellipse.setPosition(100,100);
        }
        public void rect() {
            //
        }
        public void triangle() {
            //
        }
        public void point() {
            //
        }
        public void text() {
            //
        }
    }

    public class image {
        public Image actial;

        public image(string path) {
            actial = new Image(path);
        }

        public image(int width, int height) {
            actial = new Image((uint)width, (uint)height, new Color(0, 0, 0));
        }

        public image(vec2d vc) {
            actial = new Image((uint)vc.x(), (uint)vc.y(), new Color(0, 0, 0));
        }

        // public Image img() {
        //     return actial;
        // }

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

            return sprite;
        }

        public void resizeImage(float pw, float ph) {
            // (sf::Image p_image,float p_width, float p_height
            // Sprite spriteTmp = new Sprite();
            // actial.Size = new Vector2u((uint)pw, (uint)ph);
            // spriteTmp.Texture = new Texture(actial);
            // Console.WriteLine(spriteTmp);
            // spriteTmp.Texture.Size = ;
            // RenderImage img;
            // img.Clear(Color(0,0,0,255));
            // img.Draw(spriteTmp);
            // img.display();
            // return img.GetImage();

            vec2d osize = new vec2d(actial.Size);
            vec2d risize = new vec2d(pw, ph);
            Image rimg = new Image((uint)pw, (uint)ph, new Color(0, 0, 0));

            for (uint y = 0; y < risize.y(); ++y) {
                for (uint x = 0; x < risize.x(); ++x) {
                    uint origX = (uint)((double)(x) / risize.x() * osize.x());
                    uint origY = (uint)((double)(y) / risize.y() * osize.y());
                    rimg.SetPixel(x, y, actial.GetPixel(origX, origY));
                }
            }

            actial = rimg;
        }
    }

    public class vec2d {
        double ix;
        double iy;

        public vec2d(double x, double y) {
            ix = x;
            iy = y;
        }

        public vec2d(Vector2u size) {
            ix = (double)size.X;
            iy = (double)size.Y;
        }

        public vec2d(Vector2f size) {
            ix = (double)size.X;
            iy = (double)size.Y;
        }

        public double x() {
            return ix;
        }

        public double y() {
            return iy;
        }

        public Vector2u tovecu() {
            return new Vector2u((uint)ix, (uint)iy);
        }

        public Vector2f tovecf() {
            return new Vector2f((float)ix, (float)iy);
        }
    }
}
/*[RenderWindow] 
Size([Vector2u] X(800) Y(600)) 
Position([Vector2i] X(560) Y(240)) 
Settings([ContextSettings] 
    DepthBits(0) 
    StencilBits(0) 
    AntialiasingLevel(0) 
    MajorVersion(4) 
    MinorVersion(6) 
    AttributeFlags(Default)) 
DefaultView([View] 
    Center([Vector2f] X(400) Y(300)) 
    Size([Vector2f] X(800) Y(600)) 
    Rotation(0) 
    Viewport([FloatRect] 
        Left(0) 
        Top(0) 
        Width(1) 
        Height(1))) 
View([View] 
    Center([Vector2f] X(400) Y(300)) 
    Size([Vector2f] X(800) Y(600)) 
Rotation(0) 
Viewport([FloatRect] 
    Left(0) 
    Top(0) 
    Width(1) 
    Height(1)))
*/