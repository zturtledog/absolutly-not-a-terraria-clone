using System;
using System.Collections;

namespace absolutelynotaterrariaclone {
    public static class helper {
        public static int map(int v, int m, int x, int nm, int nx) {
            return (v - m) * (nx - nm) / (x - m) + nm;
        }

        public static double clamp(int v, int m, int x) {
            if (v > x) {
                return x;
            }else if (v < m) {
                return m;
            }else {
                return v;
            }
        }

        public static long utc() {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
        }
    }

    public class timer {
        int time;
        long st;

        public timer(int time) {
            this.time = -time;
            st = helper.utc();
        }
        
        public void start() {
            while (st-helper.utc() < time) {
                update();
            }
            end();
        }
        
        // public Func<> update;
        public virtual void update() {
            //
        }

        public virtual void end() {
            //
        }
    }

    public class toaster {
        Stack que = new Stack();
        int maxtime;
        long st;
        bool active = true;
        image b1 = new image("src/assets/border1.png").resizeImage(246,68);
        image b2 = new image("src/assets/border2.png").resizeImage(246,68);
        image b3 = new image("src/assets/border3.png").resizeImage(246,68);

        public toaster(int mt) {
            maxtime = mt;
            st = helper.utc();
        }

        public void toast(string name, string discription, image icon, int style) {
            que.Push(new trst(name,discription,icon,style));
        }

        public void update(window win) {
            if (que.Count > 0) {
                if (st-helper.utc() < -maxtime) {
                    active = false;
                    que.Pop();
                    if (que.Count > 0) {
                        active = true;
                        st = helper.utc();
                    }
                }
                if (active) {
                    trst peek = (trst)que.Peek();
                    if (peek.style() == 0) {
                        win.drawimage(b1,((int)win.size().x())-246,5);
                    }else if (peek.style() == 1) {
                        win.textcol(new color("#000000ff"));
                        win.drawimage(b2,((int)win.size().x())-246,5);
                    }else if (peek.style() == 2) {
                        win.textcol(new color("#000000ff"));
                        win.drawimage(b3,((int)win.size().x())-246,5);
                    }

                    win.text(peek.title(), ((int)win.size().x())-175, 20, 20);
                    win.text(peek.sub(), ((int)win.size().x())-162, 37, 15);
                    win.drawimage(peek.thumbnail().resizeImage(48,48), ((int)win.size().x())-237, 16);
                }
            }else{
                st = helper.utc();
            }
        }

        class trst {
            string name, disc;
            image icon;
            int styl;

            public trst(string name, string discription, image icon, int style) {
                this.name = name;
                this.disc = discription;
                this.icon = icon;
                this.styl = style;
            }

            public image thumbnail() {
                return icon;
            }

            public string title() {
                return name;
            }

            public string sub() {
                return disc;
            }

            public int style() {
                return styl;
            }
        }
    }
}