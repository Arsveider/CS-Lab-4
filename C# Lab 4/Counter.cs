internal class Counter
{
    private int maxValue, minValue, currentValue;

    public int MaxValue
    {
        get { return maxValue; }
        set { maxValue = value; }
    }

    public int MinValue
    {
        get { return minValue; }
        set { minValue = value; }
    }

    public int CurrentValue
    {
        get { return currentValue; }
        set
        {
            if (value < minValue)
            {
                Console.WriteLine("Введено значение меньшее указанного минимального, принимаю максимальное");
                currentValue = maxValue;
            }
            else if (value > maxValue)
            {
                Console.WriteLine("Введено значение больше указанного максимального, принимаю минимальное");
                currentValue = minValue;
            }
            else
                currentValue = value;
        }
    }

    public Counter() { }

    public Counter(int minValue, int maxValue, int currentValue)
    {
        MaxValue = maxValue;
        MinValue = minValue;
        CurrentValue = currentValue;
    }

    public int Plus()
    {
        CurrentValue = CurrentValue + 1;
        return CurrentValue;
    }

    public int Minus()
    {
        CurrentValue = CurrentValue - 1;
        return CurrentValue;
    }
}

