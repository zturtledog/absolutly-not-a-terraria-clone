//# purpose : host the entry
//# contributor : ConfusedParrotfish

using System;

namespace absolutelynotaterrariaclone {
    class Program {
        public static window win;

        //. testing
        
        static int fps,avg,times;
        static long putc;

        //. entrypoint

        static void Main(string[] args) {
            win = new subwin();
            win.start(800, 600, "yay a window", "D:/Imggggggss/fixedlgo.jpg");
        }

        //. implementation

        class subwin : window {
            public toaster toastr;
            
            public override void init(window win) {
                // Console.WriteLine(new image("D:/imggggggss/vsfrd.png").tosprite());
                toastr = new toaster(20);
                
                toastr.toast("one","The first one",new image("D:/Imggggggss/fixedlgo.jpg"),0);
                toastr.toast("two","the second two",new image("C:/Users/nycas/Downloads/deno-1536x786.jpg"),2);
                toastr.toast("three","the third three",new image("D:/Imggggggss/fixedlgo.jpg"),1);

                loadfont("src/assets/Quicksand-Regular.ttf");
            }

            public override void update(window win) {
                clear();
                drawimage(new image("D:/imggggggss/vsfrd.png"), 0, 0); 
                text("hello",0,0,12);
                toastr.update(win);

                if(helper.utc()!=putc){avg+=fps;times++;fps=0;}putc=helper.utc();fps++;
            }

            public override void close(window win) {
                Console.WriteLine("---------------------------\n"+avg/times);
            }
        }
    }
}