namespace DutchTreat.Services {
    public interface IPracticeASP {

        public List<T> collectionOfThings<T,H>(T thing1, H thing2);
        public int Add(params int[] numbers);
        public int arrayPrac();
    }
}
