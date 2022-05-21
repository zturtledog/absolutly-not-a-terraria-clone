//# purpose : host the entry
//# contributor : ConfusedParrotfish

using System;

namespace absolutelynotaterrariaclone {
    class Program {
        public static window win;

        static void Main(string[] args) {
            Console.WriteLine(helper.utc());

            win = new subwin();
            win.start(800, 600, "yay a window", "D:/Imggggggss/fixedlgo.jpg");
        }

        class subwin : window {
            public toaster toastr;
            
            public override void init(window win) {
                // Console.WriteLine(new image("D:/imggggggss/vsfrd.png").tosprite());
                toastr = new toaster(2);
                
                toastr.toast("","",new image("D:/Imggggggss/fixedlgo.jpg"),0);
                toastr.toast("","",new image("C:/Users/nycas/Downloads/deno-1536x786.jpg"),0);
                toastr.toast("","",new image("D:/Imggggggss/fixedlgo.jpg"),0);
            }

            public override void update(window win) {
                drawimage(new image("D:/imggggggss/vsfrd.png"), 0, 0); 
                toastr.update(win);
            }
        }
    }
}