namespace ClickerCounter.Models
{
    public class Counter
    {
        public int Value { get; set; }
        public int Click(int nowValue)
        {
            Value = nowValue;
            Value++;
            return Value;
        }
    }
}
