namespace ThiccShapes
{
    public class ShapeScore
    {
        // Variable to store all shapescores
        private int[] SC = new int[7];

        //Sets shapescore at a sertain index
        public  void setSC(int sc, int index)
        {
            SC[index] = sc;
        }

        //returns shapescore from a certain index
        public int GetShapeScore(int index)
        {
            return SC[index];
        }
    }
}