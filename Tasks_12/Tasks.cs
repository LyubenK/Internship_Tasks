using System;
namespace Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Tasks_1_To_12
    {
        public static partial class Program
        {
            //Execise 1
            public static int GetAllSegments(string sentance) => sentance.Split(' ').Count();

            //Exercise 3
            public static string LargestNumber(int[] nums)
            {
                string[] stringNumbers = nums.Select(num => num.ToString()).ToArray();

                Array.Sort(stringNumbers, (a, b) => (b + a).CompareTo(a + b));


                if (stringNumbers[0] == "0")
                {
                    return "0";
                }

                return string.Join("", stringNumbers);
            }

            //Exercise 4
            public static int Calculator(string s)
            {
                int result = 0;
                int num = 0;
                int sign = 1;
                Stack<int> stack = new Stack<int>();

                for (int i = 0; i < s.Length; i++)
                {
                    char character = s[i];

                    if (character == '+')
                    {
                        result += sign * num;
                        sign = 1;
                        num = 0;
                    }
                    else if (character == '-')
                    {
                        result += sign * num;
                        sign = -1;
                        num = 0;
                    }
                    else if (character == '(')
                    {
                        stack.Push(result);
                        stack.Push(sign);
                        result = 0;
                        sign = 1;
                    }
                    else if (character == ')')
                    {
                        result += sign * num;
                        result *= stack.Pop();
                        result += stack.Pop();
                        num = 0;
                    }

                    else if (character >= '0' && character <= '9')
                    {
                        num = int.Parse(num.ToString() + character);
                    }
                }

                return result + (sign * num);
            }

            //Exercise 5
            public static int SumUniqueNumbers(int[] array)
            {
                int sum = 0;

                var numbers = new Dictionary<int, int>();

                if (array.Length < 1 || array.Length > 100)
                {
                    throw new Exception("Number must be between 1 and 100");
                }

                foreach (var item in array)
                {
                    if (!numbers.ContainsKey(item))
                    {
                        numbers.Add(item, 1);
                    }
                    else
                    {
                        numbers[item]++;
                    }
                }

                var uniqueNumbers = numbers.Where(v => v.Value == 1);

                foreach (var num in uniqueNumbers)
                {
                    sum += num.Key;
                }

                return sum;
            }

            //Exercise 6
            public static void TwiceApperingIntegers(int[] numbersArray)
            {
                //dictionary that will track how many time a number is added and will sort the collection
                var dictionaryNumbers = new SortedDictionary<int, int>();
                var finalNumbers = new List<int>();

                foreach (var num in numbersArray)
                {
                    if (dictionaryNumbers.ContainsKey(num))
                    {
                        dictionaryNumbers[num]++;
                    }

                    else
                    {
                        dictionaryNumbers.Add(num, 1);
                    }
                }

                //foreach the items in the collection and print only those which are appearing twice
                foreach (var item in dictionaryNumbers.Where(num => num.Value == 2))
                {
                    Console.Write(item.Key + " ");
                }

            }

            //Exercise 7
            public static List<List<int>> PlayersWithZeroAndOneLosses(int[][] matches)
            {
                Dictionary<int, int> losses = new Dictionary<int, int>();
                Dictionary<int, bool> played = new Dictionary<int, bool>();

                foreach (var match in matches)
                {
                    int winner = match[0];
                    int loser = match[1];

                    played[winner] = true;
                    played[loser] = true;

                    if (!losses.ContainsKey(loser))
                    {
                        losses[loser] = 0;
                    }
                    losses[loser]++;
                }

                List<int> noLoss = new List<int>();
                List<int> oneLost = new List<int>();

                foreach (var player in played.Keys)
                {
                    if (played[player])
                    {
                        if (!losses.ContainsKey(player) || losses[player] == 0)
                        {
                            noLoss.Add(player);
                        }
                        else if (losses[player] == 1)
                        {
                            oneLost.Add(player);
                        }
                    }
                }

                noLoss.Sort();
                oneLost.Sort();

                return new List<List<int>> { noLoss, oneLost };

            }

            //Exercise 8
            public static int BaseballGameSeparator(string[] operations)
            {
                int sum = 0;
                var finalElements = new Stack<string>();

                for (int i = 0; i < operations.Length; i++)
                {
                    //Summing the last 2 numbers into one and add it the collection
                    if (operations[i] == "+")
                    {
                        if (finalElements.Count() == 0 || finalElements.Count() == 1)
                        {
                            throw new Exception("Stack is empty");
                        }
                        var lastEl = int.Parse(finalElements.Peek());
                        finalElements.Pop();
                        var previousEl = int.Parse(finalElements.Peek());


                        var newEl = lastEl + previousEl;

                        finalElements.Push(lastEl.ToString());
                        finalElements.Push(newEl.ToString());
                    }

                    //Multiply the number by 2, making it string and adding it to the collection
                    else if (operations[i].ToUpper() == "D")
                    {
                        if (finalElements.Count() == 0)
                        {
                            throw new Exception("Stack is empty");
                        }

                        var doublElement = int.Parse(finalElements.Peek());
                        doublElement *= 2;
                        finalElements.Push(doublElement.ToString());
                    }
                    //Removing the string number from the collection
                    else if (operations[i].ToUpper() == "C")
                    {
                        if (finalElements.Count() == 0)
                        {
                            throw new Exception("Stack is empty");
                        }
                        finalElements.Pop();
                    }
                    //Adding the string number to the collection
                    else
                    {
                        var lastEl = operations[i];
                        finalElements.Push(lastEl);
                    }
                }

                sum = finalElements.Select(num => int.Parse(num)).Sum();
                return sum;
            }


            //Exercise 9
            public static bool IsStringValid(string s)
            {
                int left = 0;
                int right = 0;
                int sightCount = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    var item = s[i];

                    if (item == '(')
                    {
                        left++;
                    }

                    else if (item == ')')
                    {
                        if (left == 0)
                        {
                            return false;
                        }
                        else
                        {
                            right++;
                        }
                    }

                    else
                    {
                        sightCount++;
                    }
                }

                if (left > right)
                {
                    right += sightCount;

                    return IsValid(right, left);
                }

                else if (right > left)
                {
                    left += sightCount;

                    return IsValid(right, left);
                }
                else
                {
                    if (sightCount % 2 == 1)
                    {
                        return false;
                    }

                    else
                    {
                        return true;
                    }
                }

            }

            // Helper method for Exercise 9
            public static bool IsValid(int left, int right)
            {
                if (right == left)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Exercise 10
            public static string RadiantVSDires(string senate)
            {
                Queue<int> radiants = new Queue<int>();
                Queue<int> dires = new Queue<int>();
                int n = senate.Length;

                for (int i = 0; i < n; i++)
                {
                    if (senate[i] == 'R')
                        radiants.Enqueue(i);
                    else
                        dires.Enqueue(i);
                }

                while (radiants.Count > 0 && dires.Count > 0)
                {
                    int radiantIndex = radiants.Dequeue();
                    int direIndex = dires.Dequeue();

                    //comparing the indexes, the smaller wins
                    if (radiantIndex < direIndex)
                        radiants.Enqueue(radiantIndex + n);
                    else
                        dires.Enqueue(direIndex + n);
                }

                if (radiants.Count > dires.Count)
                {
                    return "Radiant";
                }

                else
                {
                    return "Dire";
                }
            }

            //Exercise 11
            // int[,] matrix = new int[,]
            // {
            //     {1, 2, 3},
            //     {4, 5, 6},
            //     {7, 8, 9}
            // }
            public static int SumOfTheDiagonalsNumbers(int[,] matrix)
            {
                int prinarySum = 0;
                int secondarySum = 0;
                int finalSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i == j && (i + j) == (matrix.GetLength(1) - 1))
                        {
                            finalSum += matrix[i, j];
                        }
                        else
                        {
                            if ((i + j) == (matrix.GetLength(1) - 1))
                            {
                                secondarySum += matrix[i, j];
                            }
                            if (i == j)
                            {
                                prinarySum += matrix[i, j];
                            }
                        }

                    }
                }

                finalSum += prinarySum + secondarySum;
                return finalSum;
            }

            //Exercise 12
            public static bool IsSudokuValid(char[][] board)
            {
                // Check if there is any dublicates in each rows
                for (int i = 0; i < 9; i++)
                {
                    if (!IsUnique(board, i, i, 0, 8))
                    {
                        return false;
                    }
                }

                // Check if there is any dublicates in each column
                for (int j = 0; j < 9; j++)
                {
                    if (!IsUnique(board, 0, 8, j, j))
                    {
                        return false;
                    }
                }

                // Check if there is any dublicates in each 3x3 sub-box
                for (int i = 0; i < 9; i += 3)
                {
                    for (int j = 0; j < 9; j += 3)
                    {
                        if (!IsUnique(board, i, i + 2, j, j + 2))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            //Helper method for Exercise 12 
            public static bool IsUnique(char[][] board, int startX, int endX, int startY, int endY)
            {
                HashSet<char> set = new HashSet<char>();

                for (int i = startX; i <= endX; i++)
                {
                    for (int j = startY; j <= endY; j++)
                    {
                        char current = board[i][j];

                        if (current != '.' && !set.Add(current))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

        }
    }

}

