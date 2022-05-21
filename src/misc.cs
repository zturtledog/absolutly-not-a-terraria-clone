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
                    win.drawimage(peek.thumbnail().resizeImage(64,64), ((int)win.size().x())-80, 90);
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
        }
    }
}