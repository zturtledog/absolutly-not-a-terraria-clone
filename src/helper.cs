namespace absolutelynotaterrariaclone {
    class helper {
        public int map(int v, int m, int x, int nm, int nx) {
            return (v - m) * (nx - nm) / (x - m) + nm;
        }
    }
}