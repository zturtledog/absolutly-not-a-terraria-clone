using System.Collections;

namespace absolutelynotaterrariaclone {
    public class worls {
        //
    }

    public class chunk {
        tilemap tilemp;
        int ox, oy;
        bool haseddit = false;

        public chunk(int x, int y, tilemap tiles) {
            tilemp = tiles;
            ox = x;
            oy = y;
        }

        public void draw(window win) {
            //
        }

        public void setile(int x, int y, id i) {
            tilemp.set(x,y,i);
        }

        public id getile(int x, int y) {
            return tilemp.get(x, y);
        }
    }

    public class tilemap {
        public id get(int x, int y) {
            return new id();
        }

        public void set(int x, int y, id i) {
            //
        }
    }

    public class id {
        ArrayList list; 

        public string sgnbt(string name) {
            return "";
        }

        public double ngnbt(string name) {
            return 0;
        }

        public bool bgnbt(string name) {
            return true;
        }

        public void ssnbt(string name) {
            //
        }

        public void nsnbt(string name) {
            //
        }

        public void bsnbt(string name) {
            //
        }
    }
}