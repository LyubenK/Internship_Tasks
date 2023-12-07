void SwapIndexes<T>(List<T> list, int indexOne, int indexTwo)
{
    if (indexOne < 0 || indexOne >= list.Count && indexTwo < 0 || indexTwo >= list.Count)
    {
        throw new ArgumentOutOfRangeException();
    }

    T temp = list[indexOne];
    list[indexOne] = list[indexTwo];
    list[indexTwo] = temp;
}

