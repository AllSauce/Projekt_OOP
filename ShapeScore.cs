namespace ThiccShapes
{
    public class ShapeScore
    {
        private int[] SC = new int[7];
        public  void setSC(int sc, int index)
        {
            SC[index] = sc;
        }
        public int GetShapeScore(int index)
        {
            return SC[index];
        }
    }
}