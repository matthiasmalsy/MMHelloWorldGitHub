namespace MyTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {
            throw new Exception("Ein Fehler ist aufgetreten");
        }


    }
}