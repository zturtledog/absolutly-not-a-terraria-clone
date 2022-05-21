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
            }

            public override void update(window win) {
                drawimage(new image("D:/imggggggss/vsfrd.png"), 0, 0);
            }
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