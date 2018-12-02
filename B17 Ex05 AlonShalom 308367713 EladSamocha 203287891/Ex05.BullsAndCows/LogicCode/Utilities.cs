namespace Ex05.BullsAndCows
{
    internal class Utilities
    {
        // $G$ CSS-013 (-5) Bad variable name (should be in the form of i_PascalCase).
        public void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }
    }
}
