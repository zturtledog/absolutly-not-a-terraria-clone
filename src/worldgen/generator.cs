namespace absolutelynotaterrariaclone {
    public class generator {
        public generator(int ww, int wh, biome[] biomes) {
            //
        }

        public chunk generate(int ox, int oy) {
            return new chunk(ox,oy,new tilemap());
        }
    }
}