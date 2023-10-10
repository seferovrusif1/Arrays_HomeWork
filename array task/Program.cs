namespace array_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 6, 41, 9, 12, 5, 23 };
            int[] newnums = new int[nums.Length];      //evvelki array uzunluqunda yeni array yaradiriq

            for (int i = 1; i < nums.Length+1; i++)
            {
                newnums[nums.Length-i] = nums[i-1];    //yeni arraya elementleri tersden mensub edirik
            }
            for (int i = 0; i <  newnums.Length; i ++)
            {
                Console.WriteLine(newnums[i]);         //Yeni arrayi capa veririk

            }
        }
    }
}