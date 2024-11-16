namespace src
{
    internal class Program
    {
        //task1
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number <= 999 && number >= 100)
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(counter);
        //}

        //task2
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number % 2 == 0)
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(counter);
        //}

        //task3
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number % 2 != 0)
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(counter);
        //}

        //task4
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number % 3 == 0 || number % 7 == 0)
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine(counter);
        //}

        //task5
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var counter = 0;
        //    var sum = 0;
        //    foreach (var number in elements)
        //    {
        //        if (number <= 99 && number >= 10 && number % 2 != 0)
        //        {
        //            counter++;
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine($"miqdori: {counter} \nyig'indisi: {sum}");
        //}

        //task6
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var temp = elements[0];
        //    elements[0] = elements[length - 1];
        //    elements[length - 1] = temp;
        //    Print(elements);
        //}

        //task7
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstTripleSum = elements[0] + elements[1] + elements[2];
        //    Console.WriteLine(firstTripleSum);
        //}

        //task8
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstTripleSum = elements[length - 1] + elements[length - 2] + elements[length - 3];
        //    Console.WriteLine(firstTripleSum);
        //}

        //task9
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var countOdd = 0;
        //    var countEven = 0;
        //    foreach (var element in elements)
        //    {
        //        if (element % 2 == 0)
        //        {
        //            countOdd++;
        //        }
        //        else
        //        {
        //            countEven++;
        //        }
        //    }
        //    if (countEven > countOdd)
        //    {
        //        Console.WriteLine(true);
        //    }
        //    else
        //    {
        //        Console.WriteLine(false);
        //    }
        //}

        //task10
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    for (int i = 0; i < length; i++)
        //    {
        //        if (elements[i] % 2 == 0)
        //        {
        //            elements[i] *= 3;
        //        }
        //    }
        //    Print(elements);
        //}

        //task11
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var test = true;
        //    foreach (var element in elements)
        //    {
        //        if (element % 5 != 0)
        //        {
        //            test = false;
        //            break;
        //        }
        //    }
        //    Console.WriteLine(test);
        //}

        //task12
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstElement = elements[0] >= 10 && elements[0] <= 99;
        //    var secondElement = elements[1] >= 10 && elements[1] <= 99;
        //    var thirdElement = elements[2] >= 10 && elements[2] <= 99;
        //Console.WriteLine(firstElement is true && secondElement is true && thirdElement is true);
        //}

        //task13
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstTwoElements = elements[0] % 2 == 0 && elements[1] % 2 == 0;
        //    var lastTwoElements = elements[length - 1] % 2 != 0 && elements[length - 2] % 2 != 0;
        //    Console.WriteLine(firstTwoElements is true && lastTwoElements is true);
        //}

        //task14
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    elements.Sort();
        //    Console.WriteLine(elements[0]);
        //}

        //task15
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    elements.Sort();
        //    Console.WriteLine($"yig'indi: {elements[0] + elements[length-1]}");
        //}

        //task16
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    for (int i = 0; i < length; i++)
        //    {
        //        if (elements[i] >= 10 && elements[i] <= 99)
        //        {
        //            elements[i] += 100;
        //        }
        //    }
        //    Print(elements);
        //}

        //task17
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var countNegativeElements = 0;
        //    var countPositiveElements = 0;
        //    foreach (var element in elements)
        //    {
        //        if (element < 0) countNegativeElements++;
        //        else countPositiveElements++;
        //    }
        //    Console.WriteLine($"musbat: {countPositiveElements}\nmanfiy: {countNegativeElements}");
        //}

        //task18
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var firstElement = elements[0];
        //    elements.Sort();
        //    var indexOfFirstElement = elements.IndexOf(firstElement);
        //    Console.WriteLine($"kichiklari: {indexOfFirstElement}");
        //}

        //task19
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var lastElement = elements.Last();
        //    elements.Sort();
        //    Print(elements);
        //    var indexOfLastElement = elements.IndexOf(lastElement);
        //    var sum = 0;
        //    for (int i = indexOfLastElement + 1; i < length; i++)
        //    {
        //        if (elements[i] != lastElement)
        //        {
        //            sum += elements[i];
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

        //task20
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var test = true;
        //    foreach (var element in elements)
        //    {
        //        if (element % 4 != 0 || element % 3 != 0)
        //        {
        //            test = false; break;
        //        }
        //    }
        //    Console.WriteLine(test);
        //}

        //task21
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var boolValue = true;
        //    for (int i = 0; i < length - 1; i++)
        //    {
        //        if (elements[i] >= elements[i + 1])
        //        {
        //            boolValue = false;
        //            break;
        //        }
        //    }
        //    Console.WriteLine(boolValue);
        //}

        //task22
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var boolValue = true;
        //    for (int i = 0; i < length - 1; i++)
        //    {
        //        if (elements[i] <= elements[i + 1])
        //        {
        //            boolValue = false;
        //            break;
        //        }
        //    }
        //    Console.WriteLine(boolValue);
        //}

        //task23
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var maxElement = elements.Max();
        //    var minElement = elements.Min();
        //    var maxElementIndex = elements.IndexOf(maxElement);
        //    var minELementIndex = elements.IndexOf(minElement);
        //    elements[maxElementIndex] = minElement;
        //    elements[minELementIndex] = maxElement;
        //    Print(elements);
        //}

        //task24
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var sumOfList = GetSumOfList(elements);
        //    Console.WriteLine(sumOfList);
        //}

        //task25
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);

        //    var comparedCouple = 0;
        //    for (int i = 1; i < length - 1; i++)
        //    {
        //        var firstTwo = elements[0] + elements[1];
        //        if (firstTwo < elements[i] + elements[i + 1])
        //        {
        //            comparedCouple = elements[i] + elements[i + 1];
        //        }
        //    }
        //    Console.WriteLine(comparedCouple);
        //}

        //task26
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var sumOfList = GetSumOfList(elements);

        //    for (int i = 0; i < length - 1; i++)
        //    {
        //        if (elements[i + 1] > elements[i])
        //        {
        //            Console.Write($"{elements[i + 1]} ");
        //        }
        //    }
        //}

        //task27
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter lists length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    var numbers = new List<int>();
        //    FillList(elements, length);
        //    FillList(numbers, length);
        //    var newList = new List<int>();
        //    for (int i = 0; i < length; i++)
        //    {
        //        newList.Add(elements[i] * numbers[i]);
        //    }
        //    Print(newList);
        //}

        //task28
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<string>();
        //    FillListWithString(elements, length);
        //    var countWords = 0;
        //    foreach (var element in elements)
        //    {
        //        if (element.StartsWith("$") is true)
        //        {
        //            countWords++;
        //        }
        //    }
        //    Console.WriteLine(countWords);
        //}

        //task29
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter list length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<string>();
        //    FillListWithString(elements, length);
        //    var checkedList = CheckAndGetUpperCase(elements);
        //    PrintStringList(checkedList);
        //}
        //public static List<string> CheckAndGetUpperCase(List<string> elements)
        //{
        //    var result = new List<string>();
        //    for (int i = 0; i < elements.Count; i++)
        //    {
        //        var temp = elements[i].ToString();
        //        if (IsAllUpper(temp) is true)
        //        {
        //            result.Add(temp);
        //        }
        //    }

        //    return result;
        //}
        //public static bool IsAllUpper(string word)
        //{
        //    var boolValue = true;
        //    foreach (var character in word)
        //    {
        //        if (char.IsUpper(character) is false)
        //        {
        //            boolValue = false;
        //            break;
        //        }
        //    }

        //    return boolValue;
        //}

        //task30
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter lists length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);

        //    var firstEvenNumber = 0;
        //    foreach (var element in elements)
        //    {
        //        if (element % 2 == 0)
        //        {
        //            firstEvenNumber = element;
        //            break;
        //        }
        //    }

        //    for (var i = 0; i < length; i++)
        //    {
        //        if (elements[i] % 2 == 0)
        //        {
        //            elements[i] += firstEvenNumber;
        //        }
        //    }

        //    Print(elements);
        //}

        //task31
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter lists length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var lastOddElement = 0;
        //    for (int i = length - 1; i >= 0; i++)
        //    {
        //        if (elements[i] % 2 != 0)
        //        {
        //            lastOddElement = elements[i];
        //            break;
        //        }
        //    }

        //    for (int i = 0; i < length; i++)
        //    {
        //        if (elements[i] % 2 != 0)
        //        {
        //            elements[i] += lastOddElement;
        //        }
        //    }

        //    Print(elements);
        //}

        //task32
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter lists length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var evenIndexList = EvenIndexList(elements);
        //    var result = evenIndexList.Min();
        //    Console.WriteLine(result);
        //}
        //public static List<int> EvenIndexList(List<int> elements)
        //{
        //    var result = new List<int>();
        //    foreach (var element in elements)
        //    {
        //        if (element % 2 == 0)
        //        {
        //            result.Add(element);
        //        }
        //    }

        //    return result;
        //}

        //task33
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter lists length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    var numbers = new List<int>();
        //    FillList(elements, length);
        //    FillList(numbers, length);
        //    var newList = new List<int>();
        //    for (int i = 0; i < length; i++)
        //    {
        //        newList[i] = Math.Max(elements[i], numbers[i]);
        //    }
        //    Print(newList);
        //}

        //task34
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter lists length: ");
        //    var length = int.Parse(Console.ReadLine());

        //    var elements = new List<int>();
        //    FillList(elements, length);
        //    var numbers = new List<int>();
        //    for (int i = 0; i < length; i++)
        //    {
        //        if (elements[i] % 2 == 0)
        //        {
        //            numbers.Add(elements[i]);
        //        }
        //    }
        //    Console.WriteLine($"elementlari soni: {numbers.Count}");
        //    Print(numbers);
        //}

        public static int GetSumOfList(List<int> elements)
        {
            var sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }

            return sum;
        }

        public static void FillList(List<int> digits, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i}: ");
                var number = int.Parse(Console.ReadLine());
                digits.Add(number);
            }
        }


        public static void FillListWithString(List<string> digits, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i}: ");
                var text = Console.ReadLine();
                digits.Add(text);
            }
        }

        public static void Print(List<int> numbers)
        {
            foreach (var digit in numbers)
            {
                Console.Write($"{digit} ");
            }
        }


        public static void PrintStringList(List<string> elements)
        {
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
