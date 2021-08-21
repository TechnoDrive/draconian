namespace Implementation.Language {
    public struct Location {
        public string File;
        public int Line;
        public int Column;

        public Location(string file, int line, int column) {
            File = file;
            Line = line;
            Column = column;
        }
    }
}