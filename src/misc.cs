namespace absolutelynotaterrariaclone {
    public class helper {
        public int map(int v, int m, int x, int nm, int nx) {
            return (v - m) * (nx - nm) / (x - m) + nm;
        }

        public double clamp(int v, int m, int x) {
            if (v > x) {
                return x;
            }else if (v < m) {
                return m;
            }else {
                return v;
            }
        }
    }

    public static class toaster {
        public static void toast(string name, string discription, image icon, int style) {
            //
        }
    }
}