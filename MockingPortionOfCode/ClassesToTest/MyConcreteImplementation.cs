namespace MockingPortionOfCode.ClassesToTest
{
    using System.Threading;

    public class MyConcreteImplementation : IMyInterface
    {
        public MyConcreteImplementation(int counter)
        {
            Counter = counter;
        }

        public int Counter { get; set; }
        public void TransformationA()
        {
            Counter++;
            TransformationB();
            Counter++;
        }

        public void TransformationB()
        {
            Thread.Sleep(25000);
        }
    }
}